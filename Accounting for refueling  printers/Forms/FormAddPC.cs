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
            // TODO: данная строка кода позволяет загрузить данные в таблицу "databaseDataSetMonitor.Monitor". При необходимости она может быть перемещена или удалена.
            this.monitorTableAdapter.Fill(this.databaseDataSetMonitor.Monitor);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "databaseDataSetSD.Storage_device". При необходимости она может быть перемещена или удалена.
            this.storage_deviceTableAdapter.Fill(this.databaseDataSetSD.Storage_device);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "databaseDataSetOC.OC". При необходимости она может быть перемещена или удалена.
            this.oCTableAdapter.Fill(this.databaseDataSetOC.OC);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "databaseDataSetCPU.CPU". При необходимости она может быть перемещена или удалена.
            this.cPUTableAdapter.Fill(this.databaseDataSetCPU.CPU);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "databaseDataSetGPU.GPU". При необходимости она может быть перемещена или удалена.
            this.gPUTableAdapter.Fill(this.databaseDataSetGPU.GPU);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "databaseDataSetRAM.RAM". При необходимости она может быть перемещена или удалена.
            this.rAMTableAdapter.Fill(this.databaseDataSetRAM.RAM);
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
            SqlCommand SD = new SqlCommand($"Select SD_ID from Storage_device where Код_производителя=N'{comboBox2.Text}'", sqlConnection);
            SqlCommand Monitor = new SqlCommand($"Select Monitor_ID from Monitor where Инв_номер=N'{comboBox1.Text}'", sqlConnection);
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

            SqlCommand command = new SqlCommand("INSERT INTO [PC] (Кабинет,ФИО_МОЛ,Инв.Номер,Монитор,Диск,OC,CPU,GPU,RAM) VALUES(@Кабинет,@ФИО_МОЛ,@Инв.Номер,@Монитор,@Диск,@OC,@CPU,@GPU,@RAM)", sqlConnection);
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
                    FormMainMenu.SelfRef.UpdatePrinter();

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

    }
}
