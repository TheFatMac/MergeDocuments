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

    public static void AppendDocumentToDocument(string doc_1_path, string doc_2_path, string new_doc_name)
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

    public static void ReassembleAllDocumentsInDirectory(string a_directory, string new_doc_name)
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

    public static bool DocNameIsValid(string doc_name)
    {
      try
      {
        string test_path_with_file_name_and_extension = Path.Combine(System.IO.Path.GetTempPath(), doc_name + ".txt");

        StringBuilder string_builder = new StringBuilder();

        string_builder.AppendLine("Please DELETE me as I have no use or value to anyone and I am just taking up disk space.");
        string_builder.AppendLine("This is a test file used to validate a file name provided by a user.");

        File.WriteAllText(test_path_with_file_name_and_extension, string_builder.ToString());

        if (!File.Exists(test_path_with_file_name_and_extension))
          return false;
        else
        {
          File.Delete(test_path_with_file_name_and_extension);
          return true;
        }
      }
      catch (Exception e)
      {
        Console.WriteLine("{0} Exception caught.", e);
        return false;
      }
    }

    public static bool FileNameIsValid(string directory, string file_name)
    {
      bool valid_file_name;
      try
      {
        string new_doc_with_full_path = Path.Combine(directory, file_name);

        if (file_name == Path.GetFileNameWithoutExtension(new_doc_with_full_path))
        {
          if (Path.IsPathRooted(new_doc_with_full_path)); 
          // Testing for invalid file name characters.     
          // Expression is not missing.
        }
        else
          valid_file_name = false;

        valid_file_name = true;
      }
      catch (Exception e)
      {
        Console.WriteLine("{0} Exception caught.", e);
        valid_file_name = false;
      }
      return valid_file_name;
    }
  }
}