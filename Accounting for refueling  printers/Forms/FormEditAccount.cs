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
            LoadTheme();
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
        

        private void btnEdit_Click(object sender, EventArgs e)
        {
            SqlCommand sqlCommand = new SqlCommand($"Select Account_ID  from Account where Account_ID = {textBox1.Text}", sqlConnection);
            if (textBox1.Text!="" &&sqlCommand.ExecuteScalar()!= null)
            {


                if (textBox2.Text != "" && textBox3.Text != "")
                {
                    SqlCommand Update = new SqlCommand($"Update Account SET " +
                       $"LoginUser = N'{textBox2.Text}'," +
                       $"PasswordUser = N'{textBox3.Text}' " +
                       $" where Cartridge_ID = {textBox1.Text}", sqlConnection);
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
                else
                {
                    MessageBox.Show("Заполните все поля", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                }
            }
            else
            {
            MessageBox.Show("Такой записи нету или не введён идентификатор", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
           

        }
        void LoadTheme()
        {
            foreach (Control btns in this.Controls)
            {
                if (btns.GetType() == typeof(Button))
                {
                    Button btn = (Button)btns;
                    btns.BackColor = ThemeColor.PrimaryColor;
                    btns.ForeColor = Color.White;
                    btn.FlatAppearance.BorderColor = ThemeColor.SecondaryColor;
                }
            }
            label1.ForeColor = ThemeColor.PrimaryColor;
            label2.ForeColor = ThemeColor.PrimaryColor;
            label3.ForeColor = ThemeColor.PrimaryColor;
                      
            textBox1.ForeColor = ThemeColor.PrimaryColor;
            textBox2.ForeColor = ThemeColor.PrimaryColor;
            textBox3.ForeColor = ThemeColor.PrimaryColor;


 

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand($"Select Account_ID from Account where Account_ID = {textBox1.Text}", sqlConnection);
            if (textBox1.Text != "" && command.ExecuteScalar() != null)
            {
                SqlCommand Edit1 = new SqlCommand($"Select LoginUser from Account where Account_ID ={textBox1.Text}", sqlConnection);
                SqlCommand Edit2 = new SqlCommand($"Select PasswordUser from Account where Account_ID ={textBox1.Text}", sqlConnection);

                textBox2.Text = Edit1.ExecuteScalar().ToString();
                textBox3.Text = Edit2.ExecuteScalar().ToString();

            }
            else
            {
                MessageBox.Show("Запись таким ID не найдено", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";


            }
        }
    }
}
