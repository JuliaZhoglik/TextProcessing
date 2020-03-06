namespace TextProcessing
{
    partial class FormMain
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonInputFile = new System.Windows.Forms.Button();
            this.OutputFileName = new System.Windows.Forms.TextBox();
            this.buttonOutputFile = new System.Windows.Forms.Button();
            this.labelOutputFileName = new System.Windows.Forms.Label();
            this.checkBoxDeleteSign = new System.Windows.Forms.CheckBox();
            this.checkBoxDeleteWord = new System.Windows.Forms.CheckBox();
            this.numDeleteWord = new System.Windows.Forms.NumericUpDown();
            this.labelDeleteWord = new System.Windows.Forms.Label();
            this.buttonProcessing = new System.Windows.Forms.Button();
            this.listBoxInputFiles = new System.Windows.Forms.ListBox();
            this.labelInputFiles = new System.Windows.Forms.Label();
            this.buttonDeleteFiles = new System.Windows.Forms.Button();
            this.OutputFilePath = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numDeleteWord)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonInputFile
            // 
            this.buttonInputFile.Location = new System.Drawing.Point(15, 151);
            this.buttonInputFile.Name = "buttonInputFile";
            this.buttonInputFile.Size = new System.Drawing.Size(187, 23);
            this.buttonInputFile.TabIndex = 0;
            this.buttonInputFile.Text = "Добавить файлы";
            this.buttonInputFile.UseVisualStyleBackColor = true;
            this.buttonInputFile.Click += new System.EventHandler(this.buttonInputFile_Click);
            // 
            // OutputFileName
            // 
            this.OutputFileName.Location = new System.Drawing.Point(15, 283);
            this.OutputFileName.Name = "OutputFileName";
            this.OutputFileName.Size = new System.Drawing.Size(406, 20);
            this.OutputFileName.TabIndex = 2;
            this.OutputFileName.Text = "- copy";
            // 
            // buttonOutputFile
            // 
            this.buttonOutputFile.Location = new System.Drawing.Point(15, 235);
            this.buttonOutputFile.Name = "buttonOutputFile";
            this.buttonOutputFile.Size = new System.Drawing.Size(187, 23);
            this.buttonOutputFile.TabIndex = 4;
            this.buttonOutputFile.Text = "Изменить путь сохранения";
            this.buttonOutputFile.UseVisualStyleBackColor = true;
            this.buttonOutputFile.Click += new System.EventHandler(this.buttonOutputFile_Click);
            // 
            // labelOutputFileName
            // 
            this.labelOutputFileName.AutoSize = true;
            this.labelOutputFileName.Location = new System.Drawing.Point(12, 267);
            this.labelOutputFileName.Name = "labelOutputFileName";
            this.labelOutputFileName.Size = new System.Drawing.Size(205, 13);
            this.labelOutputFileName.TabIndex = 6;
            this.labelOutputFileName.Text = "Дополнить имя обработанных файлов:";
            // 
            // checkBoxDeleteSign
            // 
            this.checkBoxDeleteSign.AutoSize = true;
            this.checkBoxDeleteSign.Location = new System.Drawing.Point(258, 322);
            this.checkBoxDeleteSign.Name = "checkBoxDeleteSign";
            this.checkBoxDeleteSign.Size = new System.Drawing.Size(165, 17);
            this.checkBoxDeleteSign.TabIndex = 7;
            this.checkBoxDeleteSign.Text = "Удалить знаки препинания";
            this.checkBoxDeleteSign.UseVisualStyleBackColor = true;
            // 
            // checkBoxDeleteWord
            // 
            this.checkBoxDeleteWord.AutoSize = true;
            this.checkBoxDeleteWord.Checked = true;
            this.checkBoxDeleteWord.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxDeleteWord.Location = new System.Drawing.Point(15, 321);
            this.checkBoxDeleteWord.Name = "checkBoxDeleteWord";
            this.checkBoxDeleteWord.Size = new System.Drawing.Size(103, 17);
            this.checkBoxDeleteWord.TabIndex = 8;
            this.checkBoxDeleteWord.Text = "Удаление слов";
            this.checkBoxDeleteWord.UseVisualStyleBackColor = true;
            this.checkBoxDeleteWord.CheckedChanged += new System.EventHandler(this.checkBoxDeleteWord_CheckedChanged);
            // 
            // numDeleteWord
            // 
            this.numDeleteWord.Location = new System.Drawing.Point(200, 320);
            this.numDeleteWord.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numDeleteWord.Name = "numDeleteWord";
            this.numDeleteWord.Size = new System.Drawing.Size(50, 20);
            this.numDeleteWord.TabIndex = 9;
            this.numDeleteWord.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // labelDeleteWord
            // 
            this.labelDeleteWord.AutoSize = true;
            this.labelDeleteWord.Location = new System.Drawing.Point(124, 322);
            this.labelDeleteWord.Name = "labelDeleteWord";
            this.labelDeleteWord.Size = new System.Drawing.Size(70, 13);
            this.labelDeleteWord.TabIndex = 10;
            this.labelDeleteWord.Text = "Длина слов:";
            // 
            // buttonProcessing
            // 
            this.buttonProcessing.Location = new System.Drawing.Point(127, 357);
            this.buttonProcessing.Name = "buttonProcessing";
            this.buttonProcessing.Size = new System.Drawing.Size(188, 23);
            this.buttonProcessing.TabIndex = 11;
            this.buttonProcessing.Text = "Обработка файлов";
            this.buttonProcessing.UseVisualStyleBackColor = true;
            this.buttonProcessing.Click += new System.EventHandler(this.buttonProcessing_Click);
            // 
            // listBoxInputFiles
            // 
            this.listBoxInputFiles.FormattingEnabled = true;
            this.listBoxInputFiles.HorizontalScrollbar = true;
            this.listBoxInputFiles.Location = new System.Drawing.Point(15, 25);
            this.listBoxInputFiles.Name = "listBoxInputFiles";
            this.listBoxInputFiles.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listBoxInputFiles.Size = new System.Drawing.Size(406, 121);
            this.listBoxInputFiles.TabIndex = 12;
            // 
            // labelInputFiles
            // 
            this.labelInputFiles.AutoSize = true;
            this.labelInputFiles.Location = new System.Drawing.Point(12, 9);
            this.labelInputFiles.Name = "labelInputFiles";
            this.labelInputFiles.Size = new System.Drawing.Size(165, 13);
            this.labelInputFiles.TabIndex = 13;
            this.labelInputFiles.Text = "Список файлов для обработки:";
            // 
            // buttonDeleteFiles
            // 
            this.buttonDeleteFiles.Location = new System.Drawing.Point(234, 151);
            this.buttonDeleteFiles.Name = "buttonDeleteFiles";
            this.buttonDeleteFiles.Size = new System.Drawing.Size(187, 23);
            this.buttonDeleteFiles.TabIndex = 14;
            this.buttonDeleteFiles.Text = "Удалить файлы";
            this.buttonDeleteFiles.UseVisualStyleBackColor = true;
            this.buttonDeleteFiles.Click += new System.EventHandler(this.buttonDeleteFiles_Click);
            // 
            // OutputFilePath
            // 
            this.OutputFilePath.Location = new System.Drawing.Point(15, 209);
            this.OutputFilePath.Name = "OutputFilePath";
            this.OutputFilePath.ReadOnly = true;
            this.OutputFilePath.Size = new System.Drawing.Size(406, 20);
            this.OutputFilePath.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 193);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(212, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Путь сохранения обработанных файлов:";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 389);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.OutputFilePath);
            this.Controls.Add(this.buttonDeleteFiles);
            this.Controls.Add(this.labelInputFiles);
            this.Controls.Add(this.listBoxInputFiles);
            this.Controls.Add(this.buttonProcessing);
            this.Controls.Add(this.labelDeleteWord);
            this.Controls.Add(this.numDeleteWord);
            this.Controls.Add(this.checkBoxDeleteWord);
            this.Controls.Add(this.checkBoxDeleteSign);
            this.Controls.Add(this.labelOutputFileName);
            this.Controls.Add(this.buttonOutputFile);
            this.Controls.Add(this.OutputFileName);
            this.Controls.Add(this.buttonInputFile);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Обработка текста";
            ((System.ComponentModel.ISupportInitialize)(this.numDeleteWord)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonInputFile;
        private System.Windows.Forms.TextBox OutputFileName;
        private System.Windows.Forms.Button buttonOutputFile;
        private System.Windows.Forms.Label labelOutputFileName;
        private System.Windows.Forms.CheckBox checkBoxDeleteSign;
        private System.Windows.Forms.CheckBox checkBoxDeleteWord;
        private System.Windows.Forms.NumericUpDown numDeleteWord;
        private System.Windows.Forms.Label labelDeleteWord;
        private System.Windows.Forms.Button buttonProcessing;
        private System.Windows.Forms.ListBox listBoxInputFiles;
        private System.Windows.Forms.Label labelInputFiles;
        private System.Windows.Forms.Button buttonDeleteFiles;
        private System.Windows.Forms.TextBox OutputFilePath;
        private System.Windows.Forms.Label label1;
    }
}

