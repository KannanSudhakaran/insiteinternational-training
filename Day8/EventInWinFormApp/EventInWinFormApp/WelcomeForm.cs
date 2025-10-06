using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EventInWinFormApp
{
    public partial class WelcomeForm : Form
    {
        public WelcomeForm()
        {
            InitializeComponent();

            //F1();
            //F2();
           
           
            this.btnHello.Click += F1;
            this.btnHello.Click += F2;

            this.btnExit.Click += F3;
        }


      private  void F1(object sender,EventArgs e) {

            MessageBox.Show("God is observing");
        }

      private  void F2(object x,EventArgs e) {
            MessageBox.Show("Devil is observing");
        }

        private void F3(object sender,EventArgs e) {
            this.Close();
        }
    }
}
