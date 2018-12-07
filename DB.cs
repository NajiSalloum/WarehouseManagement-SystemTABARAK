using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Windows.Forms;
using System.Data;

namespace Tabarak
{
    class DB
    {
        OleDbConnection conn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0; Data Source=" + Application.StartupPath + @"\Tbarak.accdb; Jet OLEDB:Database Password=123;");
        OleDbCommand cmd = new OleDbCommand();
        public void SetCommand(String SQLStatement)
        {
            cmd.Connection = conn;
            cmd.CommandText = SQLStatement;
        }
        public bool RunNonQuery(String SQLStatement, String Message)
        {   
            try
            {
                SetCommand(SQLStatement);
                conn.Open();
                cmd.ExecuteNonQuery();
                if (Message != "")
                    MessageBox.Show(Message);
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message );
                return false;
            }
            finally
            {
                conn.Close();
            }

            

        }
        public DataTable RunReader(String SelectStatement)
        {
            DataTable tbl = new DataTable();
            SetCommand(SelectStatement );
            conn.Open();
            tbl.Load(cmd.ExecuteReader());
            conn.Close();
            return tbl;
        }

    }
}
