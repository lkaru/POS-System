using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace POS_System
{
    public partial class Main : Form
    {
        DataTable table = new DataTable();

        public Main()
        {
            InitializeComponent();
            this.Load += Main_Load;

            table.Columns.Add("상품명", typeof(string));
            table.Columns.Add("가격", typeof(string));
            table.Columns.Add("개수", typeof(string));
            table.Columns.Add("총액", typeof(string));

            DGV.DataSource = table;
            NUD_Count.Value = 1;
        }

        private void Main_Load(object sender, EventArgs e)
        {
            MySqlConnection connection = new MySqlConnection("datasource=localhost;port=3306;username=root;password=lkaruQPALYFE_0623@MYSQL;");
            connection.Open();
            if (connection.State == ConnectionState.Open)
            {
                LBL_Connectivity.Text = "Server Connected";
                LBL_Connectivity.ForeColor = Color.Black;
            }
            else
            {
                LBL_Connectivity.Text = "Server DisConnected";
                LBL_Connectivity.ForeColor = Color.Red;
            }
        }

        private void BTN_Putting_Click(object sender, EventArgs e)
        {
            if (TBX_TradeName.Text == "" || TBX_Price.Text == "")
            {
                MessageBox.Show("항목을 정확히 입력해주세요");
                TBX_TradeName.Clear();
                TBX_Price.Clear();
            }
            else
            {
                //합계를 구하기 위해 품목명과 가격을 정의하고 total로 합침
                decimal price = decimal.Parse(TBX_Price.Text);
                decimal count = NUD_Count.Value;
                decimal total = price * count;

                //text박스내의 정보를 표에 삽입
                table.Rows.Add(TBX_TradeName.Text, price, count, total);
                DGV.DataSource = table;

                //text박스의 정보 초기화
                TBX_TradeName.Clear();
                TBX_Price.Clear();
                NUD_Count.Value = 1;

                //합계
                decimal all = 0;
                for (int i = 0; i < DGV.Rows.Count; ++i)
                {
                    all += Convert.ToDecimal(DGV.Rows[i].Cells[3].Value);
                }
                TBX_Total.Text = all.ToString();
            }
        }

        private void BTN_Cancel_Click(object sender, EventArgs e)
        {
            //행 지우기
            foreach (DataGridViewRow item in this.DGV.SelectedRows)
            {
                DGV.Rows.RemoveAt(item.Index);
            }

            //합계창에 수정된 값 넣기
            decimal all = 0;
            for (int i = 0; i < DGV.Rows.Count; ++i)
            {
                all += Convert.ToDecimal(DGV.Rows[i].Cells[3].Value);
            }

            TBX_Total.Text = all.ToString();
        }

        private void BTN_Calulate_Click(object sender, EventArgs e)
        {
            //DB연결 후 데이터 전송
            using (MySqlConnection conn = new MySqlConnection("Server=localhost;Port=3306;Database=pos_dataset;Uid=root;Pwd=lkaruQPALYFE_0623@MYSQL"))
            {
                try 
                {
                    conn.Open();
                }
                catch(Exception err)
                {
                    Console.WriteLine("catch : " + err.Message);
                }
                //각 행의 정보를 반복문으로 불러온다
                for (int i = 0; i < DGV.Rows.Count - 1; i++)
                {
                    String Name = DGV.Rows[i].Cells[0].Value.ToString();
                    String Price = DGV.Rows[i].Cells[1].Value.ToString();
                    String Count = DGV.Rows[i].Cells[2].Value.ToString();
                    String Total = DGV.Rows[i].Cells[3].Value.ToString();

                    //INSERT INTO 쿼리문으로 받아온 정보를 DB에 전송한다. 
                    string sql = string.Format("INSERT INTO table_sales(name,price,count,total,count_num) VALUES  ('{0}',{1},{2},{3},{4})", @Name, @Price, @Count, @Total, @i);

                    //DB전송을 진행하고 실패시 에러메세지 출력
                    try
                    {
                        MySqlCommand command = new MySqlCommand(sql, conn);
                        command.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }

            MessageBox.Show("계산되었습니다.");

            //데이터 그리드뷰 초기화
            int rowCount = DGV.Rows.Count;
            for (int n = 0; n < rowCount; n++)
            {
                if (DGV.Rows[0].IsNewRow == false)
                    DGV.Rows.RemoveAt(0);
            }

            //합계창 초기화
            TBX_Total.Text = "0";
        }
    }
}
