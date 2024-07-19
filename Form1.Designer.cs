namespace To_Do_List
{
    partial class ToDoList
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
            toDoListButtom = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            DescriptionTextBox = new Label();
            TitleTextBox = new Label();         
            NewButton = new Button();
            EditeButton = new Button();
            DeleteButton = new Button();
            SaveButton = new Button();
            toDoListView = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)toDoListView).BeginInit();
            SuspendLayout();
            // 
            // toDoListButtom
            // 
            toDoListButtom.Font = new Font("Segoe UI Historic", 36F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            toDoListButtom.Location = new Point(-1, 9);
            toDoListButtom.Name = "toDoListButtom";
            toDoListButtom.Size = new Size(1200, 69);
            toDoListButtom.TabIndex = 0;
            toDoListButtom.Text = "To Do List ";
            toDoListButtom.TextAlign = ContentAlignment.TopCenter;
       //    // toDoListButtom.Click += toDoListButtom_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 127);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(1133, 27);
            textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(12, 189);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(1133, 27);
            textBox2.TabIndex = 2;
        //    textBox2.TextChanged += textBox2_TextChanged;
            // 
            // DescriptionTextBox
            // 
            DescriptionTextBox.Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            DescriptionTextBox.Location = new Point(12, 157);
            DescriptionTextBox.Name = "DescriptionTextBox";
            DescriptionTextBox.Size = new Size(1127, 29);
            DescriptionTextBox.TabIndex = 3;
            DescriptionTextBox.Text = "Description:";
            
            // 
            // TitleTextBox
            // 
            TitleTextBox.Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TitleTextBox.Location = new Point(13, 96);
            TitleTextBox.Name = "TitleTextBox";
            TitleTextBox.Size = new Size(1127, 28);
            TitleTextBox.TabIndex = 4;
            TitleTextBox.Text = "Title:";
            
            // 
            // NewButton
            // 
            NewButton.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            NewButton.Location = new Point(13, 231);
            NewButton.Name = "NewButton";
            NewButton.Size = new Size(203, 47);
            NewButton.TabIndex = 5;
            NewButton.Text = "New";
            NewButton.UseVisualStyleBackColor = true;
            NewButton.Click += NewButton_Click;
            // 
            // EditeButton
            // 
            EditeButton.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            EditeButton.Location = new Point(323, 231);
            EditeButton.Name = "EditeButton";
            EditeButton.Size = new Size(197, 47);
            EditeButton.TabIndex = 6;
            EditeButton.Text = "Edite";
            EditeButton.UseVisualStyleBackColor = true;
            EditeButton.Click += EditeButton_Click;
            // 
            // DeleteButton
            // 
            DeleteButton.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            DeleteButton.Location = new Point(647, 231);
            DeleteButton.Name = "DeleteButton";
            DeleteButton.Size = new Size(197, 47);
            DeleteButton.TabIndex = 7;
            DeleteButton.Text = "Delete";
            DeleteButton.UseVisualStyleBackColor = true;
            DeleteButton.Click += DeleteButton_Click;
            // 
            // SaveButton
            // 
            SaveButton.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            SaveButton.Location = new Point(948, 231);
            SaveButton.Name = "SaveButton";
            SaveButton.Size = new Size(197, 47);
            SaveButton.TabIndex = 8;
            SaveButton.Text = "Save";
            SaveButton.UseVisualStyleBackColor = true;
            SaveButton.Click += SaveButton_Click;
            // 
            // toDoListView
            // 
            toDoListView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            toDoListView.BackgroundColor = Color.LightGray;
            toDoListView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            toDoListView.Location = new Point(13, 299);
            toDoListView.Name = "toDoListView";
            toDoListView.RowHeadersWidth = 51;
            toDoListView.Size = new Size(1132, 244);
            toDoListView.TabIndex = 9;
            // 
            // ToDoList
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Thistle;
            ClientSize = new Size(1199, 605);
            Controls.Add(toDoListView);
            Controls.Add(SaveButton);
            Controls.Add(DeleteButton);
            Controls.Add(EditeButton);
            Controls.Add(NewButton);
            Controls.Add(TitleTextBox);
            Controls.Add(DescriptionTextBox);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(toDoListButtom);
            Name = "ToDoList";
            Text = "To Do List";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)toDoListView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label toDoListButtom;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label DescriptionTextBox;
        private Label TitleTextBox;
        private Button NewButton;
        private Button EditeButton;
        private Button DeleteButton;
        private Button SaveButton;
        private DataGridView toDoListView;
    }
}
