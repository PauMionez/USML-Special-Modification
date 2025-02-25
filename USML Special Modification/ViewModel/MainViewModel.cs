using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using DevExpress.Mvvm;
using USML_Special_Modification.Processes;

namespace USML_Special_Modification.ViewModel
{
    internal class MainViewModel : Abstracts.ViewModelBase
    {
        public AsyncCommand SelectedXMLCommand { get; private set; }

        public MainViewModel()
        {
            SelectedXMLCommand = new AsyncCommand(SelectedXML);
        }

        private string _fileNamemyVar;

        public string FileName
        {
            get { return _fileNamemyVar; }
            set { _fileNamemyVar = value; OnPropertyChanged(); }
        }

        private string _xmlTextContent;

        public string XmlTextContent
        {
            get { return _xmlTextContent; }
            set { _xmlTextContent = value; OnPropertyChanged(); }
        }


        private async Task SelectedXML()
        {

            try
            {
                //string xmlFilePaths = GetFilePath(@"Select docx files (*.xml)", "*.xml", "Open multiple Xml documents");
                //if (xmlFilePaths == null) return;


                string selectedPath = GetFolderPath("Select Downsized Image Folder");
                if (string.IsNullOrWhiteSpace(selectedPath)) { return; }
                
                List<string> xmlFilePathsList = Directory.GetFiles(selectedPath, "*.*", SearchOption.TopDirectoryOnly).ToList();
                if (xmlFilePathsList == null || xmlFilePathsList.Count == 0) return;
                
               
                FileName = Path.GetFileName(selectedPath);

                foreach (string xmlFilePath in xmlFilePathsList)
                {

                    // Load xml file in textviewer
                    using (FileStream fs = new FileStream(xmlFilePath, FileMode.Open, FileAccess.ReadWrite, FileShare.ReadWrite))
                    {
                        using (StreamReader reader = new StreamReader(fs))
                        {
                            XmlTextContent = reader.ReadToEnd();
                        }
                    }

                    ISpecialAutoTagging autoTag = new XmlModifierTags();
                    string updatedDocumentText = await autoTag.AutoTaggingScan(XmlTextContent);

                    //Create Updated folder inside the current file's directory
                    string inputDirectory = Path.GetDirectoryName(xmlFilePath);
                    string outputFolder = Path.Combine(inputDirectory, "Updated");

                    if (!Directory.Exists(outputFolder))
                    {
                        Directory.CreateDirectory(outputFolder);
                    }

                    string outputFilePath = Path.Combine(outputFolder, $"{Path.GetFileNameWithoutExtension(xmlFilePath)}_updated.xml" );

                    // Save the modified XML
                    File.WriteAllText(outputFilePath, updatedDocumentText);
                }


                InformationMessage("Special Modification", "Update Completed");
            }
            catch (Exception ex)
            {
                ErrorMessage(ex);
            }

        }


    }
}
