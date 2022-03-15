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
    public partial class FormSearchGPU : Form
    {
        public string filter;
        private SqlConnection sqlConnection = null;
        public FormSearchGPU()
        {
            InitializeComponent();
        }
        private void FormSearchGPU_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "databaseDataSetGPU.GPU5". При необходимости она может быть перемещена или удалена.
            this.gPU5TableAdapter.Fill(this.databaseDataSetGPU.GPU5);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "databaseDataSetGPU.GPU2". При необходимости она может быть перемещена или удалена.
            this.gPU2TableAdapter.Fill(this.databaseDataSetGPU.GPU2);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "databaseDataSetGPUModel.GPUModel". При необходимости она может быть перемещена или удалена.
            this.gPUModelTableAdapter.Fill(this.databaseDataSetGPUModel.GPUModel);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "databaseDataSetGPU.GPU4". При необходимости она может быть перемещена или удалена.
            this.gPU4TableAdapter.Fill(this.databaseDataSetGPU.GPU4);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "databaseDataSetGPU.GPU3". При необходимости она может быть перемещена или удалена.
            this.gPU3TableAdapter.Fill(this.databaseDataSetGPU.GPU3);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "databaseDataSetGPU.GPU2". При необходимости она может быть перемещена или удалена.
           
            this.gPU1TableAdapter.Fill(this.databaseDataSetGPU.GPU1);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "databaseDataSetGPU.GPU1". При необходимости она может быть перемещена или удалена.
            this.gPU1TableAdapter.Fill(this.databaseDataSetGPU.GPU1);


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
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            filter = "";

            try
            {
                if (comboBox1.Text != "")
                {
                    filter += $" Производитель like '{comboBox1.Text}%' and ";
                }
                if (comboBox2.Text != "")
                {
                    filter += $" Код_производителя like '{comboBox2.Text}%' and ";
                }


                if (comboBox3.Text != "")
                    {
                        filter += $" Графический_процессор = (Select GPUModel_ID from GPUModel where Model = N'{comboBox3.Text}') and ";
                    }
                        if (comboBox4.Text != "")
                        {
                            filter += $" Тип_памяти like '{comboBox4.Text}%' and ";
                        }
                            if (comboBox5.Text != "")
                            {
                                filter += $" Шина_памяти like '{comboBox5.Text}%' and ";
                            }

                filter = filter.Remove(filter.Length - 4);
                SqlCommand command = new SqlCommand($"Select GPU.GPU_ID as 'Идентификатор', GPU.Код_производителя as 'Код производителя',GPU.Производитель,GPUModel.Model as 'Графический процессор'," +
                "GPU.Тип_памяти as 'Тип памяти',GPU.Шина_памяти as 'Шина памяти' from GPU" +
                " Join GPUModel on GPU.Графический_процессор = GPUModel_ID" +
                $" where {filter}", sqlConnection);
                if (command.ExecuteScalar() != null)
                {
                    SqlDataAdapter dataAdapter = new SqlDataAdapter($"Select GPU.GPU_ID as 'Идентификатор',GPU.Код_производителя as 'Код производителя', GPU.Производитель,GPUModel.Model as 'Графический процессор'," +
                "GPU.Тип_памяти as 'Тип памяти',GPU.Шина_памяти as 'Шина памяти' from GPU" +
                " Join GPUModel on GPU.Графический_процессор = GPUModel_ID" +
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
      

            comboBox1.ForeColor = ThemeColor.PrimaryColor;
            comboBox2.ForeColor = ThemeColor.PrimaryColor;
            comboBox3.ForeColor = ThemeColor.PrimaryColor;
            comboBox4.ForeColor = ThemeColor.PrimaryColor;
            comboBox5.ForeColor = ThemeColor.PrimaryColor;

        }

      
    }
}
