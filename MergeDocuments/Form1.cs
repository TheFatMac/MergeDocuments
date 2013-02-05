using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
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
      string directory_provided = folder_to_merge_textBox.Text;
      string new_doc_name = new_document_name_textBox.Text;

      if (String.IsNullOrEmpty(directory_provided) == true)
      {
        string message = "Please choose a directory and try again.";
        string caption = "More Information Needed";
        MessageBox.Show(message, caption, MessageBoxButtons.OK);
      }
      else if (String.IsNullOrEmpty(new_doc_name) == true)
      {
        string message = "Please provide a good name for the new merged document and try again.";
        string caption = "More Information Needed";
        MessageBox.Show(message, caption, MessageBoxButtons.OK);
      }
      else
      {
        string new_doc_with_full_path = directory_provided + Path.DirectorySeparatorChar + new_doc_name;

        if (IsPathValidRootedLocal(new_doc_with_full_path))
        {
          DocumentBuilderHelper doc_builder = new DocumentBuilderHelper();
          doc_builder.ReassembleAllDocumentsInDirectory(directory_provided, new_doc_with_full_path);
        }
        else
        {
          string message = "Please provide a name for the new merged document without special characters and try again.";
          string caption = "Bad Document Name";
          MessageBox.Show(message, caption, MessageBoxButtons.OK);
        }
      }
    }

    public bool IsPathValidRootedLocal(String pathString)
    {
      Uri pathUri;
      return Uri.TryCreate(pathString, UriKind.Absolute, out pathUri)
          && pathUri.IsLoopback;
    }
  }
}
