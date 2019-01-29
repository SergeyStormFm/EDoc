using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.OleDb;

namespace EDoc
{
    public partial class logins : Form
    {
       
     
        public logins()
        {
            InitializeComponent();
        }

        private void btn_logins_Click(object sender, EventArgs e)
        {
            EDoc frm1 = new EDoc();
            frm1.Activate();
            frm1.Show();
            this.Hide();
          //  }
            // Create a command ad set its connection  
    //        OleDbCommand command = new OleDbCommand(strSQL, connection);
            // Open the connection and execute the select command.  
            // Open connecton  
      //      connection.Open();
            // Execute command  
      //      OleDbDataReader reader = command.ExecuteReader();
            //Console.WriteLine("------------Original data----------------");  
          //  while (reader.Read())
          //  {
                //Console.WriteLine("{0} {1}", reader["Name"].ToString(), reader["Address"].ToString());  
          //  }
       
        }
        private void btn_cancels_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }      

        private void logins_Load(object sender, EventArgs e)
        {
           

        }

      

       
    }
}
