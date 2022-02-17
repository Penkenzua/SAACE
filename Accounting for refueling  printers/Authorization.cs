using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Accounting_for_refueling__printers
{
    public partial class Authorization : Form
    {
        private SqlConnection sqlConnection;
        
        
        public Authorization()
        {
            InitializeComponent();
            panelСhoice.Visible = true;
            panelAutorization.Visible = false;

        }


        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void Authorization_Load(object sender, EventArgs e)
        {
            sqlConnection = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename =" + Application.StartupPath + @"\Database.mdf; Integrated Security = True");
            sqlConnection.Open();
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    

        private void btnUser_Click(object sender, EventArgs e)
        {
            FormMainMenu formMainMenu = new FormMainMenu();
            formMainMenu.Show();
            AcessRight.Acess = 0;
        }

        private void btnAdministrator_Click(object sender, EventArgs e)
        {
            panelСhoice.Visible = false;
            panelAutorization.Visible = true;
            btnExit.Visible = true;
        }

        private void btnInput_Click(object sender, EventArgs e)
        {
            var LoginUser = textLogin.Text;
            var PasswordUser = textPassword.Text;
            SqlCommand Acess = new SqlCommand(@"Select * from Register where LoginUser= @ul and PasswordUser= @up " ,sqlConnection);
            Acess.Parameters.Add("@ul", sqlDbType: SqlDbType.VarChar).Value = LoginUser;
            Acess.Parameters.Add("@up", sqlDbType: SqlDbType.VarChar).Value = PasswordUser;


            if (Acess.ExecuteScalar()!= null)
            {
                AcessRight.Acess = 1;
                this.Hide();
                FormMainMenu formMainMenu = new FormMainMenu();
                formMainMenu.Show();
            }
            else
            {
                if (AcessRight.Count == 0)
                {
                    MessageBox.Show("Доступ закрыт");
                    Application.Exit();
                    
                }
                MessageBox.Show($"Логин или пароль неверный осталось {AcessRight.Count} попытки");
             
                AcessRight.Count -= 1;
              
            }
        }

        private void btnExit2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panelHeader1_MouseDown(object sender, MouseEventArgs e)
        {
             ReleaseCapture();
             SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
