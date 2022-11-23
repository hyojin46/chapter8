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
    public partial class _2 : Form
    {
        public _2()
        {
            InitializeComponent();
        }
        private string strTemp; // 필드
        private void UpdateLabel(string s, bool b)
        {
            if (b) // 체크된 경우
            {
                label1.Text += s;
            }
            else // 체크되지않은 경우
            {
                strTemp = label1.Text;
                int i = strTemp.IndexOf(s);
                label1.Text = strTemp.Remove(i, s.Length);
            }
        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e) // 체크박스 이벤트 처리기
        {
            UpdateLabel(checkBox1.Text, checkBox1.Checked);
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e) // 체크박스 이벤트 처리기
        {
            UpdateLabel(checkBox2.Text, checkBox2.Checked);
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            UpdateLabel(checkBox3.Text, checkBox3.Checked);
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            UpdateLabel(checkBox4.Text, checkBox4.Checked);
        }
    }
}
