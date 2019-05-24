using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TeaBagMaker2
{
    public partial class Form1 : Form
    {
        string[] SList = new string[] { "홍차", "녹차", "루이보스차", "국화차" };
        string orgStr = ""; // 선택 결과 저장
        int CountOrgNum = 0; //타이머의 초기값
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < SList.Length; i++)
            {
                this.cbList.Items.Add(SList[i]);
            }
            
            if (cbList.Items.Count > 0)
            {
                this.cbList.SelectedIndex = 0;
            }

            if (orgStr.Equals("홍차"))
            {
                CountOrgNum = 180;
            }
            else if (orgStr.Equals("루이보스차"))
            {
                CountOrgNum = 300;
            }
            else
                CountOrgNum = 120;

        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            if (CountOrgNum < 1)
            {
                this.Timer.Enabled = false;
                
                MessageBox.Show("티백을 건지세요!", "알림",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.cbList.Focus();
             
            }
            else
            {
                this.CountOrgNum--;
                this.txtCountDown.Text = Convert.ToString(this.CountOrgNum);
            }

        }

        private void BtnCount_Click(object sender, EventArgs e)
        {
         this.Timer.Enabled = true;
        
        }
    }
}
