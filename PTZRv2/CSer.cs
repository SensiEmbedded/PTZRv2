using System;
using System.Collections;
using System.Xml.Serialization;
using System.IO;
using System.Linq;
//using System.Drawing;
using System.Windows.Forms;
using System.IO.Ports;  //for serial port
using System.ComponentModel;

namespace PTZRv2 {
  [Serializable]
  public class CSer {
    [Category("COM port"), Description("Parity")]
    public Parity parity {   get; set; }

    [Category("COM port"), Description("Number of stop bits")]
    public StopBits stopBits { get; set; }

    [Category("COM port"), Description("number of data bits")]
    public int dataBits { get; set;}

    [Category("COM port"), Description("Baud rate,9600,14400,19200,38400,115200")]
    public int baudRate { get; set; }

    [Category("COM port"), Description("Name of the port COM1, COM2, COM3")]
    public string portName { get;set;}

    [Category("Communication"), Description("answer timeout (ms)")]
    public int timeOut { get; set;}

    [Category("Communication"), Description("how many times to ask")]
    public int retries {  get;set; }

    [Category("Communication"), Description("Asking for data interval (ms)")]
    public int updatems { get;set; }

    public void SetDefaults() {
      parity = Parity.None;
      stopBits = StopBits.One;
      dataBits = 8;
      baudRate = 9600;
      portName = "COM3";
      timeOut = 500;
      retries = 2;
      updatems = 1000;
      
    }
    #region Serialize Deserialize
    /// <summary>
    /// Serialize
    /// </summary>
    /// <param name="instan"></param>
    public static void SerializeMe(CSer instan, string path) {

      FileStream fs = null;
      XmlSerializer xs = new XmlSerializer(typeof(CSer));
      //fs = File.Open("CSer.xml", FileMode.Create, FileAccess.Write);
      fs = File.Open(path, FileMode.Create, FileAccess.Write);

      try {
        xs.Serialize(fs, instan);
      } finally {
        fs.Close();
      }
    }
    /// <summary>
    /// DeserializeMe
    /// </summary>
    public static CSer DeserializeMe(string path) {
      CSer itm;//= new CL.CSer();
      FileStream fsd = null;
      XmlSerializer xs = new XmlSerializer(typeof(CSer));
      //fsd = File.Open("CSer.xml", FileMode.Open, FileAccess.Read);
      fsd = File.Open(path, FileMode.Open, FileAccess.Read);

      try {
        itm = (CSer)xs.Deserialize(fsd);
      } finally {
        fsd.Close();

      }
      return itm;
    }
    #endregion
  }
}
