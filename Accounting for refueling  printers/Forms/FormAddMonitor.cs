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
    public partial class FormAddMonitor : Form
    {
        private SqlConnection sqlConnection = null;

        public FormAddMonitor()
        {
            InitializeComponent();
        }

        private void FormAddMonitor_Load(object sender, EventArgs e)
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

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (textBox1.Text!=""&& textBox2.Text!=""&&textBox3.Text!=""&&textBox4.Text!="")
            {


                SqlCommand command = new SqlCommand("INSERT INTO [Monitor] (Инв_Номер,Производитель,Диагональ,Частота) VALUES(@Инв_Номер,@Производитель,@Диагональ,@Частота)", sqlConnection);
                command.Parameters.AddWithValue("Инв_Номер", textBox1.Text);
                command.Parameters.AddWithValue("Производитель", textBox1.Text);
                command.Parameters.AddWithValue("Диагональ", textBox1.Text);
                command.Parameters.AddWithValue("Частота", textBox1.Text);
                if (command.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Вставка успешна завершена");
                    FormMainMenu.SelfRef.UpdateMonitor();

                }
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
            textBox3.ForeColor = ThemeColor.PrimaryColor;
            textBox4.ForeColor = ThemeColor.PrimaryColor;
           


        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            if (Regex.IsMatch(textBox3.Text, "[^0-9]"))
            {
                MessageBox.Show("Только цифры", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                textBox3.Text = textBox3.Text.Remove(textBox3.Text.Length - 1);
                textBox3.SelectionStart = textBox3.TextLength;
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            if (textBox4.Text != "" && Regex.IsMatch(textBox4.Text[0].ToString(), "[^0-9]"))
            {
                MessageBox.Show("Первый знак должен начинаться с цифры ", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                textBox4.Text = textBox4.Text.Remove(textBox4.Text.Length - 1);
                textBox4.SelectionStart = textBox4.TextLength;
            }
            else
            {
                textBox4.Text = new Regex(@",").Replace(textBox4.Text, ".");
                textBox4.SelectionStart = textBox4.TextLength;
                if (Regex.IsMatch(textBox4.Text, "[^0-9.,]"))
                {

                    MessageBox.Show("Только цифры", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    textBox4.Text = textBox4.Text.Remove(textBox4.Text.Length - 1);
                    textBox4.SelectionStart = textBox4.TextLength;
                }
            }
        }
    }
}
