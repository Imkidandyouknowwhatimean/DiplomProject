namespace UchetStudentovDlyaObrazovatelnoyOrganizacii
{
    partial class ManageSpecialty
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageSpecialty));
            label4 = new Label();
            label3 = new Label();
            DeleteSpecialtyTextBox = new TextBox();
            DeleteSpecialtyButton = new Button();
            EditSpecialtyTextBox = new TextBox();
            EditSpecialtyButton = new Button();
            AddSpecialtyButton = new Button();
            dataGridView1 = new DataGridView();
            RefreshButton = new Button();
            label2 = new Label();
            panel1 = new Panel();
            label5 = new Label();
            SortDownButton = new Button();
            SortUpButton = new Button();
            searchButton = new Button();
            searchTextBox = new TextBox();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Tahoma", 8.25F);
            label4.Location = new Point(833, 151);
            label4.Name = "label4";
            label4.Size = new Size(15, 13);
            label4.TabIndex = 38;
            label4.Text = "id";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Tahoma", 8.25F);
            label3.Location = new Point(833, 99);
            label3.Name = "label3";
            label3.Size = new Size(15, 13);
            label3.TabIndex = 37;
            label3.Text = "id";
            // 
            // DeleteSpecialtyTextBox
            // 
            DeleteSpecialtyTextBox.Location = new Point(849, 148);
            DeleteSpecialtyTextBox.Name = "DeleteSpecialtyTextBox";
            DeleteSpecialtyTextBox.Size = new Size(39, 23);
            DeleteSpecialtyTextBox.TabIndex = 36;
            // 
            // DeleteSpecialtyButton
            // 
            DeleteSpecialtyButton.BackColor = Color.Transparent;
            DeleteSpecialtyButton.BackgroundImage = Properties.Resources.ButtonsImage;
            DeleteSpecialtyButton.BackgroundImageLayout = ImageLayout.Stretch;
            DeleteSpecialtyButton.Font = new Font("Tahoma", 8.25F);
            DeleteSpecialtyButton.Location = new Point(726, 135);
            DeleteSpecialtyButton.Name = "DeleteSpecialtyButton";
            DeleteSpecialtyButton.Size = new Size(106, 46);
            DeleteSpecialtyButton.TabIndex = 35;
            DeleteSpecialtyButton.Text = "Удалить специальность";
            DeleteSpecialtyButton.UseVisualStyleBackColor = false;
            DeleteSpecialtyButton.Click += DeleteSpecialtyButton_Click;
            // 
            // EditSpecialtyTextBox
            // 
            EditSpecialtyTextBox.Location = new Point(849, 96);
            EditSpecialtyTextBox.Name = "EditSpecialtyTextBox";
            EditSpecialtyTextBox.Size = new Size(39, 23);
            EditSpecialtyTextBox.TabIndex = 34;
            // 
            // EditSpecialtyButton
            // 
            EditSpecialtyButton.BackColor = Color.Transparent;
            EditSpecialtyButton.BackgroundImage = Properties.Resources.ButtonsImage;
            EditSpecialtyButton.BackgroundImageLayout = ImageLayout.Stretch;
            EditSpecialtyButton.Font = new Font("Tahoma", 8.25F);
            EditSpecialtyButton.Location = new Point(726, 83);
            EditSpecialtyButton.Name = "EditSpecialtyButton";
            EditSpecialtyButton.Size = new Size(106, 46);
            EditSpecialtyButton.TabIndex = 32;
            EditSpecialtyButton.Text = "Редактировать специальность";
            EditSpecialtyButton.UseVisualStyleBackColor = false;
            EditSpecialtyButton.Click += EditSpecialtyButton_Click;
            // 
            // AddSpecialtyButton
            // 
            AddSpecialtyButton.BackColor = Color.Transparent;
            AddSpecialtyButton.BackgroundImage = Properties.Resources.ButtonsImage;
            AddSpecialtyButton.BackgroundImageLayout = ImageLayout.Stretch;
            AddSpecialtyButton.Font = new Font("Tahoma", 8.25F);
            AddSpecialtyButton.Location = new Point(726, 31);
            AddSpecialtyButton.Name = "AddSpecialtyButton";
            AddSpecialtyButton.Size = new Size(162, 46);
            AddSpecialtyButton.TabIndex = 31;
            AddSpecialtyButton.Text = "Добавить специальность";
            AddSpecialtyButton.UseVisualStyleBackColor = false;
            AddSpecialtyButton.Click += AddSpecialtyButton_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 31);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(708, 426);
            dataGridView1.TabIndex = 27;
            // 
            // RefreshButton
            // 
            RefreshButton.BackColor = Color.Transparent;
            RefreshButton.BackgroundImage = Properties.Resources.ButtonsImage;
            RefreshButton.BackgroundImageLayout = ImageLayout.Stretch;
            RefreshButton.Font = new Font("Tahoma", 8.25F);
            RefreshButton.Location = new Point(726, 319);
            RefreshButton.Name = "RefreshButton";
            RefreshButton.Size = new Size(162, 46);
            RefreshButton.TabIndex = 33;
            RefreshButton.Text = "Обновить";
            RefreshButton.UseVisualStyleBackColor = false;
            RefreshButton.Click += RefreshButton_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Tahoma", 18F);
            label2.Location = new Point(12, -1);
            label2.Name = "label2";
            label2.Size = new Size(350, 29);
            label2.TabIndex = 39;
            label2.Text = "Управление специальностями";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.GradientActiveCaption;
            panel1.BackgroundImage = Properties.Resources.PanelsImage;
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Controls.Add(label5);
            panel1.Controls.Add(SortDownButton);
            panel1.Controls.Add(SortUpButton);
            panel1.Location = new Point(730, 187);
            panel1.Name = "panel1";
            panel1.Size = new Size(158, 126);
            panel1.TabIndex = 40;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Tahoma", 18F);
            label5.Location = new Point(6, 15);
            label5.Name = "label5";
            label5.Size = new Size(142, 29);
            label5.TabIndex = 15;
            label5.Text = "Сортировка";
            // 
            // SortDownButton
            // 
            SortDownButton.BackColor = Color.Transparent;
            SortDownButton.BackgroundImage = Properties.Resources.ButtonsImage;
            SortDownButton.BackgroundImageLayout = ImageLayout.Stretch;
            SortDownButton.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            SortDownButton.Location = new Point(86, 50);
            SortDownButton.Name = "SortDownButton";
            SortDownButton.Size = new Size(49, 44);
            SortDownButton.TabIndex = 14;
            SortDownButton.Text = "▼";
            SortDownButton.UseVisualStyleBackColor = false;
            SortDownButton.Click += SortDownButton_Click;
            // 
            // SortUpButton
            // 
            SortUpButton.BackColor = Color.Transparent;
            SortUpButton.BackgroundImage = Properties.Resources.ButtonsImage;
            SortUpButton.BackgroundImageLayout = ImageLayout.Stretch;
            SortUpButton.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            SortUpButton.Location = new Point(14, 50);
            SortUpButton.Name = "SortUpButton";
            SortUpButton.Size = new Size(49, 44);
            SortUpButton.TabIndex = 13;
            SortUpButton.Text = "▲";
            SortUpButton.UseVisualStyleBackColor = false;
            SortUpButton.Click += SortUpButton_Click;
            // 
            // searchButton
            // 
            searchButton.BackColor = Color.Transparent;
            searchButton.BackgroundImage = Properties.Resources.ButtonsImage;
            searchButton.BackgroundImageLayout = ImageLayout.Stretch;
            searchButton.Font = new Font("Tahoma", 9F);
            searchButton.Location = new Point(221, 464);
            searchButton.Name = "searchButton";
            searchButton.Size = new Size(82, 46);
            searchButton.TabIndex = 60;
            searchButton.Text = "Поиск";
            searchButton.UseVisualStyleBackColor = false;
            searchButton.Click += searchButton_Click;
            // 
            // searchTextBox
            // 
            searchTextBox.Location = new Point(12, 477);
            searchTextBox.Name = "searchTextBox";
            searchTextBox.Size = new Size(203, 23);
            searchTextBox.TabIndex = 59;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Tahoma", 9F);
            label6.Location = new Point(12, 460);
            label6.Name = "label6";
            label6.Size = new Size(130, 14);
            label6.TabIndex = 58;
            label6.Text = "Найти специальность";
            // 
            // ManageSpecialty
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Background;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(895, 553);
            Controls.Add(searchButton);
            Controls.Add(searchTextBox);
            Controls.Add(label6);
            Controls.Add(panel1);
            Controls.Add(label2);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(DeleteSpecialtyTextBox);
            Controls.Add(DeleteSpecialtyButton);
            Controls.Add(EditSpecialtyTextBox);
            Controls.Add(EditSpecialtyButton);
            Controls.Add(AddSpecialtyButton);
            Controls.Add(dataGridView1);
            Controls.Add(RefreshButton);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "ManageSpecialty";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Управление специальностями";
            FormClosing += ManageSpecialty_FormClosing;
            Load += ManageSpecialty_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label4;
        private Label label3;
        private TextBox DeleteSpecialtyTextBox;
        private Button DeleteSpecialtyButton;
        private TextBox EditSpecialtyTextBox;
        private Button EditSpecialtyButton;
        private Button AddSpecialtyButton;
        private DataGridView dataGridView1;
        private Button RefreshButton;
        private Label label2;
        private Panel panel1;
        private Label label5;
        private Button SortDownButton;
        private Button SortUpButton;
        private Button searchButton;
        private TextBox searchTextBox;
        private Label label6;
    }
}