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
    public partial class FormSearchPC : Form
    {
        public string filter;

        private SqlConnection sqlConnection = null;
        public FormSearchPC()
        {
            InitializeComponent();
        }

     
        private void FormSearchPC_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "databaseDataSetPC.PC". При необходимости она может быть перемещена или удалена.
            this.pCTableAdapter.Fill(this.databaseDataSetPC.PC);
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
            filter = "";
            comboBox1.Text = "";
            comboBox2.Text = "";
            comboBox3.Text = "";
            comboBox4.Text = "";
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            filter = "";
            try
            {
                if (comboBox1.Text != "")
                {
                    filter += $"Кабинет like '{comboBox1.Text}%' and ";
                }
                if (comboBox2.Text != "")
                {
                    filter += $"ФИО_МОЛ like '{comboBox2.Text}%' and ";
                }
                if (comboBox3.Text != "")
                {
                    filter += $"Инв_Номер like '{comboBox3.Text}%' and ";
                }
                if (comboBox4.Text != "")
                {
                    filter += $"Монитор = (Select Monitor_ID from Monitor where Инв_номер=N'{comboBox4.Text}') and ";
                }
                if (comboBox5.Text != "")
                {
                    filter += $"Диск = (Select SD_ID from Storage_device where Код_производителя=N'{comboBox5.Text}') and ";
                }
                if (comboBox6.Text != "")
                {
                    filter += $"OC = (Select OC_ID from OC where Название=N'{comboBox6.Text}') and ";
                }
                if (comboBox7.Text != "")
                {
                    filter += $"CPU = (Select CPU_ID from CPU where Модельный_ряд =N'{comboBox7.Text}') and ";
                }
                if (comboBox8.Text != "")
                {
                    filter += $"GPU =(Select GPU_ID from GPU where Графический_процессор=N'{comboBox8.Text}') and ";
                }
                if (comboBox9.Text != "")
                {
                    filter += $"RAM = (Select RAM_ID from RAM where Код_производителя =N'{comboBox9.Text}') and ";
                }


                filter = filter.Remove(filter.Length - 4);
                SqlCommand command = new SqlCommand($"Select SD_ID as 'Идентификатор',Storage_device.Код_производителя as 'Код производителя',Storage_device.Производитель,Storage_device.Тип," +
                    $"Storage_device.Форм_фактор as 'Форм-фактор',Storage_device.Интерфейс, from Storage_device where {filter}", sqlConnection);
                //if (command.ExecuteScalar() != null)
                //{
                //    SqlDataAdapter dataAdapter = new SqlDataAdapter($"Select RAM_ID as 'Идентификатор', RAM.Название,RAM.Производитель,RAM.Тип,RAM.Объём from RAM where {filter}", sqlConnection);
                //    DataSet dataSet = new DataSet();
                //    dataAdapter.Fill(dataSet);
                //    dataGridView1.DataSource = dataSet.Tables[0];
                //    panel1.Visible = false;
                //    panel2.Visible = true;
                //}
                //else
                //{
                //    MessageBox.Show("Записи с такими условиями не найдено", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);

                //}


            }
            catch
            {
                MessageBox.Show("Введите хотя бы один фильтр", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

    }
}
