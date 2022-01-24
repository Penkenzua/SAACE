using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Accounting_for_refueling__printers.Forms
{
    public partial class FormEdditPC : Form
    {
         private SqlConnection sqlConnection = null;
        public FormEdditPC()
        {
            InitializeComponent();
        }

        private void FormEdditPC_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "databaseDataSet.PC". При необходимости она может быть перемещена или удалена.
            this.pCTableAdapter.Fill(this.databaseDataSet.PC);

          
         
            try
            {
                sqlConnection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + Application.StartupPath + @"\Database.mdf;Integrated Security=True");
                sqlConnection.Open();
            }
            catch
            {
                sqlConnection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + PathDatabase.Path + ";Integrated Security=True");
                sqlConnection.Open();
            }
            comboBox1.Text = " ";
            comboBox2.Text = " ";
            comboBox3.Text = " ";
            comboBox4.Text = " ";
            comboBox5.Text = " ";

        }

    

        private void btnOutput_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand($"Select PC_ID from PC where PC_ID = {comboBox1.Text}", sqlConnection);
            if (comboBox1.Text != "" && command.ExecuteScalar() != null)
            {
                SqlCommand Edit1 = new SqlCommand($"Select Модель from PC where PC_ID ={comboBox1.Text}", sqlConnection);
                SqlCommand Edit2 = new SqlCommand($"Select OC from PC where PC_ID ={comboBox1.Text}", sqlConnection);
                SqlCommand Edit3 = new SqlCommand($"Select CPU from PC where PC_ID ={comboBox1.Text}", sqlConnection);
                SqlCommand Edit4 = new SqlCommand($"Select GPU from PC where PC_ID ={comboBox1.Text}", sqlConnection);
                SqlCommand Edit5 = new SqlCommand($"Select RAM from PC where PC_ID ={comboBox1.Text}", sqlConnection);
                textBox1.Text = Edit1.ExecuteScalar().ToString();
                comboBox2.Text = Edit2.ExecuteScalar().ToString();
                comboBox3.Text = Edit3.ExecuteScalar().ToString();
                comboBox4.Text = Edit4.ExecuteScalar().ToString();
                comboBox5.Text = Edit5.ExecuteScalar().ToString();

            }
        }
    }
}
