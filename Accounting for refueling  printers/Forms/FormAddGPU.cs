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
    public partial class FormAddGPU : Form
    {
              private SqlConnection sqlConnection = null;
        public FormAddGPU()
        {
            InitializeComponent();
        }

        private void FormAddGPU_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "databaseDataSetGPUModel.GPUModel". При необходимости она может быть перемещена или удалена.
            this.gPUModelTableAdapter.Fill(this.databaseDataSetGPUModel.GPUModel);

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
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "" )
            {


                SqlCommand selectmodel = new SqlCommand($"Select Model from GPUModel where Model = N'{comboBox1.Text}'", sqlConnection);
                if (selectmodel.ExecuteScalar() == null)
                {
                    SqlCommand gpumodel = new SqlCommand("INSERT INTO [GPUModel](Model)VALUES(@Model)", sqlConnection);
                    gpumodel.Parameters.AddWithValue("Model", comboBox1.Text);
                    gpumodel.ExecuteNonQuery();
                    SqlCommand idgpumodel = new SqlCommand($"Select GPUModel_ID from GPUModel where Model = N'{comboBox1.Text}'", sqlConnection);
                    SqlCommand command = new SqlCommand("INSERT INTO [GPU] (Производитель,Код_производителя,Графический_процессор,Тип_памяти,Шина_памяти) VALUES(@Производитель,@Код_производителя,@Графический_процессор,@Тип_памяти,@Шина_памяти)", sqlConnection);
                    command.Parameters.AddWithValue("Производитель", textBox1.Text);
                    command.Parameters.AddWithValue("Код_производителя", textBox2.Text);
                    command.Parameters.AddWithValue("Графический_процессор", idgpumodel.ExecuteScalar());
                    command.Parameters.AddWithValue("Тип_памяти", textBox3.Text);
                    command.Parameters.AddWithValue("Шина_памяти", textBox4.Text);
                    if (command.ExecuteNonQuery() == 1)
                    {
                        MessageBox.Show("Вставка успешна завершена");
                        FormMainMenu.SelfRef.UpdateGPU();

                    }
                }
                else
                {
                    SqlCommand idgpumodel2 = new SqlCommand($"Select GPUModel_ID from GPUModel where Model = N'{comboBox1.Text}'", sqlConnection);
                    SqlCommand command = new SqlCommand("INSERT INTO [GPU] (Производитель,Код_производителя,Графический_процессор,Тип_памяти,Шина_памяти) VALUES(@Производитель,@Код_производителя,@Графический_процессор,@Тип_памяти,@Шина_памяти)", sqlConnection);
                    command.Parameters.AddWithValue("Производитель", textBox1.Text);
                    command.Parameters.AddWithValue("Код_производителя", textBox2.Text);
                    command.Parameters.AddWithValue("Графический_процессор",idgpumodel2.ExecuteScalar());
                    command.Parameters.AddWithValue("Тип_памяти", textBox3.Text);
                    command.Parameters.AddWithValue("Шина_памяти", textBox4.Text);
                    if (command.ExecuteNonQuery() == 1)
                    {
                        MessageBox.Show("Вставка успешна завершена");
                        FormMainMenu.SelfRef.UpdateGPU();

                    }
                } 
            }

            else
            {
                MessageBox.Show("Заполните все поля", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

            textBox1.ForeColor = ThemeColor.PrimaryColor;
            textBox2.ForeColor = ThemeColor.PrimaryColor;
            textBox3.ForeColor = ThemeColor.PrimaryColor;
            textBox4.ForeColor = ThemeColor.PrimaryColor;


        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            if (Regex.IsMatch(textBox4.Text, "[^0-9]"))
            {
                MessageBox.Show("Только цифры", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                textBox4.Text = textBox4.Text.Remove(textBox4.Text.Length - 1);
                textBox4.SelectionStart = textBox4.TextLength;
            }
        }
    }
}
