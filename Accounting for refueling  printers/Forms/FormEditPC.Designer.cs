
namespace Accounting_for_refueling__printers.Forms
{
    partial class FormEditPC
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
            this.btnOutput = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.comboBox6 = new System.Windows.Forms.ComboBox();
            this.rAM1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.databaseDataSetRAM = new Accounting_for_refueling__printers.DatabaseDataSetRAM();
            this.comboBox5 = new System.Windows.Forms.ComboBox();
            this.gPU2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.databaseDataSetGPU = new Accounting_for_refueling__printers.DatabaseDataSetGPU();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.cPU2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.databaseDataSetCPU = new Accounting_for_refueling__printers.DatabaseDataSetCPU();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.oCBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.databaseDataSetOC = new Accounting_for_refueling__printers.DatabaseDataSetOC();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.storagedevice1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.databaseDataSetSD = new Accounting_for_refueling__printers.DatabaseDataSetSD();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.monitor1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.databaseDataSetMonitor = new Accounting_for_refueling__printers.DatabaseDataSetMonitor();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.monitor1TableAdapter = new Accounting_for_refueling__printers.DatabaseDataSetMonitorTableAdapters.Monitor1TableAdapter();
            this.storage_device1TableAdapter = new Accounting_for_refueling__printers.DatabaseDataSetSDTableAdapters.Storage_device1TableAdapter();
            this.oCTableAdapter = new Accounting_for_refueling__printers.DatabaseDataSetOCTableAdapters.OCTableAdapter();
            this.cPU2TableAdapter = new Accounting_for_refueling__printers.DatabaseDataSetCPUTableAdapters.CPU2TableAdapter();
            this.gPU2TableAdapter = new Accounting_for_refueling__printers.DatabaseDataSetGPUTableAdapters.GPU2TableAdapter();
            this.rAM1TableAdapter = new Accounting_for_refueling__printers.DatabaseDataSetRAMTableAdapters.RAM1TableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.rAM1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSetRAM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gPU2BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSetGPU)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cPU2BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSetCPU)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.oCBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSetOC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.storagedevice1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSetSD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.monitor1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSetMonitor)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox1.Font = new System.Drawing.Font("Roboto Cn", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.Location = new System.Drawing.Point(360, 54);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(121, 27);
            this.textBox1.TabIndex = 1;
            // 
            // btnOutput
            // 
            this.btnOutput.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnOutput.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOutput.Font = new System.Drawing.Font("Roboto Cn", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnOutput.Location = new System.Drawing.Point(218, 396);
            this.btnOutput.Name = "btnOutput";
            this.btnOutput.Size = new System.Drawing.Size(121, 54);
            this.btnOutput.TabIndex = 6;
            this.btnOutput.Text = "Вывод";
            this.btnOutput.UseVisualStyleBackColor = true;
            this.btnOutput.Click += new System.EventHandler(this.btnOutput_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto Cn", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(232, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 19);
            this.label1.TabIndex = 7;
            this.label1.Text = "Идентификатор:";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Roboto Cn", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnUpdate.Location = new System.Drawing.Point(483, 396);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(121, 54);
            this.btnUpdate.TabIndex = 13;
            this.btnUpdate.Text = "Ввод";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Roboto Cn", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(171, 222);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(188, 19);
            this.label9.TabIndex = 40;
            this.label9.Text = "Накопительно устройство:";
            // 
            // comboBox6
            // 
            this.comboBox6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBox6.DataSource = this.rAM1BindingSource;
            this.comboBox6.DisplayMember = "Код_производителя";
            this.comboBox6.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox6.Font = new System.Drawing.Font("Roboto Cn", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox6.FormattingEnabled = true;
            this.comboBox6.Location = new System.Drawing.Point(360, 351);
            this.comboBox6.Name = "comboBox6";
            this.comboBox6.Size = new System.Drawing.Size(121, 27);
            this.comboBox6.TabIndex = 39;
            // 
            // rAM1BindingSource
            // 
            this.rAM1BindingSource.DataMember = "RAM1";
            this.rAM1BindingSource.DataSource = this.databaseDataSetRAM;
            // 
            // databaseDataSetRAM
            // 
            this.databaseDataSetRAM.DataSetName = "DatabaseDataSetRAM";
            this.databaseDataSetRAM.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // comboBox5
            // 
            this.comboBox5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBox5.DataSource = this.gPU2BindingSource;
            this.comboBox5.DisplayMember = "Код_производителя";
            this.comboBox5.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox5.Font = new System.Drawing.Font("Roboto Cn", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox5.FormattingEnabled = true;
            this.comboBox5.Location = new System.Drawing.Point(360, 318);
            this.comboBox5.Name = "comboBox5";
            this.comboBox5.Size = new System.Drawing.Size(121, 27);
            this.comboBox5.TabIndex = 38;
            // 
            // gPU2BindingSource
            // 
            this.gPU2BindingSource.DataMember = "GPU2";
            this.gPU2BindingSource.DataSource = this.databaseDataSetGPU;
            // 
            // databaseDataSetGPU
            // 
            this.databaseDataSetGPU.DataSetName = "DatabaseDataSetGPU";
            this.databaseDataSetGPU.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Roboto Cn", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(281, 189);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 19);
            this.label8.TabIndex = 37;
            this.label8.Text = "Монитор:";
            // 
            // textBox3
            // 
            this.textBox3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox3.Font = new System.Drawing.Font("Roboto Cn", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox3.Location = new System.Drawing.Point(360, 153);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(121, 27);
            this.textBox3.TabIndex = 36;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Roboto Cn", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(270, 156);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 19);
            this.label7.TabIndex = 35;
            this.label7.Text = "Инв.номер:";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Roboto Cn", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(287, 90);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 19);
            this.label6.TabIndex = 34;
            this.label6.Text = "Кабинет:";
            // 
            // textBox2
            // 
            this.textBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox2.Font = new System.Drawing.Font("Roboto Cn", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox2.Location = new System.Drawing.Point(360, 120);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(121, 27);
            this.textBox2.TabIndex = 33;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Roboto Cn", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(206, 354);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(154, 19);
            this.label5.TabIndex = 32;
            this.label5.Text = "Оперативная память:";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Roboto Cn", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(266, 318);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 19);
            this.label4.TabIndex = 31;
            this.label4.Text = "Видеокарта:";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Roboto Cn", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(270, 288);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 19);
            this.label3.TabIndex = 30;
            this.label3.Text = "Процессор:";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Roboto Cn", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(191, 255);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(168, 19);
            this.label2.TabIndex = 29;
            this.label2.Text = "Операционная система:";
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Roboto Cn", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(277, 123);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(79, 19);
            this.label10.TabIndex = 28;
            this.label10.Text = "ФИО МОЛ:";
            // 
            // comboBox4
            // 
            this.comboBox4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBox4.DataSource = this.cPU2BindingSource;
            this.comboBox4.DisplayMember = "Модельный_ряд";
            this.comboBox4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox4.Font = new System.Drawing.Font("Roboto Cn", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Location = new System.Drawing.Point(360, 285);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(121, 27);
            this.comboBox4.TabIndex = 27;
            // 
            // cPU2BindingSource
            // 
            this.cPU2BindingSource.DataMember = "CPU2";
            this.cPU2BindingSource.DataSource = this.databaseDataSetCPU;
            // 
            // databaseDataSetCPU
            // 
            this.databaseDataSetCPU.DataSetName = "DatabaseDataSetCPU";
            this.databaseDataSetCPU.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // comboBox3
            // 
            this.comboBox3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBox3.DataSource = this.oCBindingSource;
            this.comboBox3.DisplayMember = "Название";
            this.comboBox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox3.Font = new System.Drawing.Font("Roboto Cn", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(360, 252);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(121, 27);
            this.comboBox3.TabIndex = 26;
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
            // comboBox2
            // 
            this.comboBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBox2.DataSource = this.storagedevice1BindingSource;
            this.comboBox2.DisplayMember = "Код_производителя";
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.Font = new System.Drawing.Font("Roboto Cn", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(360, 219);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 27);
            this.comboBox2.TabIndex = 25;
            // 
            // storagedevice1BindingSource
            // 
            this.storagedevice1BindingSource.DataMember = "Storage_device1";
            this.storagedevice1BindingSource.DataSource = this.databaseDataSetSD;
            // 
            // databaseDataSetSD
            // 
            this.databaseDataSetSD.DataSetName = "DatabaseDataSetSD";
            this.databaseDataSetSD.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // comboBox1
            // 
            this.comboBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBox1.DataSource = this.monitor1BindingSource;
            this.comboBox1.DisplayMember = "Инв_Номер";
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Font = new System.Drawing.Font("Roboto Cn", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(360, 186);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 27);
            this.comboBox1.TabIndex = 24;
            // 
            // monitor1BindingSource
            // 
            this.monitor1BindingSource.DataMember = "Monitor1";
            this.monitor1BindingSource.DataSource = this.databaseDataSetMonitor;
            // 
            // databaseDataSetMonitor
            // 
            this.databaseDataSetMonitor.DataSetName = "DatabaseDataSetMonitor";
            this.databaseDataSetMonitor.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // textBox4
            // 
            this.textBox4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox4.Font = new System.Drawing.Font("Roboto Cn", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox4.Location = new System.Drawing.Point(360, 87);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(121, 27);
            this.textBox4.TabIndex = 23;
            // 
            // monitor1TableAdapter
            // 
            this.monitor1TableAdapter.ClearBeforeFill = true;
            // 
            // storage_device1TableAdapter
            // 
            this.storage_device1TableAdapter.ClearBeforeFill = true;
            // 
            // oCTableAdapter
            // 
            this.oCTableAdapter.ClearBeforeFill = true;
            // 
            // cPU2TableAdapter
            // 
            this.cPU2TableAdapter.ClearBeforeFill = true;
            // 
            // gPU2TableAdapter
            // 
            this.gPU2TableAdapter.ClearBeforeFill = true;
            // 
            // rAM1TableAdapter
            // 
            this.rAM1TableAdapter.ClearBeforeFill = true;
            // 
            // FormEditPC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 494);
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
            this.Controls.Add(this.label10);
            this.Controls.Add(this.comboBox4);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnOutput);
            this.Controls.Add(this.textBox1);
            this.Name = "FormEditPC";
            this.Text = "Изменение данных в компьютерах";
            this.Load += new System.EventHandler(this.FormEdditPC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.rAM1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSetRAM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gPU2BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSetGPU)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cPU2BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSetCPU)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.oCBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSetOC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.storagedevice1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSetSD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.monitor1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSetMonitor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnOutput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnUpdate;

        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox comboBox6;
        private System.Windows.Forms.ComboBox comboBox5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox4;
        private DatabaseDataSetMonitor databaseDataSetMonitor;
        private System.Windows.Forms.BindingSource monitor1BindingSource;
        private DatabaseDataSetMonitorTableAdapters.Monitor1TableAdapter monitor1TableAdapter;
        private DatabaseDataSetSD databaseDataSetSD;
        private System.Windows.Forms.BindingSource storagedevice1BindingSource;
        private DatabaseDataSetSDTableAdapters.Storage_device1TableAdapter storage_device1TableAdapter;
        private DatabaseDataSetOC databaseDataSetOC;
        private System.Windows.Forms.BindingSource oCBindingSource;
        private DatabaseDataSetOCTableAdapters.OCTableAdapter oCTableAdapter;
        private DatabaseDataSetCPU databaseDataSetCPU;
        private System.Windows.Forms.BindingSource cPU2BindingSource;
        private DatabaseDataSetCPUTableAdapters.CPU2TableAdapter cPU2TableAdapter;
        private DatabaseDataSetGPU databaseDataSetGPU;
        private System.Windows.Forms.BindingSource gPU2BindingSource;
        private DatabaseDataSetGPUTableAdapters.GPU2TableAdapter gPU2TableAdapter;
        private DatabaseDataSetRAM databaseDataSetRAM;
        private System.Windows.Forms.BindingSource rAM1BindingSource;
        private DatabaseDataSetRAMTableAdapters.RAM1TableAdapter rAM1TableAdapter;
    }
}