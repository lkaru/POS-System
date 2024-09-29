using System;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace POS_System
{
    public partial class Form_TheSalesGoods : Form
    {
        DataTable table = new DataTable();

        public Form_TheSalesGoods()
        {
            InitializeComponent();
            this.Load += Form_TheSalesGoods_Load;

            // 테이블 컬럼 정의
            table.Columns.Add("상품명", typeof(string));
            table.Columns.Add("가격", typeof(decimal));
            table.Columns.Add("개수", typeof(decimal));
            table.Columns.Add("총액", typeof(decimal));

            DGV_TheSalesGoods.DataSource = table;
            NUD_Count.Value = 1;

            // 로그인 정보에 따른 UI 표시 설정
            if (Form_LogIn.chk == "0")
            {
                LBL_Job.Text = "매니저님 반갑습니다.";
                BTN_StockStatus.Visible = true;
                BTN_MemberList.Visible = true;
            }
            else
            {
                LBL_Job.Text = "사원님 반갑습니다.";
                BTN_StockStatus.Visible = false;
                BTN_MemberList.Visible = false;
            }
        }

        private void Form_TheSalesGoods_Load(object sender, EventArgs e)
        {
            // 데이터베이스 연결 상태 표시
            using (MySqlConnection connection = new MySqlConnection("datasource=localhost;port=3306;username=root;password=lkaruQPALYFE_0623@MYSQL;"))
            {
                try
                {
                    connection.Open();
                    if (connection.State == ConnectionState.Open)
                    {
                        LBL_Connectivity.Text = "Server Connected";
                        LBL_Connectivity.ForeColor = Color.Black;
                    }
                }
                catch
                {
                    LBL_Connectivity.Text = "Server DisConnected";
                    LBL_Connectivity.ForeColor = Color.Red;
                }
            }
        }

        private void Form_SerialConnection_Closed(object sender, FormClosedEventArgs e)
        {
            if (Form_SerialConnection.mySerialPort != null && Form_SerialConnection.mySerialPort.IsOpen)
            {
                Form_SerialConnection.mySerialPort.DataReceived += MySerialPort_DataReceived;
            }
        }

        private void MySerialPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            try
            {
                SerialPort sp = (SerialPort)sender;
                string indata = sp.ReadLine().Replace("\r\n", "").Replace("\n", "").Replace("\r", "");
                Console.Write(indata);

                // 데이터베이스에서 해당 데이터를 조회
                DataTable result = GetItemFromDatabase(indata);
                if (result.Rows.Count > 0)
                {
                    DataRow row = result.Rows[0];
                    string itemName = row["ItemName"].ToString();
                    decimal itemPrice = Convert.ToDecimal(row["ItemPrice"]);

                    this.Invoke(new MethodInvoker(delegate
                    {
                        // 데이터 그리드 뷰에 추가 또는 업데이트
                        AddOrUpdateItem(itemName, itemPrice);

                        // 합계 갱신
                        decimal all = 0;
                        for (int i = 0; i < DGV_TheSalesGoods.Rows.Count; ++i)
                        {
                            all += Convert.ToDecimal(DGV_TheSalesGoods.Rows[i].Cells[3].Value);
                        }
                        TBX_Total.Text = all.ToString();
                    }));
                }
                else
                {
                    MessageBox.Show("아이템을 찾을 수 없습니다.");
                }
            }
            catch (Exception ex)
            {
                this.Invoke(new MethodInvoker(delegate
                {
                    MessageBox.Show(ex.Message);
                }));
            }
        }

        private DataTable GetItemFromDatabase(string itemId)
        {
            DataTable dt = new DataTable();
            string query = "SELECT ItemName, ItemPrice FROM tb_itemid WHERE ItemId = @itemId";
            using (MySqlConnection conn = new MySqlConnection("Server=localhost;Port=3306;Database=pos_dataset;Uid=root;Pwd=lkaruQPALYFE_0623@MYSQL"))
            {
                try
                {
                    conn.Open();
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@itemId", itemId);

                        using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                        {
                            adapter.Fill(dt);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

            return dt;
        }

        private void AddOrUpdateItem(string itemName, decimal itemPrice)
        {
            bool itemExists = false;

            foreach (DataRow row in table.Rows)
            {
                if (row["상품명"].ToString() == itemName)
                {
                    row["개수"] = (decimal)row["개수"] + 1;
                    row["총액"] = (decimal)row["가격"] * (decimal)row["개수"];
                    itemExists = true;
                    break;
                }
            }

            if (!itemExists)
            {
                table.Rows.Add(itemName, itemPrice, 1, itemPrice);
            }

            DGV_TheSalesGoods.DataSource = table;

            // 합계 갱신
            decimal all = 0;
            for (int i = 0; i < DGV_TheSalesGoods.Rows.Count; ++i)
            {
                all += Convert.ToDecimal(DGV_TheSalesGoods.Rows[i].Cells[3].Value);
            }
            TBX_Total.Text = all.ToString();
        }

        private void BTN_Putting_Click(object sender, EventArgs e)
        {
            if (TBX_ItemName.Text == "" || TBX_Price.Text == "")
            {
                MessageBox.Show("항목을 정확히 입력해주세요");
                TBX_ItemName.Clear();
                TBX_Price.Clear();
            }
            else
            {
                // 합계를 구하기 위해 품목명과 가격을 정의하고 total로 합침
                decimal price = decimal.Parse(TBX_Price.Text);
                decimal count = NUD_Count.Value;
                decimal total = price * count;

                // 텍스트 박스의 정보를 표에 삽입
                table.Rows.Add(TBX_ItemName.Text, price, count, total);
                DGV_TheSalesGoods.DataSource = table;

                // 텍스트 박스의 정보 초기화
                TBX_ItemName.Clear();
                TBX_Price.Clear();
                NUD_Count.Value = 1;

                // 합계 갱신
                decimal all = 0;
                for (int i = 0; i < DGV_TheSalesGoods.Rows.Count; ++i)
                {
                    all += Convert.ToDecimal(DGV_TheSalesGoods.Rows[i].Cells[3].Value);
                }
                TBX_Total.Text = all.ToString();
            }
        }

        private void BTN_Cancel_Click(object sender, EventArgs e)
        {
            // 선택된 행 지우기
            foreach (DataGridViewRow item in this.DGV_TheSalesGoods.SelectedRows)
            {
                DGV_TheSalesGoods.Rows.RemoveAt(item.Index);
            }

            // 합계 갱신
            decimal all = 0;
            for (int i = 0; i < DGV_TheSalesGoods.Rows.Count; ++i)
            {
                all += Convert.ToDecimal(DGV_TheSalesGoods.Rows[i].Cells[3].Value);
            }

            TBX_Total.Text = all.ToString();
        }

        private void BTN_Calculate_Click(object sender, EventArgs e)
        {
            // DB 연결 후 데이터 전송
            using (MySqlConnection conn = new MySqlConnection("Server=localhost;Port=3306;Database=pos_dataset;Uid=root;Pwd=lkaruQPALYFE_0623@MYSQL"))
            {
                try
                {
                    conn.Open();
                }
                catch (Exception err)
                {
                    Console.WriteLine("catch : " + err.Message);
                    return;
                }

                // 각 행의 정보를 반복문으로 불러온다
                for (int i = 0; i < DGV_TheSalesGoods.Rows.Count - 1; i++)
                {
                    String Name = DGV_TheSalesGoods.Rows[i].Cells[0].Value.ToString();
                    String Price = DGV_TheSalesGoods.Rows[i].Cells[1].Value.ToString();
                    String Count = DGV_TheSalesGoods.Rows[i].Cells[2].Value.ToString();
                    String Total = DGV_TheSalesGoods.Rows[i].Cells[3].Value.ToString();

                    // INSERT INTO 쿼리문으로 받아온 정보를 DB에 전송한다.
                    string sql = string.Format("INSERT INTO tb_sales(name,price,count,total,count_num) VALUES  ('{0}',{1},{2},{3},{4})", Name, Price, Count, Total, i);

                    // DB 전송을 진행하고 실패시 에러 메시지 출력
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

            // 데이터 그리드뷰 초기화
            int rowCount = DGV_TheSalesGoods.Rows.Count;
            for (int n = 0; n < rowCount; n++)
            {
                if (DGV_TheSalesGoods.Rows[0].IsNewRow == false)
                    DGV_TheSalesGoods.Rows.RemoveAt(0);
            }

            // 합계창 초기화
            TBX_Total.Text = "0";
        }

        private void BTN_StockStatus_Click(object sender, EventArgs e)
        {
            Form_StockStatus form_stockStatus = new Form_StockStatus();
            form_stockStatus.ShowDialog();
        }

        private void BTN_SalesHistory_Click(object sender, EventArgs e)
        {
            Form_SalesHistory form_salesHistory = new Form_SalesHistory();
            form_salesHistory.ShowDialog();
        }

        private void BTN_SerialPanel_Click(object sender, EventArgs e)
        {
            Form_SerialConnection form_serialConnection = new Form_SerialConnection();
            form_serialConnection.FormClosed += new FormClosedEventHandler(Form_SerialConnection_Closed);
            form_serialConnection.ShowDialog();
        }
    }
}
