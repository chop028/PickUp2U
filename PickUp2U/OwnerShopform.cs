using Oracle.DataAccess.Client;
using System;
using System.Windows.Forms;

namespace PickUp2U
{
    public partial class OwnerShopform : Form
    {
        private int userId;
        public OwnerShopform(int userId)
        {
            InitializeComponent();
            this.userId = userId;
            InitializeListView();
        }

        private void InitializeListView()
        {
            listViewOwnerShops.View = View.Details;
            listViewOwnerShops.Columns.Add("매장ID", 60);
            listViewOwnerShops.Columns.Add("매장명", 150);
            listViewOwnerShops.Columns.Add("전화번호", 120);
            listViewOwnerShops.Columns.Add("매장주소", 200);
        }

        private void Btninquiry_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Btninquiry_Click 이벤트 발생");
            LoadOwnerShops(userId);
        }

        private void LoadOwnerShops(int userId)
        {
            Console.WriteLine("LoadOwnerShops 메서드 호출");

            listViewOwnerShops.Items.Clear();

            string connectionString = "User Id=admin;Password=admin;Data Source=(DESCRIPTION = (ADDRESS = (PROTOCOL = TCP)(HOST = localhost)(PORT = 1521))(CONNECT_DATA = (SERVER =DEDICATED)(SERVICE_NAME = xe)) )";

            using (OracleConnection connection = new OracleConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    string selectShopsQuery = "SELECT S.SHOP_ID, S.SHOP_NAME, S.SHOP_TELEPHONE, S.SHOP_LOCATION " +
                          "FROM SHOPS S " +
                          "JOIN USERS U ON S.USER_ID = U.USER_ID " +
                          "WHERE U.USER_TYPE = 1 AND U.USER_ID = " + userId; ;

                    OracleCommand selectShopsCommand = new OracleCommand(selectShopsQuery, connection);
                    selectShopsCommand.Parameters.Add(":UserID", OracleDbType.Int32).Value = userId;


                    using (OracleDataReader reader = selectShopsCommand.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                ListViewItem item = new ListViewItem(reader["SHOP_ID"].ToString());
                                item.SubItems.Add(reader["SHOP_NAME"].ToString());
                                item.SubItems.Add(reader["SHOP_TELEPHONE"].ToString());
                                item.SubItems.Add(reader["SHOP_LOCATION"].ToString());

                                listViewOwnerShops.Items.Add(item);
                            }
                        }
                        else
                        {
                            MessageBox.Show("보유하고 있는 매장이 없습니다.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");
                }
            }
        }

        // ... (다른 메서드 및 이벤트 핸들러 참조)
    }
}
