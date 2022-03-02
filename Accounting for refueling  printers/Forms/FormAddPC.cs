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
    public partial class FormAddPC : Form
    {
           private SqlConnection sqlConnection = null;
        public FormAddPC()
        {
            InitializeComponent();
            comboBox1.Text = "";
            comboBox2.Text = "";
            comboBox3.Text = "";
            comboBox4.Text = "";


        }

        private void FormAddPC_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "databaseDataSetRAM.RAM1". При необходимости она может быть перемещена или удалена.
            this.rAM1TableAdapter.Fill(this.databaseDataSetRAM.RAM1);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "databaseDataSetGPU.GPU2". При необходимости она может быть перемещена или удалена.
            this.gPU2TableAdapter.Fill(this.databaseDataSetGPU.GPU2);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "databaseDataSetCPU.CPU2". При необходимости она может быть перемещена или удалена.
            this.cPU2TableAdapter.Fill(this.databaseDataSetCPU.CPU2);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "databaseDataSetOC.OC". При необходимости она может быть перемещена или удалена.
            this.oCTableAdapter.Fill(this.databaseDataSetOC.OC);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "databaseDataSetSD.Storage_device1". При необходимости она может быть перемещена или удалена.
            this.storage_device1TableAdapter.Fill(this.databaseDataSetSD.Storage_device1);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "databaseDataSetMonitor.Monitor1". При необходимости она может быть перемещена или удалена.
            this.monitor1TableAdapter.Fill(this.databaseDataSetMonitor.Monitor1);





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
            SqlCommand Monitor = new SqlCommand($"Select Monitor_ID from Monitor where Инв_номер=N'{comboBox1.Text}'", sqlConnection);
            SqlCommand SD = new SqlCommand($"Select SD_ID from Storage_device where Код_производителя=N'{comboBox2.Text}'", sqlConnection);
            SqlCommand OC = new SqlCommand($"Select OC_ID from OC where Название=N'{comboBox3.Text}'", sqlConnection);
            SqlCommand CPU = new SqlCommand($"Select CPU_ID from CPU where Модельный_ряд =N'{comboBox4.Text}'", sqlConnection);
            SqlCommand GPU = new SqlCommand($"Select GPU_ID from GPU where Графический_процессор=N'{comboBox5.Text}'", sqlConnection);
            SqlCommand RAM = new SqlCommand($"Select RAM_ID from RAM where Код_производителя =N'{comboBox6.Text}'", sqlConnection);



            var monitor = Monitor.ExecuteScalar().ToString();
            var sd = SD.ExecuteScalar().ToString();
            var oc = OC.ExecuteScalar().ToString();
            var cpu = CPU.ExecuteScalar().ToString();
            var gpu = GPU.ExecuteScalar().ToString();
            var ram = RAM.ExecuteScalar().ToString();

            SqlCommand command = new SqlCommand("INSERT INTO [PC] (Кабинет,ФИО_МОЛ,Инв_Номер,Монитор,Диск,OC,CPU,GPU,RAM) VALUES(@Кабинет,@ФИО_МОЛ,@Инв_Номер,@Монитор,@Диск,@OC,@CPU,@GPU,@RAM)", sqlConnection);
            command.Parameters.AddWithValue("Кабинет", textBox1.Text);
            command.Parameters.AddWithValue("ФИО_МОЛ",textBox2.Text);
            command.Parameters.AddWithValue("Инв_Номер", textBox3.Text);
            command.Parameters.AddWithValue("Монитор", monitor);
            command.Parameters.AddWithValue("Диск", sd);
            command.Parameters.AddWithValue("OC", oc);
            command.Parameters.AddWithValue("CPU", cpu);
            command.Parameters.AddWithValue("GPU", gpu);
            command.Parameters.AddWithValue("RAM", ram);
            if (textBox1.Text!="" &&textBox2.Text!="" && textBox3.Text!="" )
            {


                if (command.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Вставка успешна завершена");
                    FormMainMenu.SelfRef.UpdatePC();

                }
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
             



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
            label7.ForeColor = ThemeColor.PrimaryColor;
            label8.ForeColor = ThemeColor.PrimaryColor;
            label9.ForeColor = ThemeColor.PrimaryColor;
            
            textBox1.ForeColor = ThemeColor.PrimaryColor;
            textBox2.ForeColor = ThemeColor.PrimaryColor;
            textBox3.ForeColor = ThemeColor.PrimaryColor;

            comboBox1.ForeColor = ThemeColor.PrimaryColor;
            comboBox2.ForeColor = ThemeColor.PrimaryColor;
            comboBox3.ForeColor = ThemeColor.PrimaryColor;
            comboBox4.ForeColor = ThemeColor.PrimaryColor;
            comboBox5.ForeColor = ThemeColor.PrimaryColor;
            comboBox6.ForeColor = ThemeColor.PrimaryColor;
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
    }
}
