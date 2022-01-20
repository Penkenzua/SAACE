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
        }

        private void FormAddPC_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "databaseDataSet.RAM". При необходимости она может быть перемещена или удалена.
            this.rAMTableAdapter.Fill(this.databaseDataSet.RAM);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "databaseDataSet.GPU". При необходимости она может быть перемещена или удалена.
            this.gPUTableAdapter.Fill(this.databaseDataSet.GPU);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "databaseDataSet.CPU". При необходимости она может быть перемещена или удалена.
            this.cPUTableAdapter.Fill(this.databaseDataSet.CPU);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "databaseDataSet.OC". При необходимости она может быть перемещена или удалена.
            this.oCTableAdapter.Fill(this.databaseDataSet.OC);
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

            SqlCommand command = new SqlCommand("INSER INTO [PC] (Модель,OC,CPU,GPU,RAM) VALUES(@Модель,@OC,@CPU,@GPU,@RAM)", sqlConnection);
            command.Parameters.AddWithValue("Модель",textBox1.Text);
            command.Parameters.AddWithValue("OC", oc);
            command.Parameters.AddWithValue("CPU", cpu);
            command.Parameters.AddWithValue("GPU", gpu);
            command.Parameters.AddWithValue("RAM", ram);
            if (textBox1.Text!="")
            {


                if (command.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Вставка успешна завершена");
                    FormMainMenu.SelfRef.UpdatePrinter();

                }
                textBox1.Text = "";
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
