namespace UchetStudentovDlyaObrazovatelnoyOrganizacii
{
    partial class EditTutor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditTutor));
            ClearButton = new Button();
            AddStudentButton = new Button();
            EmailTextBox = new TextBox();
            PhoneTextBox = new TextBox();
            PatronymicTextBox = new TextBox();
            SurnameTextBox = new TextBox();
            NameTextBox = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // ClearButton
            // 
            ClearButton.BackColor = Color.Transparent;
            ClearButton.BackgroundImage = Properties.Resources.EditButtonsImage;
            ClearButton.BackgroundImageLayout = ImageLayout.Center;
            ClearButton.Font = new Font("Tahoma", 9F);
            ClearButton.Location = new Point(201, 257);
            ClearButton.Name = "ClearButton";
            ClearButton.Size = new Size(117, 49);
            ClearButton.TabIndex = 39;
            ClearButton.Text = "Очистить поля";
            ClearButton.UseVisualStyleBackColor = false;
            ClearButton.Click += ClearButton_Click;
            // 
            // AddStudentButton
            // 
            AddStudentButton.BackColor = Color.Transparent;
            AddStudentButton.BackgroundImage = Properties.Resources.EditButtonsImage;
            AddStudentButton.BackgroundImageLayout = ImageLayout.Center;
            AddStudentButton.Font = new Font("Tahoma", 9F);
            AddStudentButton.Location = new Point(324, 257);
            AddStudentButton.Name = "AddStudentButton";
            AddStudentButton.Size = new Size(165, 49);
            AddStudentButton.TabIndex = 38;
            AddStudentButton.Text = "Отредактировать руководителя";
            AddStudentButton.UseVisualStyleBackColor = false;
            AddStudentButton.Click += AddTutorButton_Click;
            // 
            // EmailTextBox
            // 
            EmailTextBox.Location = new Point(160, 147);
            EmailTextBox.Name = "EmailTextBox";
            EmailTextBox.Size = new Size(132, 23);
            EmailTextBox.TabIndex = 37;
            // 
            // PhoneTextBox
            // 
            PhoneTextBox.Location = new Point(12, 147);
            PhoneTextBox.Name = "PhoneTextBox";
            PhoneTextBox.Size = new Size(132, 23);
            PhoneTextBox.TabIndex = 36;
            PhoneTextBox.KeyPress += PhoneTextBox_KeyPress;
            // 
            // PatronymicTextBox
            // 
            PatronymicTextBox.Location = new Point(311, 83);
            PatronymicTextBox.Name = "PatronymicTextBox";
            PatronymicTextBox.Size = new Size(132, 23);
            PatronymicTextBox.TabIndex = 35;
            // 
            // SurnameTextBox
            // 
            SurnameTextBox.Location = new Point(162, 83);
            SurnameTextBox.Name = "SurnameTextBox";
            SurnameTextBox.Size = new Size(132, 23);
            SurnameTextBox.TabIndex = 34;
            // 
            // NameTextBox
            // 
            NameTextBox.Location = new Point(12, 83);
            NameTextBox.Name = "NameTextBox";
            NameTextBox.Size = new Size(132, 23);
            NameTextBox.TabIndex = 33;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Tahoma", 9F);
            label6.Location = new Point(159, 129);
            label6.Name = "label6";
            label6.Size = new Size(34, 14);
            label6.TabIndex = 32;
            label6.Text = "Email";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Tahoma", 9F);
            label5.Location = new Point(12, 129);
            label5.Name = "label5";
            label5.Size = new Size(105, 14);
            label5.TabIndex = 31;
            label5.Text = "Номер телефона";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Tahoma", 9F);
            label4.Location = new Point(306, 65);
            label4.Name = "label4";
            label4.Size = new Size(145, 14);
            label4.TabIndex = 30;
            label4.Text = "Отчество руководителя";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Tahoma", 9F);
            label3.Location = new Point(157, 65);
            label3.Name = "label3";
            label3.Size = new Size(143, 14);
            label3.TabIndex = 29;
            label3.Text = "Фамилия руководителя";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Tahoma", 9F);
            label2.Location = new Point(12, 65);
            label2.Name = "label2";
            label2.Size = new Size(114, 14);
            label2.TabIndex = 28;
            label2.Text = "Имя руководителя";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Tahoma", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(338, 29);
            label1.TabIndex = 27;
            label1.Text = "Редактировать руководителя";
            // 
            // EditTutor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.AuthorizationBackground1;
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(513, 328);
            Controls.Add(ClearButton);
            Controls.Add(AddStudentButton);
            Controls.Add(EmailTextBox);
            Controls.Add(PhoneTextBox);
            Controls.Add(PatronymicTextBox);
            Controls.Add(SurnameTextBox);
            Controls.Add(NameTextBox);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "EditTutor";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Редактировать руководителя";
            FormClosing += EditTutor_FormClosing;
            Load += EditTutor_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button ClearButton;
        private Button AddStudentButton;
        private TextBox EmailTextBox;
        private TextBox PhoneTextBox;
        private TextBox PatronymicTextBox;
        private TextBox SurnameTextBox;
        private TextBox NameTextBox;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}