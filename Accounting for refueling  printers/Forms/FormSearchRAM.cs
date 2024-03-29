﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Accounting_for_refueling__printers.Forms
{
    public partial class FormSearchRAM : Form
    {
        public string filter;
        private SqlConnection sqlConnection = null;
        public FormSearchRAM()
        {
            InitializeComponent();
        }

        private void FormSearchRAM_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "databaseDataSetRAM.RAM6". При необходимости она может быть перемещена или удалена.
            this.rAM6TableAdapter.Fill(this.databaseDataSetRAM.RAM6);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "databaseDataSetRAM.RAM5". При необходимости она может быть перемещена или удалена.
            this.rAM5TableAdapter.Fill(this.databaseDataSetRAM.RAM5);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "databaseDataSetRAM.RAM4". При необходимости она может быть перемещена или удалена.
            this.rAM4TableAdapter.Fill(this.databaseDataSetRAM.RAM4);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "databaseDataSetRAM.RAM3". При необходимости она может быть перемещена или удалена.
            this.rAM3TableAdapter.Fill(this.databaseDataSetRAM.RAM3);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "databaseDataSetRAM.RAM2". При необходимости она может быть перемещена или удалена.
            this.rAM2TableAdapter.Fill(this.databaseDataSetRAM.RAM2);
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
        }

            private void btnSearch_Click(object sender, EventArgs e)
            {
                filter = "";
           
                if (comboBox1.Text != "")
                {
                    filter += $"Код_производителя like '{comboBox1.Text}%' and ";
                }
                if (comboBox2.Text != "")
                {
                    filter += $"Производитель like '{comboBox2.Text}%' and ";
                }
                if (comboBox3.Text != "")
                {
                    filter += $"Тип like '{comboBox3.Text}%' and ";
                }
                if (comboBox4.Text != "")
                {
                    filter += $"PC_индекс like '{comboBox4.Text}%' and ";

                }
                if (comboBox5.Text != "")
                {
                    filter += $"Объём like '{comboBox5.Text}%' and ";
                }
                if (comboBox6.Text != "")
                {
                    filter += $"Напряжение like '{comboBox6.Text = new Regex(@",").Replace(comboBox6.Text, ".")}%' and ";
                }

                filter = filter.Remove(filter.Length - 4);
                SqlCommand command = new SqlCommand($"Select RAM_ID as 'Идентификатор', RAM.Код_производителя as 'Код производителя',RAM.Производитель," +
                        $"RAM.Тип, RAM.PC_индекс as 'PC-индекс',RAM.Объём,RAM.Напряжение from RAM where {filter}", sqlConnection);
                if (command.ExecuteScalar() != null)
                {
                    SqlDataAdapter dataAdapter = new SqlDataAdapter($"Select RAM_ID as 'Идентификатор', RAM.Код_производителя as 'Код производителя',RAM.Производитель," +
                        $"RAM.Тип, RAM.PC_индекс as 'PC-индекс',RAM.Объём,RAM.Напряжение from RAM where {filter}", sqlConnection);
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


            comboBox1.ForeColor = ThemeColor.PrimaryColor;
            comboBox2.ForeColor = ThemeColor.PrimaryColor;
            comboBox3.ForeColor = ThemeColor.PrimaryColor;
            comboBox4.ForeColor = ThemeColor.PrimaryColor;
            comboBox5.ForeColor = ThemeColor.PrimaryColor;
            comboBox6.ForeColor = ThemeColor.PrimaryColor;
        }

       
    }
    
}
