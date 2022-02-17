
namespace Accounting_for_refueling__printers.Forms
{
    partial class FormAddPC
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.monitorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.databaseDataSetMonitor = new Accounting_for_refueling__printers.DatabaseDataSetMonitor();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.storagedeviceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.databaseDataSetSD = new Accounting_for_refueling__printers.DatabaseDataSetSD();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.oCBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.databaseDataSetOC = new Accounting_for_refueling__printers.DatabaseDataSetOC();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.cPUBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.databaseDataSetCPU = new Accounting_for_refueling__printers.DatabaseDataSetCPU();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.comboBox5 = new System.Windows.Forms.ComboBox();
            this.gPUBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.databaseDataSetGPU = new Accounting_for_refueling__printers.DatabaseDataSetGPU();
            this.comboBox6 = new System.Windows.Forms.ComboBox();
            this.rAMBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.databaseDataSetRAM = new Accounting_for_refueling__printers.DatabaseDataSetRAM();
            this.label9 = new System.Windows.Forms.Label();
            this.rAMTableAdapter = new Accounting_for_refueling__printers.DatabaseDataSetRAMTableAdapters.RAMTableAdapter();
            this.gPUTableAdapter = new Accounting_for_refueling__printers.DatabaseDataSetGPUTableAdapters.GPUTableAdapter();
            this.cPUTableAdapter = new Accounting_for_refueling__printers.DatabaseDataSetCPUTableAdapters.CPUTableAdapter();
            this.oCTableAdapter = new Accounting_for_refueling__printers.DatabaseDataSetOCTableAdapters.OCTableAdapter();
            this.storage_deviceTableAdapter = new Accounting_for_refueling__printers.DatabaseDataSetSDTableAdapters.Storage_deviceTableAdapter();
            this.monitorTableAdapter = new Accounting_for_refueling__printers.DatabaseDataSetMonitorTableAdapters.MonitorTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.monitorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSetMonitor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.storagedeviceBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSetSD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.oCBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSetOC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cPUBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSetCPU)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gPUBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSetGPU)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rAMBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSetRAM)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox1.Font = new System.Drawing.Font("Roboto Cn", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.Location = new System.Drawing.Point(343, 36);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(151, 27);
            this.textBox1.TabIndex = 0;
            // 
            // comboBox1
            // 
            this.comboBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBox1.DataSource = this.monitorBindingSource;
            this.comboBox1.DisplayMember = "Инв_Номер";
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Font = new System.Drawing.Font("Roboto Cn", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(343, 135);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(151, 27);
            this.comboBox1.TabIndex = 1;
            // 
            // monitorBindingSource
            // 
            this.monitorBindingSource.DataMember = "Monitor";
            this.monitorBindingSource.DataSource = this.databaseDataSetMonitor;
            // 
            // databaseDataSetMonitor
            // 
            this.databaseDataSetMonitor.DataSetName = "DatabaseDataSetMonitor";
            this.databaseDataSetMonitor.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // comboBox2
            // 
            this.comboBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBox2.DataSource = this.storagedeviceBindingSource;
            this.comboBox2.DisplayMember = "Код_производителя";
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.Font = new System.Drawing.Font("Roboto Cn", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(343, 168);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(151, 27);
            this.comboBox2.TabIndex = 3;
            // 
            // storagedeviceBindingSource
            // 
            this.storagedeviceBindingSource.DataMember = "Storage_device";
            this.storagedeviceBindingSource.DataSource = this.databaseDataSetSD;
            // 
            // databaseDataSetSD
            // 
            this.databaseDataSetSD.DataSetName = "DatabaseDataSetSD";
            this.databaseDataSetSD.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // comboBox3
            // 
            this.comboBox3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBox3.DataSource = this.oCBindingSource;
            this.comboBox3.DisplayMember = "Название";
            this.comboBox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox3.Font = new System.Drawing.Font("Roboto Cn", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(343, 201);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(151, 27);
            this.comboBox3.TabIndex = 5;
            // 
            // oCBindingSource
            // 
            this.oCBindingSource.DataMember = "OC";
            this.oCBindingSource.DataSource = this.databaseDataSetOC;
            // 
            // databaseDataSetOC
            // 
            this.databaseDataSetOC.DataSetName = "DatabaseDataSetOC";
            this.databaseDataSetOC.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // comboBox4
            // 
            this.comboBox4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBox4.DataSource = this.cPUBindingSource;
            this.comboBox4.DisplayMember = "Модельный_ряд";
            this.comboBox4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox4.Font = new System.Drawing.Font("Roboto Cn", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Location = new System.Drawing.Point(343, 234);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(151, 27);
            this.comboBox4.TabIndex = 7;
            // 
            // cPUBindingSource
            // 
            this.cPUBindingSource.DataMember = "CPU";
            this.cPUBindingSource.DataSource = this.databaseDataSetCPU;
            // 
            // databaseDataSetCPU
            // 
            this.databaseDataSetCPU.DataSetName = "DatabaseDataSetCPU";
            this.databaseDataSetCPU.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Roboto Cn", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAdd.Location = new System.Drawing.Point(343, 345);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(151, 47);
            this.btnAdd.TabIndex = 8;
            this.btnAdd.Text = "Добавить";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto Cn", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(261, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 19);
            this.label1.TabIndex = 9;
            this.label1.Text = "ФИО МОЛ:";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Roboto Cn", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(171, 204);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(168, 19);
            this.label2.TabIndex = 10;
            this.label2.Text = "Операционная система:";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Roboto Cn", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(253, 237);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 19);
            this.label3.TabIndex = 11;
            this.label3.Text = "Процессор:";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Roboto Cn", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(246, 275);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 19);
            this.label4.TabIndex = 12;
            this.label4.Text = "Видеокарта:";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Roboto Cn", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(183, 303);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(154, 19);
            this.label5.TabIndex = 13;
            this.label5.Text = "Оперативная память:";
            // 
            // textBox2
            // 
            this.textBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox2.Font = new System.Drawing.Font("Roboto Cn", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox2.Location = new System.Drawing.Point(343, 69);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(151, 27);
            this.textBox2.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Roboto Cn", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(272, 39);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 19);
            this.label6.TabIndex = 15;
            this.label6.Text = "Кабинет:";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Roboto Cn", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(254, 105);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 19);
            this.label7.TabIndex = 16;
            this.label7.Text = "Инв.Номер:";
            // 
            // textBox3
            // 
            this.textBox3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox3.Font = new System.Drawing.Font("Roboto Cn", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox3.Location = new System.Drawing.Point(343, 102);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(151, 27);
            this.textBox3.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Roboto Cn", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(268, 138);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 19);
            this.label8.TabIndex = 19;
            this.label8.Text = "Монитор:";
            // 
            // comboBox5
            // 
            this.comboBox5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBox5.DataSource = this.gPUBindingSource;
            this.comboBox5.DisplayMember = "Графический_процессор";
            this.comboBox5.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox5.Font = new System.Drawing.Font("Roboto Cn", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox5.FormattingEnabled = true;
            this.comboBox5.Location = new System.Drawing.Point(343, 267);
            this.comboBox5.Name = "comboBox5";
            this.comboBox5.Size = new System.Drawing.Size(151, 27);
            this.comboBox5.TabIndex = 20;
            // 
            // gPUBindingSource
            // 
            this.gPUBindingSource.DataMember = "GPU";
            this.gPUBindingSource.DataSource = this.databaseDataSetGPU;
            // 
            // databaseDataSetGPU
            // 
            this.databaseDataSetGPU.DataSetName = "DatabaseDataSetGPU";
            this.databaseDataSetGPU.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // comboBox6
            // 
            this.comboBox6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBox6.DataSource = this.rAMBindingSource;
            this.comboBox6.DisplayMember = "Код_производителя";
            this.comboBox6.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox6.Font = new System.Drawing.Font("Roboto Cn", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox6.FormattingEnabled = true;
            this.comboBox6.Location = new System.Drawing.Point(343, 300);
            this.comboBox6.Name = "comboBox6";
            this.comboBox6.Size = new System.Drawing.Size(151, 27);
            this.comboBox6.TabIndex = 21;
            // 
            // rAMBindingSource
            // 
            this.rAMBindingSource.DataMember = "RAM";
            this.rAMBindingSource.DataSource = this.databaseDataSetRAM;
            // 
            // databaseDataSetRAM
            // 
            this.databaseDataSetRAM.DataSetName = "DatabaseDataSetRAM";
            this.databaseDataSetRAM.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Roboto Cn", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(152, 171);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(188, 19);
            this.label9.TabIndex = 22;
            this.label9.Text = "Накопительно устройство:";
            // 
            // rAMTableAdapter
            // 
            this.rAMTableAdapter.ClearBeforeFill = true;
            // 
            // gPUTableAdapter
            // 
            this.gPUTableAdapter.ClearBeforeFill = true;
            // 
            // cPUTableAdapter
            // 
            this.cPUTableAdapter.ClearBeforeFill = true;
            // 
            // oCTableAdapter
            // 
            this.oCTableAdapter.ClearBeforeFill = true;
            // 
            // storage_deviceTableAdapter
            // 
            this.storage_deviceTableAdapter.ClearBeforeFill = true;
            // 
            // monitorTableAdapter
            // 
            this.monitorTableAdapter.ClearBeforeFill = true;
            // 
            // FormAddPC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.comboBox6);
            this.Controls.Add(this.comboBox5);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.comboBox4);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.textBox1);
            this.Name = "FormAddPC";
            this.Text = "Добавление компьютера";
            this.Load += new System.EventHandler(this.FormAddPC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.monitorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSetMonitor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.storagedeviceBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSetSD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.oCBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSetOC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cPUBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSetCPU)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gPUBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSetGPU)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rAMBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSetRAM)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.ComboBox comboBox4;

        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboBox5;
        private System.Windows.Forms.ComboBox comboBox6;
        private System.Windows.Forms.Label label9;
        private DatabaseDataSetRAM databaseDataSetRAM;
        private System.Windows.Forms.BindingSource rAMBindingSource;
        private DatabaseDataSetRAMTableAdapters.RAMTableAdapter rAMTableAdapter;
        private DatabaseDataSetGPU databaseDataSetGPU;
        private System.Windows.Forms.BindingSource gPUBindingSource;
        private DatabaseDataSetGPUTableAdapters.GPUTableAdapter gPUTableAdapter;
        private DatabaseDataSetCPU databaseDataSetCPU;
        private System.Windows.Forms.BindingSource cPUBindingSource;
        private DatabaseDataSetCPUTableAdapters.CPUTableAdapter cPUTableAdapter;
        private DatabaseDataSetOC databaseDataSetOC;
        private System.Windows.Forms.BindingSource oCBindingSource;
        private DatabaseDataSetOCTableAdapters.OCTableAdapter oCTableAdapter;
        private DatabaseDataSetSD databaseDataSetSD;
        private System.Windows.Forms.BindingSource storagedeviceBindingSource;
        private DatabaseDataSetSDTableAdapters.Storage_deviceTableAdapter storage_deviceTableAdapter;
        private DatabaseDataSetMonitor databaseDataSetMonitor;
        private System.Windows.Forms.BindingSource monitorBindingSource;
        private DatabaseDataSetMonitorTableAdapters.MonitorTableAdapter monitorTableAdapter;
    }
}