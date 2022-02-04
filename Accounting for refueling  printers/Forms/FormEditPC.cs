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

        }

    

        private void btnOutput_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand($"Select PC_ID from PC where PC_ID = {textBox1.Text}", sqlConnection);
            if (textBox1.Text != "" && command.ExecuteScalar() != null)
            {
                SqlCommand Edit1 = new SqlCommand($"Select Кабинет   from PC  where PC_ID = {textBox1.Text}", sqlConnection);
                SqlCommand Edit2 = new SqlCommand($"Select Модель    from PC  where PC_ID = {textBox1.Text}", sqlConnection);
                SqlCommand Edit3 = new SqlCommand($"Select Инв_Номер from PC  where PC_ID = {textBox1.Text}", sqlConnection);
                SqlCommand Edit4 = new SqlCommand($"Select Название  from OC  where OC_ID =  (Select OC  from PC where PC_ID = {textBox1.Text})", sqlConnection);
                SqlCommand Edit5 = new SqlCommand($"Select Модель    from CPU where CPU_ID = (Select CPU from PC where PC_ID = {textBox1.Text})", sqlConnection);
                SqlCommand Edit6 = new SqlCommand($"Select Модель    from GPU where GPU_ID = (Select GPU from PC where PC_ID = {textBox1.Text})", sqlConnection);
                SqlCommand Edit7 = new SqlCommand($"Select Модель    from RAM where RAM_ID = (Select RAM from PC where PC_ID = {textBox1.Text})", sqlConnection);
                textBox2.Text = Edit1.ExecuteScalar().ToString();
                textBox3.Text = Edit2.ExecuteScalar().ToString();
                textBox4.Text = Edit3.ExecuteScalar().ToString();
                comboBox1.Text = Edit4.ExecuteScalar().ToString();
                comboBox2.Text = Edit5.ExecuteScalar().ToString();
                comboBox3.Text = Edit6.ExecuteScalar().ToString();
                comboBox4.Text = Edit7.ExecuteScalar().ToString();

            }
            else
            {
                textBox1.Text = "";
                MessageBox.Show("Запись таким ID не найдено", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            SqlCommand OC = new SqlCommand($"Select OC_ID from OC where Название=N'{comboBox1.Text}'", sqlConnection);
            SqlCommand CPU = new SqlCommand($"Select CPU_ID from CPU where Модель=N'{comboBox2.Text}'", sqlConnection);
            SqlCommand GPU = new SqlCommand($"Select GPU_ID from GPU where Модель=N'{comboBox3.Text}'", sqlConnection);
            SqlCommand RAM = new SqlCommand($"Select RAM_ID from RAM where Модель=N'{comboBox4.Text}'", sqlConnection);
            SqlCommand command = new SqlCommand($"Select PC_ID from PC where PC_ID = {textBox1.Text}", sqlConnection);
            if (textBox1.Text != "" && command.ExecuteScalar() != null && OC.ExecuteScalar()!= null&& CPU.ExecuteScalar()!= null&& GPU.ExecuteScalar()!= null&& RAM.ExecuteScalar()!= null)
            {
                SqlCommand Update1 = new SqlCommand($"Update PC SET " +
                    $"Кабинет = N'{textBox2.Text}'," +
                    $"Модель = N'{textBox3.Text}', " +
                    $"Инв_Номер = {textBox4.Text}" +
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
                    textBox4.Text = "";

                }
                else
                {
                    MessageBox.Show("Введены неверные данные или неверный формат");
                    Update1.Cancel();
                }
            }
            else
            {
                MessageBox.Show("Таких данных нету в бд");  
            }
        }
    }
}
