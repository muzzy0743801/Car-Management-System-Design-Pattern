using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DPCMS
{
    public partial class User : Form, login
    {
        public User()
        {
            InitializeComponent();

            setDGV();
        }

        DPCMS_CONNECTION connection = DPCMS_CONNECTION.getinst();


        //APPLYING FACADE PATTERN (structural pattern) TO INSERT UPDATE AND DELETE


        ActionMaker act = new ActionMaker();

        public void setDGV()
        {
            connection.insert_Connection_string("server=DESKTOP-J114GEE;Initial Catalog=DPCMS;Integrated Security=True");

            connection.connect_open();
            SqlDataAdapter da = new SqlDataAdapter(" select * from c_user name", connection.con);
            DataSet ds = new DataSet();
            da.Fill(ds, "Users ");
            dataGridView1.DataSource = ds.Tables[0];
            ds.Tables.Clear();
            connection.connect_close();
        
        }

        private int id;
               

        private void User_Load(object sender, EventArgs e)
        {

        }



        public void getUserInfo()
        {
            throw new NotImplementedException();
        }

        public void openform()
        {
            this.Show();
        }

        string fname, lname, phone;

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                id = Convert.ToInt16(row.Cells["c_user_id"].Value);
                fname = row.Cells["f_name"].Value.ToString();
                lname = row.Cells["l_name"].Value.ToString();
                phone = row.Cells["phone"].Value.ToString();

                textBox6.Text = row.Cells["f_name"].Value.ToString();
                textBox5.Text = row.Cells["l_name"].Value.ToString();
                textBox4.Text = row.Cells["phone"].Value.ToString();

               
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                act.Delete(id);

                setDGV();
                
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                act.Update(id, textBox6.Text, textBox5.Text, textBox4.Text);

                setDGV();

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                act.Insert(textBox1.Text, textBox2.Text, textBox3.Text);

                setDGV();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
