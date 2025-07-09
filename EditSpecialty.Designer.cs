namespace UchetStudentovDlyaObrazovatelnoyOrganizacii
{
    partial class EditSpecialty
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditSpecialty));
            ClearButton = new Button();
            AddSpecialtyButton = new Button();
            DescriptionTextBox = new TextBox();
            CodeTextBox = new TextBox();
            QualificationTextBox = new TextBox();
            NameTextBox = new TextBox();
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
            ClearButton.Font = new Font("Tahoma", 9F);
            ClearButton.Location = new Point(201, 257);
            ClearButton.Name = "ClearButton";
            ClearButton.Size = new Size(117, 49);
            ClearButton.TabIndex = 74;
            ClearButton.Text = "Очистить поля";
            ClearButton.UseVisualStyleBackColor = false;
            ClearButton.Click += ClearButton_Click;
            // 
            // AddSpecialtyButton
            // 
            AddSpecialtyButton.BackColor = Color.Transparent;
            AddSpecialtyButton.BackgroundImage = Properties.Resources.EditButtonsImage;
            AddSpecialtyButton.Font = new Font("Tahoma", 9F);
            AddSpecialtyButton.Location = new Point(324, 257);
            AddSpecialtyButton.Name = "AddSpecialtyButton";
            AddSpecialtyButton.Size = new Size(165, 49);
            AddSpecialtyButton.TabIndex = 73;
            AddSpecialtyButton.Text = "Отредактировать специальность";
            AddSpecialtyButton.UseVisualStyleBackColor = false;
            AddSpecialtyButton.Click += AddSpecialtyButton_Click;
            // 
            // DescriptionTextBox
            // 
            DescriptionTextBox.Location = new Point(12, 147);
            DescriptionTextBox.Name = "DescriptionTextBox";
            DescriptionTextBox.Size = new Size(431, 23);
            DescriptionTextBox.TabIndex = 72;
            // 
            // CodeTextBox
            // 
            CodeTextBox.Location = new Point(311, 83);
            CodeTextBox.Name = "CodeTextBox";
            CodeTextBox.Size = new Size(132, 23);
            CodeTextBox.TabIndex = 71;
            CodeTextBox.KeyPress += EditCodeTextBox_KeyPress;
            // 
            // QualificationTextBox
            // 
            QualificationTextBox.Location = new Point(162, 83);
            QualificationTextBox.Name = "QualificationTextBox";
            QualificationTextBox.Size = new Size(132, 23);
            QualificationTextBox.TabIndex = 70;
            // 
            // NameTextBox
            // 
            NameTextBox.Location = new Point(12, 83);
            NameTextBox.Name = "NameTextBox";
            NameTextBox.Size = new Size(132, 23);
            NameTextBox.TabIndex = 69;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Tahoma", 9F);
            label5.Location = new Point(12, 129);
            label5.Name = "label5";
            label5.Size = new Size(63, 14);
            label5.TabIndex = 68;
            label5.Text = "Описание";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Tahoma", 9F);
            label4.Location = new Point(311, 65);
            label4.Name = "label4";
            label4.Size = new Size(118, 14);
            label4.TabIndex = 67;
            label4.Text = "Код специальности";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Tahoma", 9F);
            label3.Location = new Point(162, 65);
            label3.Name = "label3";
            label3.Size = new Size(90, 14);
            label3.TabIndex = 66;
            label3.Text = "Квалификация";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Tahoma", 9F);
            label2.Location = new Point(12, 65);
            label2.Name = "label2";
            label2.Size = new Size(120, 14);
            label2.TabIndex = 65;
            label2.Text = "Имя специальности";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Tahoma", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(350, 29);
            label1.TabIndex = 64;
            label1.Text = "Редактировать специальность";
            // 
            // EditSpecialty
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.AuthorizationBackground;
            ClientSize = new Size(502, 320);
            Controls.Add(ClearButton);
            Controls.Add(AddSpecialtyButton);
            Controls.Add(DescriptionTextBox);
            Controls.Add(CodeTextBox);
            Controls.Add(QualificationTextBox);
            Controls.Add(NameTextBox);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "EditSpecialty";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Редактировать специальность";
            FormClosing += EditSpecialty_FormClosing;
            Load += EditSpecialty_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button ClearButton;
        private Button AddSpecialtyButton;
        private TextBox DescriptionTextBox;
        private TextBox CodeTextBox;
        private TextBox QualificationTextBox;
        private TextBox NameTextBox;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}