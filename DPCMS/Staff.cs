using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DPCMS
{
    public partial class Staff : Form,login
    {
        public Staff()
        {
            InitializeComponent();
        }
        int user_id;
        string username;

       

        private void Staff_Load(object sender, EventArgs e)
        {

        }

       
        public void openform()
        {
            this.Show();
        }

        public void getUserInfo()
        {
            throw new NotImplementedException();
        }


//br
        private void button1_Click(object sender, EventArgs e)
        {
            Worker manager = new Employ(new Manager());

            manager.open();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Worker subordinate = new Employ(new Subordinate());

            subordinate.open();
        }
    }
}
