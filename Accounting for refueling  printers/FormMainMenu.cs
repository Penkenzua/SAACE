using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;


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
        private Form activeForm;
        public int znachenie;
     


        //Constructor
        public FormMainMenu()
        {

            Thread t = new Thread(new ThreadStart(StartForm));
            t.Start();
            Thread.Sleep(5000);

            InitializeComponent();
            customizeDesign();
            t.Abort(t);
            random = new Random();
            SelfRef = this;
            this.Text = string.Empty;
            this.ControlBox = false;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        //Metods


        public void StartForm()
        {
            Application.Run(new SplashScreen());
        }
        void customizeDesign()
        {
            PanelCPUSubMenu.Visible = false;
            PanelGPUSubMenu.Visible = false;
            PanelRAMSubMenu.Visible = false;
            PanelOCSubMenu.Visible = false;
            PanelPCSubMenu.Visible = false;
            PanelCatridgeSubMenu.Visible = false;
            PanelPrinterSubMenu.Visible = false;

        }
        void hideSubMenu()
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
        }
        public void UpdatePrinter()
        {
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("Select Printer.Id as ID,Printer.Дата,Printer.Кабинет,Catridge.Модель as 'Модель катриджа',Printer.Операции,Printer.Состояние From Printer " +
                "Join Catridge on Printer.Катридж = Catridge.C_Id", sqlConnection);
            DataSet dataSet = new DataSet();
            sqlDataAdapter.Fill(dataSet);
            dataGridView1.DataSource = dataSet.Tables[0];
        }
        public void UpdateCatrdige()
        {
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("Select * from Catridge", sqlConnection);
            DataSet dataSet = new DataSet();
            sqlDataAdapter.Fill(dataSet);
            dataGridView1.DataSource = dataSet.Tables[0];
        }
        public void UpdateCPU()
        {
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("Select * from CPU", sqlConnection);
            DataSet dataSet = new DataSet();
            sqlDataAdapter.Fill(dataSet);
            dataGridView1.DataSource = dataSet.Tables[0];
        }
        public void UpdateGPU()
        {
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("Select * from GPU", sqlConnection);
            DataSet dataSet = new DataSet();
            sqlDataAdapter.Fill(dataSet);
            dataGridView1.DataSource = dataSet.Tables[0];
        }
        public void UpdateOC()
        {
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("Select * from OC", sqlConnection);
            DataSet dataSet = new DataSet();
            sqlDataAdapter.Fill(dataSet);
            dataGridView1.DataSource = dataSet.Tables[0];
        }
        public void UpdatePC()

        {
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("Select PC.PC_ID as ID,PC.Кабинет, PC.Модель, OC.Название As 'Операционная система'," +
                "CPU.Модель as 'Модель процессора',GPU.Модель as 'Модель видеокарты',RAM.Модель as 'Модель ОЗУ' from PC " +
                " JOIN OC on PC.OC = OC.OC_ID" +
                " JOIN CPU on PC.CPU = CPU.CPU_ID" +
                " JOIN GPU on PC.GPU = GPU.GPU_ID" +
                " JOIN RAM on PC.RAM = RAM.RAM_ID", sqlConnection);
            DataSet dataSet = new DataSet();
            sqlDataAdapter.Fill(dataSet);
            dataGridView1.DataSource = dataSet.Tables[0];
        }
        public void UpdateRAM()
        {
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("Select * from RAM", sqlConnection);
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
        private void OpenChildForm(Form childform, object btnSender)
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
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormAddPrinter(), sender);
            btnCloseChildForm.Visible = true;
            btnDelete.Visible = false;

        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormSearchPrinter(), sender);
            btnCloseChildForm.Visible = true;
            btnDelete.Visible = false;

        }
        private void btnEddit_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormEdditPrinter(), sender);
            btnCloseChildForm.Visible = true;
            btnDelete.Visible = false;

        }
        private void btnCloseChildForm_Click(object sender, EventArgs e)
        {
            if (activeForm != null)
                activeForm.Close();
            Reset();
         

        }
        private void Reset()
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
                            MessageBox.Show(new Form { TopMost = true },"Соеденение открыто","Информация",MessageBoxButtons.OK,MessageBoxIcon.Information);
                        }
           }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                znachenie = Convert.ToInt32(dataGridView1[0, e.RowIndex].Value);
            }
            catch
            {
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            //DialogResult dialogResult = MessageBox.Show("Вы действительно хотите безвозвратно удалить этоту запись? ", "Предупреждение", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            //if (dialogResult == DialogResult.OK)
            //{
            //    if (znachenie >= 0)
            //    {
            //        SqlCommand VDeleteLast3 = new SqlCommand($"Delete from Printer where id ={znachenie}", sqlConnection);
            //        VDeleteLast3.ExecuteNonQuery();
            //        UpdatePrinter();
            //    }
            //    else
            //    {
            //        MessageBox.Show("Выберите запись перед удалением", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    }
            //}
        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("\"Учёт компьютерной техники\" v1.0\nРазработал: Балабанов Артём Андреевич\nE-mail: artem.balabanov.2017@gmail.com","О программе",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void btnPrinters_Click(object sender, EventArgs e)
        {
            if (activeForm != null)
                activeForm.Close();
            btnCloseChildForm.Visible = false;
            ShowSubMenu(PanelPrinterSubMenu);
            dataGridView1.Visible = true;
            UpdatePrinter();
            lblTittle.Text = "Принтеры";
            NameActiveForm.NameForm = "Принтеры";
            
        }

        private void btnPC_Click(object sender, EventArgs e)
        {

            if (activeForm != null)
                activeForm.Close();
            btnCloseChildForm.Visible = false;
            ShowSubMenu(PanelPCSubMenu);
            dataGridView1.Visible = true;
            UpdatePC();
            lblTittle.Text = "Компьютеры";
            NameActiveForm.NameForm = "Компьютеры";


        }

        private void btnOC_Click(object sender, EventArgs e)
        {

            if (activeForm != null)
                activeForm.Close();
            btnCloseChildForm.Visible = false;
            ShowSubMenu(PanelOCSubMenu);
            dataGridView1.Visible = true;
            UpdateOC();
            lblTittle.Text = "Операционные системы";
            NameActiveForm.NameForm = "Операционные системы";

        }
        private void btnCatridge_Click(object sender, EventArgs e)
        {
            if (activeForm != null)
                activeForm.Close();
            btnCloseChildForm.Visible = false;
            ShowSubMenu(PanelCatridgeSubMenu);
            dataGridView1.Visible = true;
            UpdateCatrdige();
            lblTittle.Text = "Картриджи";
            NameActiveForm.NameForm = "Картридж";
        }
        private void btnCPU_Click(object sender, EventArgs e)
        {
            if (activeForm != null)
                activeForm.Close();
            btnCloseChildForm.Visible = false;
            ShowSubMenu(PanelCPUSubMenu);
            dataGridView1.Visible = true;
            UpdateCPU();
            lblTittle.Text = "Процессоры";
            NameActiveForm.NameForm = "Процессоры";

        }

        private void btnGPU_Click(object sender, EventArgs e)
        {
            if (activeForm != null)
                activeForm.Close();
            btnCloseChildForm.Visible = false;
            ShowSubMenu(PanelGPUSubMenu);
            dataGridView1.Visible = true;
            UpdateGPU();
            lblTittle.Text = "Видеокарты";
            NameActiveForm.NameForm = "Видеокарты";

        }

        private void btnRAM_Click(object sender, EventArgs e)
        {
            if (activeForm != null)
                activeForm.Close();
            btnCloseChildForm.Visible = false;
            ShowSubMenu(PanelRAMSubMenu);
            dataGridView1.Visible = true;
            UpdateRAM();
            lblTittle.Text = "Оперативная память";
            NameActiveForm.NameForm = "Оперативная память";

        }

        private void btnAddPC_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormAddPC(), sender);
            btnCloseChildForm.Visible = true;
            btnDelete.Visible = false;
        }

        private void btnSearchPC_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormSearchPC(), sender);
            btnCloseChildForm.Visible = true;
            btnDelete.Visible = false;
        }

        private void btnEdditPC_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormEditPC(), sender);
            btnCloseChildForm.Visible = true;
            btnDelete.Visible = false;
            
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
            OpenChildForm(new Forms.FormEdditRAM(), sender);
            btnCloseChildForm.Visible = true;
            btnDelete.Visible = false;
        }

        private void btnAddCatridge_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormAddCatridge(), sender);
            btnCloseChildForm.Visible = true;
            btnDelete.Visible = false;
        }

        private void btnSearchCatridge_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormSearchCatridge(), sender);
            btnCloseChildForm.Visible = true;
            btnDelete.Visible = false;
        }

        private void btnEdditCatridge_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormEditCatridge(), sender);
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
            lblTittle.Text = "Домашняя страница";
        }
    }

    } 