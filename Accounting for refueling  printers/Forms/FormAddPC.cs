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
            SqlCommand OC = new SqlCommand($"Select OC_ID from OC where Название=N'{comboBox1.Text}'", sqlConnection);
            SqlCommand CPU = new SqlCommand($"Select CPU_ID from CPU where Модель=N'{comboBox2.Text}'", sqlConnection);
            SqlCommand GPU = new SqlCommand($"Select GPU_ID from GPU where Модель=N'{comboBox3.Text}'", sqlConnection);
            SqlCommand RAM = new SqlCommand($"Select RAM_ID from RAM where Модель=N'{comboBox4.Text}'", sqlConnection);

            var oc = OC.ExecuteScalar().ToString();
            var cpu = CPU.ExecuteScalar().ToString();
            var gpu = GPU.ExecuteScalar().ToString();
            var ram = RAM.ExecuteScalar().ToString();

            SqlCommand command = new SqlCommand("INSERT INTO [PC] (Кабинет,Модель,Инв.Номер,OC,CPU,GPU,RAM) VALUES(@Кабинет,@Модель,@Инв.Номер,@OC,@CPU,@GPU,@RAM)", sqlConnection);
            command.Parameters.AddWithValue("Кабинет", textBox1.Text);
            command.Parameters.AddWithValue("Модель",textBox2.Text);
            command.Parameters.AddWithValue("Инв_Номер", textBox3.Text);

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
                comboBox1.Text = "";
                comboBox2.Text = "";
                comboBox3.Text = "";
                comboBox4.Text = "";



            }
            else
            {
                MessageBox.Show("Заполните все поля", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }


}

    }
}
