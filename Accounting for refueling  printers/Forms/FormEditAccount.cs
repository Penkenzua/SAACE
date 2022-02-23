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
    public partial class FormEditAccount : Form
    {
        private SqlConnection sqlConnection;

        public FormEditAccount()
        {
            InitializeComponent();
        }

       
        private void FormEditAccount_Load(object sender, EventArgs e)
        {
            //LoadTheme();
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
        }
        private void comboBox1_TextUpdate(object sender, EventArgs e)
        {
            try
            {
                SqlCommand Login = new SqlCommand($"Select LoginUser from Account where Account_ID = {comboBox1.Text}", sqlConnection);
                SqlCommand Password = new SqlCommand($"Select PasswordUser from Account where Account_ID = {comboBox1.Text}", sqlConnection);
                textBox1.Text = Login.ExecuteScalar().ToString();
                textBox2.Text = Password.ExecuteScalar().ToString();
            }
            catch (Exception)
            {

                throw;
            }
        
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {

        }
    }
}
