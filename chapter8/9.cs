﻿using System;
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
        public _9()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) //선택 버튼 이벤트 처리기
        {
            string strTemp = "";
            foreach (object obj in checkedListBox1.CheckedItems)
            {
                strTemp += obj.ToString();
                strTemp += ": ";      
            }
            MessageBox.Show("당신의 취미는" + strTemp + "입니다.");
        }
    }
}
