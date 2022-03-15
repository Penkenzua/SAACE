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
    public partial class FormSearchBreaking : Form
    {
        private SqlConnection sqlConnection;
        public string filter;

        public FormSearchBreaking()
        {
            InitializeComponent();
        }
        private void FormSearchBreaking_Load(object sender, EventArgs e)
        {
            LoadTheme();
            // TODO: данная строка кода позволяет загрузить данные в таблицу "databaseDataSetRAM.RAM1". При необходимости она может быть перемещена или удалена.
            this.rAM1TableAdapter.Fill(this.databaseDataSetRAM.RAM1);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "databaseDataSetGPU.GPU2". При необходимости она может быть перемещена или удалена.
            this.gPU2TableAdapter.Fill(this.databaseDataSetGPU.GPU2);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "databaseDataSetCPU.CPU2". При необходимости она может быть перемещена или удалена.
            this.cPU2TableAdapter.Fill(this.databaseDataSetCPU.CPU2);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "databaseDataSetSD.Storage_device1". При необходимости она может быть перемещена или удалена.
            this.storage_device1TableAdapter.Fill(this.databaseDataSetSD.Storage_device1);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "databaseDataSetMonitor.Monitor1". При необходимости она может быть перемещена или удалена.
            this.monitor1TableAdapter.Fill(this.databaseDataSetMonitor.Monitor1);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "databaseDataSetBreaking.Breaking1". При необходимости она может быть перемещена или удалена.
            this.breaking1TableAdapter.Fill(this.databaseDataSetBreaking.Breaking1);
      
            // TODO: данная строка кода позволяет загрузить данные в таблицу "databaseDataSetPC.PC3". При необходимости она может быть перемещена или удалена.
            this.pC3TableAdapter.Fill(this.databaseDataSetPC.PC3);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "databaseDataSetPC.PC2". При необходимости она может быть перемещена или удалена.
            this.pC2TableAdapter.Fill(this.databaseDataSetPC.PC2);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "databaseDataSetPC.PC1". При необходимости она может быть перемещена или удалена.
            this.pC1TableAdapter.Fill(this.databaseDataSetPC.PC1);
      
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
            comboBox1.Text = "";
            comboBox2.Text = "";
            comboBox3.Text = "";
            comboBox4.Text = "";
            comboBox5.Text = "";
            comboBox6.Text = "";
            comboBox7.Text = "";
            comboBox8.Text = "";
            comboBox9.Text = "";
            textBox1.Text = "";
           
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            filter = "";
            if (checkBox1.Checked && !checkBox2.Checked)
            {
                DateTime date = DateTime.Parse(dateTimePicker1.Text);
                if (comboBox1.Text != "")
                {
                    filter += $" PC_ID = {comboBox1.Text} and ";
                }
                if (comboBox2.Text != "")
                {
                    filter += $" Кабинет = N'{comboBox2.Text}' and ";
                }
                if (comboBox3.Text != "")
                {
                    filter += $" ФИО_МОЛ  like N'%{comboBox3.Text}%' and ";
                }
                if (comboBox4.Text != "")
                {
                    filter += $"Инв_Номер = N'{comboBox4.Text}' and";
                }
                if (comboBox5.Text != "")
                {
                    filter += $"Монитор = N'{comboBox5.Text}' and ";
                }
                if (comboBox6.Text != "")
                {
                    filter += $"Диск like '{comboBox6.Text}%' and ";

                }

                if (comboBox7.Text != "")
                {
                    filter += $"CPU  like '{comboBox7.Text}%' and ";

                }
                if (comboBox8.Text != "")
                {
                    filter += $"GPU like '{comboBox8.Text}%' and ";

                }
                if (comboBox9.Text != "")
                {
                    filter += $"RAM like '{comboBox9.Text}%' and ";

                }
                if (textBox1.Text != "")
                {
                    filter += $"Причина like '{textBox1.Text}%' and ";
                }
                filter += $" Дата = '{date.Year}.{date.Month}.{date.Day}' and ";
                filter = filter.Remove(filter.Length - 4);

                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter($"Select Breaking_ID as 'Идентификатор', PC_ID as 'Идентификатор ПК', Дата,Кабинет,ФИО_МОЛ as 'ФИО материально ответственного лица', Монитор,Диск,CPU as 'Процессор',GPU as 'Видеокарта',RAM as 'Оперетивная память',Причина from Breaking where {filter}", sqlConnection);

                DataSet dataSet = new DataSet();
                sqlDataAdapter.Fill(dataSet);
                dataGridView1.DataSource = dataSet.Tables[0];
                PanelSelects.Visible = false;
                PanelDatagrid.Visible = true;
            }
            else if(!checkBox1.Checked && !checkBox2.Checked)
            {
                if (comboBox1.Text != "")
                {
                    filter += $" PC_ID = {comboBox1.Text} and ";
                }
                if (comboBox2.Text != "")
                {
                    filter += $" Кабинет = N'{comboBox2.Text}' and ";
                }
                if (comboBox3.Text != "")
                {
                    filter += $" ФИО_МОЛ  like N'%{comboBox3.Text}%' and ";
                }
                if (comboBox4.Text != "")
                {
                    filter += $"Инв_Номер = N'{comboBox4.Text}' and";
                }
                if (comboBox5.Text != "")
                {
                    filter += $"Монитор = N'{comboBox5.Text}' and ";
                }
                if (comboBox6.Text != "")
                {
                    filter += $"Диск like '{comboBox6.Text}%' and ";

                }

                if (comboBox7.Text != "")
                {
                    filter += $"CPU  like '{comboBox7.Text}%' and ";

                }
                if (comboBox8.Text != "")
                {
                    filter += $"GPU like '{comboBox8.Text}%' and ";

                }
                if (comboBox9.Text != "")
                {
                    filter += $"RAM like '{comboBox9.Text}%' and ";

                }
                if (textBox1.Text != "")
                {
                    filter += $"Причина like '{textBox1.Text}%' and ";
                }

                filter = filter.Remove(filter.Length - 4);
                MessageBox.Show(filter);

                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter($"Select Breaking_ID as 'Идентификатор', PC_ID as 'Идентификатор ПК', Дата,Кабинет,ФИО_МОЛ as 'ФИО материально ответственного лица', Монитор,Диск,CPU as 'Процессор',GPU as 'Видеокарта',RAM as 'Оперетивная память',Причина from Breaking where {filter}", sqlConnection);

                DataSet dataSet = new DataSet();
                sqlDataAdapter.Fill(dataSet);
                dataGridView1.DataSource = dataSet.Tables[0];
                PanelSelects.Visible = false;
                PanelDatagrid.Visible = true;
            }
            else if (checkBox1.Checked && checkBox2.Checked)
            {
                DateTime date = DateTime.Parse(dateTimePicker1.Text);
                DateTime date1 = DateTime.Parse(dateTimePicker2.Text);
                if (comboBox1.Text != "")
                {
                    filter += $" PC_ID = {comboBox1.Text} and ";
                }
                if (comboBox2.Text != "")
                {
                    filter += $" Кабинет = N'{comboBox2.Text}' and ";
                }
                if (comboBox3.Text != "")
                {
                    filter += $" ФИО_МОЛ  like N'%{comboBox3.Text}%' and ";
                }
                if (comboBox4.Text != "")
                {
                    filter += $"Инв_Номер = N'{comboBox4.Text}' and";
                }
                if (comboBox5.Text != "")
                {
                    filter += $"Монитор = N'{comboBox5.Text}' and ";
                }
                if (comboBox6.Text != "")
                {
                    filter += $"Диск like '{comboBox6.Text}%' and ";

                }

                if (comboBox7.Text != "")
                {
                    filter += $"CPU  like '{comboBox7.Text}%' and ";

                }
                if (comboBox8.Text != "")
                {
                    filter += $"GPU like '{comboBox8.Text}%' and ";

                }
                if (comboBox9.Text != "")
                {
                    filter += $"RAM like '{comboBox9.Text}%' and ";

                }
                if (textBox1.Text != "")
                {
                    filter += $"Причина like '{textBox1.Text}%' and ";
                }
                filter += $" Дата between '{date.Year}.{date.Month}.{date.Day}' and '{date1.Year}.{date1.Month}.{date1.Day}' and ";
                filter = filter.Remove(filter.Length - 4);

                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter($"Select Breaking_ID as 'Идентификатор', PC_ID as 'Идентификатор ПК', Дата,Кабинет,ФИО_МОЛ as 'ФИО материально ответственного лица', Монитор,Диск,CPU as 'Процессор',GPU as 'Видеокарта',RAM as 'Оперетивная память',Причина from Breaking where {filter}", sqlConnection);
                DataSet dataSet = new DataSet();
                sqlDataAdapter.Fill(dataSet);
                dataGridView1.DataSource = dataSet.Tables[0];
                PanelSelects.Visible = false;
                PanelDatagrid.Visible = true;
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                checkBox1.Checked = true;
                checkBox1.Enabled = false;
            }
            else
            {
                checkBox1.Checked = false;
                checkBox1.Enabled = true;
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

            //btnSearch
            btnSearch.BackColor = ThemeColor.PrimaryColor;
            btnSearch.ForeColor = Color.White;
            btnSearch.FlatAppearance.BorderColor = ThemeColor.SecondaryColor;
            //btnReturn
            btnReturn.BackColor = ThemeColor.PrimaryColor;
            btnReturn.ForeColor = Color.White;
            btnReturn.FlatAppearance.BorderColor = ThemeColor.SecondaryColor;
            //btnPrint
            btnPrint.BackColor = ThemeColor.PrimaryColor;
            btnPrint.ForeColor = Color.White;
            btnPrint.FlatAppearance.BorderColor = ThemeColor.SecondaryColor;
            //Panel
            panelTool.BackColor = ThemeColor.ChangeColorBrightness(ThemeColor.PrimaryColor, -0.3);

        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            if (PanelSelects.Visible)
            {
                PanelSelects.Visible = false;
                PanelDatagrid.Visible = true;
                filter = "";
            }
        }
    }
}
