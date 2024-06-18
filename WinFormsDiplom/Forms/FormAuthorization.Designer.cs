namespace WinFormsDiplom
{
    partial class FormAuthorization
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
            label1 = new Label();
            textBoxLogin = new TextBox();
            textBoxPassword = new TextBox();
            label2 = new Label();
            buttonLogIn = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Left;
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.Location = new Point(86, 126);
            label1.Name = "label1";
            label1.Size = new Size(84, 31);
            label1.TabIndex = 0;
            label1.Text = "Логин";
            // 
            // textBoxLogin
            // 
            textBoxLogin.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            textBoxLogin.Cursor = Cursors.IBeam;
            textBoxLogin.Font = new Font("Times New Roman", 24F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBoxLogin.Location = new Point(176, 126);
            textBoxLogin.Name = "textBoxLogin";
            textBoxLogin.PlaceholderText = "Введите логин";
            textBoxLogin.Size = new Size(209, 44);
            textBoxLogin.TabIndex = 1;
            // 
            // textBoxPassword
            // 
            textBoxPassword.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            textBoxPassword.Cursor = Cursors.IBeam;
            textBoxPassword.Font = new Font("Times New Roman", 24F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBoxPassword.Location = new Point(176, 206);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.PlaceholderText = "Введите пароль";
            textBoxPassword.Size = new Size(227, 44);
            textBoxPassword.TabIndex = 2;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Left;
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label2.Location = new Point(72, 213);
            label2.Name = "label2";
            label2.Size = new Size(98, 31);
            label2.TabIndex = 3;
            label2.Text = "Пароль";
            // 
            // buttonLogIn
            // 
            buttonLogIn.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            buttonLogIn.Font = new Font("Times New Roman", 24F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonLogIn.Location = new Point(176, 412);
            buttonLogIn.Name = "buttonLogIn";
            buttonLogIn.Size = new Size(144, 58);
            buttonLogIn.TabIndex = 4;
            buttonLogIn.Text = "Войти";
            buttonLogIn.UseVisualStyleBackColor = true;
            buttonLogIn.Click += buttonLogIn_Click;
            // 
            // FormAuthorization
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(529, 541);
            Controls.Add(buttonLogIn);
            Controls.Add(label2);
            Controls.Add(textBoxPassword);
            Controls.Add(textBoxLogin);
            Controls.Add(label1);
            MaximumSize = new Size(645, 680);
            MinimumSize = new Size(545, 580);
            Name = "FormAuthorization";
            Text = "Авторизация";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBoxLogin;
        private TextBox textBoxPassword;
        private Label label2;
        private Button buttonLogIn;
    }
}
