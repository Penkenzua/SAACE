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
    public partial class FormSearch : Form
    {
        public string filter;
        private SqlConnection sqlConnection = null;
        public FormSearch()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "databaseDataSet5.Printer". При необходимости она может быть перемещена или удалена.
            this.printerTableAdapter.Fill(this.databaseDataSet5.Printer);
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
            LoadTheme();
        }
        private void button2_Click(object sender, EventArgs e)
        {

            BackgroundWorker worker = new BackgroundWorker();
            worker.WorkerReportsProgress = true;
            worker.DoWork += ExportinExcel_DoWork;
            worker.RunWorkerAsync();


            SqlCommand Update1 = new SqlCommand($"Update Printer " +
             $"SET Состояние  = N'Выписано'" +
             $" where {filter}", sqlConnection);

            if (Update1.ExecuteNonQuery() >= 1)
            {
                FormMainMenu.SelfRef.UpdateTable();


            }
            else
            {
                MessageBox.Show("Произошла ошибка обновления бд");
                Update1.Cancel();

            }
        
            //SqlCommand Update1 = new SqlCommand($"Update Printer " +
            //   $"SET Состояние  = N'Выписано'" +
            //   $" where {filter}", sqlConnection);

            //if (Update1.ExecuteNonQuery() >= 1)
            //{
            //    MessageBox.Show("Изменение true");
            //    FormMainMenu.SelfRef.UpdateTable();


            //}
            //else
            //{
            //    MessageBox.Show("Произошла ошибка обновления бд");
            //    Update1.Cancel();

            //}




            //try
            //{

            //    DateTime now = DateTime.Now;
            //    Excel.Application app = new Excel.Application();
            //    Workbook workbook = app.Workbooks.Add(Type.Missing);
            //    Worksheet worksheet = null;

            //    worksheet = workbook.Sheets[1];
            //    worksheet = workbook.ActiveSheet;
            //    worksheet.Name = "Exported from gridview";
            //    //Fill Excel.
            //    worksheet.Cells[1, 1] = $"Заправки принтеров за {now.ToString("Y").ToUpper()}";

            //    for (int i = 1; i < dataGridView1.Columns.Count + 1; i++)
            //    {
            //        worksheet.Cells[2, i] = dataGridView1.Columns[i - 1].HeaderText;
            //    }
            //    worksheet.Cells[2, 5] = "Стоимость с НДС";
            //    worksheet.Cells[2, 6] = "Б или В/Б";
            //    for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
            //    {
            //        for (int j = 0; j < dataGridView1.Columns.Count; j++)
            //        {
            //            if (j == 0)
            //            {
            //                worksheet.Cells[i + 3, j + 1] = dataGridView1.Rows[i].Cells[j].Value.ToString().Remove(dataGridView1.Rows[i].Cells[j].Value.ToString().Length - 8);
            //            }
            //            else if (j == 4)
            //            {
            //                continue;
            //            }

            //            else
            //            {
            //                worksheet.Cells[i + 3, j + 1] = dataGridView1.Rows[i].Cells[j].Value.ToString();
            //            }


            //        }

            //    }
            //        //Format export in Excel.

            //        ((Range)worksheet.get_Range($"A1:F1")).Merge();
            //    ((Range)worksheet.get_Range($"A1:F{dataGridView1.Rows.Count + 1}")).Cells.Borders.LineStyle = XlLineStyle.xlContinuous;
            //    ((Range)worksheet.get_Range($"A1:F2")).Cells.Font.FontStyle = "Bold";
            //    worksheet.Cells.Style.HorizontalAlignment = XlHAlign.xlHAlignCenter;
            //    worksheet.Cells.Font.Name = "Arial";
            //    worksheet.Cells.Font.Size = 10;
            //    worksheet.Columns.AutoFit();
            //    app.Visible = true;



            //}
            //catch (Exception ex)
            //{



            //    MessageBox.Show(ex.Message, "Ошибка экспорта данных Excel таблицу");
            //}
            //filter = "";


        }
        

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked && !checkBox2.Checked)
            {
                DateTime date = DateTime.Parse(dateTimePicker1.Text);



                if (textBox1.Text != "")
                {
                    filter += $" Кабинет like '{textBox1.Text}%' and ";
                }
                if (comboBox1.Text != "")
                {
                    filter += $" Модель like '{comboBox1.Text}%' and ";

                }

                filter += $" Дата = '{date.Year}.{date.Month}.{date.Day}' and ";
                if (comboBox1.Text != "")
                {
                    filter += $" Операции like N'{textBox4.Text}%' and ";

                }
                if (comboBox2.Text != "")
                {
                    filter += $" Состояние like N'{comboBox2.Text}%' and ";

                }

                filter = filter.Remove(filter.Length - 4);

                SqlDataAdapter dataAdapter1 = new SqlDataAdapter($"Select Дата,Кабинет, Модель,  Операции, Состояние from Printer where {filter}", sqlConnection);
                DataSet dataSet1 = new DataSet();
                dataAdapter1.Fill(dataSet1);
                dataGridView1.DataSource = dataSet1.Tables[0];

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
                        filter += $" Модель like '{comboBox1.Text}%' and ";

                    }

                    if (textBox4.Text != "")
                    {
                        filter += $" Операции like N'{textBox4.Text}%' and ";

                    }
                    if (comboBox2.Text != "")
                    {
                        filter += $" Состояние like N'{comboBox2.Text}%' and ";

                    }

                    filter = filter.Remove(filter.Length - 4);
                    SqlDataAdapter dataAdapter = new SqlDataAdapter($"Select Дата, Кабинет, Модель,  Операции, Состояние from Printer where {filter}", sqlConnection);
                    DataSet dataSet = new DataSet();
                    dataAdapter.Fill(dataSet);
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
                        filter += $" Модель like '{comboBox1.Text}%' and ";

                    }
                        filter += $" Дата between '{date.Year}.{date.Month}.{date.Day}' and '{date1.Year}.{date1.Month}.{date1.Day}' and ";
                            if (comboBox1.Text != "")
                            {
                                filter += $" Операции like N'{textBox4.Text}%' and ";

                            }
                if (comboBox2.Text != "")
                {
                    filter += $" Состояние like N'{comboBox2.Text}%' and ";

                }
                filter = filter.Remove(filter.Length - 4);
                SqlDataAdapter dataAdapter = new SqlDataAdapter($"Select Дата, Кабинет, Модель, Операции, Состояние from Printer where {filter}", sqlConnection);
                DataSet dataSetSearch = new DataSet();
                dataAdapter.Fill(dataSetSearch);
                dataGridView1.DataSource = dataSetSearch.Tables[0];
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
            label6.ForeColor = ThemeColor.PrimaryColor;
            textBox1.ForeColor = ThemeColor.PrimaryColor;
            textBox4.ForeColor = ThemeColor.PrimaryColor;
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
                worksheet.Cells[1, 1] = $"Заправки принтеров за {now.ToString("Y").ToUpper()}";

                for (int i = 1; i < dataGridView1.Columns.Count + 1; i++)
                {
                    worksheet.Cells[2, i] = dataGridView1.Columns[i - 1].HeaderText;
                }
                worksheet.Cells[2, 5] = "Стоимость с НДС";
                worksheet.Cells[2, 6] = "Б или В/Б";
                for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                {
                    for (int j = 0; j < dataGridView1.Columns.Count; j++)
                    {
                        if (j == 0)
                        {
                            worksheet.Cells[i + 3, j + 1] = dataGridView1.Rows[i].Cells[j].Value.ToString().Remove(dataGridView1.Rows[i].Cells[j].Value.ToString().Length - 8);
                        }
                        else if (j == 4)
                        {
                            continue;
                        }

                        else
                        {
                            worksheet.Cells[i + 3, j + 1] = dataGridView1.Rows[i].Cells[j].Value.ToString();
                        }


                    }

                }
                    //Format export in Excel.

                ((Range)worksheet.get_Range($"A1:F1")).Merge();
                ((Range)worksheet.get_Range($"A1:F{dataGridView1.Rows.Count + 1}")).Cells.Borders.LineStyle = XlLineStyle.xlContinuous;
                ((Range)worksheet.get_Range($"A1:F2")).Cells.Font.FontStyle = "Bold";
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
