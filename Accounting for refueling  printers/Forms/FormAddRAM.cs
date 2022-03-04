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
    public partial class FormAddRAM : Form
    {
           private SqlConnection sqlConnection = null;
        public FormAddRAM()
        {
            InitializeComponent();
        }

        private void FormAddRAM_Load(object sender, EventArgs e)
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
            if (textBox1.Text != ""&&textBox2.Text != ""&&textBox3.Text != ""&&textBox4.Text != "")
            {


                SqlCommand command = new SqlCommand("INSERT INTO [RAM] (Код_производителя,Производитель,Тип,PC_индекс,Объём,Напряжение) VALUES(@Код_производителя,@Производитель,@Тип,@PC_индекс,@Объём,@Напряжение)", sqlConnection);
                command.Parameters.AddWithValue("Код_производителя", textBox1.Text);
                command.Parameters.AddWithValue("Производитель", textBox2.Text);
                command.Parameters.AddWithValue("Тип", textBox3.Text);
                command.Parameters.AddWithValue("PC_индекс", textBox4.Text);
                command.Parameters.AddWithValue("Объём", textBox5.Text);
                command.Parameters.AddWithValue("Напряжение", textBox6.Text);
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

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            if (textBox6.Text != "" && Regex.IsMatch(textBox6.Text[0].ToString(), "[^0-9]"))
            {
                MessageBox.Show("Первый знак должен начинаться с цифры ", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                textBox6.Text = textBox6.Text.Remove(textBox6.Text.Length - 1);
                textBox6.SelectionStart = textBox6.TextLength;
            }
            else
            {
                textBox6.Text = new Regex(@",").Replace(textBox6.Text, ".");
                textBox6.SelectionStart = textBox6.TextLength;
                if (Regex.IsMatch(textBox6.Text, "[^0-9.,]"))
                {

                    MessageBox.Show("Только цифры", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    textBox6.Text = textBox6.Text.Remove(textBox6.Text.Length - 1);
                    textBox6.SelectionStart = textBox6.TextLength;
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
           
            textBox1.ForeColor = ThemeColor.PrimaryColor;
            textBox2.ForeColor = ThemeColor.PrimaryColor;
            textBox3.ForeColor = ThemeColor.PrimaryColor;
            textBox4.ForeColor = ThemeColor.PrimaryColor;
            textBox5.ForeColor = ThemeColor.PrimaryColor;
            textBox6.ForeColor = ThemeColor.PrimaryColor;


        }

     

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            if (Regex.IsMatch(textBox5.Text, "[^0-9]"))
            {
                MessageBox.Show("Только цифры", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                textBox5.Text = textBox5.Text.Remove(textBox5.Text.Length - 1);
                textBox5.SelectionStart = textBox5.TextLength;
            }
        }
    }
}
