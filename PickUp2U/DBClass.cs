using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading.Tasks;
using Oracle.DataAccess.Client;

namespace PickUp2U
{
    public class DBClass
    {
        private OracleDataAdapter dBAdapter;
        private DataSet dS;
        private DataTable phoneTable;
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

        public DBClass()
        {
            // 생성자에서 초기화
            try
            {
                string connectionString = "User Id=admin; Password=admin; Data Source=(DESCRIPTION = (ADDRESS = (PROTOCOL = TCP)(HOST = localhost)(PORT = 1521)) (CONNECT_DATA = (SERVER = DEDICATED)(SERVICE_NAME = xe)) ); ";
                string commandString = "SELECT * FROM shops"; 
                                                            
                dBAdapter = new OracleDataAdapter(commandString, connectionString);
                myCommandBuilder = new OracleCommandBuilder(dBAdapter);
                dS = new DataSet();
                dBAdapter.Fill(dS, "shops"); 
                phoneTable = dS.Tables["shops"]; 
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
                string commandString = "SELECT * FROM products";
                dBAdapter = new OracleDataAdapter(commandString, connectionString);
                myCommandBuilder = new OracleCommandBuilder(dBAdapter);
                dS = new DataSet();
                dBAdapter.Fill(dS, "products"); 
                phoneTable = dS.Tables["products"]; 
            }
            catch (DataException DE)
            {
                MessageBox.Show(DE.Message);
            }
        }



        public void DB_Open()
        {

        }

        public DataSet DS { get { return dS; } set { dS = value; } }

    }

}