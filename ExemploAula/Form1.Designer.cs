﻿namespace ExemploAula
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lbllogin = new Label();
            lblusuario = new Label();
            txtuser = new TextBox();
            lblsenha = new Label();
            txtsenha = new TextBox();
            btnlogin = new Button();
            SuspendLayout();
            // 
            // lbllogin
            // 
            lbllogin.AutoSize = true;
            lbllogin.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbllogin.Location = new Point(336, 49);
            lbllogin.Name = "lbllogin";
            lbllogin.Size = new Size(104, 45);
            lbllogin.TabIndex = 0;
            lbllogin.Text = "Login";
            lbllogin.Click += lbllogin_Click;
            // 
            // lblusuario
            // 
            lblusuario.AutoSize = true;
            lblusuario.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblusuario.Location = new Point(213, 143);
            lblusuario.Name = "lblusuario";
            lblusuario.Size = new Size(73, 21);
            lblusuario.TabIndex = 1;
            lblusuario.Text = "Usuário:";
            // 
            // txtuser
            // 
            txtuser.Location = new Point(340, 141);
            txtuser.Name = "txtuser";
            txtuser.Size = new Size(100, 23);
            txtuser.TabIndex = 2;
            // 
            // lblsenha
            // 
            lblsenha.AutoSize = true;
            lblsenha.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblsenha.Location = new Point(213, 195);
            lblsenha.Name = "lblsenha";
            lblsenha.Size = new Size(61, 21);
            lblsenha.TabIndex = 3;
            lblsenha.Text = "Senha:";
            // 
            // txtsenha
            // 
            txtsenha.Location = new Point(340, 197);
            txtsenha.Name = "txtsenha";
            txtsenha.Size = new Size(100, 23);
            txtsenha.TabIndex = 4;
            // 
            // btnlogin
            // 
            btnlogin.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnlogin.Location = new Point(351, 262);
            btnlogin.Name = "btnlogin";
            btnlogin.Size = new Size(77, 33);
            btnlogin.TabIndex = 5;
            btnlogin.Text = "Login";
            btnlogin.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnlogin);
            Controls.Add(txtsenha);
            Controls.Add(lblsenha);
            Controls.Add(txtuser);
            Controls.Add(lblusuario);
            Controls.Add(lbllogin);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbllogin;
        private Label lblusuario;
        private TextBox txtuser;
        private Label lblsenha;
        private TextBox txtsenha;
        private Button btnlogin;
    }
}
