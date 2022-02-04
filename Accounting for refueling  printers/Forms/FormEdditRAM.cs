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
    public partial class FormEdditRAM : Form
    {
           private SqlConnection sqlConnection = null;
        public FormEdditRAM()
        {
            InitializeComponent();
        }

        private void FormEdditRAM_Load(object sender, EventArgs e)
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

        private void btnSearch_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand($"Select RAM_ID from RAM where RAM_ID = {textBox1.Text}", sqlConnection);
            if (textBox1.Text != "" && command.ExecuteScalar() != null)
            {
                SqlCommand Edit1 = new SqlCommand($"Select Название from RAM where RAM_ID = {textBox1.Text}", sqlConnection);
                SqlCommand Edit2 = new SqlCommand($"Select Производитель from RAM where RAM_ID = {textBox1.Text}", sqlConnection);
                SqlCommand Edit3 = new SqlCommand($"Select Тип from RAM where RAM_ID = {textBox1.Text}", sqlConnection);
                SqlCommand Edit4 = new SqlCommand($"Select Объём from RAM where RAM_ID = {textBox1.Text}", sqlConnection);

                textBox2.Text = Edit1.ExecuteScalar().ToString();


            }
            else
            {
                MessageBox.Show("Запись таким ID не найдено", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBox1.Text = "";

            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand($"Select RAM_ID from RAM where RAM_ID = {textBox1.Text}", sqlConnection);
            if (textBox1.Text != "" && command.ExecuteScalar() != null)
            {
                SqlCommand Update1 = new SqlCommand($"Update RAM SET " +
                    $"Название = N'{textBox2.Text}' ," +
                    $"Производитель = N'{textBox3.Text}'," +
                    $"Тип = N'{textBox4.Text}'," +
                    $"Объём = {textBox5.Text}" +
                    $"where RAM_ID = {textBox1.Text}", sqlConnection);
                if (Update1.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Вставка успешно выполнена");
                    FormMainMenu.SelfRef.UpdateRAM();
                }
                else
                {
                    MessageBox.Show("Введены неверные данные или неверный формат");
                    Update1.Cancel();
                }
            }
        }
    }
}
