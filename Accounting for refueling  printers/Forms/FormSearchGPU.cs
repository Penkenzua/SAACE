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
            // TODO: данная строка кода позволяет загрузить данные в таблицу "databaseDataSetGPU.GPU". При необходимости она может быть перемещена или удалена.
            this.gPUTableAdapter.Fill(this.databaseDataSetGPU.GPU);

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
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            filter = "";
            try
            {
                if (comboBox1.Text != "")
                {
                    filter += $"Производитель like '{comboBox1.Text}%' and ";
                }
                    if (comboBox2.Text != "")
                    {
                        filter += $"Графический_процессор like '{comboBox3.Text}%' and ";
                    }
                        if (comboBox3.Text != "")
                        {
                            filter += $"Тип_памяти like '{comboBox3.Text}%' and ";
                        }
                            if (comboBox4.Text != "")
                            {
                                filter += $"Шина_памяти like '{comboBox4.Text}%' and ";
                            }

                filter = filter.Remove(filter.Length - 4);
                SqlCommand command = new SqlCommand($"Select GPU_ID as 'Идентификатор', GPU.Производитель,GPU.Графический_процессор as 'Графический процессор'," +
                    $"GPU.Тип_памяти as 'Тип памяти',GPU.Шина_памяти as 'Шина памяти' from GPU where {filter}", sqlConnection);
                if (command.ExecuteScalar() != null)
                {
                    SqlDataAdapter dataAdapter = new SqlDataAdapter($"Select GPU_ID as 'Идентификатор', GPU.Производитель, GPU.Графический_процессор as 'Графический процессор', " +
                    $"GPU.Тип_памяти as 'Тип памяти',GPU.Шина_памяти as 'Шина памяти' from GPU where {filter}", sqlConnection);
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
            label1.ForeColor = ThemeColor.PrimaryColor;
            label2.ForeColor = ThemeColor.PrimaryColor;
            label3.ForeColor = ThemeColor.PrimaryColor;
            label4.ForeColor = ThemeColor.PrimaryColor;
      

            comboBox1.ForeColor = ThemeColor.PrimaryColor;
            comboBox2.ForeColor = ThemeColor.PrimaryColor;
            comboBox3.ForeColor = ThemeColor.PrimaryColor;
            comboBox4.ForeColor = ThemeColor.PrimaryColor;
     
        }
    }
}
