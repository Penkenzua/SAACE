using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace Accounting_for_refueling__printers.Forms
{
    public partial class FormEddit : Form
    {
        private SqlConnection sqlConnection = null;
        public FormEddit()
        {
            InitializeComponent();
        }

        private void FormEddit_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "databaseDataSet2.Printer". При необходимости она может быть перемещена или удалена.
            this.printerTableAdapter.Fill(this.databaseDataSet2.Printer);

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


            LoadTheme();
            comboBox1.Text = "";




        }
        private void btnAdd_Click(object sender, EventArgs e)
        {

            DateTime date = DateTime.Parse(dateTimePicker1.Text);
            SqlCommand command = new SqlCommand($"Select id from Printer where id = {textBox1.Text}", sqlConnection);
            if (textBox1.Text != "" && command.ExecuteScalar() != null)
            {
                SqlCommand Update1 = new SqlCommand($"Update Printer SET " +
                    $"Дата = '{date.Month}/{date.Day}/{date.Year}'," +
                    $"Кабинет = N'{textBox2.Text}'," +
                    $"Модель = N'{comboBox1.Text}', " +
                    $"Операции = N'{textBox3.Text}', " +
                    $"Состояние = N'{comboBox2.Text}' " +
                    $"where id = {textBox1.Text}", sqlConnection);
                if (Update1.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Вставка успешно выполнена");
                    FormMainMenu.SelfRef.UpdateTable();
                }
                else
                {
                    MessageBox.Show("Введены неверные данные или неверный формат");
                    Update1.Cancel();
                }
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand($"Select id from Printer where id = {textBox1.Text}", sqlConnection);
            if (textBox1.Text != "" && command.ExecuteScalar() != null)
            {
                SqlCommand Edit1 = new SqlCommand($"Select Кабинет from Printer where id ={textBox1.Text}", sqlConnection);
                SqlCommand Edit2 = new SqlCommand($"Select Операции from Printer where id ={textBox1.Text}", sqlConnection);
                SqlCommand Edit3 = new SqlCommand($"Select Модель from Printer where id ={textBox1.Text}", sqlConnection);
                SqlCommand Edit4 = new SqlCommand($"Select Состояние from Printer where id ={textBox1.Text}", sqlConnection);
                SqlCommand Edit5 = new SqlCommand($"Select Дата from Printer where id ={textBox1.Text}", sqlConnection);
                textBox2.Text = Edit1.ExecuteScalar().ToString();
                textBox3.Text = Edit2.ExecuteScalar().ToString();
                comboBox1.Text = Edit3.ExecuteScalar().ToString();
                comboBox2.Text = Edit4.ExecuteScalar().ToString();
                DateTime date = DateTime.Parse(Edit5.ExecuteScalar().ToString());
                int x = Convert.ToInt32(date.Year);
                int y = Convert.ToInt32(date.Month);
                int z = Convert.ToInt32(date.Day);
                dateTimePicker1.Value = new DateTime(x, y, z);
            }
            else
            {
                MessageBox.Show("Записис таким id не найдено", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                comboBox1.Text = "";
                comboBox2.Text = "";
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
            label4.ForeColor = ThemeColor.PrimaryColor;
            label5.ForeColor = ThemeColor.PrimaryColor;
            label6.ForeColor = ThemeColor.PrimaryColor;
            textBox1.ForeColor = ThemeColor.PrimaryColor;
            textBox2.ForeColor = ThemeColor.PrimaryColor;
            textBox3.ForeColor = ThemeColor.PrimaryColor;
            comboBox1.ForeColor = ThemeColor.PrimaryColor;
            comboBox2.ForeColor = ThemeColor.PrimaryColor;
        }
    }
}
