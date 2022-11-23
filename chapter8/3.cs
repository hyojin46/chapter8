using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace chapter8
{
    public partial class _3 : Form
    {
        public _3()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            label1.Text = radioButton1.Text;
        }
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            label1.Text = radioButton2.Text;
        }
        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            abel1.Text = radioButton3.Text;
        }
        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
