﻿
namespace Accounting_for_refueling__printers.Forms
{
    partial class FormAddСartridge
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
            this.btnAdd = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.cartridgeTypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.databaseDataSetCartridgeType = new Accounting_for_refueling__printers.DatabaseDataSetCartridgeType();
            this.cartridgeTypeTableAdapter = new Accounting_for_refueling__printers.DatabaseDataSetCartridgeTypeTableAdapters.CartridgeTypeTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.cartridgeTypeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSetCartridgeType)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Roboto Cn", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAdd.Location = new System.Drawing.Point(341, 252);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(175, 41);
            this.btnAdd.TabIndex = 11;
            this.btnAdd.Text = "Добавить ";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto Cn", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(219, 139);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 19);
            this.label1.TabIndex = 10;
            this.label1.Text = "Производитель:";
            // 
            // textBox1
            // 
            this.textBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox1.Font = new System.Drawing.Font("Roboto Cn", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.Location = new System.Drawing.Point(341, 136);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(175, 27);
            this.textBox1.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Roboto Cn", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(270, 172);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 19);
            this.label2.TabIndex = 13;
            this.label2.Text = "Модель:";
            // 
            // textBox2
            // 
            this.textBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox2.Font = new System.Drawing.Font("Roboto Cn", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox2.Location = new System.Drawing.Point(341, 169);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(175, 27);
            this.textBox2.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Roboto Cn", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(219, 205);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 19);
            this.label3.TabIndex = 15;
            this.label3.Text = "Тип картриджа:";
            // 
            // comboBox1
            // 
            this.comboBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBox1.DataSource = this.cartridgeTypeBindingSource;
            this.comboBox1.DisplayMember = "Type";
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Font = new System.Drawing.Font("Roboto Cn", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(341, 202);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(175, 27);
            this.comboBox1.TabIndex = 16;
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
            // FormAddСartridge
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Name = "FormAddСartridge";
            this.Text = "Добавление в картриджа";
            this.Load += new System.EventHandler(this.FormAddCatridge_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cartridgeTypeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSetCartridgeType)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox1;
        private DatabaseDataSetCartridgeType databaseDataSetCartridgeType;
        private System.Windows.Forms.BindingSource cartridgeTypeBindingSource;
        private DatabaseDataSetCartridgeTypeTableAdapters.CartridgeTypeTableAdapter cartridgeTypeTableAdapter;
    }
}