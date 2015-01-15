using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PTZRv2 {
  public partial class frmSett : Form {
    CGlobal glob;
    public frmSett() {
      InitializeComponent();
    }
    public void SetRef(ref CGlobal rfGl) {
      glob = rfGl;
      propertyGrid1.SelectedObject = glob.g_wr;
    }
    private void button1_Click(object sender, EventArgs e) {
      if (glob.g_wr == null) {
        glob.g_wr = new CSer();
        glob.g_wr.SetDefaults();
      }

      glob.SaveSettings();
    }

    private void btnClose_Click(object sender, EventArgs e) {
      this.Close();
    }

    private void btnTestConnection_Click(object sender, EventArgs e) {
      
    }

    private void btnDefault_Click(object sender, EventArgs e) {
      glob.g_wr.SetDefaults();
      propertyGrid1.SelectedObject = glob.g_wr;
    }

    private void button2_Click(object sender, EventArgs e) {
      
    }
  }
}
