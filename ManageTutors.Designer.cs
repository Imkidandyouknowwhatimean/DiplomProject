namespace UchetStudentovDlyaObrazovatelnoyOrganizacii
{
    partial class ManageTutors
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageTutors));
            dataGridView1 = new DataGridView();
            label4 = new Label();
            label3 = new Label();
            DeleteTutorTextBox = new TextBox();
            DeleteTutorButton = new Button();
            EditTutorTextBox = new TextBox();
            EditTutorButton = new Button();
            AddTutorButton = new Button();
            panel1 = new Panel();
            label1 = new Label();
            SortButtonDown = new Button();
            SortButtonUp = new Button();
            RefreshButton = new Button();
            label2 = new Label();
            searchButton = new Button();
            searchTextBox = new TextBox();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 31);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(708, 426);
            dataGridView1.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Tahoma", 8.25F);
            label4.Location = new Point(833, 151);
            label4.Name = "label4";
            label4.Size = new Size(15, 13);
            label4.TabIndex = 26;
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
            label3.TabIndex = 25;
            label3.Text = "id";
            // 
            // DeleteTutorTextBox
            // 
            DeleteTutorTextBox.Location = new Point(849, 148);
            DeleteTutorTextBox.Name = "DeleteTutorTextBox";
            DeleteTutorTextBox.Size = new Size(39, 23);
            DeleteTutorTextBox.TabIndex = 24;
            // 
            // DeleteTutorButton
            // 
            DeleteTutorButton.BackColor = Color.Transparent;
            DeleteTutorButton.BackgroundImage = Properties.Resources.ButtonsImage;
            DeleteTutorButton.BackgroundImageLayout = ImageLayout.Stretch;
            DeleteTutorButton.Font = new Font("Tahoma", 8.25F);
            DeleteTutorButton.Location = new Point(726, 135);
            DeleteTutorButton.Name = "DeleteTutorButton";
            DeleteTutorButton.Size = new Size(106, 46);
            DeleteTutorButton.TabIndex = 23;
            DeleteTutorButton.Text = "Удалить руководителя";
            DeleteTutorButton.UseVisualStyleBackColor = false;
            DeleteTutorButton.Click += DeleteTutorButton_Click;
            // 
            // EditTutorTextBox
            // 
            EditTutorTextBox.Location = new Point(849, 96);
            EditTutorTextBox.Name = "EditTutorTextBox";
            EditTutorTextBox.Size = new Size(39, 23);
            EditTutorTextBox.TabIndex = 22;
            // 
            // EditTutorButton
            // 
            EditTutorButton.BackColor = Color.Transparent;
            EditTutorButton.BackgroundImage = Properties.Resources.ButtonsImage;
            EditTutorButton.BackgroundImageLayout = ImageLayout.Stretch;
            EditTutorButton.Font = new Font("Tahoma", 8.25F);
            EditTutorButton.Location = new Point(726, 83);
            EditTutorButton.Name = "EditTutorButton";
            EditTutorButton.Size = new Size(106, 46);
            EditTutorButton.TabIndex = 21;
            EditTutorButton.Text = "Редактировать руководителя";
            EditTutorButton.UseVisualStyleBackColor = false;
            EditTutorButton.Click += EditTutorButton_Click;
            // 
            // AddTutorButton
            // 
            AddTutorButton.BackColor = Color.Transparent;
            AddTutorButton.BackgroundImage = Properties.Resources.ButtonsImage;
            AddTutorButton.BackgroundImageLayout = ImageLayout.Stretch;
            AddTutorButton.Font = new Font("Tahoma", 8.25F);
            AddTutorButton.Location = new Point(726, 31);
            AddTutorButton.Name = "AddTutorButton";
            AddTutorButton.Size = new Size(162, 46);
            AddTutorButton.TabIndex = 20;
            AddTutorButton.Text = "Добавить руководителя";
            AddTutorButton.UseVisualStyleBackColor = false;
            AddTutorButton.Click += AddTutorButton_Click;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.GradientActiveCaption;
            panel1.BackgroundImage = Properties.Resources.PanelsImage;
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(SortButtonDown);
            panel1.Controls.Add(SortButtonUp);
            panel1.Location = new Point(730, 187);
            panel1.Name = "panel1";
            panel1.Size = new Size(158, 115);
            panel1.TabIndex = 27;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Tahoma", 18F);
            label1.Location = new Point(3, 15);
            label1.Name = "label1";
            label1.Size = new Size(142, 29);
            label1.TabIndex = 15;
            label1.Text = "Сортировка";
            // 
            // SortButtonDown
            // 
            SortButtonDown.BackColor = Color.Transparent;
            SortButtonDown.BackgroundImage = Properties.Resources.ButtonsImage;
            SortButtonDown.BackgroundImageLayout = ImageLayout.Stretch;
            SortButtonDown.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            SortButtonDown.Location = new Point(86, 50);
            SortButtonDown.Name = "SortButtonDown";
            SortButtonDown.Size = new Size(49, 44);
            SortButtonDown.TabIndex = 14;
            SortButtonDown.Text = "▼";
            SortButtonDown.UseVisualStyleBackColor = false;
            SortButtonDown.Click += SortButtonDown_Click;
            // 
            // SortButtonUp
            // 
            SortButtonUp.BackColor = Color.Transparent;
            SortButtonUp.BackgroundImage = Properties.Resources.ButtonsImage;
            SortButtonUp.BackgroundImageLayout = ImageLayout.Stretch;
            SortButtonUp.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            SortButtonUp.Location = new Point(14, 50);
            SortButtonUp.Name = "SortButtonUp";
            SortButtonUp.Size = new Size(49, 44);
            SortButtonUp.TabIndex = 13;
            SortButtonUp.Text = "▲";
            SortButtonUp.UseVisualStyleBackColor = false;
            SortButtonUp.Click += SortButtonUp_Click;
            // 
            // RefreshButton
            // 
            RefreshButton.BackColor = Color.Transparent;
            RefreshButton.BackgroundImage = Properties.Resources.ButtonsImage;
            RefreshButton.BackgroundImageLayout = ImageLayout.Stretch;
            RefreshButton.Font = new Font("Tahoma", 8.25F);
            RefreshButton.Location = new Point(726, 308);
            RefreshButton.Name = "RefreshButton";
            RefreshButton.Size = new Size(162, 46);
            RefreshButton.TabIndex = 21;
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
            label2.Size = new Size(408, 29);
            label2.TabIndex = 16;
            label2.Text = "Управление руководителями групп";
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
            searchButton.TabIndex = 63;
            searchButton.Text = "Поиск";
            searchButton.UseVisualStyleBackColor = false;
            searchButton.Click += searchButton_Click;
            // 
            // searchTextBox
            // 
            searchTextBox.Location = new Point(12, 477);
            searchTextBox.Name = "searchTextBox";
            searchTextBox.Size = new Size(203, 23);
            searchTextBox.TabIndex = 62;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Tahoma", 9F);
            label6.Location = new Point(12, 460);
            label6.Name = "label6";
            label6.Size = new Size(125, 14);
            label6.TabIndex = 61;
            label6.Text = "Найти руководителя";
            // 
            // ManageTutors
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Background;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(900, 527);
            Controls.Add(searchButton);
            Controls.Add(searchTextBox);
            Controls.Add(label6);
            Controls.Add(label2);
            Controls.Add(RefreshButton);
            Controls.Add(panel1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(DeleteTutorTextBox);
            Controls.Add(DeleteTutorButton);
            Controls.Add(EditTutorTextBox);
            Controls.Add(EditTutorButton);
            Controls.Add(AddTutorButton);
            Controls.Add(dataGridView1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "ManageTutors";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Управление руководителями групп";
            FormClosing += ManageTutors_FormClosing;
            Load += ManageTutors_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Label label4;
        private Label label3;
        private TextBox DeleteTutorTextBox;
        private Button DeleteTutorButton;
        private TextBox EditTutorTextBox;
        private Button EditTutorButton;
        private Button AddTutorButton;
        private Panel panel1;
        private Label label1;
        private Button SortButtonDown;
        private Button SortButtonUp;
        private Button RefreshButton;
        private Label label2;
        private Button searchButton;
        private TextBox searchTextBox;
        private Label label6;
    }
}