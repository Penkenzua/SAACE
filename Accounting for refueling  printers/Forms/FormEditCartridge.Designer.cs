﻿
namespace Accounting_for_refueling__printers.Forms
{
    partial class FormEditCartridge
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.cartridgeTypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.databaseDataSetCartridgeType = new Accounting_for_refueling__printers.DatabaseDataSetCartridgeType();
            this.cartridgeTypeTableAdapter = new Accounting_for_refueling__printers.DatabaseDataSetCartridgeTypeTableAdapters.CartridgeTypeTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.cartridgeTypeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSetCartridgeType)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox1.Font = new System.Drawing.Font("Roboto Cn", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.Location = new System.Drawing.Point(357, 113);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 27);
            this.textBox1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto Cn", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(230, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Идентификатор:";
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Roboto Cn", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSearch.Location = new System.Drawing.Point(193, 274);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(152, 47);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Найти";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // textBox2
            // 
            this.textBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox2.Font = new System.Drawing.Font("Roboto Cn", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox2.Location = new System.Drawing.Point(357, 146);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 27);
            this.textBox2.TabIndex = 3;
            // 
            // textBox3
            // 
            this.textBox3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox3.Font = new System.Drawing.Font("Roboto Cn", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox3.Location = new System.Drawing.Point(357, 179);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 27);
            this.textBox3.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Roboto Cn", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(230, 149);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 19);
            this.label2.TabIndex = 5;
            this.label2.Text = "Производитель:";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Roboto Cn", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(283, 182);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 19);
            this.label3.TabIndex = 6;
            this.label3.Text = "Модель:";
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Roboto Cn", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAdd.Location = new System.Drawing.Point(448, 274);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(152, 47);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.Text = "Изменить";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Roboto Cn", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(232, 215);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 19);
            this.label4.TabIndex = 9;
            this.label4.Text = "Тип картриджа:";
            // 
            // comboBox1
            // 
            this.comboBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBox1.DataSource = this.cartridgeTypeBindingSource;
            this.comboBox1.DisplayMember = "Type";
            this.comboBox1.Font = new System.Drawing.Font("Roboto Cn", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(357, 212);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(100, 27);
            this.comboBox1.TabIndex = 10;
            // 
            // cartridgeTypeBindingSource
            // 
            this.cartridgeTypeBindingSource.DataMember = "CartridgeType";
            this.cartridgeTypeBindingSource.DataSource = this.databaseDataSetCartridgeType;
            // 
            // databaseDataSetCartridgeType
            // 
            this.databaseDataSetCartridgeType.DataSetName = "DatabaseDataSetCartridgeType";
            this.databaseDataSetCartridgeType.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cartridgeTypeTableAdapter
            // 
            this.cartridgeTypeTableAdapter.ClearBeforeFill = true;
            // 
            // FormEditCartridge
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Name = "FormEditCartridge";
            this.Text = "Изменения данных в картриджах";
            this.Load += new System.EventHandler(this.FormEdditCatridge_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cartridgeTypeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSetCartridgeType)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox1;
        private DatabaseDataSetCartridgeType databaseDataSetCartridgeType;
        private System.Windows.Forms.BindingSource cartridgeTypeBindingSource;
        private DatabaseDataSetCartridgeTypeTableAdapters.CartridgeTypeTableAdapter cartridgeTypeTableAdapter;
    }
}