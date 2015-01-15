using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using aUtils;

namespace PTZRv2 {
  public delegate void ChangedEventHandler(object sender, EventArgs e);


  public partial class frmMain : Form {
    CGlobal glob = new CGlobal();
    public frmMain() {
      InitializeComponent();
    }

    private void frmMain_Load(object sender, EventArgs e) {
      glob.comm.SetRef(ref glob);
      glob.mainForm = this;
      
    }

    private void pictureBox2_Click(object sender, EventArgs e) {
      frmSett fr = new frmSett();
      fr.SetRef(ref glob);
      fr.ShowDialog();
    }

    private void btnReadMeasureTemp_Click(object sender, EventArgs e) {
      glob.comm.devs.devVir.ReadTemperature();
    }

    private void btnReadMeasurePressure_Click(object sender, EventArgs e) {
      glob.comm.devs.devVir.ReadMeasurePressure();
    }

    private void btnReadNotCorrectedFlow_Click(object sender, EventArgs e) {
      glob.comm.devs.devVir.ReadNotCorrectedFlow();
    }

    private void btnEsimateCompres_Click(object sender, EventArgs e) {
      glob.comm.devs.devVir.ReadEstimateCopmpress();
    }

    private void btnTemperatureInKelvin_Click(object sender, EventArgs e) {
      glob.comm.devs.devVir.ReadTemperatureInKelvins();
    }

    private void btnCorrectionCoefitient_Click(object sender, EventArgs e) {
      glob.comm.devs.devVir.ReadCorrectionCoefitient();
    }

    private void btnReadMeasureImpuls_Click(object sender, EventArgs e) {
      glob.comm.devs.devVir.ReadMeasureImpulses();
    }

    private void btnResetMeasureImpuls_Click(object sender, EventArgs e) {
      glob.comm.devs.devVir.ResetMeasureImpulses();
    }

    private void btnReadCorrectedFlow_Click(object sender, EventArgs e) {
      glob.comm.devs.devVir.ReadCorrectedFlow();
    }

    private void btnResetCorrectedFlow_Click(object sender, EventArgs e) {
      glob.comm.devs.devVir.ResetCorrectedFlow();
    }

    private void btnReadCover_Click(object sender, EventArgs e) {
      glob.comm.devs.devVir.ReadCover();
    }

    private void btnResetCover_Click(object sender, EventArgs e) {
      glob.comm.devs.devVir.ResetCover();
      glob.comm.devs.devVir.ReadCover();
    }

    private void btnReadCorrectedFlowDp_Click(object sender, EventArgs e) {
      glob.comm.devs.devVir.ReadCorrectedFlowDp();
    }

    private void btnResetCorrectedFlowDp_Click(object sender, EventArgs e) {
      glob.comm.devs.devVir.ResetCorrectedFlowDp();
      glob.comm.devs.devVir.ReadCorrectedFlowDp();
    }

    private void btnReadHighLimit_Click(object sender, EventArgs e) {
      glob.comm.devs.devVir.ReadHighLimitStatus();
      glob.comm.devs.devVir.ReadAlarmsTime();
    }

    private void btnResetHighLimit_Click(object sender, EventArgs e) {
      glob.comm.devs.devVir.ResetHighLimitStatus();
    }

    private void btnReadLowLimit_Click(object sender, EventArgs e) {
      glob.comm.devs.devVir.ReadLowLimitStatus();
      glob.comm.devs.devVir.ReadAlarmsTime();
    }

    private void btnResetLowLimit_Click(object sender, EventArgs e) {
      glob.comm.devs.devVir.ResetLowLimitStatus();
    }

    private void btnResetFlow_Click(object sender, EventArgs e) {
      glob.comm.devs.devVir.ResetFlowCounters();
    }

    private void btnReadAll_Click(object sender, EventArgs e) {                                                     
      MessageBox.Show("Натискайки този бутон се съгласяваш, че:\n" + 
        "- много полезни ги прави тези програми Асенчо-готиното.\n" +
        " -Винаги ще купувам на Sensi обяд, когато той ме помоли.\n" +
        "- Винаги ще му запоявам диодите, когато му трябва.\n",
        "Заклевам се"
        
        );
      glob.comm.devs.devVir.ReadTemperature();
      glob.comm.devs.devVir.ReadMeasurePressure();
      glob.comm.devs.devVir.ReadNotCorrectedFlow();
      glob.comm.devs.devVir.ReadEstimateCopmpress();
      glob.comm.devs.devVir.ReadMeasureImpulses();
      glob.comm.devs.devVir.ReadTemperatureInKelvins();
      glob.comm.devs.devVir.ReadCorrectedFlow();
      glob.comm.devs.devVir.ReadCorrectionCoefitient();
      glob.comm.devs.devVir.ReadCover();
      glob.comm.devs.devVir.ReadCorrectedFlowDp();
      glob.comm.devs.devVir.ReadHighLimitStatus();
      glob.comm.devs.devVir.ReadLowLimitStatus();
    }

    private void btnStartPeriodicRead_Click(object sender, EventArgs e) {
      timer1.Interval = 3000;
      timer1.Enabled = true;
    }

    private void btnStopPeriodicRead_Click(object sender, EventArgs e) {
      timer1.Enabled = false;
    }

    private void timer1_Tick(object sender, EventArgs e) {
      btnReadAll_Click(this, new EventArgs());
    }

    private void btnReadBaseTemperature_Click(object sender, EventArgs e) {
      glob.comm.devs.devVir.ReadBaseTemperature();
    }

    private void btnSetBaseTemperature_Click(object sender, EventArgs e) {
      try {
        float baseT = (float)Convert.ToDouble(txtBaseTemperature.Text);
        glob.comm.devs.devVir.SetBaseTemperature(baseT);
      } catch {
      
      }
      
      //
    }

   
  }
}
