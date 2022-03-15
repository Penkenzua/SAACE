
namespace Accounting_for_refueling__printers.Forms
{
    partial class FormSearchStorageDevice
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
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.storagedevice4BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.databaseDataSetSD = new Accounting_for_refueling__printers.DatabaseDataSetSD();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.storagedevice3BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.storagedevice2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.storagedevice1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnSearch = new System.Windows.Forms.Button();
            this.comboBox5 = new System.Windows.Forms.ComboBox();
            this.storagedevice5BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.storage_device1TableAdapter = new Accounting_for_refueling__printers.DatabaseDataSetSDTableAdapters.Storage_device1TableAdapter();
            this.storage_device2TableAdapter = new Accounting_for_refueling__printers.DatabaseDataSetSDTableAdapters.Storage_device2TableAdapter();
            this.storage_device3TableAdapter = new Accounting_for_refueling__printers.DatabaseDataSetSDTableAdapters.Storage_device3TableAdapter();
            this.storage_device4TableAdapter = new Accounting_for_refueling__printers.DatabaseDataSetSDTableAdapters.Storage_device4TableAdapter();
            this.storage_device5TableAdapter = new Accounting_for_refueling__printers.DatabaseDataSetSDTableAdapters.Storage_device5TableAdapter();
            this.eventLog1 = new System.Diagnostics.EventLog();
            ((System.ComponentModel.ISupportInitialize)(this.storagedevice4BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSetSD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.storagedevice3BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.storagedevice2BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.storagedevice1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.storagedevice5BindingSource)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eventLog1)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox4
            // 
            this.comboBox4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBox4.DataSource = this.storagedevice4BindingSource;
            this.comboBox4.DisplayMember = "Форм_фактор";
            this.comboBox4.Font = new System.Drawing.Font("Roboto Cn", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Location = new System.Drawing.Point(315, 214);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(172, 27);
            this.comboBox4.TabIndex = 33;
            // 
            // storagedevice4BindingSource
            // 
            this.storagedevice4BindingSource.DataMember = "Storage_device4";
            this.storagedevice4BindingSource.DataSource = this.databaseDataSetSD;
            // 
            // databaseDataSetSD
            // 
            this.databaseDataSetSD.DataSetName = "DatabaseDataSetSD";
            this.databaseDataSetSD.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // comboBox3
            // 
            this.comboBox3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBox3.DataSource = this.storagedevice3BindingSource;
            this.comboBox3.DisplayMember = "Тип";
            this.comboBox3.Font = new System.Drawing.Font("Roboto Cn", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(315, 181);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(172, 27);
            this.comboBox3.TabIndex = 32;
            // 
            // storagedevice3BindingSource
            // 
            this.storagedevice3BindingSource.DataMember = "Storage_device3";
            this.storagedevice3BindingSource.DataSource = this.databaseDataSetSD;
            // 
            // comboBox2
            // 
            this.comboBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBox2.DataSource = this.storagedevice2BindingSource;
            this.comboBox2.DisplayMember = "Производитель";
            this.comboBox2.Font = new System.Drawing.Font("Roboto Cn", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(315, 148);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(172, 27);
            this.comboBox2.TabIndex = 31;
            // 
            // storagedevice2BindingSource
            // 
            this.storagedevice2BindingSource.DataMember = "Storage_device2";
            this.storagedevice2BindingSource.DataSource = this.databaseDataSetSD;
            // 
            // comboBox1
            // 
            this.comboBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBox1.DataSource = this.storagedevice1BindingSource;
            this.comboBox1.DisplayMember = "Код_производителя";
            this.comboBox1.Font = new System.Drawing.Font("Roboto Cn", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(315, 115);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(172, 27);
            this.comboBox1.TabIndex = 30;
            // 
            // storagedevice1BindingSource
            // 
            this.storagedevice1BindingSource.DataMember = "Storage_device1";
            this.storagedevice1BindingSource.DataSource = this.databaseDataSetSD;
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Roboto Cn", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSearch.Location = new System.Drawing.Point(315, 295);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(172, 46);
            this.btnSearch.TabIndex = 25;
            this.btnSearch.Text = "Поиск";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // comboBox5
            // 
            this.comboBox5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBox5.DataSource = this.storagedevice5BindingSource;
            this.comboBox5.DisplayMember = "Интерфейс";
            this.comboBox5.Font = new System.Drawing.Font("Roboto Cn", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox5.FormattingEnabled = true;
            this.comboBox5.Location = new System.Drawing.Point(315, 247);
            this.comboBox5.Name = "comboBox5";
            this.comboBox5.Size = new System.Drawing.Size(172, 27);
            this.comboBox5.TabIndex = 35;
            // 
            // storagedevice5BindingSource
            // 
            this.storagedevice5BindingSource.DataMember = "Storage_device5";
            this.storagedevice5BindingSource.DataSource = this.databaseDataSetSD;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Roboto Cn", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(222, 255);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 19);
            this.label5.TabIndex = 39;
            this.label5.Text = "Интерфейс:";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Roboto Cn", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(205, 217);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 19);
            this.label4.TabIndex = 40;
            this.label4.Text = "Форм-фактор:";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Roboto Cn", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(272, 181);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 19);
            this.label3.TabIndex = 38;
            this.label3.Text = "Тип:";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Roboto Cn", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(193, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 19);
            this.label2.TabIndex = 37;
            this.label2.Text = "Производитель:";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto Cn", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(165, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 19);
            this.label1.TabIndex = 36;
            this.label1.Text = "Код производителя:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 450);
            this.panel2.TabIndex = 41;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(800, 450);
            this.dataGridView1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnSearch);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.comboBox2);
            this.panel1.Controls.Add(this.comboBox3);
            this.panel1.Controls.Add(this.comboBox4);
            this.panel1.Controls.Add(this.comboBox5);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 450);
            this.panel1.TabIndex = 1;
            // 
            // storage_device1TableAdapter
            // 
            this.storage_device1TableAdapter.ClearBeforeFill = true;
            // 
            // storage_device2TableAdapter
            // 
            this.storage_device2TableAdapter.ClearBeforeFill = true;
            // 
            // storage_device3TableAdapter
            // 
            this.storage_device3TableAdapter.ClearBeforeFill = true;
            // 
            // storage_device4TableAdapter
            // 
            this.storage_device4TableAdapter.ClearBeforeFill = true;
            // 
            // storage_device5TableAdapter
            // 
            this.storage_device5TableAdapter.ClearBeforeFill = true;
            // 
            // eventLog1
            // 
            this.eventLog1.SynchronizingObject = this;
            // 
            // FormSearchStorageDevice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "FormSearchStorageDevice";
            this.Text = "Поиск накопительных устройств";
            this.Load += new System.EventHandler(this.FormSearchStorageDevice_Load);
            ((System.ComponentModel.ISupportInitialize)(this.storagedevice4BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSetSD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.storagedevice3BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.storagedevice2BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.storagedevice1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.storagedevice5BindingSource)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eventLog1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.ComboBox comboBox5;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
        private DatabaseDataSetSD databaseDataSetSD;
        private System.Windows.Forms.BindingSource storagedevice1BindingSource;
        private DatabaseDataSetSDTableAdapters.Storage_device1TableAdapter storage_device1TableAdapter;
        private System.Windows.Forms.BindingSource storagedevice2BindingSource;
        private DatabaseDataSetSDTableAdapters.Storage_device2TableAdapter storage_device2TableAdapter;
        private System.Windows.Forms.BindingSource storagedevice3BindingSource;
        private DatabaseDataSetSDTableAdapters.Storage_device3TableAdapter storage_device3TableAdapter;
        private System.Windows.Forms.BindingSource storagedevice4BindingSource;
        private DatabaseDataSetSDTableAdapters.Storage_device4TableAdapter storage_device4TableAdapter;
        private System.Windows.Forms.BindingSource storagedevice5BindingSource;
        private DatabaseDataSetSDTableAdapters.Storage_device5TableAdapter storage_device5TableAdapter;
        private System.Diagnostics.EventLog eventLog1;
    }
}