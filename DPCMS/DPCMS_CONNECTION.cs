using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DPCMS
{
    class DPCMS_CONNECTION
    {
        //singleton
        private static DPCMS_CONNECTION inst; 


        private DPCMS_CONNECTION() { }

        public static DPCMS_CONNECTION getinst(){
            if (inst==null)
            {
               inst = new DPCMS_CONNECTION();
            }
            return inst;
        }

       public  SqlConnection con;

        private string connection_string;
        public void insert_Connection_string(string a)
        {
            connection_string = a;
        
        }
        public void connect_open()
        {
            try
            {
                con = new SqlConnection(connection_string);
                con.Open();
                //label3.Text = "ACTIVE";

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                //label3.Text = "DISABLED";
            }
        }

        public void connect_close()
        {
            try
            {
                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                //label3.Text = "DISABLED";
            }
        }

    }
}
