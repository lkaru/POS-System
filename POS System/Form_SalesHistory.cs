using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Relational;
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


    public partial class Form_SalesHistory : Form
    {
        //서버 사용 선언
        MySqlConnection connection = new MySqlConnection("Server=localhost;Port=3306;Database=pos_dataset;Uid=root;Pwd=lkaruQPALYFE_0623@MYSQL");
        MySqlCommand command;
        MySqlDataAdapter adapter;
        DataTable table = new DataTable();

        int selectedRow;



        public Form_SalesHistory()
        {
            InitializeComponent();
        }

        //DB에서 데이터 불러온 후 텍스트 박스 초기화 (데이터 갱신 함수)
        public void LoadData()
        {
            string sql = "Server=localhost;Port=3306;Database=pos_dataset;Uid=root;Pwd=lkaruQPALYFE_0623@MYSQL";
            MySqlConnection con = new MySqlConnection(sql);
            MySqlCommand cmd_db = new MySqlCommand("SELECT * FROM tb_sales;", con);

            try
            {
                MySqlDataAdapter sda = new MySqlDataAdapter();
                sda.SelectCommand = cmd_db;
                DataTable dbdataset = new DataTable();
                sda.Fill(dbdataset);
                BindingSource bSource = new BindingSource();

                bSource.DataSource = dbdataset;
                DGV_SalesHistory.DataSource = bSource;
                sda.Update(dbdataset);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            //텍스트 박스 초기화
            TBX_SearchItem.Text = "";
            TBX_SerialNum.Text = "";
            TBX_Price.Text = "";
            TBX_ItemName.Text = "";
            TBX_Amount.Text = "";
            TBX_Total.Text = "";
        }
        
        //DB 불러오기(새로고침)
        private void BTN_Refresh_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        //데이터 조회 함수
        public void searchData(string valueToSearch)
        {
            try
            {
                string query = "SELECT * FROM tb_sales WHERE CONCAT(`name`, `price`, `count`, `total`) like '%" + valueToSearch + "%'";
                command = new MySqlCommand(query, connection);
                adapter = new MySqlDataAdapter(command);
                table = new DataTable();
                adapter.Fill(table);
                DGV_SalesHistory.DataSource = table;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Form_SalesHistory_Load(object sender, EventArgs e)
        {
            searchData("");
        }

        //검색
        private void BTN_SearchForItems_Click(object sender, EventArgs e)
        {
            if (TBX_SearchItem.Text == "")
            {
                MessageBox.Show("검색 정보를 입력해주세요");
            }
            else
            {
                string valueToSearch = TBX_SearchItem.Text.ToString();
                searchData(valueToSearch);
                //텍스트 박스 초기화
                TBX_SearchItem.Text = "";
            }
        }



        private void LBL_Title_Click(object sender, EventArgs e)
        {

        }

        //셀 클릭시 해당 행의 정보를 텍스트박스에 채움
        private void DGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                selectedRow = e.RowIndex;
                DataGridViewRow row = DGV_SalesHistory.Rows[selectedRow];
                TBX_SerialNum.Text = row.Cells[0].Value.ToString();
                TBX_ItemName.Text = row.Cells[1].Value.ToString();
                TBX_Price.Text = row.Cells[2].Value.ToString();
                TBX_Amount.Text = row.Cells[3].Value.ToString();
                TBX_Total.Text = row.Cells[4].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        //품목 삭제
        private void BTN_ItemDelete_Click(object sender, EventArgs e)
        {
            string constring = "Server=localhost;Port=3306;Database=pos_dataset;Uid=root;Pwd=lkaruQPALYFE_0623@MYSQL";
            if (TBX_SerialNum.Text == "")
            {
                MessageBox.Show("삭제 할 항목을 찾지 못했습니다.");
            }
            else
            {
                //delete를 통해 DB로 삭제된 데이터 전송 - 기본키 기준으로 삭제위치 탐색
                string Query = "delete from pos_dataset.tb_sales where no ='" + this.TBX_SerialNum.Text + "';";
                MySqlConnection conDataBase = new MySqlConnection(constring);
                MySqlCommand cmdDatabase = new MySqlCommand(Query, conDataBase);
                MySqlDataReader myReader;

                try
                {
                    conDataBase.Open();
                    myReader = cmdDatabase.ExecuteReader();
                    MessageBox.Show("삭제완료");

                    while (myReader.Read())
                    {

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                LoadData();
            }
        }
 
        //품목 수정
        private void BTN_Modifi_Click(object sender, EventArgs e)
        {
            string constring = "Server=localhost;Port=3306;Database=pos_data;Uid=root;Pwd=lkaruQPALYFE_0623@MYSQL";

            if (TBX_ItemName.Text == "" || TBX_Price.Text == "" || TBX_Amount.Text == "")
            {
                MessageBox.Show("항목을 정확히 입력해주세요");
                TBX_ItemName.Clear();
                TBX_Price.Clear();
                TBX_Amount.Clear();
            }
            else
            {
                decimal price = decimal.Parse(TBX_Price.Text);
                decimal count = decimal.Parse(TBX_Amount.Text);
                decimal total = price * count;

                TBX_Total.Text = total.ToString();

                //업데이트를 통해 DB로 수정된 데이터 전송 - 기본키 기준으로 수정위치 탐색
                string Query = "update pos_dataset.tb_sales set no ='" + this.TBX_SerialNum.Text + "',name='" + this.TBX_ItemName.Text + "',price='" + this.TBX_Price.Text + "'," +
                    "count='" + this.TBX_Amount.Text + "',total='" + this.TBX_Total.Text + "' where no ='" + this.TBX_SerialNum.Text + "'";
                MySqlConnection conDataBase = new MySqlConnection(constring);
                MySqlCommand cmdDatabase = new MySqlCommand(Query, conDataBase);
                MySqlDataReader myReader;

                try
                {
                    conDataBase.Open();
                    myReader = cmdDatabase.ExecuteReader();
                    MessageBox.Show("수정완료");

                    while (myReader.Read())
                    {

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            LoadData();
        }

        private void TBX_Amount_TextChanged(object sender, EventArgs e)
        {

        }

        private void LBL_Amount_Click(object sender, EventArgs e)
        {

        }

        private void TBX_Price_TextChanged(object sender, EventArgs e)
        {

        }

        private void LBL_Price_Click(object sender, EventArgs e)
        {

        }

        private void TBX_TradeName_TextChanged(object sender, EventArgs e)
        {

        }

        private void LBL_TradeName_Click(object sender, EventArgs e)
        {

        }

        private void TBX_SerialNum_TextChanged(object sender, EventArgs e)
        {

        }

        private void BTN_BackSpace_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
