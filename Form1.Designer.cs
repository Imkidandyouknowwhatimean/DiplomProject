namespace UchetStudentovDlyaObrazovatelnoyOrganizacii
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            LabelLogin = new Label();
            LabelPassword = new Label();
            AuthButton = new Button();
            TextBoxPassword = new TextBox();
            TextBoxLogin = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // LabelLogin
            // 
            LabelLogin.AutoSize = true;
            LabelLogin.BackColor = Color.Transparent;
            LabelLogin.Font = new Font("Tahoma", 9F);
            LabelLogin.Location = new Point(128, 147);
            LabelLogin.Name = "LabelLogin";
            LabelLogin.Size = new Size(41, 14);
            LabelLogin.TabIndex = 0;
            LabelLogin.Text = "Логин";
            // 
            // LabelPassword
            // 
            LabelPassword.AutoSize = true;
            LabelPassword.BackColor = Color.Transparent;
            LabelPassword.Font = new Font("Tahoma", 9F);
            LabelPassword.Location = new Point(128, 200);
            LabelPassword.Name = "LabelPassword";
            LabelPassword.Size = new Size(48, 14);
            LabelPassword.TabIndex = 1;
            LabelPassword.Text = "Пароль";
            // 
            // AuthButton
            // 
            AuthButton.BackColor = Color.Transparent;
            AuthButton.BackgroundImage = Properties.Resources.ButtonsImage;
            AuthButton.BackgroundImageLayout = ImageLayout.Stretch;
            AuthButton.Font = new Font("Tahoma", 9F);
            AuthButton.Location = new Point(142, 360);
            AuthButton.Name = "AuthButton";
            AuthButton.Size = new Size(171, 52);
            AuthButton.TabIndex = 2;
            AuthButton.Text = "Авторизоваться";
            AuthButton.UseVisualStyleBackColor = false;
            AuthButton.Click += AuthButton_Click;
            // 
            // TextBoxPassword
            // 
            TextBoxPassword.Location = new Point(128, 218);
            TextBoxPassword.Name = "TextBoxPassword";
            TextBoxPassword.Size = new Size(208, 23);
            TextBoxPassword.TabIndex = 3;
            // 
            // TextBoxLogin
            // 
            TextBoxLogin.Location = new Point(128, 165);
            TextBoxLogin.Name = "TextBoxLogin";
            TextBoxLogin.Size = new Size(208, 23);
            TextBoxLogin.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Tahoma", 24F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.Location = new Point(128, 29);
            label1.Name = "label1";
            label1.Size = new Size(206, 39);
            label1.TabIndex = 5;
            label1.Text = "Авторизация";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackgroundImage = Properties.Resources.AuthorizationBackground;
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(454, 450);
            Controls.Add(label1);
            Controls.Add(TextBoxLogin);
            Controls.Add(TextBoxPassword);
            Controls.Add(AuthButton);
            Controls.Add(LabelPassword);
            Controls.Add(LabelLogin);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Авторизация";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LabelLogin;
        private Label LabelPassword;
        private Button AuthButton;
        private TextBox TextBoxPassword;
        private TextBox TextBoxLogin;
        private Label label1;
    }
}
