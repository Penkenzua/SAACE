
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Application = System.Windows.Forms.Application;
using Excel = Microsoft.Office.Interop.Excel;
using Microsoft.Office.Interop.Excel;
using Button = System.Windows.Forms.Button;
using Font = System.Drawing.Font;
using System.ComponentModel;

namespace Accounting_for_refueling__printers
{

    public partial class FormMainMenu : Form
    {
        //Fields        
        private SqlConnection sqlConnection;
        public static FormMainMenu SelfRef { get; set; }
        private Button curentButton;
        private Random random;
        private int tempIndex;
        public Form activeForm;
        public int Cell;
        //Constructor
        public FormMainMenu()
        {



            InitializeComponent();
            dataGridView1.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            if (AcessRight.Acess == 0)
            {
                AcessUser();
            }
            customizeDesign();

            random = new Random();
            SelfRef = this;
            this.Text = string.Empty;
            this.ControlBox = false;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            this.dataGridView1.RowsDefaultCellStyle.BackColor = Color.FromArgb(240, 240, 240);
            this.dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.White;

        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        //Metods
        private void customizeDesign()
        {
            PanelCPUSubMenu.Visible = false;
            PanelGPUSubMenu.Visible = false;
            PanelRAMSubMenu.Visible = false;
            PanelOCSubMenu.Visible = false;
            PanelPCSubMenu.Visible = false;
            PanelCatridgeSubMenu.Visible = false;
            PanelPrinterSubMenu.Visible = false;
            PanelMonitorSubMenu.Visible = false;
            PanelStorageDeviceSubMenu.Visible = false;
            panelAccountSubMenu.Visible = false;
            PanelBreakingSubMenu.Visible = false;


        }
        //Hide Sub Menu when click on another Sub Menu.
        public void hideSubMenu()
        {
            if (PanelPrinterSubMenu.Visible == true)
            {
                if (activeForm != null)
                    activeForm.Close();
                btnCloseChildForm.Visible = false;
                PanelPrinterSubMenu.Visible = false;
            }
            if (PanelPCSubMenu.Visible == true)
            {
                if (activeForm != null)
                    activeForm.Close();
                btnCloseChildForm.Visible = false;
                PanelPCSubMenu.Visible = false;
            }
            if (PanelCPUSubMenu.Visible == true)
            {
                if (activeForm != null)
                    activeForm.Close();
                btnCloseChildForm.Visible = false;
                PanelCPUSubMenu.Visible = false;
            }
            if (PanelGPUSubMenu.Visible == true)
            {
                if (activeForm != null)
                    activeForm.Close();
                btnCloseChildForm.Visible = false;
                PanelGPUSubMenu.Visible = false;
            }
            if (PanelOCSubMenu.Visible == true)
            {
                if (activeForm != null)
                    activeForm.Close();
                btnCloseChildForm.Visible = false;
                PanelOCSubMenu.Visible = false;
            }
            if (PanelRAMSubMenu.Visible == true)

            {

                if (activeForm != null)
                    activeForm.Close();
                btnCloseChildForm.Visible = false;
                PanelRAMSubMenu.Visible = false;
            }
            if (PanelCatridgeSubMenu.Visible == true)

            {

                if (activeForm != null)
                    activeForm.Close();
                btnCloseChildForm.Visible = false;
                PanelCatridgeSubMenu.Visible = false;
            }

            if (PanelMonitorSubMenu.Visible == true)

            {

                if (activeForm != null)
                    activeForm.Close();
                btnCloseChildForm.Visible = false;
                PanelMonitorSubMenu.Visible = false;
            }
            if (PanelStorageDeviceSubMenu.Visible == true)

            {

                if (activeForm != null)
                    activeForm.Close();
                btnCloseChildForm.Visible = false;
                PanelStorageDeviceSubMenu.Visible = false;
            }
            if (PanelBreakingSubMenu.Visible == true)

            {

                if (activeForm != null)
                    activeForm.Close();
                btnCloseChildForm.Visible = false;
                PanelBreakingSubMenu.Visible = false;
            }
            if (panelAccountSubMenu.Visible == true)

            {

                if (activeForm != null)
                    activeForm.Close();
                btnCloseChildForm.Visible = false;
                panelAccountSubMenu.Visible = false;
            }
          
        }

        public void UpdatePrinter()
        {
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("Select Printer.Printer_ID as Идентификатор,Printer.Дата,Printer.Кабинет,Printer.Модель as 'Модель принтера',Cartridge.Модель as 'Модель картриджа',CartridgeType.Type as 'Тип картриджа',Printer.Операции From Printer " +
            " Join Cartridge on Printer.Картридж = Cartridge.Cartridge_ID " +
            " Join CartridgeType on Printer.Тип_картриджа = CartridgeType.CartridgeType_ID", sqlConnection);
            DataSet dataSet = new DataSet();
            sqlDataAdapter.Fill(dataSet);
            dataGridView1.DataSource = dataSet.Tables[0];
        }
        public void UpdateCartrdige()
        {
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("Select Cartridge.Cartridge_ID as 'Идентификатор', Cartridge.Производитель,Cartridge.Модель,CartridgeType.Type as 'Тип картриджа' from Cartridge" +
                " Join CartridgeType  on Cartridge.Тип = CartridgeType.CartridgeType_ID", sqlConnection);
            DataSet dataSet = new DataSet();
            sqlDataAdapter.Fill(dataSet);
            dataGridView1.DataSource = dataSet.Tables[0];
        }
        public void UpdateCPU()
        {
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("Select CPU.CPU_ID as 'Идентификатор', CPU.Производитель,CPU.Модельный_ряд as 'Модельный ряд'," +
                "CPU.Сокет,CPU.Количество_ядер as 'Количество ядер',CPU.Кол_потоков as 'Кол-во потоков',CPU.Частота as 'Частота ГГц' from CPU", sqlConnection);
            DataSet dataSet = new DataSet();
            sqlDataAdapter.Fill(dataSet);
            dataGridView1.DataSource = dataSet.Tables[0];
        }
        public void UpdateGPU()
        {
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("Select GPU.GPU_ID as 'Идентификатор',GPU.Код_производителя as 'Код производителя',GPU.Производитель,GPUModel.Model as 'Графический процессор'," +
                "GPU.Тип_памяти as 'Тип памяти',GPU.Шина_памяти as 'Шина памяти' from GPU" +
                " Join GPUModel on GPU.Графический_процессор = GPUModel_ID", sqlConnection);
            DataSet dataSet = new DataSet();
            sqlDataAdapter.Fill(dataSet);
            dataGridView1.DataSource = dataSet.Tables[0];
        }
        public void UpdateOC()
        {
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("Select OC.OC_ID as 'Идентификатор', OC.Название from OC", sqlConnection);
            DataSet dataSet = new DataSet();
            sqlDataAdapter.Fill(dataSet);
            dataGridView1.DataSource = dataSet.Tables[0];
        }
        public void UpdatePC()

        {
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("Select PC.PC_ID as Идентификатор,PC.Кабинет,PC.ФИО_МОЛ as 'ФИО материально ответственного лица',PC.Инв_Номер as 'Инв.номер ПК',Monitor.Инв_Номер as 'Инв.номер монитора', " +
                "Storage_device.Код_производителя as 'Код производителя накопительного устройство', OC.Название As 'Операционная система'," +
                "CPU.Модельный_ряд as 'Название процессора',GPU.Код_производителя as 'Код производителя видеокарты',RAM.Код_производителя as 'Код производителя оперативной памяти' from PC " +
                " JOIN OC on PC.OC = OC.OC_ID" +
                " JOIN CPU on PC.CPU = CPU.CPU_ID" +
                " Join GPU on GPU_ID = PC.GPU" +
                " JOIN RAM on PC.RAM = RAM.RAM_ID" +
                " JOIN Storage_device on PC.Диск = SD_ID" +
                " JOIN Monitor on PC.Монитор = Monitor_ID", sqlConnection);
            DataSet dataSet = new DataSet();
            sqlDataAdapter.Fill(dataSet);
            dataGridView1.DataSource = dataSet.Tables[0];
        }
        public void UpdateMonitor()
        {
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("Select Monitor.Monitor_ID as 'Идентификатор', Monitor.Инв_Номер as 'Инв.номер', Monitor.Производитель, Monitor.Диагональ, Monitor.Частота from Monitor", sqlConnection);
            DataSet dataSet = new DataSet();
            sqlDataAdapter.Fill(dataSet);
            dataGridView1.DataSource = dataSet.Tables[0];
        }
        public void UpdateStorageDevice()
        {
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("Select Storage_device.SD_ID as 'Идентификатор',Storage_device.Код_производителя as 'Код производителя', Storage_device.Производитель,Storage_device.Тип,Storage_device.Форм_фактор as 'Форм-фактор',Storage_device.Интерфейс from Storage_device", sqlConnection);
            DataSet dataSet = new DataSet();
            sqlDataAdapter.Fill(dataSet);
            dataGridView1.DataSource = dataSet.Tables[0];
        }
        public void UpdateRAM()
        {
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("Select RAM_ID as  'Идентификатор', RAM.Код_производителя as 'Код производителя',RAM.Производитель,RAM.Тип,RAM.PC_индекс as 'PC-индекс',RAM.Объём as 'Объём ГБ',RAM.Напряжение as 'Напряжение В'  from RAM", sqlConnection);
            DataSet dataSet = new DataSet();
            sqlDataAdapter.Fill(dataSet);
            dataGridView1.DataSource = dataSet.Tables[0];
        }
        public void UpdateBreaking()
        {
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("Select Breaking_ID as 'Идентификатор', PC_ID as 'Идентификатор ПК', Дата,Кабинет,ФИО_МОЛ as 'ФИО материально ответственного лица', Монитор,Диск,CPU as 'Процессор',GPU as 'Видеокарта',RAM as 'Оперетивная память',Причина from Breaking", sqlConnection);
            DataSet dataSet = new DataSet();
            sqlDataAdapter.Fill(dataSet);
            dataGridView1.DataSource = dataSet.Tables[0];
        }
        public void UpdateAccount()
        {
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("Select Account_ID as 'Идентификатор', LoginUser as 'Логин',PasswordUSer as 'Пароль', RightAcess as 'Права администратора' from Account ", sqlConnection);
            DataSet dataSet = new DataSet();
            sqlDataAdapter.Fill(dataSet);
            dataGridView1.DataSource = dataSet.Tables[0];
        }

        private Color SelectThemeColor()
        {
            int index = random.Next(ThemeColor.ColorList.Count);
            while (tempIndex == index)
            {
                index = random.Next(ThemeColor.ColorList.Count);
            }
            tempIndex = index;
            string color = ThemeColor.ColorList[index];
            return ColorTranslator.FromHtml(color);
        }

        private void ActivateButon(object btnSender)
        {
            if (btnSender != null)
            {
                if (curentButton != (Button)btnSender)
                {
                    DisableButton();
                    Color color = SelectThemeColor();
                    curentButton = (Button)btnSender;
                    curentButton.BackColor = color;
                    curentButton.ForeColor = Color.White;
                    curentButton.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(204)));
                    panelTitleBar.BackColor = color;
                    panelLogo.BackColor = ThemeColor.ChangeColorBrightness(color, -0.3);
                    ThemeColor.PrimaryColor = color;
                    ThemeColor.SecondaryColor = ThemeColor.ChangeColorBrightness(color, -0.3);
                }
            }
        }

        public void OpenChildForm(Form childform, object btnSender)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            ActivateButon(btnSender);
            activeForm = childform;
            childform.TopLevel = false;
            childform.FormBorderStyle = FormBorderStyle.None;
            childform.Dock = DockStyle.Fill;
            this.panelDesktopPane.Controls.Add(childform);
            this.panelDesktopPane.Tag = childform;
            childform.BringToFront();
            childform.Show();
            lblTittle.Text = childform.Text;
        }
        void ShowSubMenu(Panel subMenu)
        {

            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
            {
                subMenu.Visible = false;
            }
        }
        private void DisableButton()
        {
            //Printer
            foreach (Control previousBtn in PanelPrinterSubMenu.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.FromArgb(51, 51, 76);
                    previousBtn.ForeColor = Color.Gainsboro;
                    previousBtn.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(204)));
                }
            }
            //PC
            foreach (Control previousBtn in PanelPCSubMenu.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.FromArgb(51, 51, 76);
                    previousBtn.ForeColor = Color.Gainsboro;
                    previousBtn.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(204)));
                }
            }
            //Catridge
            foreach (Control previousBtn in PanelCatridgeSubMenu.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.FromArgb(51, 51, 76);
                    previousBtn.ForeColor = Color.Gainsboro;
                    previousBtn.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(204)));
                }
            }
            //OC
            foreach (Control previousBtn in PanelOCSubMenu.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.FromArgb(51, 51, 76);
                    previousBtn.ForeColor = Color.Gainsboro;
                    previousBtn.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(204)));
                }
            }
            //CPU
            foreach (Control previousBtn in PanelCPUSubMenu.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.FromArgb(51, 51, 76);
                    previousBtn.ForeColor = Color.Gainsboro;
                    previousBtn.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(204)));
                }
            }
            //GPU
            foreach (Control previousBtn in PanelGPUSubMenu.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.FromArgb(51, 51, 76);
                    previousBtn.ForeColor = Color.Gainsboro;
                    previousBtn.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(204)));
                }
            }
            //RAM
            foreach (Control previousBtn in PanelRAMSubMenu.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.FromArgb(51, 51, 76);
                    previousBtn.ForeColor = Color.Gainsboro;
                    previousBtn.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(204)));
                }
            }
            //Monitor
            foreach (Control previousBtn in PanelMonitorSubMenu.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.FromArgb(51, 51, 76);
                    previousBtn.ForeColor = Color.Gainsboro;
                    previousBtn.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(204)));
                }
            }
            //Storage device
            foreach (Control previousBtn in PanelStorageDeviceSubMenu.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.FromArgb(51, 51, 76);
                    previousBtn.ForeColor = Color.Gainsboro;
                    previousBtn.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(204)));
                }
            }
            //Accounts
            foreach (Control previousBtn in panelAccountSubMenu.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.FromArgb(51, 51, 76);
                    previousBtn.ForeColor = Color.Gainsboro;
                    previousBtn.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(204)));
                }
            }
            //Breaking
            foreach (Control previousBtn in PanelBreakingSubMenu.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.FromArgb(51, 51, 76);
                    previousBtn.ForeColor = Color.Gainsboro;
                    previousBtn.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(204)));
                }
            }
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormAddPrinter(), sender);
            btnCloseChildForm.Visible = true;
            btnDelete.Visible = false;
            btnPrint.Visible = false;

        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormSearchPrinter(), sender);
            btnCloseChildForm.Visible = true;
            btnDelete.Visible = false;
             btnPrint.Visible = false;

        }
        private void btnEddit_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormEditPrinter(), sender);
            btnCloseChildForm.Visible = true;
            btnDelete.Visible = false;
             btnPrint.Visible = false;

        }
        private void btnCloseChildForm_Click(object sender, EventArgs e)
        {
            if (activeForm != null)
                activeForm.Close();
            Reset();


        }
        public void Reset()
        {
            DisableButton();
            lblTittle.Text = NameActiveForm.NameForm;
            panelTitleBar.BackColor = Color.FromArgb(0, 150, 136);
            panelLogo.BackColor = Color.FromArgb(39, 39, 58);
            curentButton = null;
            btnCloseChildForm.Visible = false;
            btnDelete.Visible = true;


        }
        private void panelTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMaximize_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;

            }
            else
            {
                this.WindowState = FormWindowState.Normal;

            }
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        public void FormMainMenu_Load(object sender, EventArgs e)
        {
            dataGridView1.ClearSelection();
            try
            {
                sqlConnection = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename =" + Application.StartupPath + @"\Database.mdf; Integrated Security = True");
                sqlConnection.Open();
            }
            catch (Exception)
            {
                DialogResult dialogResult = MessageBox.Show("База данных не найдена или находится в другом месте выберите место нахождение базы данных ", "Ошибка", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                if (dialogResult == DialogResult.OK)

                    using (OpenFileDialog openFileDialog = new OpenFileDialog())
                    {
                        openFileDialog.InitialDirectory = Application.StartupPath;
                        openFileDialog.Filter = "txt files (*.mdf)|*.mdf";
                        if (openFileDialog.ShowDialog() == DialogResult.OK)
                        {
                            PathDatabase.Path = openFileDialog.FileName;
                        }
                        sqlConnection = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename =" + PathDatabase.Path + " Integrated Security = True");
                        sqlConnection.Open();
                    }
            }

            dataGridView1.Visible = false;
            btnDelete.Visible = false;
            lblTittle.Text = "Домашняя страница";
            if (sqlConnection.State == ConnectionState.Open)
            {
                MessageBox.Show(new Form { TopMost = true }, "Соединение открыто", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                Cell = Convert.ToInt32(dataGridView1[0, e.RowIndex].Value);

            }
            catch
            {
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Вы действительно хотите безвозвратно удалить эту запись? ", "Предупреждение", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.OK)
            {
                if (Cell >= 0)
                {
                    SqlCommand Delete = new SqlCommand($"Delete from {NameActiveForm.NameTable} where {NameActiveForm.NameIdTable} = {Cell}", sqlConnection);
                    Delete.ExecuteNonQuery();
                    NameActiveForm.Update(NameActiveForm.NameTable);
                }
                else
                {
                    MessageBox.Show("Выберите запись перед удалением", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
           
            
                
           
        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("\"Автоматизированный учёт компьютерной техники\" v1.0\nРазработал: Балабанов Артём Андреевич\nE-mail: artem.balabanov.2018@gmail.com", "О программе", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnPrinters_Click(object sender, EventArgs e)
        {
            btnPrint.Visible = true;
            DisableButton();
            if (activeForm != null)
                activeForm.Close();
            btnCloseChildForm.Visible = false;
            btnDelete.Visible = true;
            ShowSubMenu(PanelPrinterSubMenu);
            dataGridView1.Visible = true;
            UpdatePrinter();
            lblTittle.Text = "Принтеры";
            NameActiveForm.NameForm = "Принтеры";
            NameActiveForm.NameTable = "Printers";
            NameActiveForm.NameIdTable = "Printer_ID";

        }

        private void btnPC_Click(object sender, EventArgs e)
        {
            btnPrint.Visible = true;
            DisableButton();
            if (activeForm != null)
                activeForm.Close();
            btnCloseChildForm.Visible = false;
            btnDelete.Visible = true;
            ShowSubMenu(PanelPCSubMenu);
            dataGridView1.Visible = true;
            UpdatePC();
            lblTittle.Text = "Компьютеры";
            NameActiveForm.NameForm = "Компьютеры";
            NameActiveForm.NameTable = "PC";
            NameActiveForm.NameIdTable = "PC_ID";
        }
        private void btnBreaking_Click(object sender, EventArgs e)
        {
            btnPrint.Visible = true;
            DisableButton();
            if (activeForm != null)
                activeForm.Close();
            btnCloseChildForm.Visible = false;
            btnDelete.Visible = true;
            ShowSubMenu(PanelBreakingSubMenu);
            dataGridView1.Visible = true;
            UpdateBreaking();
            lblTittle.Text = "Поломки";
            NameActiveForm.NameForm = "Поломки";
            NameActiveForm.NameTable = "Breaking";
            NameActiveForm.NameIdTable = "Breaking_ID";
        }

        private void btnOC_Click(object sender, EventArgs e)
        {
            btnPrint.Visible = false;
            DisableButton();
            if (activeForm != null)
                activeForm.Close();
            btnCloseChildForm.Visible = false;
            btnDelete.Visible = true;
            ShowSubMenu(PanelOCSubMenu);
            dataGridView1.Visible = true;
            UpdateOC();
            lblTittle.Text = "Операционные системы";
            NameActiveForm.NameTable = "Операционные системы";
            NameActiveForm.NameForm = "OC";
            NameActiveForm.NameIdTable = "OC_ID";



        }
        private void btnCatridge_Click(object sender, EventArgs e)
        {
            btnPrint.Visible = false;
             DisableButton();
            if (activeForm != null)
                activeForm.Close();
            btnCloseChildForm.Visible = false;
            btnDelete.Visible = true;
            ShowSubMenu(PanelCatridgeSubMenu);
            dataGridView1.Visible = true;
            UpdateCartrdige();
            lblTittle.Text = "Картриджи";
            NameActiveForm.NameForm = "Картридж";
            NameActiveForm.NameTable = "Cartridge";
            NameActiveForm.NameIdTable = "Cartridge_ID";


        }
        private void btnCPU_Click(object sender, EventArgs e)
        {
            btnPrint.Visible = false;
            DisableButton();
            if (activeForm != null)
                activeForm.Close();
            btnCloseChildForm.Visible = false;
            btnDelete.Visible = true;
            ShowSubMenu(PanelCPUSubMenu);
            dataGridView1.Visible = true;
            UpdateCPU();
            lblTittle.Text = "Процессоры";
            NameActiveForm.NameForm = "Процессоры";
            NameActiveForm.NameTable = "CPU";
            NameActiveForm.NameIdTable = "CPU_ID";


        }

        private void btnGPU_Click(object sender, EventArgs e)
        {
            btnPrint.Visible = false;
            DisableButton();
            if (activeForm != null)
                activeForm.Close();
            btnCloseChildForm.Visible = false;
            btnDelete.Visible = true;
            ShowSubMenu(PanelGPUSubMenu);
            dataGridView1.Visible = true;
            UpdateGPU();
            lblTittle.Text = "Видеокарты";
            NameActiveForm.NameForm = "Видеокарты";
            NameActiveForm.NameTable = "GPU";
            NameActiveForm.NameIdTable = "GPU_ID";



        }

        private void btnRAM_Click(object sender, EventArgs e)
        {
            btnPrint.Visible = false;
            DisableButton();
            if (activeForm != null)
                activeForm.Close();
            btnCloseChildForm.Visible = false;
            btnDelete.Visible = true;
            ShowSubMenu(PanelRAMSubMenu);
            dataGridView1.Visible = true;
            UpdateRAM();
            lblTittle.Text = "Оперативная память";
            NameActiveForm.NameForm = "Оперативная память";
            NameActiveForm.NameTable = "RAM";
            NameActiveForm.NameIdTable = "RAM_ID";



        }
        private void btnMonitor_Click(object sender, EventArgs e)
        {
            btnPrint.Visible = false;
            DisableButton();
            if (activeForm != null)
                activeForm.Close();
            btnCloseChildForm.Visible = false;
            btnDelete.Visible = true;
            ShowSubMenu(PanelMonitorSubMenu);
            dataGridView1.Visible = true;
            UpdateMonitor();
            lblTittle.Text = "Мониторы";
            NameActiveForm.NameForm = "Мониторы";
            NameActiveForm.NameTable = "Monitor";
            NameActiveForm.NameIdTable = "Monitor_ID";


        }

        private void btnStorageDevice_Click(object sender, EventArgs e)
        {
            btnPrint.Visible = false;
            DisableButton();
            if (activeForm != null)
                activeForm.Close();
            btnCloseChildForm.Visible = false;
            btnDelete.Visible = true;
            ShowSubMenu(PanelStorageDeviceSubMenu);
            dataGridView1.Visible = true;
            UpdateStorageDevice();
            lblTittle.Text = "Накопительные устройства";
            NameActiveForm.NameForm = "Накопительные устройства";
            NameActiveForm.NameTable = "Storage_device";
            NameActiveForm.NameIdTable = "SD_ID";


        }
        private void btnControlAccount_Click(object sender, EventArgs e)
        {
            btnPrint.Visible = false;
            DisableButton();
            if (activeForm != null)
                activeForm.Close();
            btnCloseChildForm.Visible = false;
            btnDelete.Visible = true;
            ShowSubMenu(panelAccountSubMenu);
            dataGridView1.Visible = true;
            UpdateAccount();
            lblTittle.Text = "Аккаунты";
            NameActiveForm.NameForm = "Аккаунты";
            NameActiveForm.NameTable = "Account";
            NameActiveForm.NameIdTable = "Account_ID";



        }

        private void btnAddPC_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormAddPC(), sender);
            btnCloseChildForm.Visible = true;
            btnDelete.Visible = false;
             btnPrint.Visible = false;
        }

        private void btnSearchPC_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormSearchPC(), sender);
            btnCloseChildForm.Visible = true;
            btnDelete.Visible = false;
             btnPrint.Visible = false;
        }

        private void btnEdditPC_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormEditPC(), sender);
            btnCloseChildForm.Visible = true;
            btnDelete.Visible = false;
             btnPrint.Visible = false;
        }

        private void btnAddOC_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormAddOC(), sender);
            btnCloseChildForm.Visible = true;
            btnDelete.Visible = false;
        }

        private void btnSearchOC_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormSearchOC(), sender);
            btnCloseChildForm.Visible = true;
            btnDelete.Visible = false;
        }

        private void btnEdditOC_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormEditOC(), sender);
            btnCloseChildForm.Visible = true;
            btnDelete.Visible = false;
        }

        private void btnAddCPU_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormAddCPU(), sender);
            btnCloseChildForm.Visible = true;
            btnDelete.Visible = false;
        }

        private void btnSearchCPU_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormSearchCPU(), sender);
            btnCloseChildForm.Visible = true;
            btnDelete.Visible = false;
        }

        private void btnEdditCPU_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormEditCPU(), sender);
            btnCloseChildForm.Visible = true;
            btnDelete.Visible = false;
        }

        private void btnAddGPU_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormAddGPU(), sender);
            btnCloseChildForm.Visible = true;
            btnDelete.Visible = false;
        }

        private void btnSearchGPU_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormSearchGPU(), sender);
            btnCloseChildForm.Visible = true;
            btnDelete.Visible = false;
        }

        private void btnEdditGPU_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormEditGPU(), sender);
            btnCloseChildForm.Visible = true;
            btnDelete.Visible = false;
        }

        private void btnAddRAM_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormAddRAM(), sender);
            btnCloseChildForm.Visible = true;
            btnDelete.Visible = false;
        }

        private void btnSearchRAM_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormSearchRAM(), sender);
            btnCloseChildForm.Visible = true;
            btnDelete.Visible = false;
        }

        private void btnEdditRAM_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormEditRAM(), sender);
            btnCloseChildForm.Visible = true;
            btnDelete.Visible = false;
        }

        private void btnAddCatridge_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormAddСartridge(), sender);
            btnCloseChildForm.Visible = true;
            btnDelete.Visible = false;
        }

        private void btnSearchCatridge_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormSearchCartridge(), sender);
            btnCloseChildForm.Visible = true;
            btnDelete.Visible = false;
        }

        private void btnEdditCatridge_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormEditCartridge(), sender);
            btnCloseChildForm.Visible = true;
            btnDelete.Visible = false;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (activeForm != null)
                activeForm.Close();
            Reset();
            dataGridView1.Visible = false;
            btnDelete.Visible = false;
            btnPrint.Visible = false;
            lblTittle.Text = "Домашняя страница";
        }



        private void btnAddMonitor_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormAddMonitor(), sender);
            btnCloseChildForm.Visible = true;
            btnDelete.Visible = false;
        }

        private void btnSearchMonitor_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormSearchMonitor(), sender);
            btnCloseChildForm.Visible = true;
            btnDelete.Visible = false;
        }

        private void btnEditMonitor_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormEditMonitor(), sender);
            btnCloseChildForm.Visible = true;
            btnDelete.Visible = false;
        }

        private void btnAddSD_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormAddStorageDevice(), sender);
            btnCloseChildForm.Visible = true;
            btnDelete.Visible = false;
        }

        private void btnSearchSD_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormSearchStorageDevice(), sender);
            btnCloseChildForm.Visible = true;
            btnDelete.Visible = false;
        }

        private void btnEditSD_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormEditStorageDevice(), sender);
            btnCloseChildForm.Visible = true;
            btnDelete.Visible = false;
        }
        public void AcessUser()
        {
            panelAccountSubMenu.Visible = false;
            btnControlAccount.Visible = false;

        }



        private void btnAddAccount_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormAddAccount(), sender);
            btnCloseChildForm.Visible = true;
            btnDelete.Visible = false;
        }

        private void btnEditAccount_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormEditAccount(), sender);
            btnCloseChildForm.Visible = true;
            btnDelete.Visible = false;
        }

        private void btnSearchBreaking_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormSearchBreaking(), sender);
            btnCloseChildForm.Visible = true;
            btnDelete.Visible = false;
             btnPrint.Visible = false;
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
           
            BackgroundWorker worker = new BackgroundWorker();
            worker.WorkerReportsProgress = true;
        
            if (PanelPrinterSubMenu.Visible)
            {
                worker.DoWork += ExportinExcel_DoWorkPrinter;
                worker.RunWorkerAsync();
            }
            else if (PanelBreakingSubMenu.Visible)
            {
                worker.DoWork += ExportinExcel_DoWorkBreaking;
                worker.RunWorkerAsync();
            }
            else if (PanelPCSubMenu.Visible)
            {
                worker.DoWork += ExportinExcel_DoWorkPC;
                worker.RunWorkerAsync();
            }
        }
        private void ExportinExcel_DoWorkPrinter(object sender, DoWorkEventArgs e)
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
                worksheet.Cells[1, 1] = $"Учёт принтеров";

                for (int i = 2; i < dataGridView1.Columns.Count + 1; i++)
                {
                    worksheet.Cells[2, i - 1] = dataGridView1.Columns[i - 1].HeaderText;
                }
                worksheet.Cells[2, 7] = "Стоимость с НДС";
                worksheet.Cells[2, 8] = "Б или В/Б";

                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    for (int j = 1; j < dataGridView1.Columns.Count; j++)
                    {


                        if (j == 1)
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

                ((Range)worksheet.get_Range($"A1:H1")).Merge();
                ((Range)worksheet.get_Range($"A1:H{dataGridView1.Rows.Count + 2}")).Cells.Borders.LineStyle = XlLineStyle.xlContinuous;
                ((Range)worksheet.get_Range($"A1:H2")).Cells.Font.FontStyle = "Bold";
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
        private void ExportinExcel_DoWorkBreaking(object sender, DoWorkEventArgs e)
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
                worksheet.Cells[1, 1] = $"Учёт поломок комплектующих";

                for (int i = 2; i < dataGridView1.Columns.Count + 1; i++)
                {
                    worksheet.Cells[2, i - 1] = dataGridView1.Columns[i - 1].HeaderText;
                }


                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    for (int j = 1; j < dataGridView1.Columns.Count; j++)
                    {


                        if (j == 2)
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

                ((Range)worksheet.get_Range($"A1:J1")).Merge();
                ((Range)worksheet.get_Range($"A1:J{dataGridView1.Rows.Count + 2}")).Cells.Borders.LineStyle = XlLineStyle.xlContinuous;
                ((Range)worksheet.get_Range($"A1:J2")).Cells.Font.FontStyle = "Bold";
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
        private void ExportinExcel_DoWorkPC(object sender, DoWorkEventArgs e)
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
                worksheet.Cells[1, 1] = $"Учёт компьютеров";

                for (int i = 2; i < dataGridView1.Columns.Count + 1; i++)
                {
                    worksheet.Cells[2, i - 1] = dataGridView1.Columns[i - 1].HeaderText;
                }

                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    for (int j = 1; j < dataGridView1.Columns.Count; j++)
                    {

                        if (j == 3 && j == 4)
                        {
                            worksheet.Cells[i + 3, j].NumberFormat = "Текстовый";
                        }
                        worksheet.Cells[i + 3, j] = dataGridView1.Rows[i].Cells[j].Value.ToString();

                    }

                }

               //Format export in Excel.

               ((Range)worksheet.get_Range($"A1:I1")).Merge();
                ((Range)worksheet.get_Range($"A1:I{dataGridView1.Rows.Count + 2}")).Cells.Borders.LineStyle = XlLineStyle.xlContinuous;
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