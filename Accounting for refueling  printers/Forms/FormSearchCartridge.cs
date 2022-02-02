﻿using System;
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
                    filter += $"Модель like '{comboBox2.Text}%' and ";
                }
                filter = filter.Remove(filter.Length - 4);
                SqlCommand command = new SqlCommand($"Select Cartridge_ID as ID, Производитель, Модель from Cartridge where {filter}", sqlConnection);
                if (command.ExecuteScalar()!=null)
                {
                    SqlDataAdapter dataAdapter = new SqlDataAdapter($"Select Cartridge_ID as ID, Производитель, Модель from Cartridge where {filter}", sqlConnection);
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