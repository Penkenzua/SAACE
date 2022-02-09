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
    public partial class FormAddStorageDevice : Form
    {
        private SqlConnection sqlConnection = null;

        public FormAddStorageDevice()
        {
            InitializeComponent();
        }

        private void FormAddStorageDevice_Load(object sender, EventArgs e)
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
            if (textBox1.Text != "" && textBox2.Text != ""&& textBox3.Text != ""&& textBox4.Text != ""&& textBox5.Text != "")
            {


                SqlCommand command = new SqlCommand("INSERT INTO [CPU] (Код_производителя,Производитель,Тип,Форм_фактор,Интерфейс) VALUES(@Код_производителя,@Производитель,@Тип,@Форм_фактор,@Интерфейс)", sqlConnection);
                command.Parameters.AddWithValue("Код_производителя", textBox1.Text);
                command.Parameters.AddWithValue("Производитель", textBox2.Text);
                command.Parameters.AddWithValue("Тип", textBox3.Text);
                command.Parameters.AddWithValue("Форм_фактор", textBox4.Text);
                command.Parameters.AddWithValue("Интерфейс", textBox5.Text);
                

                if (command.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Вставка успешна завершена");
                    FormMainMenu.SelfRef.UpdateStorageDevice();

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
            

            textBox1.ForeColor = ThemeColor.PrimaryColor;
            textBox2.ForeColor = ThemeColor.PrimaryColor;
            textBox3.ForeColor = ThemeColor.PrimaryColor;
            textBox4.ForeColor = ThemeColor.PrimaryColor;
            textBox5.ForeColor = ThemeColor.PrimaryColor;
           


        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            textBox4.Text = new Regex(@",").Replace(textBox4.Text, ".");
            textBox4.SelectionStart = textBox4.TextLength;
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            textBox5.Text = new Regex(@",").Replace(textBox5.Text, ".");
            textBox5.SelectionStart = textBox5.TextLength;
        }
    }
}
