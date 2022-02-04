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
    public partial class FormAddCPU : Form
    {
         private SqlConnection sqlConnection = null;
        public FormAddCPU()
        {
            InitializeComponent();
        }

        private void FormAddCPU_Load(object sender, EventArgs e)
        {
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
            if (textBox1.Text!=""&&textBox2.Text!="")
            {


                SqlCommand command = new SqlCommand("INSERT INTO [CPU] (Название,Производитель) VALUES(@Название,@Производитель)", sqlConnection);
                command.Parameters.AddWithValue("Название", textBox1.Text);
                command.Parameters.AddWithValue("Производитель", textBox1.Text);
                if (command.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Вставка успешна завершена");
                    FormMainMenu.SelfRef.UpdateCPU();

                }
            }
            else
            {
                 MessageBox.Show("Заполните все поля", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }

    }
}
