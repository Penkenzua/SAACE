﻿
namespace Accounting_for_refueling__printers.Forms
{
    partial class FormSearchRAM
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.comboBox6 = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBox5 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.databaseDataSetRAM = new Accounting_for_refueling__printers.DatabaseDataSetRAM();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.rAM1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rAM1TableAdapter = new Accounting_for_refueling__printers.DatabaseDataSetRAMTableAdapters.RAM1TableAdapter();
            this.rAM2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rAM2TableAdapter = new Accounting_for_refueling__printers.DatabaseDataSetRAMTableAdapters.RAM2TableAdapter();
            this.rAM3BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rAM3TableAdapter = new Accounting_for_refueling__printers.DatabaseDataSetRAMTableAdapters.RAM3TableAdapter();
            this.rAM4BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rAM4TableAdapter = new Accounting_for_refueling__printers.DatabaseDataSetRAMTableAdapters.RAM4TableAdapter();
            this.rAM5BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rAM5TableAdapter = new Accounting_for_refueling__printers.DatabaseDataSetRAMTableAdapters.RAM5TableAdapter();
            this.rAM6BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rAM6TableAdapter = new Accounting_for_refueling__printers.DatabaseDataSetRAMTableAdapters.RAM6TableAdapter();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSetRAM)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rAM1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rAM2BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rAM3BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rAM4BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rAM5BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rAM6BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.comboBox6);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.comboBox5);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.comboBox4);
            this.panel1.Controls.Add(this.comboBox3);
            this.panel1.Controls.Add(this.comboBox2);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnSearch);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 450);
            this.panel1.TabIndex = 3;
            // 
            // comboBox6
            // 
            this.comboBox6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBox6.DataSource = this.rAM6BindingSource;
            this.comboBox6.DisplayMember = "Напряжение";
            this.comboBox6.Font = new System.Drawing.Font("Roboto Cn", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox6.FormattingEnabled = true;
            this.comboBox6.Location = new System.Drawing.Point(341, 244);
            this.comboBox6.Name = "comboBox6";
            this.comboBox6.Size = new System.Drawing.Size(172, 27);
            this.comboBox6.TabIndex = 28;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Roboto Cn", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(239, 247);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 19);
            this.label6.TabIndex = 27;
            this.label6.Text = "Напряжение:";
            // 
            // comboBox5
            // 
            this.comboBox5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBox5.DataSource = this.rAM5BindingSource;
            this.comboBox5.DisplayMember = "Объём";
            this.comboBox5.Font = new System.Drawing.Font("Roboto Cn", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox5.FormattingEnabled = true;
            this.comboBox5.Location = new System.Drawing.Point(341, 211);
            this.comboBox5.Name = "comboBox5";
            this.comboBox5.Size = new System.Drawing.Size(172, 27);
            this.comboBox5.TabIndex = 26;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Roboto Cn", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(278, 214);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 19);
            this.label5.TabIndex = 25;
            this.label5.Text = "Объём:";
            // 
            // comboBox4
            // 
            this.comboBox4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBox4.DataSource = this.rAM4BindingSource;
            this.comboBox4.DisplayMember = "PC_индекс";
            this.comboBox4.Font = new System.Drawing.Font("Roboto Cn", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Location = new System.Drawing.Point(341, 178);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(172, 27);
            this.comboBox4.TabIndex = 24;
            // 
            // comboBox3
            // 
            this.comboBox3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBox3.DataSource = this.rAM3BindingSource;
            this.comboBox3.DisplayMember = "Тип";
            this.comboBox3.Font = new System.Drawing.Font("Roboto Cn", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(341, 145);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(172, 27);
            this.comboBox3.TabIndex = 23;
            // 
            // comboBox2
            // 
            this.comboBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBox2.DataSource = this.rAM2BindingSource;
            this.comboBox2.DisplayMember = "Производитель";
            this.comboBox2.Font = new System.Drawing.Font("Roboto Cn", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(341, 112);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(172, 27);
            this.comboBox2.TabIndex = 22;
            // 
            // comboBox1
            // 
            this.comboBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBox1.DataSource = this.rAM1BindingSource;
            this.comboBox1.DisplayMember = "Код_производителя";
            this.comboBox1.Font = new System.Drawing.Font("Roboto Cn", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(341, 79);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(172, 27);
            this.comboBox1.TabIndex = 21;
            // 
            // databaseDataSetRAM
            // 
            this.databaseDataSetRAM.DataSetName = "DatabaseDataSetRAM";
            this.databaseDataSetRAM.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Roboto Cn", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(299, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 19);
            this.label4.TabIndex = 19;
            this.label4.Text = "Тип:";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Roboto Cn", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(251, 181);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 19);
            this.label3.TabIndex = 20;
            this.label3.Text = "PC-индекс:";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Roboto Cn", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(218, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 19);
            this.label2.TabIndex = 16;
            this.label2.Text = "Производитель:";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto Cn", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(190, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 19);
            this.label1.TabIndex = 14;
            this.label1.Text = "Код производителя:";
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Roboto Cn", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSearch.Location = new System.Drawing.Point(341, 283);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(172, 46);
            this.btnSearch.TabIndex = 7;
            this.btnSearch.Text = "Поиск";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 450);
            this.panel2.TabIndex = 4;
            this.panel2.Visible = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(800, 450);
            this.dataGridView1.TabIndex = 8;
            // 
            // rAM1BindingSource
            // 
            this.rAM1BindingSource.DataMember = "RAM1";
            this.rAM1BindingSource.DataSource = this.databaseDataSetRAM;
            // 
            // rAM1TableAdapter
            // 
            this.rAM1TableAdapter.ClearBeforeFill = true;
            // 
            // rAM2BindingSource
            // 
            this.rAM2BindingSource.DataMember = "RAM2";
            this.rAM2BindingSource.DataSource = this.databaseDataSetRAM;
            // 
            // rAM2TableAdapter
            // 
            this.rAM2TableAdapter.ClearBeforeFill = true;
            // 
            // rAM3BindingSource
            // 
            this.rAM3BindingSource.DataMember = "RAM3";
            this.rAM3BindingSource.DataSource = this.databaseDataSetRAM;
            // 
            // rAM3TableAdapter
            // 
            this.rAM3TableAdapter.ClearBeforeFill = true;
            // 
            // rAM4BindingSource
            // 
            this.rAM4BindingSource.DataMember = "RAM4";
            this.rAM4BindingSource.DataSource = this.databaseDataSetRAM;
            // 
            // rAM4TableAdapter
            // 
            this.rAM4TableAdapter.ClearBeforeFill = true;
            // 
            // rAM5BindingSource
            // 
            this.rAM5BindingSource.DataMember = "RAM5";
            this.rAM5BindingSource.DataSource = this.databaseDataSetRAM;
            // 
            // rAM5TableAdapter
            // 
            this.rAM5TableAdapter.ClearBeforeFill = true;
            // 
            // rAM6BindingSource
            // 
            this.rAM6BindingSource.DataMember = "RAM6";
            this.rAM6BindingSource.DataSource = this.databaseDataSetRAM;
            // 
            // rAM6TableAdapter
            // 
            this.rAM6TableAdapter.ClearBeforeFill = true;
            // 
            // FormSearchRAM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "FormSearchRAM";
            this.Text = "Поиск в оперативной памяти";
            this.Load += new System.EventHandler(this.FormSearchRAM_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSetRAM)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rAM1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rAM2BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rAM3BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rAM4BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rAM5BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rAM6BindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox6;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBox5;
        private System.Windows.Forms.Label label5;
        private DatabaseDataSetRAM databaseDataSetRAM;
        private System.Windows.Forms.BindingSource rAM1BindingSource;
        private DatabaseDataSetRAMTableAdapters.RAM1TableAdapter rAM1TableAdapter;
        private System.Windows.Forms.BindingSource rAM2BindingSource;
        private DatabaseDataSetRAMTableAdapters.RAM2TableAdapter rAM2TableAdapter;
        private System.Windows.Forms.BindingSource rAM3BindingSource;
        private DatabaseDataSetRAMTableAdapters.RAM3TableAdapter rAM3TableAdapter;
        private System.Windows.Forms.BindingSource rAM4BindingSource;
        private DatabaseDataSetRAMTableAdapters.RAM4TableAdapter rAM4TableAdapter;
        private System.Windows.Forms.BindingSource rAM5BindingSource;
        private DatabaseDataSetRAMTableAdapters.RAM5TableAdapter rAM5TableAdapter;
        private System.Windows.Forms.BindingSource rAM6BindingSource;
        private DatabaseDataSetRAMTableAdapters.RAM6TableAdapter rAM6TableAdapter;
    }
}