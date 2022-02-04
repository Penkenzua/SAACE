using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace Accounting_for_refueling__printers.Forms
{
    public partial class FormAddPrinter : Form
    {
        private SqlConnection sqlConnection = null;
        public FormAddPrinter()
        {
            InitializeComponent();
        }

        private void FormAdd_Load(object sender, EventArgs e)
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
            comboBox1.Text = "";
            LoadTheme();

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            SqlCommand sqlCommand = new SqlCommand($"Select Cartridge_ID from Cartridge where Модель=N'{comboBox2.Text}'",sqlConnection);
            var temp = sqlCommand.ExecuteScalar().ToString();
            if (textBox1.Text != "" && textBox2.Text != "" && comboBox1.Text != "")
            {

                DateTime date = DateTime.Parse(dateTimePicker1.Text);
                SqlCommand command = new SqlCommand("INSERT INTO [Printer] (Дата,Кабинет,Модель,Катридж,Операции,Состояние) VALUES(@Дата,@Кабинет," +
                "@Модель,@Катридж,@Операции,N'Не выписано')", sqlConnection);
                command.Parameters.AddWithValue("Дата", $"{date.Month}/{date.Day}/{date.Year}");
                command.Parameters.AddWithValue("Кабинет", textBox1.Text);
                command.Parameters.AddWithValue("Модель", comboBox1.Text);
                command.Parameters.AddWithValue("Картридж", temp);
                command.Parameters.AddWithValue("Операции", textBox2.Text);
                if (command.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Вставка успешна завершена");
                    FormMainMenu.SelfRef.UpdatePrinter();

                }
                textBox1.Text = "";
                textBox2.Text = "";
                comboBox1.Text = "";
            }
            else
            {
                MessageBox.Show("Заполните все поля", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
            label3.ForeColor = ThemeColor.PrimaryColor;
            label4.ForeColor = ThemeColor.PrimaryColor;
            textBox1.ForeColor = ThemeColor.PrimaryColor;
            textBox2.ForeColor = ThemeColor.PrimaryColor;
            comboBox1.ForeColor = ThemeColor.PrimaryColor;
        }
    }
}
