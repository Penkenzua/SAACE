﻿
namespace Accounting_for_refueling__printers.Forms
{
    partial class FormSearchGPU
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
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.databaseDataSetGPU = new Accounting_for_refueling__printers.DatabaseDataSetGPU();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.gPU1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gPU1TableAdapter = new Accounting_for_refueling__printers.DatabaseDataSetGPUTableAdapters.GPU1TableAdapter();
            this.gPU2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gPU2TableAdapter = new Accounting_for_refueling__printers.DatabaseDataSetGPUTableAdapters.GPU2TableAdapter();
            this.gPU3BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gPU3TableAdapter = new Accounting_for_refueling__printers.DatabaseDataSetGPUTableAdapters.GPU3TableAdapter();
            this.gPU4BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gPU4TableAdapter = new Accounting_for_refueling__printers.DatabaseDataSetGPUTableAdapters.GPU4TableAdapter();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSetGPU)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gPU1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gPU2BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gPU3BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gPU4BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.comboBox4);
            this.panel1.Controls.Add(this.comboBox3);
            this.panel1.Controls.Add(this.comboBox2);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.btnSearch);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 450);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Roboto Cn", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(238, 224);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 19);
            this.label4.TabIndex = 34;
            this.label4.Text = "Шина памяти:";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Roboto Cn", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(252, 191);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 19);
            this.label3.TabIndex = 33;
            this.label3.Text = "Тип памяти:";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Roboto Cn", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(170, 160);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(176, 19);
            this.label2.TabIndex = 32;
            this.label2.Text = "Графический процессор:";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto Cn", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(228, 127);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 19);
            this.label1.TabIndex = 31;
            this.label1.Text = "Производитель:";
            // 
            // comboBox4
            // 
            this.comboBox4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBox4.DataSource = this.gPU4BindingSource;
            this.comboBox4.DisplayMember = "Шина_памяти";
            this.comboBox4.Font = new System.Drawing.Font("Roboto Cn", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Location = new System.Drawing.Point(348, 221);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(121, 27);
            this.comboBox4.TabIndex = 17;
            // 
            // comboBox3
            // 
            this.comboBox3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBox3.DataSource = this.gPU3BindingSource;
            this.comboBox3.DisplayMember = "Тип_памяти";
            this.comboBox3.Font = new System.Drawing.Font("Roboto Cn", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(348, 188);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(121, 27);
            this.comboBox3.TabIndex = 16;
            // 
            // comboBox2
            // 
            this.comboBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBox2.DataSource = this.gPU2BindingSource;
            this.comboBox2.DisplayMember = "Графический_процессор";
            this.comboBox2.Font = new System.Drawing.Font("Roboto Cn", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(348, 155);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 27);
            this.comboBox2.TabIndex = 15;
            // 
            // databaseDataSetGPU
            // 
            this.databaseDataSetGPU.DataSetName = "DatabaseDataSetGPU";
            this.databaseDataSetGPU.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // comboBox1
            // 
            this.comboBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBox1.DataSource = this.gPU1BindingSource;
            this.comboBox1.DisplayMember = "Производитель";
            this.comboBox1.Font = new System.Drawing.Font("Roboto Cn", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(348, 122);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 27);
            this.comboBox1.TabIndex = 6;
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Roboto Cn", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSearch.Location = new System.Drawing.Point(310, 272);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(172, 45);
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
            this.panel2.TabIndex = 2;
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
            // gPU1BindingSource
            // 
            this.gPU1BindingSource.DataMember = "GPU1";
            this.gPU1BindingSource.DataSource = this.databaseDataSetGPU;
            // 
            // gPU1TableAdapter
            // 
            this.gPU1TableAdapter.ClearBeforeFill = true;
            // 
            // gPU2BindingSource
            // 
            this.gPU2BindingSource.DataMember = "GPU2";
            this.gPU2BindingSource.DataSource = this.databaseDataSetGPU;
            // 
            // gPU2TableAdapter
            // 
            this.gPU2TableAdapter.ClearBeforeFill = true;
            // 
            // gPU3BindingSource
            // 
            this.gPU3BindingSource.DataMember = "GPU3";
            this.gPU3BindingSource.DataSource = this.databaseDataSetGPU;
            // 
            // gPU3TableAdapter
            // 
            this.gPU3TableAdapter.ClearBeforeFill = true;
            // 
            // gPU4BindingSource
            // 
            this.gPU4BindingSource.DataMember = "GPU4";
            this.gPU4BindingSource.DataSource = this.databaseDataSetGPU;
            // 
            // gPU4TableAdapter
            // 
            this.gPU4TableAdapter.ClearBeforeFill = true;
            // 
            // FormSearchGPU
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "FormSearchGPU";
            this.Text = "Поиск в видеокартах";
            this.Load += new System.EventHandler(this.FormSearchGPU_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSetGPU)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gPU1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gPU2BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gPU3BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gPU4BindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridView1;
  
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private DatabaseDataSetGPU databaseDataSetGPU;
        private System.Windows.Forms.BindingSource gPU1BindingSource;
        private DatabaseDataSetGPUTableAdapters.GPU1TableAdapter gPU1TableAdapter;
        private System.Windows.Forms.BindingSource gPU2BindingSource;
        private DatabaseDataSetGPUTableAdapters.GPU2TableAdapter gPU2TableAdapter;
        private System.Windows.Forms.BindingSource gPU3BindingSource;
        private DatabaseDataSetGPUTableAdapters.GPU3TableAdapter gPU3TableAdapter;
        private System.Windows.Forms.BindingSource gPU4BindingSource;
        private DatabaseDataSetGPUTableAdapters.GPU4TableAdapter gPU4TableAdapter;
    }
}