using Microsoft.Office.Interop.Excel;
using System;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using Application = System.Windows.Forms.Application;
using Excel = Microsoft.Office.Interop.Excel;

namespace Accounting_for_refueling__printers.Forms
{
    public partial class FormSearchPrinter : Form
    {
        public string filter;
        private SqlConnection sqlConnection = null;
        public FormSearchPrinter()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "databaseDataSetCartridgeType.CartridgeType". При необходимости она может быть перемещена или удалена.
            this.cartridgeTypeTableAdapter.Fill(this.databaseDataSetCartridgeType.CartridgeType);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "databaseDataSetCartridge.Cartridge2". При необходимости она может быть перемещена или удалена.
            this.cartridge2TableAdapter.Fill(this.databaseDataSetCartridge.Cartridge2);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "databaseDataSetPrinter.Printer2". При необходимости она может быть перемещена или удалена.
            this.printer2TableAdapter.Fill(this.databaseDataSetPrinter.Printer2);


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

            LoadTheme();
        }
        private void button2_Click(object sender, EventArgs e)
        {

            BackgroundWorker worker = new BackgroundWorker();
            worker.WorkerReportsProgress = true;
            worker.DoWork += ExportinExcel_DoWork;
            worker.RunWorkerAsync();

        }
        

        private void btnSearch_Click(object sender, EventArgs e)
        {
           
            filter = "";
            if (checkBox1.Checked && !checkBox2.Checked)
            {
                DateTime date = DateTime.Parse(dateTimePicker1.Text);



                if (textBox1.Text != "")
                {
                    filter += $" Кабинет like '{textBox1.Text}%' and ";
                }
                    if (comboBox1.Text != "")
                    {
                        filter += $" Printer.Модель like '{comboBox1.Text}%' and ";

                    }

                if (comboBox2.Text != "")
                {
                    filter += $" Картридж =  (Select Cartridge_ID  from Cartridge where Модель = N'{comboBox2.Text}') and ";

                }
                if (comboBox3.Text != "")
                {
                    filter += $" Тип_картриджа  = (Select CartridgeType_ID  from CartridgeType where Type = N'{comboBox3.Text}') and ";
                }
                      
                                    if (textBox2.Text != "")
                                    {
                                        filter += $" Операции like N'%{textBox2.Text}%' and ";

                                    }
                filter += $" Дата = '{date.Year}.{date.Month}.{date.Day}' and ";
               

                filter = filter.Remove(filter.Length - 4);

                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("Select Printer.Printer_ID as Идентификатор,Printer.Дата,Printer.Кабинет,Printer.Модель as 'Модель принтера',Cartridge.Модель as 'Модель картриджа',CartridgeType.Type as 'Тип картриджа',Printer.Операции From Printer " +
          " Join Cartridge on Printer.Картридж = Cartridge.Cartridge_ID " +
          " Join CartridgeType on Printer.Тип_картриджа = CartridgeType.CartridgeType_ID " +
          $" where {filter}", sqlConnection);
                DataSet dataSet = new DataSet();
                sqlDataAdapter.Fill(dataSet);
                dataGridView1.DataSource = dataSet.Tables[0];

                panel1.Visible = false;
                panel2.Visible = true;

            }
            else if (!checkBox1.Checked && !checkBox2.Checked)
            {


                try
                {

                    if (textBox1.Text != "")
                    {
                        filter += $" Кабинет like '{textBox1.Text}%' and ";
                    }
                        if (comboBox1.Text != "")
                        {
                            filter += $" Printer.Модель like '{comboBox1.Text}%' and ";

                        }

                            if (comboBox2.Text != "")
                            {
                                filter += $" Картридж =  (Select Cartridge_ID  from Cartridge where Cartridge.Модель = N'{comboBox2.Text}') and ";

                            }
                                if (comboBox3.Text != "")
                                {
                                 filter += $" Тип_картриджа  = (Select CartridgeType_ID  from CartridgeType where Type = N'{comboBox3.Text}') and ";
                                }
                                   
                                        if (textBox2.Text != "")
                                        {
                                            filter += $" Операции like N'%{textBox2.Text}%' and ";

                                        }

                    filter = filter.Remove(filter.Length - 4);
                
                    SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("Select Printer.Printer_ID as Идентификатор,Printer.Дата,Printer.Кабинет,Printer.Модель as 'Модель принтера',Cartridge.Модель as 'Модель картриджа',CartridgeType.Type as 'Тип картриджа',Printer.Операции From Printer " +
          " Join Cartridge on Printer.Картридж = Cartridge.Cartridge_ID " +
          " Join CartridgeType on Printer.Тип_картриджа = CartridgeType.CartridgeType_ID " +
          $" where {filter}", sqlConnection);
                    DataSet dataSet = new DataSet();
                    sqlDataAdapter.Fill(dataSet);
                    dataGridView1.DataSource = dataSet.Tables[0];
                    panel1.Visible = false;
                    panel2.Visible = true;
                }
                    catch
                    {
                        MessageBox.Show("Введите хотя бы один фильтр", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
            }
            else if (checkBox1.Checked && checkBox2.Checked)
            {
                DateTime date = DateTime.Parse(dateTimePicker1.Text);
                    DateTime date1 = DateTime.Parse(dateTimePicker2.Text);
                if (textBox1.Text != "")
                {
                    filter += $" Кабинет like '{textBox1.Text}%' and ";
                }
                    if (comboBox1.Text != "")
                    {
                        filter += $" Printer.Модель like '{comboBox1.Text}%' and ";

                    }

                if (comboBox2.Text != "")
                {
                    filter += $" Картридж =  (Select Cartridge_ID  from Cartridge where Модель = N'{comboBox2.Text}') and ";

                }
                if (comboBox3.Text != "")
                {
                    filter += $" Тип_картриджа  = (Select CartridgeType_ID  from CartridgeType where Type = N'{comboBox3.Text}') and ";
                }
                
                                    if (textBox2.Text != "")
                                    {
                                        filter += $" Операции like N'%{textBox2.Text}%' and ";

                                    }
                filter += $" Дата between '{date.Year}.{date.Month}.{date.Day}' and '{date1.Year}.{date1.Month}.{date1.Day}' and ";
                filter = filter.Remove(filter.Length - 4);
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("Select Printer.Printer_ID as Идентификатор,Printer.Дата,Printer.Кабинет,Printer.Модель as 'Модель принтера',Cartridge.Модель as 'Модель картриджа',CartridgeType.Type as 'Тип картриджа',Printer.Операции From Printer " +
            " Join Cartridge on Printer.Картридж = Cartridge.Cartridge_ID " +
            " Join CartridgeType on Printer.Тип_картриджа = CartridgeType.CartridgeType_ID " +
            $" where {filter}", sqlConnection);
                DataSet dataSet = new DataSet();
                sqlDataAdapter.Fill(dataSet);
                dataGridView1.DataSource = dataSet.Tables[0];
                panel1.Visible = false;
                panel2.Visible = true;
            }
        }
        void LoadTheme()
        {
            label1.ForeColor = ThemeColor.PrimaryColor;
            label2.ForeColor = ThemeColor.PrimaryColor;
            label3.ForeColor = ThemeColor.PrimaryColor;
            label4.ForeColor = ThemeColor.PrimaryColor;
            label5.ForeColor = ThemeColor.PrimaryColor;
            label7.ForeColor = ThemeColor.PrimaryColor;
            label8.ForeColor = ThemeColor.PrimaryColor;


            textBox1.ForeColor = ThemeColor.PrimaryColor;
            textBox2.ForeColor = ThemeColor.PrimaryColor;
            comboBox1.ForeColor = ThemeColor.PrimaryColor;
            comboBox2.ForeColor = ThemeColor.PrimaryColor;
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

        private void btnReturn_Click(object sender, EventArgs e)
        {
            if (panel2.Visible)
            {
                panel2.Visible = false;
                panel1.Visible = true;
                filter = "";
            }
        }

        private void ExportinExcel_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {

                DateTime now = DateTime.Now;
                Excel.Application app = new Excel.Application();
                Workbook workbook = app.Workbooks.Add(Type.Missing);
                Worksheet worksheet = null;

                worksheet = workbook.Sheets[1];
                worksheet = workbook.ActiveSheet;
                worksheet.Name = "Exported from gridview";
                //Fill Excel.
                worksheet.Cells[1, 1] = $"Учёт принтеров за {now.ToString("Y").ToUpper()}";

                for (int i = 2; i < dataGridView1.Columns.Count + 1; i++)
                {
                    worksheet.Cells[2, i-1] = dataGridView1.Columns[i - 1].HeaderText;
                }
                worksheet.Cells[2, 7] = "Стоимость с НДС";
                worksheet.Cells[2, 8] = "Б или В/Б";
              
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    for (int j = 1; j < dataGridView1.Columns.Count; j++)
                    {


                        if (j==1)
                        {
                         worksheet.Cells[i + 3, j] = dataGridView1.Rows[i].Cells[j].Value.ToString().Remove(dataGridView1.Rows[i].Cells[j].Value.ToString().Length - 8);

                        }
                        else
                        {
                        worksheet.Cells[i + 3, j] = dataGridView1.Rows[i].Cells[j].Value.ToString();
                        }

                        


                    }

                }

                //Format export in Excel.

                ((Range)worksheet.get_Range($"A1:I1")).Merge();
                ((Range)worksheet.get_Range($"A1:I{dataGridView1.Rows.Count+2}")).Cells.Borders.LineStyle = XlLineStyle.xlContinuous;
                ((Range)worksheet.get_Range($"A1:I2")).Cells.Font.FontStyle = "Bold";
                worksheet.Cells.Style.HorizontalAlignment = XlHAlign.xlHAlignCenter;
                worksheet.Cells.Font.Name = "Arial";
                worksheet.Cells.Font.Size = 10;
                worksheet.Columns.AutoFit();
                app.Visible = true;
                
            }
            catch (Exception ex)
            {



                MessageBox.Show(ex.Message, "Ошибка экспорта данных Excel таблицу");
            }
            
        }
    }
}
