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
    public partial class FormSearchCPU : Form
    {
        public string filter;
        private SqlConnection sqlConnection = null;
        public FormSearchCPU()
        {
            InitializeComponent();
        }
        private void FormSearchCPU_Load(object sender, EventArgs e)
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
            filter = "";

            comboBox1.Text = "";
            comboBox2.Text = "";
            comboBox3.Text = "";
            comboBox4.Text = "";
            comboBox5.Text = "";
            comboBox6.Text = "";
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboBox1.Text != "")
                {
                    filter += $"Производитель like '{comboBox1.Text}%' and ";
                }
                if (comboBox2.Text != "")
                {
                    filter += $"Модельный_ряд like '{comboBox2.Text}%' and ";
                }
                if (comboBox3.Text != "")
                {
                    filter += $"Сокет like '{comboBox3.Text}%' and ";
                }
                if (comboBox4.Text != "")
                {
                    filter += $"Количество_ядер like '{comboBox4.Text}%' and ";
                }
                if (comboBox5.Text != "")
                {
                    filter += $"Кол_потоков like '{comboBox5.Text}%' and ";
                }
                if (comboBox6.Text != "")
                {
                    filter += $"Частота like '{comboBox6.Text}%' and ";
                }

                filter = filter.Remove(filter.Length - 4);
                SqlCommand command = new SqlCommand($"Select CPU_ID as 'Идентификатор', CPU.Производитель,CPU.Модельный_ряд as 'Модельный ряд',CPU.Сокет,CPU.Количество_ядер as 'Количество ядер',CPU.Кол_потоков as 'Кол-во потоков',CPU.Частота from CPU where {filter}", sqlConnection);
                if (command.ExecuteScalar() != null)
                {
                    SqlDataAdapter dataAdapter = new SqlDataAdapter($"Select CPU_ID as 'Идентификатор', CPU.Производитель,CPU.Модельный_ряд as 'Модельный ряд',CPU.Сокет,CPU.Количество_ядер as 'Количество ядер',CPU.Кол_потоков as 'Кол-во потоков',CPU.Частота from CPU where {filter}", sqlConnection);
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

     
    }
}
