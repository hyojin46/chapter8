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
    public partial class _9 : Form
    {
        public _9() //생성자
        {
            InitializeComponent(); //초기화
        }

        private void button1_Click(object sender, EventArgs e) //선택 버튼 이벤트 처리기
        {
            string strTemp = ""; // 메시지박스에 출력할 문자열
            foreach (object obj in checkedListBox1.CheckedItems) //반복문
            {
                strTemp += obj.ToString(); // 메시지박스에 출력할 문자열에 체크된 체크리스트의 이름을 문자열형으로 변환하여 저장
                strTemp += ": ";      
            }
            MessageBox.Show("당신의 취미는" + strTemp + "입니다.");
        }
    }
}
