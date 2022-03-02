
namespace Accounting_for_refueling__printers.Forms
{
    partial class FormSearchCPU
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
            this.databaseDataSetCPU = new Accounting_for_refueling__printers.DatabaseDataSetCPU();
            this.comboBox5 = new System.Windows.Forms.ComboBox();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cPU1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cPU1TableAdapter = new Accounting_for_refueling__printers.DatabaseDataSetCPUTableAdapters.CPU1TableAdapter();
            this.cPU2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cPU2TableAdapter = new Accounting_for_refueling__printers.DatabaseDataSetCPUTableAdapters.CPU2TableAdapter();
            this.cPU3BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cPU3TableAdapter = new Accounting_for_refueling__printers.DatabaseDataSetCPUTableAdapters.CPU3TableAdapter();
            this.cPU4BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cPU4TableAdapter = new Accounting_for_refueling__printers.DatabaseDataSetCPUTableAdapters.CPU4TableAdapter();
            this.cPU5BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cPU5TableAdapter = new Accounting_for_refueling__printers.DatabaseDataSetCPUTableAdapters.CPU5TableAdapter();
            this.cPU6BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cPU6TableAdapter = new Accounting_for_refueling__printers.DatabaseDataSetCPUTableAdapters.CPU6TableAdapter();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSetCPU)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cPU1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cPU2BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cPU3BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cPU4BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cPU5BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cPU6BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.comboBox6);
            this.panel1.Controls.Add(this.comboBox5);
            this.panel1.Controls.Add(this.comboBox4);
            this.panel1.Controls.Add(this.comboBox3);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.comboBox2);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.btnSearch);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 450);
            this.panel1.TabIndex = 0;
            // 
            // comboBox6
            // 
            this.comboBox6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBox6.DataSource = this.cPU6BindingSource;
            this.comboBox6.DisplayMember = "Частота";
            this.comboBox6.Font = new System.Drawing.Font("Roboto Cn", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox6.FormattingEnabled = true;
            this.comboBox6.Location = new System.Drawing.Point(338, 265);
            this.comboBox6.Name = "comboBox6";
            this.comboBox6.Size = new System.Drawing.Size(158, 27);
            this.comboBox6.TabIndex = 26;
            this.comboBox6.TextChanged += new System.EventHandler(this.comboBox6_TextChanged);
            // 
            // databaseDataSetCPU
            // 
            this.databaseDataSetCPU.DataSetName = "DatabaseDataSetCPU";
            this.databaseDataSetCPU.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // comboBox5
            // 
            this.comboBox5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBox5.DataSource = this.cPU5BindingSource;
            this.comboBox5.DisplayMember = "Кол_потоков";
            this.comboBox5.Font = new System.Drawing.Font("Roboto Cn", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox5.FormattingEnabled = true;
            this.comboBox5.Location = new System.Drawing.Point(338, 232);
            this.comboBox5.Name = "comboBox5";
            this.comboBox5.Size = new System.Drawing.Size(158, 27);
            this.comboBox5.TabIndex = 25;
            // 
            // comboBox4
            // 
            this.comboBox4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBox4.DataSource = this.cPU4BindingSource;
            this.comboBox4.DisplayMember = "Количество_ядер";
            this.comboBox4.Font = new System.Drawing.Font("Roboto Cn", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Location = new System.Drawing.Point(338, 199);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(158, 27);
            this.comboBox4.TabIndex = 24;
            // 
            // comboBox3
            // 
            this.comboBox3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBox3.DataSource = this.cPU3BindingSource;
            this.comboBox3.DisplayMember = "Сокет";
            this.comboBox3.Font = new System.Drawing.Font("Roboto Cn", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(338, 166);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(158, 27);
            this.comboBox3.TabIndex = 23;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Roboto Cn", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(264, 268);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 19);
            this.label6.TabIndex = 21;
            this.label6.Text = "Частота:";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Roboto Cn", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(215, 233);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(119, 19);
            this.label5.TabIndex = 22;
            this.label5.Text = "Кол-во потоков:";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Roboto Cn", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(208, 200);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 19);
            this.label3.TabIndex = 20;
            this.label3.Text = "Количество ядер:";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Roboto Cn", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(280, 169);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 19);
            this.label4.TabIndex = 19;
            this.label4.Text = "Сокет:";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Roboto Cn", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(215, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 19);
            this.label2.TabIndex = 18;
            this.label2.Text = "Модельный ряд:";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto Cn", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(215, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 19);
            this.label1.TabIndex = 17;
            this.label1.Text = "Производитель:";
            // 
            // comboBox2
            // 
            this.comboBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBox2.DataSource = this.cPU2BindingSource;
            this.comboBox2.DisplayMember = "Модельный_ряд";
            this.comboBox2.Font = new System.Drawing.Font("Roboto Cn", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(338, 133);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(158, 27);
            this.comboBox2.TabIndex = 9;
            // 
            // comboBox1
            // 
            this.comboBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBox1.DataSource = this.cPU1BindingSource;
            this.comboBox1.DisplayMember = "Производитель";
            this.comboBox1.Font = new System.Drawing.Font("Roboto Cn", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(338, 100);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(158, 27);
            this.comboBox1.TabIndex = 6;
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Roboto Cn", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSearch.Location = new System.Drawing.Point(338, 304);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(158, 43);
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
            this.panel2.TabIndex = 0;
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
            // cPU1BindingSource
            // 
            this.cPU1BindingSource.DataMember = "CPU1";
            this.cPU1BindingSource.DataSource = this.databaseDataSetCPU;
            // 
            // cPU1TableAdapter
            // 
            this.cPU1TableAdapter.ClearBeforeFill = true;
            // 
            // cPU2BindingSource
            // 
            this.cPU2BindingSource.DataMember = "CPU2";
            this.cPU2BindingSource.DataSource = this.databaseDataSetCPU;
            // 
            // cPU2TableAdapter
            // 
            this.cPU2TableAdapter.ClearBeforeFill = true;
            // 
            // cPU3BindingSource
            // 
            this.cPU3BindingSource.DataMember = "CPU3";
            this.cPU3BindingSource.DataSource = this.databaseDataSetCPU;
            // 
            // cPU3TableAdapter
            // 
            this.cPU3TableAdapter.ClearBeforeFill = true;
            // 
            // cPU4BindingSource
            // 
            this.cPU4BindingSource.DataMember = "CPU4";
            this.cPU4BindingSource.DataSource = this.databaseDataSetCPU;
            // 
            // cPU4TableAdapter
            // 
            this.cPU4TableAdapter.ClearBeforeFill = true;
            // 
            // cPU5BindingSource
            // 
            this.cPU5BindingSource.DataMember = "CPU5";
            this.cPU5BindingSource.DataSource = this.databaseDataSetCPU;
            // 
            // cPU5TableAdapter
            // 
            this.cPU5TableAdapter.ClearBeforeFill = true;
            // 
            // cPU6BindingSource
            // 
            this.cPU6BindingSource.DataMember = "CPU6";
            this.cPU6BindingSource.DataSource = this.databaseDataSetCPU;
            // 
            // cPU6TableAdapter
            // 
            this.cPU6TableAdapter.ClearBeforeFill = true;
            // 
            // FormSearchCPU
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "FormSearchCPU";
            this.Text = "Поиск в процессарах";
            this.Load += new System.EventHandler(this.FormSearchCPU_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSetCPU)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cPU1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cPU2BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cPU3BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cPU4BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cPU5BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cPU6BindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox6;
        private System.Windows.Forms.ComboBox comboBox5;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private DatabaseDataSetCPU databaseDataSetCPU;
        private System.Windows.Forms.BindingSource cPU1BindingSource;
        private DatabaseDataSetCPUTableAdapters.CPU1TableAdapter cPU1TableAdapter;
        private System.Windows.Forms.BindingSource cPU2BindingSource;
        private DatabaseDataSetCPUTableAdapters.CPU2TableAdapter cPU2TableAdapter;
        private System.Windows.Forms.BindingSource cPU3BindingSource;
        private DatabaseDataSetCPUTableAdapters.CPU3TableAdapter cPU3TableAdapter;
        private System.Windows.Forms.BindingSource cPU4BindingSource;
        private DatabaseDataSetCPUTableAdapters.CPU4TableAdapter cPU4TableAdapter;
        private System.Windows.Forms.BindingSource cPU5BindingSource;
        private DatabaseDataSetCPUTableAdapters.CPU5TableAdapter cPU5TableAdapter;
        private System.Windows.Forms.BindingSource cPU6BindingSource;
        private DatabaseDataSetCPUTableAdapters.CPU6TableAdapter cPU6TableAdapter;
    }
}