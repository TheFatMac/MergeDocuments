using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MergeDocuments
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void select_folder_button_Click(object sender, EventArgs e)
        {
            if (docs_to_merge_folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                folder_to_merge_textBox.Text = docs_to_merge_folderBrowserDialog.SelectedPath;
            }
        }

        private void merge_button_Click(object sender, EventArgs e)
        {

        }


    }
}
