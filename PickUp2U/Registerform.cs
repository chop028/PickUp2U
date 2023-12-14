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
    public partial class Registerform : Form
    {
        public Registerform()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!button2.Enabled)
            {
                if (!(radioButton1.Checked && !string.IsNullOrWhiteSpace(rgId.Text) && !string.IsNullOrWhiteSpace(rgPw.Text) &&!string.IsNullOrWhiteSpace(rgName.Text) && !string.IsNullOrWhiteSpace(rgPhone.Text) && !string.IsNullOrWhiteSpace(rgMail.Text)))
                        {
                    MessageBox.Show("모든 정보를 입력하세요.");
                    return;
                }


                string connectionString = "User Id=admin; Password=admin; Data Source=(DESCRIPTION = (ADDRESS = (PROTOCOL = TCP)(HOST = localhost)(PORT = 1521)) (CONNECT_DATA = (SERVER = DEDICATED)(SERVICE_NAME = xe)) )";

                using (OracleConnection connection = new OracleConnection(connectionString))
                {
                    try
                    {
                        connection.Open();

                        string getMaxUserIdQuery = "SELECT MAX(USER_ID) FROM USERS";
                        OracleCommand getMaxUserIdCommand = new OracleCommand(getMaxUserIdQuery, connection);
                        int maxUserId = Convert.ToInt32(getMaxUserIdCommand.ExecuteScalar());

                        int USER_ID = maxUserId + 1;

                        int TYPE = radioButton1.Checked ? 0 : 1;
                        string IDENTITY = rgId.Text;
                        string PASSWORD = rgPw.Text;
                        string MEMBERSHIP = "Bronze";
                        string NAME = rgName.Text;
                        string PHONE = rgPhone.Text;
                        string EMAIL = rgMail.Text;

                        string query = $"INSERT INTO USERS (USER_ID, USER_TYPE, USER_IDENTITY, PASSWORD, MEMBERSHIP_ID, USER_NAME, PHONE_NUM, EMAIL) " +
                                       $"VALUES ({USER_ID}, {TYPE}, '{IDENTITY}', '{PASSWORD}', '{MEMBERSHIP}', '{NAME}', '{PHONE}', '{EMAIL}')";

                        OracleCommand command = new OracleCommand(query, connection);

                        command.ExecuteNonQuery();

                        MessageBox.Show("회원가입 성공.");
                        Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("에러 발생: " + ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("아이디 중복 검사해주세요.");
            }
        }



        private void button2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(rgId.Text))
            {
                MessageBox.Show("ID를 입력하세요.");
                return;
            }

            string connectionString = "User Id=admin; Password=admin; Data Source=(DESCRIPTION = (ADDRESS = (PROTOCOL = TCP)(HOST = localhost)(PORT = 1521)) (CONNECT_DATA = (SERVER = DEDICATED)(SERVICE_NAME = xe)) )";

            using (OracleConnection connection = new OracleConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    string checkUserIdQuery = $"SELECT COUNT(*) FROM USERS WHERE USER_IDENTITY = '{rgId.Text}'";
                    OracleCommand checkUserIdCommand = new OracleCommand(checkUserIdQuery, connection);
                    int existingRecords = Convert.ToInt32(checkUserIdCommand.ExecuteScalar());

                    if (existingRecords > 0)
                    {
                        MessageBox.Show("이미 존재하는 사용자 ID입니다. 다른 ID를 선택해주세요.");
                        return;
                    }
                    button2.Text = "확인";
                    button2.Enabled = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("에러 발생: " + ex.Message);
                }
            }
        }


    }
}
