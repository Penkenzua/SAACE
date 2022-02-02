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
    public partial class FormAddRAM : Form
    {
           private SqlConnection sqlConnection = null;
        public FormAddRAM()
        {
            InitializeComponent();
        }

        private void FormAddRAM_Load(object sender, EventArgs e)
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
            if (textBox1.Text != ""&&textBox2.Text != ""&&textBox3.Text != ""&&textBox4.Text != "")
            {


                SqlCommand command = new SqlCommand("INSERT INTO [RAM] (Название,Производитель,Тип,Объём) VALUES(@Название,@Производитель,@Тип,@Объём)", sqlConnection);
                command.Parameters.AddWithValue("Название", textBox1.Text);
                command.Parameters.AddWithValue("Производитель", textBox2.Text);
                command.Parameters.AddWithValue("Тип", textBox3.Text);
                command.Parameters.AddWithValue("Объём", textBox4.Text);
                if (command.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Вставка успешна завершена");
                    FormMainMenu.SelfRef.UpdateRAM();

                }
            }
            else
            {
                MessageBox.Show("Заполните все поля", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
