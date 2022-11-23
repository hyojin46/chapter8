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
    public partial class _7 : Form
    {
        public _7()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) //추가버튼 이벤트 처리기
        {
            if (textBox1.Text != "") 
            {
                listBox1.Items.Add(textBox1.Text);
                textBox1.Text = ""; 
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex > -1)
                listBox1.Items.RemoveAt(listBox1.SelectedIndex);
        }
    }
}
