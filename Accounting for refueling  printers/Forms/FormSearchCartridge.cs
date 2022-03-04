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
    public partial class FormSearchCartridge : Form
    {
        public string filter;
        private SqlConnection sqlConnection = null;
        public FormSearchCartridge()
        {
            InitializeComponent();
        }

        private void FormSearchCatridge_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "databaseDataSetCartridgeType.CartridgeType". При необходимости она может быть перемещена или удалена.
            this.cartridgeTypeTableAdapter.Fill(this.databaseDataSetCartridgeType.CartridgeType);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "databaseDataSetCartridge.Cartridge2". При необходимости она может быть перемещена или удалена.
            this.cartridge2TableAdapter.Fill(this.databaseDataSetCartridge.Cartridge2);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "databaseDataSetCartridge.Cartridge1". При необходимости она может быть перемещена или удалена.
            this.cartridge1TableAdapter.Fill(this.databaseDataSetCartridge.Cartridge1);

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
                    filter += $"Модель like '{comboBox2.Text}%' and ";
                }
                if (comboBox3.Text != "")
                {
                    filter += $"Тип  = (Select CartrdigeType_ID from CartrdigeType where Type  = N'{comboBox3.Text}' )";
                }
                filter = filter.Remove(filter.Length - 4);
                SqlCommand command = new SqlCommand($"Select Cartridge_ID as ID, Производитель, Модель from Cartridge where {filter}", sqlConnection);
                if (command.ExecuteScalar()!=null)
                {
                    SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("Select Cartridge.Cartridge_ID as 'Идентификатор', Cartridge.Производитель,Cartridge.Модель,CartridgeType.Type as 'Тип картриджа' from Cartridge" +
             " Join CartridgeType  on Cartridge.Тип = CartridgeType.CartridgeType_ID", sqlConnection);
                    DataSet dataSet = new DataSet();
                    sqlDataAdapter.Fill(dataSet);
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
            comboBox1.ForeColor = ThemeColor.PrimaryColor;
            comboBox2.ForeColor = ThemeColor.PrimaryColor;
            comboBox3.ForeColor = ThemeColor.PrimaryColor;
     
        }

    }

}
