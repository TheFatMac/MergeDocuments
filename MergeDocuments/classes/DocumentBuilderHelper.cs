using System;
using System.IO;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Validation;
using OpenXmlPowerTools;

namespace MergeDocuments
{
  public class DocumentBuilderHelper
  {

    private void AppendDocumentToDocument(string doc_1_path, string doc_2_path, string new_doc_name)
    {
      try
      {
        if ((Path.GetExtension(doc_1_path) == ".docx") && (Path.GetExtension(doc_2_path) == ".docx"))
        {
          List<Source> sources = null;

          sources = new List<Source>()
                {
                    new Source(new WmlDocument(doc_1_path), true),
                    new Source(new WmlDocument(doc_2_path), false),
                };
          DocumentBuilder.BuildDocument(sources, new_doc_name + ".docx");
        }
      }
      catch (Exception e)
      {
        Console.WriteLine("{0} Exception caught.", e);
      }

    }

    public void ReassembleAllDocumentsInDirectory(string a_directory, string new_doc_name)
    {
      try
      {
        if (Directory.Exists(a_directory))
        {
          List<Source> sources = null;

          sources = new DirectoryInfo(a_directory)
              .GetFiles("*.docx")
              .Select(d => new Source(new WmlDocument(d.FullName), true))
              .ToList();
          DocumentBuilder.BuildDocument(sources, new_doc_name + ".docx");
        }
      }
      catch (Exception e)
      {
        Console.WriteLine("{0} Exception caught.", e);
      }

    }
  }
}