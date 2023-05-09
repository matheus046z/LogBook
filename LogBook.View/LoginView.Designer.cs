namespace LogBook.View
{
    partial class LoginView
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
            this.btnLogin = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtLoginRa = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtLoginClassCode = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(28, 103);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(101, 23);
            this.btnLogin.TabIndex = 7;
            this.btnLogin.Text = "LOGAR";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Codigo de Turma";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "RA";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtLoginRa
            // 
            this.txtLoginRa.Location = new System.Drawing.Point(9, 32);
            this.txtLoginRa.Name = "txtLoginRa";
            this.txtLoginRa.Size = new System.Drawing.Size(135, 20);
            this.txtLoginRa.TabIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnLogin);
            this.groupBox1.Controls.Add(this.txtLoginClassCode);
            this.groupBox1.Controls.Add(this.txtLoginRa);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(165, 155);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            // 
            // txtLoginClassCode
            // 
            this.txtLoginClassCode.Location = new System.Drawing.Point(9, 77);
            this.txtLoginClassCode.Name = "txtLoginClassCode";
            this.txtLoginClassCode.Size = new System.Drawing.Size(135, 20);
            this.txtLoginClassCode.TabIndex = 5;
            // 
            // LoginView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(185, 178);
            this.Controls.Add(this.groupBox1);
            this.Name = "LoginView";
            this.Text = "Login";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtLoginRa;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtLoginClassCode;
    }
}