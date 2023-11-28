using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;
using Oracle.DataAccess.Client;

namespace UserForm
{
    class DBClass_user
    {
        private OracleDataAdapter dBAdapter;
        private DataSet dS;
        private DataTable userTable;
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

        public DataTable UserTable { get { return userTable; } }

        public DBClass_user()
        {
            try
            {
                string connectionString = "User Id=admin; Password=admin; Data Source=(DESCRIPTION = (ADDRESS = (PROTOCOL = TCP)(HOST = localhost)(PORT = 1521)) (CONNECT_DATA = (SERVER = DEDICATED)(SERVICE_NAME = xe)) ); ";
                string commandString = "SELECT * FROM \"USER\"";
                //string commandString = "SELECT shop_name, shop_location FROM shop"; 
                dBAdapter = new OracleDataAdapter(commandString, connectionString);
                myCommandBuilder = new OracleCommandBuilder(dBAdapter);
                dS = new DataSet();
                dBAdapter.Fill(dS, "\"USER\"");
                userTable = dS.Tables["\"USER\""];


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
