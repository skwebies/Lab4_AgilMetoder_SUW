using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class frmCalculator : Form
    {
        public frmCalculator()
        {
            InitializeComponent();
        }

        private void btnOne_Click(object sender, EventArgs e)
        {
            if (txtResult.Text == "0")
            {
                txtResult.Clear();
            }
            
                Button button = (Button)sender;
                txtResult.Text = txtResult.Text + button.Text;


           



        }
    }
}
