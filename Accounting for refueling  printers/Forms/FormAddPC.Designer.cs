﻿
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
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.databaseDataSet = new Accounting_for_refueling__printers.DatabaseDataSet();
            this.oCBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.oCTableAdapter = new Accounting_for_refueling__printers.DatabaseDataSetTableAdapters.OCTableAdapter();
            this.cPUBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cPUTableAdapter = new Accounting_for_refueling__printers.DatabaseDataSetTableAdapters.CPUTableAdapter();
            this.gPUBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gPUTableAdapter = new Accounting_for_refueling__printers.DatabaseDataSetTableAdapters.GPUTableAdapter();
            this.rAMBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rAMTableAdapter = new Accounting_for_refueling__printers.DatabaseDataSetTableAdapters.RAMTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.oCBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cPUBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gPUBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rAMBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(344, 127);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(121, 20);
            this.textBox1.TabIndex = 0;
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.oCBindingSource;
            this.comboBox1.DisplayMember = "Название";
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(344, 153);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 1;
            // 
            // comboBox2
            // 
            this.comboBox2.DataSource = this.cPUBindingSource;
            this.comboBox2.DisplayMember = "Модель";
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(344, 180);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 3;
            // 
            // comboBox3
            // 
            this.comboBox3.DataSource = this.gPUBindingSource;
            this.comboBox3.DisplayMember = "Модель";
            this.comboBox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(344, 207);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(121, 21);
            this.comboBox3.TabIndex = 5;
            // 
            // comboBox4
            // 
            this.comboBox4.DataSource = this.rAMBindingSource;
            this.comboBox4.DisplayMember = "Модель";
            this.comboBox4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Location = new System.Drawing.Point(344, 234);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(121, 21);
            this.comboBox4.TabIndex = 7;
            // 
            // databaseDataSet
            // 
            this.databaseDataSet.DataSetName = "DatabaseDataSet";
            this.databaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // oCBindingSource
            // 
            this.oCBindingSource.DataMember = "OC";
            this.oCBindingSource.DataSource = this.databaseDataSet;
            // 
            // oCTableAdapter
            // 
            this.oCTableAdapter.ClearBeforeFill = true;
            // 
            // cPUBindingSource
            // 
            this.cPUBindingSource.DataMember = "CPU";
            this.cPUBindingSource.DataSource = this.databaseDataSet;
            // 
            // cPUTableAdapter
            // 
            this.cPUTableAdapter.ClearBeforeFill = true;
            // 
            // gPUBindingSource
            // 
            this.gPUBindingSource.DataMember = "GPU";
            this.gPUBindingSource.DataSource = this.databaseDataSet;
            // 
            // gPUTableAdapter
            // 
            this.gPUTableAdapter.ClearBeforeFill = true;
            // 
            // rAMBindingSource
            // 
            this.rAMBindingSource.DataMember = "RAM";
            this.rAMBindingSource.DataSource = this.databaseDataSet;
            // 
            // rAMTableAdapter
            // 
            this.rAMTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(290, 292);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(189, 47);
            this.button1.TabIndex = 8;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(271, 127);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Модель:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(190, 156);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Операционная система:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(254, 183);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Процессор:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(250, 207);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Видеокарта:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(203, 234);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Оперативная память:";
            // 
            // FormAddPC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox4);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.textBox1);
            this.Name = "FormAddPC";
            this.Text = "FormAddPC";
            this.Load += new System.EventHandler(this.FormAddPC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.oCBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cPUBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gPUBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rAMBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.ComboBox comboBox4;
        private DatabaseDataSet databaseDataSet;
        private System.Windows.Forms.BindingSource oCBindingSource;
        private DatabaseDataSetTableAdapters.OCTableAdapter oCTableAdapter;
        private System.Windows.Forms.BindingSource cPUBindingSource;
        private DatabaseDataSetTableAdapters.CPUTableAdapter cPUTableAdapter;
        private System.Windows.Forms.BindingSource gPUBindingSource;
        private DatabaseDataSetTableAdapters.GPUTableAdapter gPUTableAdapter;
        private System.Windows.Forms.BindingSource rAMBindingSource;
        private DatabaseDataSetTableAdapters.RAMTableAdapter rAMTableAdapter;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}