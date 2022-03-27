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
    public partial class FormAddBreaking : Form
    {
        private SqlConnection sqlConnection = null;
        public string monitor, sd, cpu, gpu, ram;
        public FormAddBreaking()
        {
            InitializeComponent();
        }


        private void FormAddBreaking_Load(object sender, EventArgs e)
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
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            SelectAcess();
            
        }
       

        

        private void btnAdd_Click(object sender, EventArgs e)
        {

            if (checkBox1.Checked==true)
            {
                 monitor = textBox1.Text;
            }
            else
            {
             monitor = "Отсутствует";
            }
            if (checkBox2.Checked == true)
            {
                 sd = textBox2.Text;
            }
            else
            {
                 sd = "Отсутствует";
            }
            if (checkBox3.Checked == true)
            {
                 cpu = textBox3.Text;
            }
            else
            {
                 cpu = "Отсутствует";
            }
            if (checkBox4.Checked == true)
            {
                 gpu = textBox4.Text;
            }
            else
            {
                 gpu = "Отсутствует";
            }
            if (checkBox5.Checked == true)
            {
                 ram = textBox5.Text;
            }
            else
            {
                 ram = "Отсутствует";
            }


            DateTime date = DateTime.Parse(dateTimePicker1.Text);
            if (checkBox1.Checked || checkBox2.Checked || checkBox3.Checked || checkBox4.Checked || checkBox5.Checked)
            {


                try
                {


                    SqlCommand SelectRoom = new SqlCommand($"Select Кабинет from PC where PC_ID = {TableBreakingAttributes.IndexCell}", sqlConnection);
                    SqlCommand FIO = new SqlCommand($"Select ФИО_МОЛ from PC where PC_ID = {TableBreakingAttributes.IndexCell} ", sqlConnection);
                    SqlCommand InventNumber = new SqlCommand($"Select Инв_Номер from PC where PC_ID = {TableBreakingAttributes.IndexCell}  ", sqlConnection);


                    SqlCommand command = new SqlCommand("INSERT INTO [BREAKING](PC_ID,Дата,Кабинет,ФИО_МОЛ,Инв_Номер,Монитор,Диск,CPU,GPU,RAM,Причина) Values (@PC_ID,@Дата,@Кабинет,@ФИО_МОЛ,@Инв_Номер,@Монитор,@Диск,@CPU,@GPU,@RAM,@Причина)", sqlConnection);
                    command.Parameters.AddWithValue("PC_ID", TableBreakingAttributes.IndexCell);
                    command.Parameters.AddWithValue("Дата", $"{date.Month}/{date.Day}/{date.Year}");
                    command.Parameters.AddWithValue("Кабинет", SelectRoom.ExecuteScalar().ToString());
                    command.Parameters.AddWithValue("ФИО_МОЛ", FIO.ExecuteScalar().ToString());
                    command.Parameters.AddWithValue("Инв_Номер", InventNumber.ExecuteScalar().ToString());
                    command.Parameters.AddWithValue("Монитор", monitor);
                    command.Parameters.AddWithValue("Диск", sd);
                    command.Parameters.AddWithValue("CPU", cpu);
                    command.Parameters.AddWithValue("GPU", gpu);
                    command.Parameters.AddWithValue("RAM", ram);
                    command.Parameters.AddWithValue("Причина", textBox6.Text);
                    if (textBox6.Text != "")
                    {
                        if (command.ExecuteNonQuery() == 1)
                        {
                            MessageBox.Show("Вставка успешна завершена");
                            FormMainMenu.SelfRef.UpdateBreaking();
                            if (FormMainMenu.SelfRef.activeForm != null)
                                FormMainMenu.SelfRef.activeForm.Close();
                            FormMainMenu.SelfRef.hideSubMenu();
                            FormMainMenu.SelfRef.PanelBreakingSubMenu.Visible = true;
                            NameActiveForm.NameForm = "Поломки";

                            FormMainMenu.SelfRef.Reset();
                         


                        }
                        else
                        {
                            command.Cancel();
                        }


                    }
                    else
                    {
                        MessageBox.Show("Заполните поле \"Причина\"", "Предуприждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                catch
                {
                      

                }
                
            }
            else
                {
                    MessageBox.Show("Выберите хотябы одну поломку", "Предуприждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
        }
        private void SelectAcess()
        {
            SqlCommand Edit1 = new SqlCommand($"Select Инв_Номер                from Monitor         where Monitor_ID =  (Select Монитор from PC where PC_ID = {TableBreakingAttributes.IndexCell})", sqlConnection);
            SqlCommand Edit2 = new SqlCommand($"Select Код_производителя        from Storage_device  where SD_ID = (Select Диск from PC where PC_ID = {TableBreakingAttributes.IndexCell})", sqlConnection);
            SqlCommand Edit3 = new SqlCommand($"Select Модельный_ряд            from CPU             where CPU_ID = (Select CPU from PC where PC_ID = {TableBreakingAttributes.IndexCell})", sqlConnection);
            SqlCommand Edit4 = new SqlCommand($"Select Код_производителя    from GPU             where GPU_ID = (Select GPU from PC where PC_ID = {TableBreakingAttributes.IndexCell})", sqlConnection);
            SqlCommand Edit5 = new SqlCommand($"Select Код_производителя        from RAM             where RAM_ID = (Select RAM from PC where PC_ID = {TableBreakingAttributes.IndexCell})", sqlConnection);
            textBox1.Text = Edit1.ExecuteScalar().ToString();
            textBox2.Text = Edit2.ExecuteScalar().ToString();
            textBox3.Text = Edit3.ExecuteScalar().ToString();
            textBox4.Text = Edit4.ExecuteScalar().ToString();
            textBox5.Text = Edit5.ExecuteScalar().ToString();
        }
    }
}
