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
        public _7() //생성자
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) //추가버튼 이벤트 처리기
        {
            if (textBox1.Text != "") //텍스트박스가 빈경우
            {
                listBox1.Items.Add(textBox1.Text); //리스트박스 아이템컬랙션에 텍스트박스의 내용을 넣는다
                textBox1.Text = ""; //텍스트박스 초기화
            }
        }

        private void button2_Click(object sender, EventArgs e) //삭제버튼 이벤트 처리기
        {
            if (listBox1.SelectedIndex > -1) 
                listBox1.Items.RemoveAt(listBox1.SelectedIndex);
        }
    }
}
