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
         private Form activeForm;

        private SqlConnection sqlConnection = null;
        public FormSearchPC()
        {
            InitializeComponent();
        }

     
        private void FormSearchPC_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "databaseDataSetPC.PC1". При необходимости она может быть перемещена или удалена.
            this.pC1TableAdapter.Fill(this.databaseDataSetPC.PC1);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "databaseDataSetPC.PC2". При необходимости она может быть перемещена или удалена.
            this.pC2TableAdapter.Fill(this.databaseDataSetPC.PC2);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "databaseDataSetPC.PC3". При необходимости она может быть перемещена или удалена.
            this.pC3TableAdapter.Fill(this.databaseDataSetPC.PC3);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "databaseDataSetMonitor.Monitor1". При необходимости она может быть перемещена или удалена.
            this.monitor1TableAdapter.Fill(this.databaseDataSetMonitor.Monitor1);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "databaseDataSetSD.Storage_device1". При необходимости она может быть перемещена или удалена.
            this.storage_device1TableAdapter.Fill(this.databaseDataSetSD.Storage_device1);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "databaseDataSetOC.OC". При необходимости она может быть перемещена или удалена.
            this.oCTableAdapter.Fill(this.databaseDataSetOC.OC);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "databaseDataSetCPU.CPU2". При необходимости она может быть перемещена или удалена.
            this.cPU2TableAdapter.Fill(this.databaseDataSetCPU.CPU2);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "databaseDataSetGPU.GPU2". При необходимости она может быть перемещена или удалена.
            this.gPU2TableAdapter.Fill(this.databaseDataSetGPU.GPU2);

            // TODO: данная строка кода позволяет загрузить данные в таблицу "databaseDataSetRAM.RAM1". При необходимости она может быть перемещена или удалена.
            this.rAM1TableAdapter.Fill(this.databaseDataSetRAM.RAM1);
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
            filter = "";
            comboBox1.Text = "";
            comboBox2.Text = "";
            comboBox3.Text = "";
            comboBox4.Text = "";
            comboBox5.Text = "";
            comboBox6.Text = "";
            comboBox7.Text = "";
            comboBox8.Text = "";
            comboBox9.Text = "";
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
                    filter += $"PC.Инв_Номер like '{comboBox3.Text}%' and ";
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
                SqlCommand command = new SqlCommand("Select PC.PC_ID as Идентификатор,PC.Кабинет,PC.ФИО_МОЛ as 'ФИО материально ответственного лица',PC.Инв_Номер as 'Инв.Номер ПК',Monitor.Инв_Номер as 'Инв.Номер Монитора', " +
                "Storage_device.Код_производителя as 'Код производителя накопительного устройство', OC.Название As 'Операционная система'," +
           $"CPU.Модельный_ряд as 'Название процессора',GPU.Графический_процессор as 'Название видеокарты',RAM.Код_производителя as 'Код производителя оперативной памяти' from PC   " +
           " JOIN OC on PC.OC = OC.OC_ID" +
           " JOIN CPU on PC.CPU = CPU.CPU_ID" +
           " JOIN GPU on PC.GPU = GPU.GPU_ID" +
           " JOIN RAM on PC.RAM = RAM.RAM_ID" +
           " JOIN Storage_device on PC.Диск = SD_ID" +
           " JOIN Monitor on PC.Монитор = Monitor_ID" +
           $" where {filter}", sqlConnection);
                if (command.ExecuteScalar() != null)
                {
                    SqlDataAdapter dataAdapter = new SqlDataAdapter("Select PC.PC_ID as Идентификатор,PC.Кабинет,PC.ФИО_МОЛ as 'ФИО материально ответственного лица',PC.Инв_Номер as 'Инв.Номер ПК',Monitor.Инв_Номер as 'Инв.Номер Монитора', " +
                    "Storage_device.Код_производителя as 'Код производителя накопительного устройство', OC.Название As 'Операционная система'," +
               $"CPU.Модельный_ряд as 'Название процессора',GPU.Графический_процессор as 'Название видеокарты',RAM.Код_производителя as 'Код производителя оперативной памяти' from PC   " +
               " JOIN OC on PC.OC = OC.OC_ID" +
               " JOIN CPU on PC.CPU = CPU.CPU_ID" +
               " JOIN GPU on PC.GPU = GPU.GPU_ID" +
               " JOIN RAM on PC.RAM = RAM.RAM_ID" +
               " JOIN Storage_device on PC.Диск = SD_ID" +
               " JOIN Monitor on PC.Монитор = Monitor_ID" +
               $" where {filter}", sqlConnection);
                    DataSet dataSet = new DataSet();
                    dataAdapter.Fill(dataSet);
                    dataGridView1.DataSource = dataSet.Tables[0];
                    panel1.Visible = false;
                    panel2.Visible = true;
                }
                else
                {
                    MessageBox.Show("Записи с такими условиями не найдено", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }


            }
            catch
            {
                MessageBox.Show("Введите хотя бы один фильтр", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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


            comboBox1.ForeColor = ThemeColor.PrimaryColor;
            comboBox2.ForeColor = ThemeColor.PrimaryColor;
            comboBox3.ForeColor = ThemeColor.PrimaryColor;
            comboBox4.ForeColor = ThemeColor.PrimaryColor;
            comboBox5.ForeColor = ThemeColor.PrimaryColor;
            comboBox6.ForeColor = ThemeColor.PrimaryColor;
            comboBox7.ForeColor = ThemeColor.PrimaryColor;
            comboBox8.ForeColor = ThemeColor.PrimaryColor;
            comboBox9.ForeColor = ThemeColor.PrimaryColor;

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                TableBreakingAttributes.IndexCell = Convert.ToInt32(dataGridView1[0, e.RowIndex].Value);

            }
            catch
            {
            }
        }

        private void btnAddBreaking_Click(object sender, EventArgs e)
        {

            if (TableBreakingAttributes.IndexCell>=1)
            {
                FormMainMenu.SelfRef.OpenChildForm(new Forms.FormAddBreaking(), sender);
                if (activeForm != null)
                    activeForm.Close();
                FormMainMenu.SelfRef.Reset();
            }
            else
            {
                MessageBox.Show("Сначала выберите нужную запись, сделав по ней нажатие левой кнопкой мышки","Предуприждение",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
           
        }
    }
}
