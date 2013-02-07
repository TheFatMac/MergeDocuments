using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Validation;
using System.Windows.Forms;
using OpenXmlPowerTools;

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
      merge_button.Enabled.Equals(false);
      merge_button.FlatStyle = FlatStyle.Flat;

      string directory_provided = folder_to_merge_textBox.Text;
      string new_doc_name = new_document_name_textBox.Text.Trim();

      if (String.IsNullOrEmpty(directory_provided) == true)
      {
        string message = "Please choose a directory and try again.";
        string caption = "More Information Needed";
        MessageBox.Show(message, caption, MessageBoxButtons.OK);
        select_folder_button.Focus();
      }
      else if (String.IsNullOrEmpty(new_doc_name) == true)
      {
        string message = "Please provide a good name for the new merged document and try again.";
        string caption = "More Information Needed";
        MessageBox.Show(message, caption, MessageBoxButtons.OK);
        new_document_name_textBox.Focus();
        new_document_name_textBox.SelectAll();
      }
      else if (System.Text.RegularExpressions.Regex.IsMatch(new_doc_name, @"[\*\[\]\^\\/{}=+%$#@!&<>:""|?]"))
      {
        string message = "Please provide a name for the new merged document without special characters and try again.";
        string caption = "Bad Document Name";
        MessageBox.Show(message, caption, MessageBoxButtons.OK);
        new_document_name_textBox.Focus();
        new_document_name_textBox.SelectAll();
      }
      else
      {
        string new_doc_with_full_path = Path.Combine(directory_provided, new_doc_name);

        DocumentBuilderHelper.ReassembleAllDocumentsInDirectory(directory_provided, new_doc_with_full_path);

        Properties.Settings.Default.previous_directory = directory_provided;
        Properties.Settings.Default.Save();
      }

      merge_button.FlatStyle = FlatStyle.Standard;
      merge_button.Enabled.Equals(true);
    }
  }
}
