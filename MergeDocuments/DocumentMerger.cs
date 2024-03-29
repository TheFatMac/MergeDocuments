﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Wordprocessing;

class DocumentMerger
{
    public DocumentMerger()
    {

    }

    public WordprocessingDocument AppendDocumentToDocument(WordprocessingDocument doc_1, WordprocessingDocument doc_2)
    {

        {
            string altChunkId = "AltChunkId1";

            MainDocumentPart mainPart = doc_1.MainDocumentPart;

            AlternativeFormatImportPart chunk = mainPart.AddAlternativeFormatImportPart(AlternativeFormatImportPartType.WordprocessingML, altChunkId);

            using (FileStream fileStream = File.Open(doc_2_path, FileMode.Open))chunk.FeedData(fileStream);
            AltChunk altChunk = new AltChunk();
            altChunk.Id = altChunkId;
            mainPart.Document
                .Body
                .InsertAfter(altChunk, mainPart.Document.Body.Elements<Paragraph>().Last());
            mainPart.Document.Save();
        }
    }

    //public WordprocessingDocument AppendDocumentToDocument(WordprocessingDocument doc_1, WordprocessingDocument doc_2)
    //{

    //    var doc_1_copy_path = Path.GetFullPath(doc_1_path) + "/Merged.docx";

    //    File.Copy(doc_1_path, doc_1_copy_path);


    //    using (WordprocessingDocument myDoc = WordprocessingDocument.Open(doc_1_copy_path, true))
    //    {
    //        string altChunkId = "AltChunkId1";

    //        MainDocumentPart mainPart = myDoc.MainDocumentPart;

    //        AlternativeFormatImportPart chunk = mainPart.AddAlternativeFormatImportPart(AlternativeFormatImportPartType.WordprocessingML, altChunkId);

    //        using (FileStream fileStream = File.Open(doc_2_path, FileMode.Open)) chunk.FeedData(fileStream);
    //        AltChunk altChunk = new AltChunk();
    //        altChunk.Id = altChunkId;
    //        mainPart.Document
    //            .Body
    //            .InsertAfter(altChunk, mainPart.Document.Body.Elements<Paragraph>().Last());
    //        mainPart.Document.Save();
    //    }
    //}
}
