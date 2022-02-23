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
    public partial class FormAddAccount : Form
    {
        private SqlConnection sqlConnection = null;

        public FormAddAccount()
        {
            InitializeComponent();
        }

        private void FormAddAccount_Load(object sender, EventArgs e)
        {
            LoadTheme();

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

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (textLogin.Text!="" && textPassword.Text!="")
            {
                var LoginUser = textLogin.Text;
                var PasswordUser = textPassword.Text;
                SqlCommand Acess = new SqlCommand(@"Select * from Account where LoginUser= @ul and PasswordUser= @up ", sqlConnection);
                Acess.Parameters.Add("@ul", sqlDbType: SqlDbType.VarChar).Value = LoginUser;
                Acess.Parameters.Add("@up", sqlDbType: SqlDbType.VarChar).Value = PasswordUser;
                if (Acess.ExecuteScalar()!=null)
                {
                    MessageBox.Show("Данный аккаунт уже занят");
                }
                else
                {
                    SqlCommand AddAccount = new SqlCommand("INSERT INTO [Account](LoginUser,PasswordUser,RightAcess) VALUES(@LoginUser,@PasswordUser,@RightAcess)", sqlConnection);
                    AddAccount.Parameters.AddWithValue("LoginUser",LoginUser);
                    AddAccount.Parameters.AddWithValue("PasswordUser",PasswordUser);
                    AddAccount.Parameters.AddWithValue("RightAcess",0);
                    if (AddAccount.ExecuteNonQuery() == 1)
                    {
                        MessageBox.Show("Вставка успешна завершена");
                        FormMainMenu.SelfRef.UpdateAccount();

                    }
                }





            }
        }
        void LoadTheme()
        {
            foreach (Control btns in this.Controls)
            {
                if (btns.GetType() == typeof(Button))
                {
                    Button btn = (Button)btns;
                    btn.BackColor = ThemeColor.PrimaryColor;
                    btn.ForeColor = Color.White;
                    btn.FlatAppearance.BorderColor = ThemeColor.SecondaryColor;
                }
            }
            label1.ForeColor = ThemeColor.PrimaryColor;
            label2.ForeColor = ThemeColor.PrimaryColor;
            textLogin.ForeColor = ThemeColor.PrimaryColor;
            textPassword.ForeColor = ThemeColor.PrimaryColor;

        }
    }
}
