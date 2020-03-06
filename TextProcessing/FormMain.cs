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

namespace TextProcessing
{
    public partial class FormMain : Form
    {

        private static readonly char[] CharNameFile = { '\\', '/', ':', '*', '?', '\"', '<', '>', '|' };
        private static readonly string[] stringSign = { ",", ".", "!", "?", ":", ";", "-", "\"", "(", ")", "\'"};


        public FormMain()
        {
            InitializeComponent();
        }

        private void buttonInputFile_Click(object sender, EventArgs e)
        { // Select input file
            OpenFileDialog OpenInputFile = new OpenFileDialog()
            {
                Filter = "Text files (*.txt)|*.txt",
                Title = "Open text file",
                Multiselect = true
            };

            if (OpenInputFile.ShowDialog() == DialogResult.OK)
            {
                foreach (var fileName in OpenInputFile.FileNames)
                { // add select file to list
                    if (listBoxInputFiles.Items.Count > 0)
                    {
                        bool Add = true;
                        for (int i = 0; i < listBoxInputFiles.Items.Count; ++i)
                        {
                            if (fileName.Equals(listBoxInputFiles.Items[i].ToString()))
                            { // do not add file because it is already in the list
                                Add = false;
                                break;
                            }
                        }

                        if (Add == true)
                        {
                            listBoxInputFiles.Items.Add(fileName);
                        }
                    }
                    else
                    {
                        listBoxInputFiles.Items.Add(fileName);
                    }
                }

                string directoryPath = Path.GetDirectoryName(OpenInputFile.FileName);
                if (OutputFilePath.Text.Length == 0)
                {
                    OutputFilePath.Text = directoryPath;
                }
                if (OutputFileName.Text.Length == 0)
                {
                    OutputFileName.Text = " - copy";
                }
            }

        }

        private void buttonOutputFile_Click(object sender, EventArgs e)
        { // Select output folder
            FolderBrowserDialog OpenOutputFolder = new FolderBrowserDialog();
            if (OpenOutputFolder.ShowDialog() == DialogResult.OK)
            {
                OutputFilePath.Text = OpenOutputFolder.SelectedPath;
            }
        }

        private void checkBoxDeleteWord_CheckedChanged(object sender, EventArgs e)
        {
            numDeleteWord.Enabled = checkBoxDeleteWord.Checked;
        }

        private void buttonProcessing_Click(object sender, EventArgs e)
        { // Processing text
            if (listBoxInputFiles.Items.Count == 0)
            {
                MessageBox.Show("Необходимо добавить файлы для обработки.");
                return;
            }
            if (OutputFilePath.Text.Length == 0)
            {
                MessageBox.Show("Необходимо указать директорию сохранения файла.");
                return;
            }
            if (OutputFileName.Text.IndexOfAny(CharNameFile) != -1)
            {
                MessageBox.Show("Имя файла не должно содержать знаков \\ / : * ? \" < > |");
                return;
            }

            for (int i = 0; i < listBoxInputFiles.Items.Count; ++i)
            {
                string FullFileName = listBoxInputFiles.Items[i].ToString();
                string fileName = Path.GetFileNameWithoutExtension(FullFileName);
                string OutputFullName = OutputFilePath.Text + "\\" + fileName + OutputFileName.Text + ".txt";
                string OutputFile = OutputFullName;
                bool ReplaceFile = false;
                if (File.Exists(OutputFullName))
                {
                    string message = "Файл " + OutputFullName + " существует. Заменить?";
                    string caption = "Замена или пропуск файла";
                    MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                    DialogResult result;
                    result = MessageBox.Show(message, caption, buttons);
                    if (result == System.Windows.Forms.DialogResult.No)
                    {
                        continue;
                    }
                    if (result == System.Windows.Forms.DialogResult.Yes)
                    {
                        string now = DateTime.Now.ToString("yyyy-MM-dd-HH-mm-ss-fffffff");
                        OutputFile = OutputFilePath.Text + "\\" + fileName + now + ".txt";
                        ReplaceFile = true;
                    }
                }
                using (StreamReader reader = File.OpenText(FullFileName))
                {
                    using (StreamWriter writer = File.CreateText(OutputFile))
                    {
                        string s = null;
                        while ((s = reader.ReadLine()) != null)
                        {
                            if (checkBoxDeleteWord.Checked == true)
                            {
                                s = DeleteWord(s); // delete words in line
                            }
                            if (checkBoxDeleteSign.Checked == true)
                            {
                                s = DeleteSign(stringSign, s, string.Empty); // to replace signs on empty string
                            }
                            writer.WriteLine(s);
                        }
                    }
                }
                if (ReplaceFile == true)
                { // replace file
                    File.Delete(OutputFullName);
                    File.Move(OutputFile, OutputFullName);
                }
            }

            MessageBox.Show("Обработка файлов завершена.");

        }

        private string DeleteSign(string[] signs, string str, string stringReplace)
        {
            foreach (string ch in signs)
            {
                str = str.Replace(ch, stringReplace); // to replace sign on string
            }
            return str; 
        }

        private string DeleteWord(string str)
        {
            string words = "";
            string[] strArr;
            strArr = str.Split(' '); // split line on words
            for (int i = 0; i < strArr.Length; ++i)
            {
                if (strArr[i].Length > 0)
                {
                    string addStr = strArr[i];
                    string strWithoutSing = DeleteSign(stringSign, strArr[i], " "); // to replace signs on char " "
                    string[] strWithoutSingArr = strWithoutSing.Split(' '); // split string after removed signs

                    foreach (string s in strWithoutSingArr)
                    {
                        if ((s.Length > 0) && (s.Length <= (int)numDeleteWord.Value)) // check lenght word
                        {
                            addStr = addStr.Replace(s, string.Empty); // delete word
                        }
                    }

                    words = words + addStr; // add word to line
                    if (i < strArr.Length - 1)
                    {
                        words = words + ' '; // to return split between words
                    }

                }
            }
            return words;
        }

        private void buttonDeleteFiles_Click(object sender, EventArgs e)
        {
            if (listBoxInputFiles.SelectedItems.Count > 0)
            {

                while (listBoxInputFiles.SelectedItems.Count > 0)
                {
                    listBoxInputFiles.Items.Remove(listBoxInputFiles.SelectedItem);
                }
            }
            else
            {
                MessageBox.Show("Не выбраны файлы для удаления.");
            }
        }
    }
}
