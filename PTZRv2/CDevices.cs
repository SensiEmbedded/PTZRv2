using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Modbus.Device;
using Modbus.Message;
using System.IO.Ports;  //for serial port
using System.Windows.Forms;
using System.Threading;
using aUtils;
using Modbus.Data;
using Modbus.Message;
using Unme.Common;


namespace PTZRv2 {
  
  public delegate int ReadDeviceDelegate();
  public delegate void AlarmOccured(int ixPressure,DevAlarms type);

  public enum DevStatus {
    None,
    OK,
    AddressExeption,
    TimeOut,
    OtherErr
  };
  public enum DevErrorCodes {
    None,
    AdcErr = -102,
    AddressExeption = -103,
    TimeOut = -104,
    ComNotExist = -105,
    ErrUnknown = -106
  };
  public enum DevAlarms {
    NotSet,
    None,
    Lo,
    LoLo,
    Hi,
    HiHi,
    OutOfRange,
    Error
  };
  public enum DevTypeSQL {
    NotSet,
    Press1,
    Press2,
    Press3

  }
  //----------------------------------------------------------------------------------------------------------------------------------
  #region Devices Class definition
  
  public class CDevCommon {

    public byte slaveID { get; set; }
    public bool enable { get; set; }
    public DevStatus status { get; set; }  //0 - not init, 1-OK;2-TimeOut;3-Exeption
    public ReadDeviceDelegate ReadDevice;
    /*
    public static void SetErrors(float[] arr,DevErrorCodes code) {
      int max = arr.Length;
      for (int i = 0; i < max; ++i) {
        arr[i] = (float)code;
      }
    }
    public static void SetVals(object[] arr, object val){
      int max = arr.Length;
      for (int i = 0; i < max; ++i) {
        arr[i]  = (int)val;
      }
    } */
    /// <summary>
    ///   
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="arr"></param>
    /// <param name="val"></param>
    public static void SetVals2<T>(T[] arr, T val) {
       
      int max = arr.Length;
      for (int i = 0; i < max; ++i) {
        arr[i] = val;
      }
    }

  }
    
  //----------------------------------------------------------------------------------------------------------------------------------
  public class CDev_Virtual {
    public CDevCommon cmn = new CDevCommon();
    private CGlobal gl;
    public int errors = 0;
    ushort startAddress = 120;
    //ushort startAddress = 1;
    ushort numofPoints = 10;
    //ushort numofPoints = 2;
    public ushort[] holdingregister = new ushort[10];

       
    public event ChangedEventHandler Changed;
    public event AlarmOccured evAlarm;
    

    private static System.Threading.Timer timer;
    private System.Timers.Timer TTTimer = new System.Timers.Timer();

    
    public CDev_Virtual(ref CGlobal gl) {
      this.gl = gl;

      cmn.slaveID = 1;          
      cmn.ReadDevice = Read;
      this.TTTimer.Interval = 1000; //1 sec
      this.TTTimer.Elapsed += new System.Timers.ElapsedEventHandler(TTTimer_Elapsed);
      this.TTTimer.Start();
    }

    /*void TimeOutCallBack(object state) {
      timer.Change(Timeout.Infinite, Timeout.Infinite); //stops the timer
      System.Diagnostics.Debug.WriteLine("Com port TimeOut Call Back");
    }    
     
     */
    /// <summary>
    /// 
    /// </summary>
    void FireChangeEvent(){
      if (Changed != null) {
        Changed(this, new EventArgs());
      } else {
        //System.Diagnostics.Debug.WriteLine("KKKKKKKUUUUUUUUUUUUUUUUUUUUUURRRRRRRRRRRRRRRRR");
      }
    }
    void FireAlarmEvent(int ixPressure,DevAlarms type) {
      if (evAlarm != null) {
        evAlarm(ixPressure, type);
      } else {
        //System.Diagnostics.Debug.WriteLine("KKKKKKKUUUUUUUUUUUUUUUUUUUUUURRRRRRRRRRRRRRRRR");
      }
    }
    void TTTimer_Elapsed(object sender, System.Timers.ElapsedEventArgs e) {
      
    }
    /// <summary>
    /// 
    /// </summary>
    /// <returns></returns>
    int Read() {
      //./timer = new System.Threading.Timer(TimeOutCallBack,null,30000,Timeout.Infinite);
      try {
        holdingregister = null;
        holdingregister = gl.comm.master.ReadHoldingRegisters(cmn.slaveID, startAddress, numofPoints);
        this.cmn.status = DevStatus.None;
      } catch (TimeoutException to) {
        System.Diagnostics.Debug.WriteLine("-->Time Out.<--");
        this.cmn.status = DevStatus.TimeOut;
        //gl.sqlite.LogMessage("Time Out Device");
        ++errors;
        //CDevCommon.SetErrors(pressure,DevErrorCodes.TimeOut);
        //CDevCommon.SetVals(pressure, DevErrorCodes.TimeOut);
        //CDevCommon.SetVals2<float>(pressure, (float)DevErrorCodes.TimeOut);
        
        FireChangeEvent();
        return 0;
      } catch (Modbus.SlaveException se) {
        System.Diagnostics.Debug.WriteLine("-->slave exeption<--");
        System.Diagnostics.Debug.WriteLine("Modbus Slave Excepton");
        this.cmn.status = DevStatus.AddressExeption;
        ++errors;
        
        //CDevCommon.SetErrors(pressure, DevErrorCodes.AddressExeption);
        //CDevCommon.SetVals2<float>(pressure, (float)DevErrorCodes.AddressExeption);
        
        FireChangeEvent();
        return 0;
      } catch (Exception ex) {
        //gl.sqlite.LogMessage(ex.Message);
        System.Diagnostics.Debug.WriteLine("-->" + ex.Message + "<--");
        this.cmn.status = DevStatus.OtherErr;
        ++errors;
        //CDevCommon.SetErrors(pressure, DevErrorCodes.ErrUnknown);
        //CDevCommon.SetVals2<float>(pressure, (float)DevErrorCodes.ErrUnknown);
        
        FireChangeEvent();
        return 0;
      }
      if (this.cmn.status == DevStatus.TimeOut) {
        System.Diagnostics.Debug.WriteLine("Device came online.");
      }
      this.cmn.status = DevStatus.OK;
      int count = 0;
      if (holdingregister != null) {
        foreach (ushort us in holdingregister) {
          System.Diagnostics.Debug.WriteLine("c " + count.ToString() + "="+us.ToString());
          aUtils.CUtils.tag_Prava prava = new aUtils.CUtils.tag_Prava();
          prava.x1 = (float)0;
          prava.y1 = (float)0.0;
          prava.x2 = (float)0xFFFF;
          prava.y2 = (float)20.0;
          //current[count] = aUtils.CUtils.PravaPrez2Tochki((float)us, prava);

          prava.x1 = (float)4;
          prava.y1 = (float)-100;
          prava.x2 = (float)20.0;
          prava.y2 = (float)100.0;
          //pressure[count] = aUtils.CUtils.PravaPrez2Tochki(current[count], prava);

          ++count;
        }
      }
      if (numofPoints != count) {
        System.Diagnostics.Debug.WriteLine("-->Error in returned registers.<--");
        FireChangeEvent();
        return 0;
      }
    
      //prDiffPress1[0] = (double)holdingregister[1];
      FireChangeEvent();
      
      //prDiffPress1 = ++testis;
      //System.Diagnostics.Debug.WriteLine(DateTime.Now.ToString() +  "Setted prDiff=" + prDiffPress1.ToString());
      //System.Diagnostics.Debug.WriteLine("RS ThreadID=" + AppDomain.GetCurrentThreadId().ToString());
      //gl.comm.master.Dispose();
      return 1;
    }
    ushort[] ReadHold(ushort startAdd,ushort howMany) {
      //./timer = new System.Threading.Timer(TimeOutCallBack,null,30000,Timeout.Infinite);
      try {
        holdingregister = null;
        holdingregister = gl.comm.master.ReadHoldingRegisters(cmn.slaveID, startAdd, howMany);
        this.cmn.status = DevStatus.None;
      } catch (TimeoutException to) {
        System.Diagnostics.Debug.WriteLine("-->Time Out.<--");
        this.cmn.status = DevStatus.TimeOut;
        FireChangeEvent();
        return null;
      } catch (Modbus.SlaveException se) {
        System.Diagnostics.Debug.WriteLine("-->slave exeption<--");
        this.cmn.status = DevStatus.AddressExeption;
        FireChangeEvent();
        return null;
      } catch (Exception ex) {
        //gl.sqlite.LogMessage(ex.Message);
        System.Diagnostics.Debug.WriteLine("-->" + ex.Message + "<--");
        this.cmn.status = DevStatus.OtherErr;
        return null;
      }
      this.cmn.status = DevStatus.OK;
      int count = 0;
      return holdingregister;
    }
    bool WriteHold(ushort startAdd, ushort[] data) {
      //./timer = new System.Threading.Timer(TimeOutCallBack,null,30000,Timeout.Infinite);
      try {
        gl.comm.master.WriteMultipleRegisters(cmn.slaveID, startAdd, data);
        this.cmn.status = DevStatus.None;
      } catch (TimeoutException to) {
        System.Diagnostics.Debug.WriteLine("-->Time Out.<--");
        this.cmn.status = DevStatus.TimeOut;
        FireChangeEvent();
        return false;
      } catch (Modbus.SlaveException se) {
        System.Diagnostics.Debug.WriteLine("-->slave exeption<--");
        this.cmn.status = DevStatus.AddressExeption;
        FireChangeEvent();
        return false;
      } catch (Exception ex) {
        //gl.sqlite.LogMessage(ex.Message);
        System.Diagnostics.Debug.WriteLine("-->" + ex.Message + "<--");
        this.cmn.status = DevStatus.OtherErr;
        return false;
      }
      this.cmn.status = DevStatus.OK;
      int count = 0;
      return true;
    }
    #region Read Params
    
    public void ReadTemperature() {
      ushort[] hold;
      hold = ReadHold(CMbAddr._PVTemp_si,(ushort)1);
      if (hold != null) {
        gl.mainForm.UIThread(() => gl.mainForm.lblMeasureTemp.Text = hold[0].ToString());
      }
    }
    public void ReadMeasurePressure() {
      ushort[] hold;
      hold = ReadHold(CMbAddr._PVPressure_flt, (ushort)2);
      if (hold != null) {
        float fl = CUtils.MountFloat(hold[1],hold[0]);
        gl.mainForm.UIThread(() => gl.mainForm.lblMeasurePressure.Text = fl.ToString());
      }
    }
    public void ReadNotCorrectedFlow() {
      ushort[] hold;
      hold = ReadHold(CMbAddr._NotCorrectFlow_ul, (ushort)2);
      if (hold != null) {
        float fl = CUtils.MountFloat(hold[1], hold[0]);
        gl.mainForm.UIThread(() => gl.mainForm.lblNotCorrectedFlow.Text = fl.ToString());
      }
    }
    public void ReadEstimateCopmpress() {
      ushort[] hold;
      hold = ReadHold(CMbAddr._Z_flt, (ushort)2);
      if (hold != null) {
        float fl = CUtils.MountFloat(hold[1], hold[0]);
        gl.mainForm.UIThread(() => gl.mainForm.lblEstimateCompres.Text = fl.ToString());
      }
    }
    public void ReadTemperatureInKelvins() {
      ushort[] hold;
      hold = ReadHold(CMbAddr._PVTempK_flt, (ushort)2);
      if (hold != null) {
        float fl = CUtils.MountFloat(hold[1], hold[0]);
        gl.mainForm.UIThread(() => gl.mainForm.lblTemperatureInKelvin.Text = fl.ToString());
      }
    }
    public void ReadCorrectionCoefitient() {
      ushort[] hold;
      hold = ReadHold(CMbAddr._CorrectionCoefitient, (ushort)2);
      if (hold != null) {
        float fl = CUtils.MountFloat(hold[1], hold[0]);
        gl.mainForm.UIThread(() => gl.mainForm.lblCorrectionCoefitient.Text = fl.ToString());
      }
    }
    public void ReadMeasureImpulses() {
      ushort[] hold;
      hold = ReadHold(CMbAddr._CountImp_ul, (ushort)2);
      if (hold != null) {
        float fl = CUtils.MountLong(hold[1], hold[0]);
        gl.mainForm.UIThread(() => gl.mainForm.lblMeasureImpuls.Text = fl.ToString());
      }
    }
    public void ResetMeasureImpulses() {
      ushort[] data = { 0, 0 };
      WriteHold(CMbAddr._CountImp_ul, data);
    }
    public void ReadCorrectedFlow() {
      ushort[] hold;
      hold = ReadHold(CMbAddr._CorrectFlow_ul, (ushort)2);
      if (hold != null) {
        float fl = CUtils.MountLong(hold[1], hold[0]);
        gl.mainForm.UIThread(() => gl.mainForm.lblCorrectedFlow.Text = fl.ToString());
      }
    }
    public void ResetCorrectedFlow() {
      ushort[] data = { 0, 0 };
      WriteHold(CMbAddr._CorrectFlow_ul, data);
    }

    public void ReadCover() {
      ushort[] hold;
      hold = ReadHold(CMbAddr._flCover, (ushort)1);
      if (hold != null) {
        gl.mainForm.UIThread(() => gl.mainForm.lblCover.Text = hold[0].ToString());
      }
    }
    public void ResetCover() {
      ushort[] data = { 0 };
      WriteHold(CMbAddr._flCover, data);
    }
    public void ReadCorrectedFlowDp() {
      ushort[] hold;
      hold = ReadHold(CMbAddr._CorrectFlow_flt, (ushort)2);
      if (hold != null) {
        float fl = CUtils.MountLong(hold[1], hold[0]);
        gl.mainForm.UIThread(() => gl.mainForm.lblCorrectedFlowDp.Text = fl.ToString());
      }
    }
    public void ResetCorrectedFlowDp() {
      ushort[] data = { 0, 0 };
      WriteHold(CMbAddr._CorrectFlow_flt, data);
    }

    public void ReadHighLimitStatus() {
      ushort[] hold;
      hold = ReadHold(CMbAddr._HighLimit_flLimit, (ushort)1);
      if (hold != null) {
        gl.mainForm.UIThread(() => gl.mainForm.lblHighLimit.Text = hold[0].ToString());
      }
    }
    public void ResetHighLimitStatus() {
      ushort[] data = { 0 };
      WriteHold(CMbAddr._HighLimit_flLimit, data);
    }
    public void ReadAlarmsTime() {
      ushort[] hold;
      hold = ReadHold(CMbAddr._HighLimit_month, (ushort)8);
      if (hold != null) {
        ushort month, date, hour, minute;
        ushort month2, date2, hour2, minute2;
        month = hold[0];
        date = hold[1];
        hour = hold[2];
        minute = hold[3];
        month2 = hold[4];
        date2 = hold[5];
        hour2 = hold[6];
        minute2 = hold[7];
        //ushort year,month,date,hour,minute,seconds;
        string str;
        str = month.ToString() + '.';
        str += date.ToString() + ' ';
        str += hour.ToString() + ':';
        str += minute.ToString();
        gl.mainForm.UIThread(() => gl.mainForm.lblDTHighLimit.Text = str);
        str = month2.ToString() + '.';
        str += date2.ToString() + ' ';
        str += hour2.ToString() + ':';
        str += minute2.ToString();
        gl.mainForm.UIThread(() => gl.mainForm.lblDTLowLimit.Text = str);
        
      }
    }

    public void ReadLowLimitStatus() {
      ushort[] hold;
      hold = ReadHold(CMbAddr._LowLimit_flLimit, (ushort)1);
      if (hold != null) {
        gl.mainForm.UIThread(() => gl.mainForm.lblLowLimit.Text = hold[0].ToString());
      }
    }
    public void ResetLowLimitStatus() {
      ushort[] data = { 0 };
      WriteHold(CMbAddr._LowLimit_flLimit, data);
    }
    public void ResetFlowCounters() {
      //Modbus.Message.IModbusMessage msg;
       
      //gl.comm.master..ExecuteCustomMessage
      
      ushort[] testValues = new ushort[] { 1,2 };



      gl.mainForm.UIThread(() => gl.mainForm.lblResetFlow.Text = "----");
      //./CCustomMessageRequest writeRequest = new CCustomMessageRequest(0x26,(byte)1, new RegisterCollection(testValues));
      CCustomMessageRequest writeRequest = new CCustomMessageRequest(0x26, (byte)1, new RegisterCollection());
       
      //gl.comm.master.ExecuteCustomMessage<CCustomMessage>(writeRequest);

      try {
        CustomMessageResponse resp =  gl.comm.master.ExecuteCustomMessage<CustomMessageResponse>(writeRequest);
        if (resp.MessageFrame[1] == 0x26) {
          gl.mainForm.UIThread(() => gl.mainForm.lblResetFlow.Text = "Counters reset.");
        }
      } catch (Exception ex) {
        System.Diagnostics.Debug.WriteLine(ex.Message);
      }
      

      /*
      CustomReadHoldingRegistersRequest readRequest = new CustomReadHoldingRegistersRequest(SlaveAddress, testAddress, (ushort)testValues.Length);
      CustomWriteMultipleRegistersRequest writeRequest = new CustomWriteMultipleRegistersRequest(SlaveAddress, testAddress, new RegisterCollection(testValues));

      var response = Master.ExecuteCustomMessage<CustomReadHoldingRegistersResponse>(readRequest);
      ushort[] originalValues = response.Data;
      Master.ExecuteCustomMessage<CustomWriteMultipleRegistersResponse>(writeRequest);
      response = Master.ExecuteCustomMessage<CustomReadHoldingRegistersResponse>(readRequest);
      ushort[] newValues = response.Data;
      Assert.AreEqual(testValues, newValues);
      writeRequest = new CustomWriteMultipleRegistersRequest(SlaveAddress, testAddress, new RegisterCollection(originalValues));
      Master.ExecuteCustomMessage<CustomWriteMultipleRegistersResponse>(writeRequest);
        */
      
    }
    #endregion
    #region Constants Tab
    //int StartingAddress = CMbAddr._Tbase_flt;
			//CTask.ReadRegisters(g_prot.g_data[ix],StartingAddress,2);
    public void ReadBaseTemperature() {
      ushort[] hold;
            
      hold = ReadHold(CMbAddr._Tbase_flt, (ushort)2);
      if (hold != null) {
        float fl = CUtils.MountFloat(hold[1], hold[0]);
        gl.mainForm.UIThread(() => gl.mainForm.txtBaseTemperature.Text = fl.ToString());
      }
    }
    public void SetBaseTemperature(float baseT) {
      ushort[] hold = new ushort[2];
      CUtils.UnMountFloat(baseT, out hold[0], out hold[1]);
      bool r = WriteHold(CMbAddr._Tbase_flt, hold);
      if (r == false) {
        gl.mainForm.UIThread(() => gl.mainForm.txtBaseTemperature.Text = "Error writing");
      }

    }

    #endregion
  }


  #endregion
  //----------------------------------------------------------------------------------------------------------------------------------
  public class CDevices {
    public CDev_Virtual devVir;
    
    private CGlobal glob;
    private int order=0;
    
    public CDevices(ref CGlobal gl) {
      //devVir.cmn
      devVir = new CDev_Virtual(ref gl);
      
    }
    public void ReadNextDevice() {
      int rez = 0;
      order = 0;
      switch (order) {
        case 0:
            //rez = devVir.cmn.ReadDevice();
            //devVir.ReadTemperature();
            //
          break;
        case 1:
          //rez = devsss[0].cmn.ReadDevice();
          break;
        case 2:
          //rez = devsss[1].cmn.ReadDevice();
          break;
      }
       
      if (++order > 2) order = 0;
      
    }
  }
}
