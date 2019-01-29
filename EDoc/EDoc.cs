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

namespace EDoc
{
    public partial class EDoc : Form
    {
        public static int users = 0;
        public EDoc()
        {
            InitializeComponent();
        }

        private void EDoc_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "eDOCDataSet.kor_in". При необходимости она может быть перемещена или удалена.
            this.kor_inTableAdapter.Fill(this.eDOCDataSet.kor_in);

            //OleDbCommand cmd = con.CreateCommand();
            //con.Open();
            //cmd.CommandText = "Insert into Student(FirstName,LastName)Values('" + textBox1.Text + "','" + textBox2.Text + "')";
            //cmd.Connection = con;
            //cmd.ExecuteNonQuery();
            //MessageBox.Show("Record Submitted", "Congrats");
            //con.Close();   
        }

        private void kor_inBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.kor_inBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.eDOCDataSet);

        }

    
    }
}
