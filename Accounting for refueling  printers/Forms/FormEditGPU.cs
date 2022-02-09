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
    public partial class FormEditGPU : Form
    {
           private SqlConnection sqlConnection = null;
        public FormEditGPU()
        {
            InitializeComponent();
        }
        private void FormEdditGPU_Load(object sender, EventArgs e)
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
            SqlCommand command = new SqlCommand($"Select GPU_ID from GPU where GPU_ID = {textBox1.Text}", sqlConnection);
            if (textBox1.Text != "" && command.ExecuteScalar() != null)
            {
                SqlCommand Edit1 = new SqlCommand($"Select Производитель from GPU where GPU_ID = {textBox1.Text}", sqlConnection);
                SqlCommand Edit2 = new SqlCommand($"Select Графический_процессор from GPU where GPU_ID = {textBox1.Text}", sqlConnection);
                SqlCommand Edit3 = new SqlCommand($"Select Тип_памяти from GPU where GPU_ID = {textBox1.Text}", sqlConnection);
                SqlCommand Edit4 = new SqlCommand($"Select Шина_памяти from GPU where GPU_ID = {textBox1.Text}", sqlConnection);

                textBox2.Text = Edit1.ExecuteScalar().ToString();
                textBox3.Text = Edit2.ExecuteScalar().ToString();
                textBox4.Text = Edit3.ExecuteScalar().ToString();
                textBox5.Text = Edit4.ExecuteScalar().ToString();



            }
            else
            {
                MessageBox.Show("Запись таким ID не найдено", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";


            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand($"Select GPU_ID from GPU where GPU_ID = {textBox1.Text}", sqlConnection);
            if (textBox1.Text != "" && command.ExecuteScalar() != null)
            {
                SqlCommand Update1 = new SqlCommand($"Update GPU SET " +
                    $"Производитель = N'{textBox2.Text}' ," +
                    $"Графический_процессор =N'{textBox3.Text}'," +
                    $"Тип_памяти =N'{textBox4.Text}'," +
                    $"Шина_памяти = N'{textBox5.Text}' " +
                    $"where GPU_ID = {textBox1.Text}", sqlConnection);
                if (Update1.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Вставка успешно выполнена");
                    FormMainMenu.SelfRef.UpdateGPU();
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
