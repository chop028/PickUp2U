using Oracle.DataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PickUp2U
{
    public partial class Loginform : Form
    {
        public Loginform()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Registerform Registerform = new Registerform(); // 이동하고자 하는 폼으로 변경
            Registerform.ShowDialog();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {

            string inputIdentity = txtId.Text; // 확인할 사용자 IDENTITY 값

            string connectionString = "User Id=admin; Password=admin; Data Source=(DESCRIPTION = (ADDRESS = (PROTOCOL = TCP)(HOST = localhost)(PORT = 1521)) (CONNECT_DATA = (SERVER = DEDICATED)(SERVICE_NAME = xe)) )";

            // 데이터베이스에서 USER_IDENTITY가 입력된 값과 일치하는 데이터의 PASSWORD 및 USER_TYPE 값을 가져오는 쿼리
            string query = "SELECT USER_ID, PASSWORD, USER_TYPE FROM USERS WHERE USER_IDENTITY = :userIdentity";

            using (OracleConnection connection = new OracleConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    OracleCommand command = new OracleCommand(query, connection);
                    command.Parameters.Add(":userIdentity", OracleDbType.Varchar2).Value = inputIdentity;

                    OracleDataReader reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        string password = reader["PASSWORD"].ToString();
                        int userType = Convert.ToInt32(reader["USER_TYPE"]);
                        int userId = Convert.ToInt32(reader["USER_ID"]); // 사용자 ID 값을 변수에 저장

                        if (password == txtPW.Text)
                        {
                            if (userType == 0)
                            {
                                MainUserform.userId = userId;
                                MessageBox.Show("[0] 환영합니다.\n 회원번호 = " +userId);
                                MainUserform userForm = new MainUserform();
                                userForm.Show();
                                this.Hide();
                            }
                            else if (userType == 1)
                            {
                                MainOwnerform.userId = userId;
                                MessageBox.Show("[1] 환영합니다.\n 회원번호 = " + userId);
                                MainOwnerform ownerForm = new MainOwnerform();
                                ownerForm.Show();
                                this.Hide();
                            }
                        }
                        else
                        {
                            MessageBox.Show("비밀번호가 일치하지 않습니다.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("해당 사용자가 존재하지 않습니다.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("에러 발생: " + ex.Message);
                }
            }
        }

    }



}
