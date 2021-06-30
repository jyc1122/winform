using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)//회원가입 버튼 클릭
        {
            string id = Convert.ToString(idtxt.Text);
            string a = Convert.ToString(password1.Text);
            string b = Convert.ToString(password2.Text);
            if (a == b && a != "" && id != "")
            {
                //db쿼리문
                this.Close();
                Form1 mainForm = new Form1();
                
                MessageBox.Show("회원가입이 완료되었습니다.");
                mainForm.Show();
            }
            //else if ()//아이디가 중복되었을때
            //{
            //    MessageBox.Show("사용불가능한 아이디 입니다.");
            //}
            else
            {
                MessageBox.Show("비밀번호가 일치하지 않습니다.");
            }
            
        }
    }
}
