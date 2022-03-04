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
            // TODO: данная строка кода позволяет загрузить данные в таблицу "databaseDataSetAcccount.Account". При необходимости она может быть перемещена или удалена.
            this.accountTableAdapter.Fill(this.databaseDataSetAcccount.Account);
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
                if (Login.ExecuteScalar()!=null && Password.ExecuteScalar()!=null )
                {
                textBox1.Text = Login.ExecuteScalar().ToString();
                textBox2.Text = Password.ExecuteScalar().ToString();
                }
                else
                {
                    MessageBox.Show("Такой записи нету");
                }
                
            }
            catch (Exception)
            {

                throw;
            }
        
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            SqlCommand sqlCommand = new SqlCommand($"Select Account_ID  form Account where Account_ID = {comboBox1.Text}", sqlConnection);
            if (sqlCommand.ExecuteScalar()!=null && textBox1.Text!="" && textBox2.Text!="")
            {
                SqlCommand Update = new SqlCommand($"Update Account SET " +
                   $"LoginUser = N'{textBox1.Text}'," +
                   $"PasswordUser = N'{textBox2.Text}' " +
                   $" where Cartridge_ID = {comboBox1.Text}", sqlConnection);
                if (Update.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Вставка успешно выполнена");
                    FormMainMenu.SelfRef.UpdateAccount();
                }
                else
                {
                    MessageBox.Show("Введены неверные данные");
                    Update.Cancel();
                }
            }
        }
    }
}
