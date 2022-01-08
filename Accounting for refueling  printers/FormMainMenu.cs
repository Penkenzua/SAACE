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
        public void UpdateTable()
        {
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("Select * From Printer", sqlConnection);
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
        private void DisableButton()
        {
            foreach (Control previousBtn in panelMenu.Controls)
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
            OpenChildForm(new Forms.FormAdd(), sender);
            btnCloseChildForm.Visible = true;
            btnDelete.Visible = false;

        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormSearch(), sender);
            btnCloseChildForm.Visible = true;
            btnDelete.Visible = false;

        }
        private void btnEddit_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormEddit(), sender);
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
            lblTittle.Text = "HOME";
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
                    UpdateTable();

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
            DialogResult dialogResult = MessageBox.Show("Вы действительно хотите безвозвратно удалить этоту запись? ", "Предупреждение", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.OK)
            {
                if (znachenie >= 0)
                {
                    SqlCommand VDeleteLast3 = new SqlCommand($"Delete from Printer where id ={znachenie}", sqlConnection);
                    VDeleteLast3.ExecuteNonQuery();
                    UpdateTable();
                }
                else
                {
                    MessageBox.Show("Выберите запись перед удалением", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("\"Учёт заправки принтеров\" v1.0\nРазработал: Балабанов Артём Андреевич\nE-mail: artem.balabanov.2017@gmail.com","О программе",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }
    }

    } 