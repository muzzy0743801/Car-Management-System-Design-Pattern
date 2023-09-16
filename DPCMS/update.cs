using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPCMS
{
    class update: Action
    {

        DPCMS_CONNECTION connection = DPCMS_CONNECTION.getinst();
        

        public void proceed(int id)
        {
            throw new NotImplementedException();
        }

        public void proceed(string fname, string lname, string phone)
        {
            throw new NotImplementedException();
        }


        public void proceed(int id, string fname, string lname, string phone)
        {
            connection.insert_Connection_string("server=DESKTOP-J114GEE;Initial Catalog=DPCMS;Integrated Security=True");

            connection.connect_open();
            string update = "update c_user set f_name ='" + fname + "' ,l_name ='" + lname + "',phone ='" + phone + "'   where c_user_id = " + id + "";
            SqlCommand com = new SqlCommand(update, connection.con);
            com.ExecuteNonQuery();

            connection.connect_close();
        }
    }
}
