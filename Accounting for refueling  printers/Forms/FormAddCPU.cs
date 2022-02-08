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
    public partial class FormAddCPU : Form
    {
         private SqlConnection sqlConnection = null;
        public FormAddCPU()
        {
            InitializeComponent();
        }

        private void FormAddCPU_Load(object sender, EventArgs e)
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
            if (textBox1.Text!=""&&textBox2.Text!="")
            {


                SqlCommand command = new SqlCommand("INSERT INTO [CPU] (Производитель,Модельный_ряд,Сокет,Количество_ядер,Кол_потоков,Частота) VALUES(@Производитель,@Модельный_ряд,@Сокет,@Количество_ядер,@Кол_потоков,@Частота)", sqlConnection);
                command.Parameters.AddWithValue("Производитель", textBox1.Text);
                command.Parameters.AddWithValue("Модельный_ряд", textBox2.Text);
                command.Parameters.AddWithValue("Сокет", textBox3.Text);
                command.Parameters.AddWithValue("Количество_ядер", textBox4.Text);
                command.Parameters.AddWithValue("Кол_потоков", textBox5.Text);
                command.Parameters.AddWithValue("Частота", textBox6.Text);

                if (command.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Вставка успешна завершена");
                    FormMainMenu.SelfRef.UpdateCPU();

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
            label5.ForeColor = ThemeColor.PrimaryColor;
            label6.ForeColor = ThemeColor.PrimaryColor;
         
            textBox1.ForeColor = ThemeColor.PrimaryColor;
            textBox2.ForeColor = ThemeColor.PrimaryColor;
            textBox3.ForeColor = ThemeColor.PrimaryColor;
            textBox4.ForeColor = ThemeColor.PrimaryColor;
            textBox5.ForeColor = ThemeColor.PrimaryColor;
            textBox6.ForeColor = ThemeColor.PrimaryColor;


        }

       

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            if (Regex.IsMatch(textBox4.Text, @"[^0-9]"))
            {
                MessageBox.Show("Только цифры", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                textBox4.Text = textBox4.Text.Remove(textBox4.Text.Length - 1);
                textBox4.SelectionStart = textBox4.TextLength;
            }
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
    }
}
