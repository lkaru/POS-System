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
    public partial class Form_LogIn : Form
    {

        //구분 값을 Form_TheSalesGoods로 전송을 위한 chk
        public static string chk;


        public Form_LogIn()
        {
            InitializeComponent();
        }


        private void BTN_SignUp_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Form_SignUp form_signUp  = new Form_SignUp();
            form_signUp.ShowDialog();
        }

        private void BTN_LogIn_Click(object sender, EventArgs e)
        {
            try
            {
                string myConnection = "Server=localhost;Port=3306;Database=pos_data;Uid=root;Pwd=lkaruQPALYFE_0623@MYSQL";
                MySqlConnection myConn = new MySqlConnection(myConnection);
                //각각의 항목을 db와 대조
                MySqlCommand selectCommand = new MySqlCommand("select * from pos_data.pos_login_tb where id='" + this.TBX_Id.Text + "' and password='" + this.TBX_Pwd.Text + "' and position='" + this.CBB_Job.Text + "'", myConn);
                MySqlDataReader myReader;

                myConn.Open();
                myReader = selectCommand.ExecuteReader();

                int count = 0;

                while (myReader.Read())
                {
                    count +=  1;
                }

                if (count == 1)
                {
                    //포지션 값을 0,1 로 나타내어 매니져 여부 판단
                    if (CBB_Job.Text == "manager")
                    {
                        chk = "0";
                    }
                    else if(CBB_Job.Text == "worker")
                    {
                        chk = "1";
                    }
                    else
                    {
                        chk = "2";
                    }

                    MessageBox.Show("로그인 되었습니다.");
                    this.Visible = false;
                    Form_TheSalesGoods form_theSalesGoods = new Form_TheSalesGoods();
                    form_theSalesGoods.ShowDialog();

                }
                else if (count > 1)
                {
                    MessageBox.Show("중복된 유저가 존재합니다.");
                }
                else
                {
                    MessageBox.Show("아이디, 비밀번호나 직책이 일치하지 않습니다.");
                }
                myConn.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Form_LogIn_Load(object sender, EventArgs e)
        {

        }
    }
}
