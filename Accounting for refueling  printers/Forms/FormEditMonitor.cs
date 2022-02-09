using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Accounting_for_refueling__printers.Forms
{
    public partial class FormEditMonitor : Form
    {
        private SqlConnection sqlConnection = null;

        public FormEditMonitor()
        {
            InitializeComponent();
        }

        private void FormEditMonitor_Load(object sender, EventArgs e)
        {
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
            SqlCommand command = new SqlCommand($"Select Monitor_ID from Monitor where Monitor_ID = {textBox1.Text}", sqlConnection);
            if (textBox1.Text != "" && command.ExecuteScalar() != null)
            {
                SqlCommand Edit1 = new SqlCommand($"Select Инв_Номер from Monitor where Monitor_ID = {textBox1.Text}", sqlConnection);
                SqlCommand Edit2 = new SqlCommand($"Select Производитель from Monitor where Monitor_ID = {textBox1.Text}", sqlConnection);
                SqlCommand Edit3 = new SqlCommand($"Select Диагональ from Monitor where Monitor_ID = {textBox1.Text}", sqlConnection);
                SqlCommand Edit4 = new SqlCommand($"Select Частота from Monitor where Monitor_ID = {textBox1.Text}", sqlConnection);
            
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
                textBox5.Text = "";
           

            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand($"Select Monitor_ID from Monitor where Monitor_ID = {textBox1.Text}", sqlConnection);
            if (textBox1.Text != "" && command.ExecuteScalar() != null)
            {
                SqlCommand Update1 = new SqlCommand($"Update Monitor SET " +
                    $"Инв_Номер = N'{textBox2.Text}' ," +
                    $"Производитель = N'{textBox3.Text}'," +
                    $"Диагональ = {textBox4.Text}," +
                    $"Частота = {textBox5.Text}" +
                    $"where Monitor_ID = {textBox1.Text}", sqlConnection);
                if (Update1.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Вставка успешно выполнена");
                    FormMainMenu.SelfRef.UpdateMonitor();
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
            label5.ForeColor = ThemeColor.PrimaryColor;
         

            textBox1.ForeColor = ThemeColor.PrimaryColor;
            textBox2.ForeColor = ThemeColor.PrimaryColor;
            textBox3.ForeColor = ThemeColor.PrimaryColor;
            textBox4.ForeColor = ThemeColor.PrimaryColor;
            textBox5.ForeColor = ThemeColor.PrimaryColor;



        }
        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            if (Regex.IsMatch(textBox4.Text, "[^0-9]"))
            {
                MessageBox.Show("Только цифры", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                textBox4.Text = textBox4.Text.Remove(textBox4.Text.Length - 1);
                textBox4.SelectionStart = textBox4.TextLength;
            }
        }
        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            textBox5.Text = new Regex(@",").Replace(textBox5.Text, ".");
            textBox5.SelectionStart = textBox5.TextLength;
            if (textBox5.Text != "" && Regex.IsMatch(textBox5.Text[0].ToString(), "[^0-9]"))
            {
                MessageBox.Show("Первый знак должен начинаться с цифры ", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                textBox5.Text = textBox5.Text.Remove(textBox5.Text.Length - 1);
                textBox5.SelectionStart = textBox5.TextLength;
            }
            else
            {
                if (Regex.IsMatch(textBox5.Text, "[^0-9.]"))
                {
                    MessageBox.Show("Только цифры или символ \"Точка\" ", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    textBox5.Text = textBox5.Text.Remove(textBox5.Text.Length - 1);
                    textBox5.SelectionStart = textBox5.TextLength;
                }
            }
        }

       
    }
}
