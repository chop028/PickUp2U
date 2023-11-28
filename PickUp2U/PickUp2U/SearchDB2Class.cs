using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.DataAccess.Client;
using System.Data;
using System.Windows.Forms;

namespace PickUp2U
{
    class SearchDB2Class
    {
        private OracleDataAdapter dBAdapter;
        private DataSet dS;
        private DataTable phoneTable;
        private DataTable shopTable; // 새로운 테이블 추가
        private OracleCommandBuilder myCommandBuilder;
        private int selectedRowIndex;

        public int SelectedRowIndex
        {
            get { return selectedRowIndex; }
            set
            { selectedRowIndex = value; }
        }
        public OracleDataAdapter DBAdapter
        {
            get { return dBAdapter; }
            set { dBAdapter = value; }
        }

        public DataTable PhoneTable { get { return phoneTable; } }
        public DataTable ShopTable { get { return shopTable; } } // 새로운 테이블 추가

        public SearchDB2Class()
        {
            try
            {
                string connectionString = "User Id=admin; Password=admin; Data Source=(DESCRIPTION = (ADDRESS = (PROTOCOL = TCP)(HOST = localhost)(PORT = 1521)) (CONNECT_DATA = (SERVER = DEDICATED)(SERVICE_NAME = xe)) ); ";
                string productCommandString = "SELECT * FROM PRODUCT";
                string shopCommandString = "SELECT * FROM SHOP"; // 새로운 테이블 쿼리 추가

                dBAdapter = new OracleDataAdapter(productCommandString, connectionString);
                myCommandBuilder = new OracleCommandBuilder(dBAdapter);
                dS = new DataSet();
                dBAdapter.Fill(dS, "PRODUCT");
                phoneTable = dS.Tables["PRODUCT"];

                // 새로운 테이블 로드
                dBAdapter = new OracleDataAdapter(shopCommandString, connectionString);
                myCommandBuilder = new OracleCommandBuilder(dBAdapter);
                dBAdapter.Fill(dS, "SHOP");
                shopTable = dS.Tables["SHOP"];
            }
            catch (DataException DE)
            {
                MessageBox.Show(DE.Message);
            }
        }

        public void DB_Open_Product()
        {
            try
            {
                string connectionString = "User Id=admin; Password=admin; Data Source=(DESCRIPTION = (ADDRESS = (PROTOCOL = TCP)(HOST = localhost)(PORT = 1521)) (CONNECT_DATA = (SERVER = DEDICATED)(SERVICE_NAME = xe)) ); ";
                string commandString = "SELECT * FROM PRODUCT";
                dBAdapter = new OracleDataAdapter(commandString, connectionString);
                myCommandBuilder = new OracleCommandBuilder(dBAdapter);
                dS = new DataSet();
                dBAdapter.Fill(dS, "product");

                phoneTable = dS.Tables["product"];
            }
            catch (DataException DE)
            {
                MessageBox.Show(DE.Message);
            }
        }

        public void DB_Open()
        {
            // 데이터베이스 연결 코드
        }

        public DataSet DS { get { return dS; } set { dS = value; } }
    }
}
