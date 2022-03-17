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
            // TODO: данная строка кода позволяет загрузить данные в таблицу "databaseDataSetCartridge.Cartridge2". При необходимости она может быть перемещена или удалена.
            this.cartridge2TableAdapter.Fill(this.databaseDataSetCartridge.Cartridge2);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "databaseDataSetPrinter.Printer2". При необходимости она может быть перемещена или удалена.
            this.printer2TableAdapter.Fill(this.databaseDataSetPrinter.Printer2);




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
            
           
            if (textBox1.Text != "" && textBox2.Text != "" && comboBox1.Text != "")
            {
                SqlCommand SelectID = new SqlCommand($"Select Cartridge_ID from Cartridge where Cartridge.Модель = N'{comboBox2.Text}'",sqlConnection);
                SqlCommand SelectTypeCartridge = new SqlCommand($"Select Cartridge.Тип from Cartridge where Cartridge_ID = {SelectID.ExecuteScalar()}",sqlConnection);
                DateTime date = DateTime.Parse(dateTimePicker1.Text);
                SqlCommand command = new SqlCommand($"INSERT INTO [PRINTER](Дата,Кабинет,Модель,Картридж,Тип_картриджа,Операции) Values(@Дата,@Кабинет,@Модель,@Картридж,@Тип_картриджа,@Операции)", sqlConnection);
                command.Parameters.AddWithValue("Дата",$"{date.Month}/{date.Day}/{date.Year}");
                command.Parameters.AddWithValue("Кабинет",textBox1.Text);
                command.Parameters.AddWithValue("Модель", comboBox1.Text);
                command.Parameters.AddWithValue("Картридж",SelectID.ExecuteScalar());
                command.Parameters.AddWithValue("Тип_картриджа",SelectTypeCartridge.ExecuteScalar());
                command.Parameters.AddWithValue("Операции",textBox2.Text);

             

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
            label5.ForeColor = ThemeColor.PrimaryColor;
            textBox1.ForeColor = ThemeColor.PrimaryColor;
            textBox2.ForeColor = ThemeColor.PrimaryColor;
            comboBox1.ForeColor = ThemeColor.PrimaryColor;
        }
    }
}
