
namespace Accounting_for_refueling__printers
{
    partial class Authorization
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Authorization));
            this.panelAutorization = new System.Windows.Forms.Panel();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.labelHeader = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.labellogin = new System.Windows.Forms.Label();
            this.btnInput = new System.Windows.Forms.Button();
            this.textPassword = new System.Windows.Forms.TextBox();
            this.textLogin = new System.Windows.Forms.TextBox();
            this.labelpassword = new System.Windows.Forms.Label();
            this.panelAutorization.SuspendLayout();
            this.panelHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelAutorization
            // 
            this.panelAutorization.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.panelAutorization.Controls.Add(this.panelHeader);
            this.panelAutorization.Controls.Add(this.labellogin);
            this.panelAutorization.Controls.Add(this.btnInput);
            this.panelAutorization.Controls.Add(this.textPassword);
            this.panelAutorization.Controls.Add(this.textLogin);
            this.panelAutorization.Controls.Add(this.labelpassword);
            this.panelAutorization.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelAutorization.Location = new System.Drawing.Point(0, 0);
            this.panelAutorization.Name = "panelAutorization";
            this.panelAutorization.Size = new System.Drawing.Size(715, 440);
            this.panelAutorization.TabIndex = 1;
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.panelHeader.Controls.Add(this.labelHeader);
            this.panelHeader.Controls.Add(this.btnExit);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(715, 69);
            this.panelHeader.TabIndex = 7;
            this.panelHeader.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelHeader_MouseDown);
            // 
            // labelHeader
            // 
            this.labelHeader.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelHeader.AutoSize = true;
            this.labelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.labelHeader.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelHeader.ForeColor = System.Drawing.Color.White;
            this.labelHeader.Location = new System.Drawing.Point(275, 13);
            this.labelHeader.Name = "labelHeader";
            this.labelHeader.Size = new System.Drawing.Size(177, 37);
            this.labelHeader.TabIndex = 1;
            this.labelHeader.Text = "Авторизация";
            // 
            // btnExit
            // 
            this.btnExit.AutoSize = true;
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.Location = new System.Drawing.Point(648, 11);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(48, 48);
            this.btnExit.TabIndex = 4;
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // labellogin
            // 
            this.labellogin.AutoSize = true;
            this.labellogin.Font = new System.Drawing.Font("Roboto Cn", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labellogin.ForeColor = System.Drawing.Color.White;
            this.labellogin.Location = new System.Drawing.Point(204, 176);
            this.labellogin.Name = "labellogin";
            this.labellogin.Size = new System.Drawing.Size(97, 38);
            this.labellogin.TabIndex = 0;
            this.labellogin.Text = "Логин";
            // 
            // btnInput
            // 
            this.btnInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.btnInput.FlatAppearance.BorderSize = 2;
            this.btnInput.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInput.Font = new System.Drawing.Font("Roboto Cn", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnInput.ForeColor = System.Drawing.Color.White;
            this.btnInput.Location = new System.Drawing.Point(307, 301);
            this.btnInput.Name = "btnInput";
            this.btnInput.Size = new System.Drawing.Size(155, 54);
            this.btnInput.TabIndex = 3;
            this.btnInput.Text = "Войти";
            this.btnInput.UseVisualStyleBackColor = false;
            this.btnInput.Click += new System.EventHandler(this.btnInput_Click);
            // 
            // textPassword
            // 
            this.textPassword.Font = new System.Drawing.Font("Roboto Bk", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textPassword.Location = new System.Drawing.Point(307, 239);
            this.textPassword.Name = "textPassword";
            this.textPassword.PasswordChar = '*';
            this.textPassword.Size = new System.Drawing.Size(155, 27);
            this.textPassword.TabIndex = 2;
            // 
            // textLogin
            // 
            this.textLogin.Font = new System.Drawing.Font("Roboto Bk", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textLogin.Location = new System.Drawing.Point(307, 185);
            this.textLogin.Name = "textLogin";
            this.textLogin.Size = new System.Drawing.Size(155, 27);
            this.textLogin.TabIndex = 1;
            // 
            // labelpassword
            // 
            this.labelpassword.AutoSize = true;
            this.labelpassword.Font = new System.Drawing.Font("Roboto Cn", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelpassword.ForeColor = System.Drawing.Color.White;
            this.labelpassword.Location = new System.Drawing.Point(186, 230);
            this.labelpassword.Name = "labelpassword";
            this.labelpassword.Size = new System.Drawing.Size(115, 38);
            this.labelpassword.TabIndex = 0;
            this.labelpassword.Text = "Пароль";
            // 
            // Authorization
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(715, 440);
            this.Controls.Add(this.panelAutorization);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Authorization";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Authorization";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Authorization_Load);
            this.panelAutorization.ResumeLayout(false);
            this.panelAutorization.PerformLayout();
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelAutorization;
        private System.Windows.Forms.TextBox textPassword;
        private System.Windows.Forms.TextBox textLogin;
        private System.Windows.Forms.Label labelpassword;
        private System.Windows.Forms.Label labellogin;
        private System.Windows.Forms.Button btnInput;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label labelHeader;
        private System.Windows.Forms.Button btnExit;
    }
}