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
    public partial class FormEditCartridge : Form
    {
        private SqlConnection sqlConnection = null;
        public FormEditCartridge()
        {
            InitializeComponent();
        }



        private void FormEdditCatridge_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "databaseDataSetCartridgeType.CartridgeType". При необходимости она может быть перемещена или удалена.
            this.cartridgeTypeTableAdapter.Fill(this.databaseDataSetCartridgeType.CartridgeType);

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
        private void btnSearch_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand($"Select Cartridge_ID from Cartridge where Cartridge_ID = {textBox1.Text}", sqlConnection);
            if (textBox1.Text != "" && command.ExecuteScalar() != null)
            {
                SqlCommand Edit1 = new SqlCommand($"Select Производитель from Cartridge where Cartridge_ID ={textBox1.Text}", sqlConnection);
                SqlCommand Edit2 = new SqlCommand($"Select Модель from Cartridge where Cartridge_ID ={textBox1.Text}", sqlConnection);
                SqlCommand Edit3 = new SqlCommand($"Select CartridgeType_ID from CartridgeType where Type =N'{comboBox1.Text}'", sqlConnection);
                textBox2.Text = Edit1.ExecuteScalar().ToString();
                textBox3.Text = Edit2.ExecuteScalar().ToString();
                comboBox1.Text = Edit3.ExecuteScalar().ToString();
               

            }
            else
            {
                MessageBox.Show("Запись таким ID не найдено", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                comboBox1.Text = "";
              
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand($"Select Cartridge_ID from Cartridge where Cartridge_ID = {textBox1.Text}", sqlConnection);
            SqlCommand Edit1 = new SqlCommand($"Select CartridgeType_ID from CartridgeType where Type =N'{comboBox1.Text}'", sqlConnection);

            if (textBox1.Text != "" && command.ExecuteScalar() != null && Edit1.ExecuteScalar()!= null)
            {
                SqlCommand Update1 = new SqlCommand($"Update Cartridge SET " +
                    $"Производитель = N'{textBox2.Text}'," +
                    $"Модель = N'{textBox3.Text}'," +
                    $"Тип = {Edit1.ExecuteScalar()} " +
                    $"where Cartridge_ID = {textBox1.Text}", sqlConnection);
                if (Update1.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Вставка успешно выполнена");
                    FormMainMenu.SelfRef.UpdateCartrdige();
                }
                else
                {
                    MessageBox.Show("Введены неверные данные или неверный формат");
                    Update1.Cancel();
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
            label3.ForeColor = ThemeColor.PrimaryColor;
            label4.ForeColor = ThemeColor.PrimaryColor;
            textBox1.ForeColor = ThemeColor.PrimaryColor;
            textBox2.ForeColor = ThemeColor.PrimaryColor;
            textBox3.ForeColor = ThemeColor.PrimaryColor;
            comboBox1.ForeColor = ThemeColor.PrimaryColor;


        }
    }
}