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
    public partial class _8 : Form
    {
        public _8()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null) //리스트박스에서 선택한 경우
            {
                comboBox1.Items.Add(listBox1.SelectedItem); // 콤보박스에 채움
                listBox1.Items.Remove(listBox1.SelectedItem); // 리스트박스에서 내용을 제거
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem != null)
            {
                listBox1.Items.Add(comboBox1.SelectedItem);
                comboBox1.Items.Remove(comboBox1.SelectedItem); 
            }
        }
    }
}
