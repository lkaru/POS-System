using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace POS_System
{
    public partial class Form_SignUp : Form
    {

        //구분 값을 Form1으로 전송을 위한 chk
        public static string chk;

        public Form_SignUp()
        {
            InitializeComponent();
        }

        private void Form_SignUp_Load(object sender, EventArgs e)
        {

        }

        private void BTN_BackSpace_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Form_LogIn form_logIn = new Form_LogIn();
            form_logIn.ShowDialog();
        }

        private void BTN_CreateAcount_Click(object sender, EventArgs e)
        {
            Console.WriteLine(CBB_Job.Text);
            if (TBX_Id.Text == "" || TBX_Pwd.Text == "" || TBX_Name.Text == "" || CBB_Job.Text == "")
            {
                MessageBox.Show("항목을 정확히 입력해주세요");
                TBX_Id.Clear();
                TBX_Pwd.Clear();
            }
            else
            {
                string constring = "Server=localhost;Port=3306;Database=pos_data;Uid=root;Pwd=lkaruQPALYFE_0623@MYSQL";
                string Query = "INSERT INTO pos_data.pos_login_tb (id,password,name,position) value ('" + this.TBX_Id.Text + "','" + this.TBX_Pwd.Text + "','" + this.TBX_Name.Text + "','" + this.CBB_Job.Text + "')";
                MySqlConnection conDataBase = new MySqlConnection(constring);
                MySqlCommand cmdDatabase = new MySqlCommand(Query, conDataBase);
                MySqlDataReader myReader;

                try
                {
                    conDataBase.Open();
                    myReader = cmdDatabase.ExecuteReader();
                    MessageBox.Show("계정 생성 완료");

                    while (myReader.Read())
                    {

                    }
                    this.Visible = false;
                    Form_LogIn form_logIn = new Form_LogIn();
                    form_logIn.ShowDialog();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("항목을 정확히 입력해주세요");
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void TBX_Id_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
