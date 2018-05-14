﻿namespace IPL_IDE_Advanced_Editor
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelProgressStatus = new System.Windows.Forms.Label();
            this.editButton = new System.Windows.Forms.Button();
            this.editProgressBar = new System.Windows.Forms.ProgressBar();
            this.ZtextBox = new System.Windows.Forms.TextBox();
            this.IDoffsetTextBox = new System.Windows.Forms.TextBox();
            this.YtextBox = new System.Windows.Forms.TextBox();
            this.XtextBox = new System.Windows.Forms.TextBox();
            this.inputTextBox = new System.Windows.Forms.TextBox();
            this.pathLabel = new System.Windows.Forms.Label();
            this.inputBrowseButton = new System.Windows.Forms.Button();
            this.browseSaveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.bgWorker = new System.ComponentModel.BackgroundWorker();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelLoadedMap = new System.Windows.Forms.Label();
            this.comboBoxLoadedMap = new System.Windows.Forms.ComboBox();
            this.patchIdeCheckBox = new System.Windows.Forms.CheckBox();
            this.patchIdeLabel = new System.Windows.Forms.Label();
            this.outputBrowseButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.outputTextBox = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID Offset:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Coord Offset:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.patchIdeLabel);
            this.groupBox1.Controls.Add(this.patchIdeCheckBox);
            this.groupBox1.Controls.Add(this.labelProgressStatus);
            this.groupBox1.Controls.Add(this.editButton);
            this.groupBox1.Controls.Add(this.editProgressBar);
            this.groupBox1.Controls.Add(this.ZtextBox);
            this.groupBox1.Controls.Add(this.IDoffsetTextBox);
            this.groupBox1.Controls.Add(this.YtextBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.XtextBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 231);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(365, 220);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "IDE/IPL Edition";
            // 
            // labelProgressStatus
            // 
            this.labelProgressStatus.AutoSize = true;
            this.labelProgressStatus.Location = new System.Drawing.Point(12, 136);
            this.labelProgressStatus.Name = "labelProgressStatus";
            this.labelProgressStatus.Size = new System.Drawing.Size(81, 13);
            this.labelProgressStatus.TabIndex = 6;
            this.labelProgressStatus.Text = "Progress Status";
            this.labelProgressStatus.Visible = false;
            // 
            // editButton
            // 
            this.editButton.Location = new System.Drawing.Point(233, 188);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(126, 23);
            this.editButton.TabIndex = 3;
            this.editButton.Text = "Build New IDE/IPLs";
            this.editButton.UseVisualStyleBackColor = true;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // editProgressBar
            // 
            this.editProgressBar.Location = new System.Drawing.Point(15, 188);
            this.editProgressBar.Name = "editProgressBar";
            this.editProgressBar.Size = new System.Drawing.Size(192, 23);
            this.editProgressBar.TabIndex = 2;
            this.editProgressBar.Visible = false;
            // 
            // ZtextBox
            // 
            this.ZtextBox.Location = new System.Drawing.Point(213, 54);
            this.ZtextBox.Name = "ZtextBox";
            this.ZtextBox.Size = new System.Drawing.Size(57, 20);
            this.ZtextBox.TabIndex = 4;
            this.ZtextBox.Text = "0.0";
            // 
            // IDoffsetTextBox
            // 
            this.IDoffsetTextBox.Location = new System.Drawing.Point(70, 25);
            this.IDoffsetTextBox.Name = "IDoffsetTextBox";
            this.IDoffsetTextBox.Size = new System.Drawing.Size(101, 20);
            this.IDoffsetTextBox.TabIndex = 1;
            this.IDoffsetTextBox.Text = "1000";
            // 
            // YtextBox
            // 
            this.YtextBox.Location = new System.Drawing.Point(150, 54);
            this.YtextBox.Name = "YtextBox";
            this.YtextBox.Size = new System.Drawing.Size(57, 20);
            this.YtextBox.TabIndex = 3;
            this.YtextBox.Text = "0.0";
            // 
            // XtextBox
            // 
            this.XtextBox.Location = new System.Drawing.Point(87, 54);
            this.XtextBox.Name = "XtextBox";
            this.XtextBox.Size = new System.Drawing.Size(57, 20);
            this.XtextBox.TabIndex = 2;
            this.XtextBox.Text = "0.0";
            // 
            // inputTextBox
            // 
            this.inputTextBox.Location = new System.Drawing.Point(99, 163);
            this.inputTextBox.Name = "inputTextBox";
            this.inputTextBox.Size = new System.Drawing.Size(208, 20);
            this.inputTextBox.TabIndex = 4;
            // 
            // pathLabel
            // 
            this.pathLabel.AutoSize = true;
            this.pathLabel.Location = new System.Drawing.Point(12, 166);
            this.pathLabel.Name = "pathLabel";
            this.pathLabel.Size = new System.Drawing.Size(83, 13);
            this.pathLabel.TabIndex = 4;
            this.pathLabel.Text = "Input Files Path:";
            // 
            // inputBrowseButton
            // 
            this.inputBrowseButton.Location = new System.Drawing.Point(313, 161);
            this.inputBrowseButton.Name = "inputBrowseButton";
            this.inputBrowseButton.Size = new System.Drawing.Size(58, 23);
            this.inputBrowseButton.TabIndex = 5;
            this.inputBrowseButton.Text = "Browse";
            this.inputBrowseButton.UseVisualStyleBackColor = true;
            this.inputBrowseButton.Click += new System.EventHandler(this.browseButton_Click);
            // 
            // bgWorker
            // 
            this.bgWorker.WorkerReportsProgress = true;
            this.bgWorker.WorkerSupportsCancellation = true;
            this.bgWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgWorker_DoWork);
            this.bgWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.bgWorker_ProgressChanged);
            this.bgWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgWorker_RunWorkerCompleted);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(15, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(356, 112);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // labelLoadedMap
            // 
            this.labelLoadedMap.AutoSize = true;
            this.labelLoadedMap.Location = new System.Drawing.Point(12, 137);
            this.labelLoadedMap.Name = "labelLoadedMap";
            this.labelLoadedMap.Size = new System.Drawing.Size(52, 13);
            this.labelLoadedMap.TabIndex = 7;
            this.labelLoadedMap.Text = "Map files:";
            // 
            // comboBoxLoadedMap
            // 
            this.comboBoxLoadedMap.FormattingEnabled = true;
            this.comboBoxLoadedMap.Location = new System.Drawing.Point(99, 134);
            this.comboBoxLoadedMap.Name = "comboBoxLoadedMap";
            this.comboBoxLoadedMap.Size = new System.Drawing.Size(208, 21);
            this.comboBoxLoadedMap.TabIndex = 9;
            this.comboBoxLoadedMap.SelectedIndexChanged += new System.EventHandler(this.comboBoxLoadedMap_SelectedIndexChanged);
            // 
            // patchIdeCheckBox
            // 
            this.patchIdeCheckBox.AutoSize = true;
            this.patchIdeCheckBox.Location = new System.Drawing.Point(15, 89);
            this.patchIdeCheckBox.Name = "patchIdeCheckBox";
            this.patchIdeCheckBox.Size = new System.Drawing.Size(234, 17);
            this.patchIdeCheckBox.TabIndex = 7;
            this.patchIdeCheckBox.Text = "Add \"ObjectCount\" (always as 1) in IDE files";
            this.patchIdeCheckBox.UseVisualStyleBackColor = true;
            // 
            // patchIdeLabel
            // 
            this.patchIdeLabel.AutoSize = true;
            this.patchIdeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.patchIdeLabel.ForeColor = System.Drawing.Color.Red;
            this.patchIdeLabel.Location = new System.Drawing.Point(12, 109);
            this.patchIdeLabel.Name = "patchIdeLabel";
            this.patchIdeLabel.Size = new System.Drawing.Size(268, 13);
            this.patchIdeLabel.TabIndex = 8;
            this.patchIdeLabel.Text = "Only check this if you know what you\'re doing";
            // 
            // outputBrowseButton
            // 
            this.outputBrowseButton.Location = new System.Drawing.Point(313, 188);
            this.outputBrowseButton.Name = "outputBrowseButton";
            this.outputBrowseButton.Size = new System.Drawing.Size(58, 23);
            this.outputBrowseButton.TabIndex = 12;
            this.outputBrowseButton.Text = "Browse";
            this.outputBrowseButton.UseVisualStyleBackColor = true;
            this.outputBrowseButton.Click += new System.EventHandler(this.browseButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 193);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Output Path:";
            // 
            // outputTextBox
            // 
            this.outputTextBox.Location = new System.Drawing.Point(99, 190);
            this.outputTextBox.Name = "outputTextBox";
            this.outputTextBox.Size = new System.Drawing.Size(208, 20);
            this.outputTextBox.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(389, 459);
            this.Controls.Add(this.outputBrowseButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.outputTextBox);
            this.Controls.Add(this.comboBoxLoadedMap);
            this.Controls.Add(this.labelLoadedMap);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.inputBrowseButton);
            this.Controls.Add(this.pathLabel);
            this.Controls.Add(this.inputTextBox);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "IDE/IPL Advanced Editor Beta v0.0.0";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox IDoffsetTextBox;
        private System.Windows.Forms.TextBox ZtextBox;
        private System.Windows.Forms.TextBox YtextBox;
        private System.Windows.Forms.TextBox XtextBox;
        private System.Windows.Forms.ProgressBar editProgressBar;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.TextBox inputTextBox;
        private System.Windows.Forms.Label pathLabel;
        private System.Windows.Forms.Button inputBrowseButton;
        private System.Windows.Forms.SaveFileDialog browseSaveFileDialog;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.ComponentModel.BackgroundWorker bgWorker;
        private System.Windows.Forms.Label labelProgressStatus;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelLoadedMap;
        private System.Windows.Forms.ComboBox comboBoxLoadedMap;
        private System.Windows.Forms.CheckBox patchIdeCheckBox;
        private System.Windows.Forms.Label patchIdeLabel;
        private System.Windows.Forms.Button outputBrowseButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox outputTextBox;
    }
}

