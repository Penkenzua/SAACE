
namespace Accounting_for_refueling__printers.Forms
{
    partial class FormSearchCartridge
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
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.cartridge1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.databaseDataSetCartridge = new Accounting_for_refueling__printers.DatabaseDataSetCartridge();
            this.btnSearch = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.cartridge2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cartridge1TableAdapter = new Accounting_for_refueling__printers.DatabaseDataSetCartridgeTableAdapters.Cartridge1TableAdapter();
            this.cartridge2TableAdapter = new Accounting_for_refueling__printers.DatabaseDataSetCartridgeTableAdapters.Cartridge2TableAdapter();
            this.databaseDataSetCartridgeType = new Accounting_for_refueling__printers.DatabaseDataSetCartridgeType();
            this.cartridgeTypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cartridgeTypeTableAdapter = new Accounting_for_refueling__printers.DatabaseDataSetCartridgeTypeTableAdapters.CartridgeTypeTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.cartridge1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSetCartridge)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cartridge2BindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSetCartridgeType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cartridgeTypeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto Cn", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(229, 142);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Производитель:";
            // 
            // comboBox1
            // 
            this.comboBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBox1.DataSource = this.cartridge1BindingSource;
            this.comboBox1.DisplayMember = "Производитель";
            this.comboBox1.Font = new System.Drawing.Font("Roboto Cn", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(352, 139);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 27);
            this.comboBox1.TabIndex = 1;
            // 
            // cartridge1BindingSource
            // 
            this.cartridge1BindingSource.DataMember = "Cartridge1";
            this.cartridge1BindingSource.DataSource = this.databaseDataSetCartridge;
            // 
            // databaseDataSetCartridge
            // 
            this.databaseDataSetCartridge.DataSetName = "DatabaseDataSetCartridge";
            this.databaseDataSetCartridge.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Roboto Cn", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSearch.Location = new System.Drawing.Point(325, 256);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(172, 50);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Поиск";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Roboto Cn", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(281, 175);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "Модель:";
            // 
            // comboBox2
            // 
            this.comboBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBox2.DataSource = this.cartridge2BindingSource;
            this.comboBox2.DisplayMember = "Модель";
            this.comboBox2.Font = new System.Drawing.Font("Roboto Cn", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(352, 172);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 27);
            this.comboBox2.TabIndex = 4;
            // 
            // cartridge2BindingSource
            // 
            this.cartridge2BindingSource.DataMember = "Cartridge2";
            this.cartridge2BindingSource.DataSource = this.databaseDataSetCartridge;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.comboBox3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.btnSearch);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.comboBox2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 450);
            this.panel1.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Roboto Cn", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(231, 208);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 19);
            this.label3.TabIndex = 5;
            this.label3.Text = "Тип картриджа:";
            // 
            // comboBox3
            // 
            this.comboBox3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBox3.DataSource = this.cartridgeTypeBindingSource;
            this.comboBox3.DisplayMember = "Type";
            this.comboBox3.Font = new System.Drawing.Font("Roboto Cn", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(352, 205);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(121, 27);
            this.comboBox3.TabIndex = 6;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 450);
            this.panel2.TabIndex = 6;
            this.panel2.Visible = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(800, 450);
            this.dataGridView1.TabIndex = 5;
            // 
            // cartridge1TableAdapter
            // 
            this.cartridge1TableAdapter.ClearBeforeFill = true;
            // 
            // cartridge2TableAdapter
            // 
            this.cartridge2TableAdapter.ClearBeforeFill = true;
            // 
            // databaseDataSetCartridgeType
            // 
            this.databaseDataSetCartridgeType.DataSetName = "DatabaseDataSetCartridgeType";
            this.databaseDataSetCartridgeType.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cartridgeTypeBindingSource
            // 
            this.cartridgeTypeBindingSource.DataMember = "CartridgeType";
            this.cartridgeTypeBindingSource.DataSource = this.databaseDataSetCartridgeType;
            // 
            // cartridgeTypeTableAdapter
            // 
            this.cartridgeTypeTableAdapter.ClearBeforeFill = true;
            // 
            // FormSearchCartridge
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "FormSearchCartridge";
            this.Text = "Поиск в картриджах";
            this.Load += new System.EventHandler(this.FormSearchCatridge_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cartridge1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSetCartridge)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cartridge2BindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSetCartridgeType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cartridgeTypeBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox3;
        private DatabaseDataSetCartridge databaseDataSetCartridge;
        private System.Windows.Forms.BindingSource cartridge1BindingSource;
        private DatabaseDataSetCartridgeTableAdapters.Cartridge1TableAdapter cartridge1TableAdapter;
        private System.Windows.Forms.BindingSource cartridge2BindingSource;
        private DatabaseDataSetCartridgeTableAdapters.Cartridge2TableAdapter cartridge2TableAdapter;
        private DatabaseDataSetCartridgeType databaseDataSetCartridgeType;
        private System.Windows.Forms.BindingSource cartridgeTypeBindingSource;
        private DatabaseDataSetCartridgeTypeTableAdapters.CartridgeTypeTableAdapter cartridgeTypeTableAdapter;
    }
}