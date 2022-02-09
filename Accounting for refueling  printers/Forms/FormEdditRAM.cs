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
    public partial class FormEdditRAM : Form
    {
           private SqlConnection sqlConnection = null;
        public FormEdditRAM()
        {
            InitializeComponent();
        }

        private void FormEdditRAM_Load(object sender, EventArgs e)
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
            SqlCommand command = new SqlCommand($"Select RAM_ID from RAM where RAM_ID = {textBox1.Text}", sqlConnection);
            if (textBox1.Text != "" && command.ExecuteScalar() != null)
            {
                SqlCommand Edit1 = new SqlCommand($"Select Код_производителя from RAM where RAM_ID = {textBox1.Text}", sqlConnection);
                SqlCommand Edit2 = new SqlCommand($"Select Производитель from RAM where RAM_ID = {textBox1.Text}", sqlConnection);
                SqlCommand Edit3 = new SqlCommand($"Select Тип from RAM where RAM_ID = {textBox1.Text}", sqlConnection);
                SqlCommand Edit4 = new SqlCommand($"Select PC_индекс from RAM where RAM_ID = {textBox1.Text}", sqlConnection);
                SqlCommand Edit5 = new SqlCommand($"Select Объём from RAM where RAM_ID = {textBox1.Text}", sqlConnection);
                SqlCommand Edit6 = new SqlCommand($"Select Напряжение from RAM where RAM_ID = {textBox1.Text}", sqlConnection);

                textBox2.Text = Edit1.ExecuteScalar().ToString();
                textBox3.Text = Edit2.ExecuteScalar().ToString();
                textBox4.Text = Edit3.ExecuteScalar().ToString();
                textBox5.Text = Edit4.ExecuteScalar().ToString();
                textBox6.Text = Edit5.ExecuteScalar().ToString();
                textBox7.Text = Edit6.ExecuteScalar().ToString();


            }
            else
            {
                MessageBox.Show("Запись таким ID не найдено", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
                textBox5.Text = "";
                textBox6.Text = "";
                textBox7.Text = "";

            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand($"Select RAM_ID from RAM where RAM_ID = {textBox1.Text}", sqlConnection);
            if (textBox1.Text != "" && command.ExecuteScalar() != null)
            {
                SqlCommand Update1 = new SqlCommand($"Update RAM SET " +
                    $"Код_производителя = N'{textBox2.Text}' ," +
                    $"Производитель = N'{textBox3.Text}'," +
                    $"Тип = N'{textBox4.Text}'," +
                    $"PC_индекс = N'{textBox5.Text}'," +
                    $"Объём = {textBox6.Text}," +
                    $"Напряжение = {textBox7.Text}" +
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

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            
                textBox7.Text = new Regex(@",").Replace(textBox7.Text, ".");
                textBox7.SelectionStart = textBox7.TextLength;
                if (textBox7.Text != "" && Regex.IsMatch(textBox7.Text[0].ToString(), "[^0-9]"))
                {
                    MessageBox.Show("Первый знак должен начинаться с цифры ", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                    textBox7.Text = textBox7.Text.Remove(textBox7.Text.Length - 1);
                    textBox7.SelectionStart = textBox7.TextLength;
                }
                else
                {
                    if (Regex.IsMatch(textBox7.Text, "[^0-9.]"))
                    {
                        MessageBox.Show("Только цифры или символ \"Точка\" ", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        textBox7.Text = textBox7.Text.Remove(textBox7.Text.Length - 1);
                        textBox7.SelectionStart = textBox7.TextLength;
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
            label6.ForeColor = ThemeColor.PrimaryColor;
            label7.ForeColor = ThemeColor.PrimaryColor;
        
            textBox1.ForeColor = ThemeColor.PrimaryColor;
            textBox2.ForeColor = ThemeColor.PrimaryColor;
            textBox3.ForeColor = ThemeColor.PrimaryColor;
            textBox4.ForeColor = ThemeColor.PrimaryColor;
            textBox5.ForeColor = ThemeColor.PrimaryColor;
            textBox6.ForeColor = ThemeColor.PrimaryColor;
            textBox7.ForeColor = ThemeColor.PrimaryColor;


        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            if (Regex.IsMatch(textBox6.Text, "[^0-9]"))
            {
                MessageBox.Show("Только цифры", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                textBox6.Text = textBox6.Text.Remove(textBox6.Text.Length - 1);
                textBox6.SelectionStart = textBox6.TextLength;
            }
        }
    }
}
