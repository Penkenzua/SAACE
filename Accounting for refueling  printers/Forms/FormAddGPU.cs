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
    public partial class FormAddGPU : Form
    {
              private SqlConnection sqlConnection = null;
        public FormAddGPU()
        {
            InitializeComponent();
        }

        private void FormAddGPU_Load(object sender, EventArgs e)
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
            if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "")
            {
                SqlCommand command = new SqlCommand("INSERT INTO [GPU] (Производитель,Графический_процессор,Тип_памяти,Шина_памяти) VALUES(@Производитель,@Графический_процессор,@Тип_памяти,@Шина_памяти)", sqlConnection);
                command.Parameters.AddWithValue("Производитель", textBox1.Text);
                command.Parameters.AddWithValue("Графический_процессор", textBox2.Text);
                command.Parameters.AddWithValue("Тип_памяти", textBox3.Text);
                command.Parameters.AddWithValue("Шина_памяти", textBox4.Text);

                if (command.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Вставка успешна завершена");
                    FormMainMenu.SelfRef.UpdateGPU();

                }
            }
            else
            {
                MessageBox.Show("Заполните все поля", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
