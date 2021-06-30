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
    public partial class Form2 : Form
    {

        public Form2()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 mainForm = new Form1();
            mainForm.Show();
        }

        private void login_btn_Click(object sender, EventArgs e)
        {
            //로그인 기능 구현
            //▼화면닫고 todolist폼으로 가는코드
            Form1 mainForm = new Form1();
            mainForm.Close();
            this.Close();
            todo todolist = new todo();
            todolist.Show();
            

        }
    }
}
