using System;
using System.Data;
using System.Windows.Forms;

namespace To_Do_List
{
    public partial class ToDoList : Form
    {
        public ToDoList()
        {
            InitializeComponent();
        }

        DataTable todoList = new DataTable();
        bool isEditing = false;

        private void Form1_Load(object sender, EventArgs e)
        {
            //create column
            todoList.Columns.Add("Title");
            todoList.Columns.Add("Description");

            //Point our datagridview to our datasource.
            toDoListView.DataSource = todoList;
        }

        private void NewButton_Click(object sender, EventArgs e)
        {
            TitleTextBox.Text = string.Empty;
            DescriptionTextBox.Text = string.Empty;
        }

        private void EditeButton_Click(object sender, EventArgs e)
        {
            if (toDoListView.CurrentCell != null)
            {
                isEditing = true;

                // Fill text fields with data from table
                TitleTextBox.Text = todoList.Rows[toDoListView.CurrentCell.RowIndex]["Title"].ToString();
                DescriptionTextBox.Text = todoList.Rows[toDoListView.CurrentCell.RowIndex]["Description"].ToString();
            }
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (toDoListView.CurrentCell != null)
            {
                try
                {
                    todoList.Rows[toDoListView.CurrentCell.RowIndex].Delete();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("ERROR:" + ex);
                }
            }
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (isEditing && toDoListView.CurrentCell != null)
            {
                todoList.Rows[toDoListView.CurrentCell.RowIndex]["Title"] = TitleTextBox.Text;
                todoList.Rows[toDoListView.CurrentCell.RowIndex]["Description"] = DescriptionTextBox.Text;
            }
            else
            {
                todoList.Rows.Add(TitleTextBox.Text, DescriptionTextBox.Text);
            }

            // Clear Fields
            TitleTextBox.Text = string.Empty;
            DescriptionTextBox.Text = string.Empty;
            isEditing = false;
        }
    }
}
