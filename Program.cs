using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace File_Merge
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmMain());
        }


        public static void AppendFiles(string input_files, string output_file)
        {
            //Gets the file names from the text box
            StringReader sr = new StringReader(input_files);
            //resulting file from all appended files
            TextWriter tw = new StreamWriter(output_file, true);

            string s;
            while ((s = sr.ReadLine()) != null)
            {
                StreamReader tr = new StreamReader(s);

                while (!tr.EndOfStream)
                {
                    tw.WriteLine(tr.ReadLine());
                }
                tr.Close();
            }
            tw.Close();
        }//end AppendFiles - No Options

        public static void AppendFiles(string input_files, string output_file, bool removeNonPrint, bool replaceFS, string c)
        {
            //Gets the file names from the text box
            StringReader sr = new StringReader(input_files);
            //resulting file from all appended files
            TextWriter tw = new StreamWriter(output_file, true);

            //if The Replace Field Separator box is checked, then this
            if (replaceFS)
            {
                string s,
                    line;
                while ((s = sr.ReadLine()) != null)
                {
                    StreamReader tr = new StreamReader(s);
                    
                    while (!tr.EndOfStream)
                    {
                        //begin by replacing the field separator
                        line = Regex.Replace(tr.ReadLine(), @"[\u001C]", c);
                        //expression to remove all non-printable characters
                        tw.WriteLine(Regex.Replace(line, @"[^\u0020-\u007E]", ""));
                    }
                    tr.Close();
                }
                tw.Close();
            }
            //if the Replace field separator box is not checked, then remove all Non Printable chars
            else
            {
                string s,
                    line;
                while ((s = sr.ReadLine()) != null)
                {
                    StreamReader tr = new StreamReader(s);

                    while (!tr.EndOfStream)
                    {
                        line = tr.ReadLine();
                        //expression to remove all non-printable characters
                        tw.WriteLine(Regex.Replace(line, @"[^\u0020-\u007E]", ""));
                    }
                    tr.Close();
                }
                tw.Close();
            }
        }//end AppendFiles with option to remove Unicode Characters


        public static string CountFileRecords(string input_files)
        {
            StringReader sr = new StringReader(input_files);
            string s;
            string counts = "File Counts: \r\n";
            string file_name;
            while ((s = sr.ReadLine()) != null)
            {
                StreamReader tr = new StreamReader(s);
                ulong n = 0;
                string line;
                while ((line = tr.ReadLine()) != null)
                {
                    n++;
                }
                tr.Close();
                file_name = Path.GetFileName(s);
                counts += "File: " + file_name + " has " + n + " records \r\n";
            }//end while loop that reads in file name

            return counts;
        }
    }//end class
}//end namespace
