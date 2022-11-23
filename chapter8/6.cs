using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace chapter8
{
    public partial class _6 : Form
    {
        public _6()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) //OK버튼 이벤트 처리기
        {
            textBox3.Text = "Name:" + textBox1.Text + "\r\nPassword: " + textBox2.Text;
        }
    }
}
