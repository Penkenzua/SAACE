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
    public partial class FormEditPC : Form
    {
         private SqlConnection sqlConnection = null;
        
        public FormEditPC()
        {
            InitializeComponent();
            
        }

        private void FormEdditPC_Load(object sender, EventArgs e)
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
       
            comboBox1.Text = " ";
            comboBox2.Text = " ";
            comboBox3.Text = " ";
            comboBox4.Text = " ";
            comboBox5.Text = " ";
            comboBox6.Text = " ";

        }

    

        private void btnOutput_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand($"Select PC_ID from PC where PC_ID = {textBox1.Text}", sqlConnection);
            if (textBox1.Text != "" && command.ExecuteScalar() != null)
            {
                SqlCommand Edit1 = new SqlCommand($"Select Кабинет    from PC  where PC_ID = {textBox1.Text}", sqlConnection);
                SqlCommand Edit2 = new SqlCommand($"Select ФИО_МОЛ    from PC  where PC_ID = {textBox1.Text}", sqlConnection);
                SqlCommand Edit3 = new SqlCommand($"Select Инв_Номер  from PC  where PC_ID = {textBox1.Text}", sqlConnection);
                SqlCommand Edit4 = new SqlCommand($"Select Инв_Номер                from Monitor         where Monitor_ID =  (Select Монитор  from PC where PC_ID = {textBox1.Text})", sqlConnection);
                SqlCommand Edit5 = new SqlCommand($"Select Код_производителя        from Storage_device  where SD_ID = (Select Диск from PC where PC_ID = {textBox1.Text})", sqlConnection);
                SqlCommand Edit6 = new SqlCommand($"Select Название                 from OC              where OC_ID = (Select OC from PC where PC_ID = {textBox1.Text})", sqlConnection);
                SqlCommand Edit7 = new SqlCommand($"Select Модельный_ряд            from CPU             where CPU_ID = (Select CPU from PC where PC_ID = {textBox1.Text})", sqlConnection);
                SqlCommand Edit8 = new SqlCommand($"Select Код_производителя        from GPU             where GPU_ID = (Select GPU from PC where PC_ID = {textBox1.Text})", sqlConnection);
                SqlCommand Edit9 = new SqlCommand($"Select Код_производителя        from RAM             where RAM_ID = (Select RAM from PC where PC_ID = {textBox1.Text})", sqlConnection);
                textBox2.Text = Edit1.ExecuteScalar().ToString();
                textBox3.Text = Edit2.ExecuteScalar().ToString();
                textBox4.Text = Edit3.ExecuteScalar().ToString();
                comboBox1.Text = Edit4.ExecuteScalar().ToString();
                comboBox2.Text = Edit5.ExecuteScalar().ToString();
                comboBox3.Text = Edit6.ExecuteScalar().ToString();
                comboBox4.Text = Edit7.ExecuteScalar().ToString();
                comboBox5.Text = Edit8.ExecuteScalar().ToString();
                comboBox6.Text = Edit9.ExecuteScalar().ToString();

            }
            else
            {
                textBox1.Text = "";
                MessageBox.Show("Запись таким ID не найдено", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

            SqlCommand Monitor = new SqlCommand($"Select Monitor_Id from Monitor where Инв_Номер=N'{comboBox1.Text}'", sqlConnection);
            SqlCommand SD = new SqlCommand($"Select SD_ID from Storage_device where Код_производителя=N'{comboBox2.Text}'", sqlConnection);
            SqlCommand OC = new SqlCommand($"Select OC_ID from OC where Название=N'{comboBox3.Text}'", sqlConnection);
            SqlCommand CPU = new SqlCommand($"Select CPU_ID from CPU where Модельный_ряд=N'{comboBox4.Text}'", sqlConnection);
            SqlCommand GPU = new SqlCommand($"Select GPU_ID from GPU where Графический_процессор=N'{comboBox5.Text}'", sqlConnection);
            SqlCommand RAM = new SqlCommand($"Select RAM_ID from RAM where Код_производителя=N'{comboBox6.Text}'", sqlConnection);
            
            SqlCommand command = new SqlCommand($"Select PC_ID from PC where PC_ID = {textBox1.Text}", sqlConnection);
            if (textBox1.Text != "" && command.ExecuteScalar() != null && SD.ExecuteScalar()!=null && Monitor.ExecuteScalar()!=null && OC.ExecuteScalar()!= null && CPU.ExecuteScalar()!= null&& GPU.ExecuteScalar()!= null&& RAM.ExecuteScalar()!= null)
            {
                SqlCommand Update1 = new SqlCommand($"Update PC SET " +
                    $"Кабинет = {textBox2.Text}," +
                    $"ФИО_МОЛ = N'{textBox3.Text}', " +
                    $"Инв_Номер = {textBox4.Text}," +
                    $"Монитор = {Monitor.ExecuteScalar()}," +
                    $"Диск = {SD.ExecuteScalar()}," +
                    $"OC =  {OC.ExecuteScalar()}," +
                    $"CPU = {CPU.ExecuteScalar()}," +
                    $"GPU = {GPU.ExecuteScalar()}," +
                    $"RAM = {RAM.ExecuteScalar()}" +
                    $"where  PC_ID = {textBox1.Text}", sqlConnection);
                if (Update1.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Вставка успешно выполнена");
                    FormMainMenu.SelfRef.UpdatePC();
                    textBox1.Text = "";
                    textBox2.Text = "";
                    textBox3.Text = "";
                    comboBox1.Text = "";
                    comboBox2.Text = "";
                    comboBox3.Text = "";
                    comboBox4.Text = "";
                    comboBox5.Text = "";
                    comboBox6.Text = "";

                }
                else
                {
                    MessageBox.Show("Введены неверные данные или неверный формат");
                    Update1.Cancel();
                }
            }
            else
            {
                MessageBox.Show("Такой записи нет или не введён идентификатор", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

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
            label10.ForeColor = ThemeColor.PrimaryColor;
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
