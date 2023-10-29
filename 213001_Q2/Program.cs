using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Collections;

namespace ListArrayListDemo
{
    public partial class Form1 : Form
    {
        private List<string> itemList = new List<string>();
        private ArrayList arrayList = new ArrayList();

        // Define your controls
        private ListBox listBox1;
        private TextBox textBox1;
        private Button addButton;
        private Button removeButton;
        private Button clearButton;
        private Button addArrayListButton;

        public Form1()
        {
            InitializeComponent();
        }

        // Add button click event
        private void addButton_Click(object sender, EventArgs e)
        {
            string item = textBox1.Text;
            if (!string.IsNullOrEmpty(item))
            {
                itemList.Add(item);
                listBox1.Items.Add(item);
                textBox1.Clear();
            }
        }

        // Remove button click event
        private void removeButton_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                int selectedIndex = listBox1.SelectedIndex;
                itemList.RemoveAt(selectedIndex);
                listBox1.Items.RemoveAt(selectedIndex);
            }
        }

        // Clear button click event
        private void clearButton_Click(object sender, EventArgs e)
        {
            itemList.Clear();
            listBox1.Items.Clear();
        }

        // AddArrayList button click event
        private void addArrayListButton_Click(object sender, EventArgs e)
        {
            string item = textBox1.Text;
            if (!string.IsNullOrEmpty(item))
            {
                arrayList.Add(item);
                textBox1.Clear();
            }
        }

        private void InitializeComponent()
        {
            // Initialize and set up your form and controls here.
            // You can do this in the Form Designer in Visual Studio.
        }
    }
}
