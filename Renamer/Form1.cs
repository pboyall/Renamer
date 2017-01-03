using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using SpreadsheetLight;


namespace Renamer
{
    public partial class Form1 : Form
    {

        public string OriginalNameCol = "A";
        public string NewNameCol = "B";
        public int startRow = 1;
        Dictionary<string, string> namemap;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            loadLookups();
            replaceNamedFiles();
            replaceRecursedFiles();

        }

        private bool loadLookups()
        {
            SLDocument pubform = new SLDocument(txtNames.Text);
            SLWorksheetStatistics stats1 = pubform.GetWorksheetStatistics();
            namemap = new Dictionary<string, string>();
            for (int j = 0; j <= stats1.EndRowIndex; j++)
            {
                string originalname = pubform.GetCellValueAsString(OriginalNameCol + j);
                string newname = pubform.GetCellValueAsString(OriginalNameCol + j);
                namemap.Add(originalname, newname);
            }
            return true;
        }

        private bool loadFiles()
        {
            string[] htmlfiles = Directory.GetFiles(txtFolders.Text, "*.html", SearchOption.AllDirectories);
            string[] jsfiles = Directory.GetFiles(txtFolders.Text, "*.js", SearchOption.AllDirectories);
            return true;
        }

        private bool replaceNamedFiles()
        {
            //For every file in the folder, open it and resave it with its new name

            foreach (var file in namemap)
            {
                string[] namedfiles = Directory.GetFiles(txtFolders.Text, file.Key, SearchOption.AllDirectories); 
                foreach(var thefile in namedfiles) { 
                    using (var input = File.OpenText(thefile))
                    using (var output = new StreamWriter(file.Value)) 
                    //While we are here take the opportunity to replace every occurance of every renamed file in these named files
                    {
                        string line;
                        while (null != (line = input.ReadLine()))
                        {
                            foreach(var oldValue in namemap) {
                                line.Replace(oldValue.Key, oldValue.Value);
                            }
                            output.WriteLine(line);
                        }
                    }
                }
            }
            return true;
        }

        private bool replaceRecursedFiles(string[] filearray)
        {
            foreach (var thefile in filearray)
            {
                //Grab new file name
                    string newfile = "";
                    namemap.TryGetValue(thefile, out newfile);
                    using (var input = File.OpenText(thefile))
                    using (var output = new StreamWriter(newfile))
                    //While we are here take the opportunity to replace every occurance of every renamed file
                    {
                        string line;
                        while (null != (line = input.ReadLine()))
                        {
                            foreach (var oldValue in namemap)
                            {
                                line.Replace(oldValue.Key, oldValue.Value);
                            }
                            output.WriteLine(line);
                        }
                    }
                }
            return true;
        }



        private void btnNames_Click(object sender, EventArgs e)
        {
            OpenFileDialog theDialog = new OpenFileDialog();
            theDialog.Title = "Open Rename File";
            theDialog.Filter = "XLSX files|*.xlsx";
            theDialog.InitialDirectory = txtFolders.Text;
            DialogResult result = theDialog.ShowDialog();
            if (result == DialogResult.OK) // Test result.
            {
                txtNames.Text = theDialog.FileName.ToString(); 
            }
        }

        private void btnFolders_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog1 = new FolderBrowserDialog();
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                txtFolders.Text = folderBrowserDialog1.SelectedPath;
            }

        }
    }
}
