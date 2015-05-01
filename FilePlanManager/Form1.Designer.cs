namespace FilePlanManager
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.tabGen = new System.Windows.Forms.TabControl();
            this.tabFolder = new System.Windows.Forms.TabPage();
            this.tabGroups = new System.Windows.Forms.TabPage();
            this.tabSecurity = new System.Windows.Forms.TabPage();
            this.imgLst = new System.Windows.Forms.ImageList(this.components);
            this.btnValidate = new System.Windows.Forms.Button();
            this.btnExec = new System.Windows.Forms.Button();
            this.btnOptions = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            this.prgBar = new System.Windows.Forms.ProgressBar();
            this.opFile = new System.Windows.Forms.OpenFileDialog();
            this.lblFileName = new System.Windows.Forms.Label();
            this.tabGen.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabGen
            // 
            this.tabGen.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabGen.Controls.Add(this.tabFolder);
            this.tabGen.Controls.Add(this.tabGroups);
            this.tabGen.Controls.Add(this.tabSecurity);
            this.tabGen.ImageList = this.imgLst;
            this.tabGen.Location = new System.Drawing.Point(12, 119);
            this.tabGen.Name = "tabGen";
            this.tabGen.SelectedIndex = 0;
            this.tabGen.Size = new System.Drawing.Size(638, 351);
            this.tabGen.TabIndex = 0;
            // 
            // tabFolder
            // 
            this.tabFolder.ImageKey = "1430040345_document-open.png";
            this.tabFolder.Location = new System.Drawing.Point(4, 39);
            this.tabFolder.Name = "tabFolder";
            this.tabFolder.Padding = new System.Windows.Forms.Padding(3);
            this.tabFolder.Size = new System.Drawing.Size(630, 308);
            this.tabFolder.TabIndex = 0;
            this.tabFolder.Text = "Carpetas";
            this.tabFolder.UseVisualStyleBackColor = true;
            // 
            // tabGroups
            // 
            this.tabGroups.ImageKey = "1430040370_emblem-people.png";
            this.tabGroups.Location = new System.Drawing.Point(4, 39);
            this.tabGroups.Name = "tabGroups";
            this.tabGroups.Padding = new System.Windows.Forms.Padding(3);
            this.tabGroups.Size = new System.Drawing.Size(630, 308);
            this.tabGroups.TabIndex = 1;
            this.tabGroups.Text = "Grupos";
            this.tabGroups.UseVisualStyleBackColor = true;
            // 
            // tabSecurity
            // 
            this.tabSecurity.ImageKey = "1430040359_preferences-desktop-user-password.png";
            this.tabSecurity.Location = new System.Drawing.Point(4, 39);
            this.tabSecurity.Name = "tabSecurity";
            this.tabSecurity.Size = new System.Drawing.Size(630, 308);
            this.tabSecurity.TabIndex = 2;
            this.tabSecurity.Text = "Seguridad";
            this.tabSecurity.UseVisualStyleBackColor = true;
            // 
            // imgLst
            // 
            this.imgLst.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgLst.ImageStream")));
            this.imgLst.TransparentColor = System.Drawing.Color.White;
            this.imgLst.Images.SetKeyName(0, "1430040345_document-open.png");
            this.imgLst.Images.SetKeyName(1, "1430040370_emblem-people.png");
            this.imgLst.Images.SetKeyName(2, "1430040359_preferences-desktop-user-password.png");
            this.imgLst.Images.SetKeyName(3, "1430040879_emblem-work.png");
            this.imgLst.Images.SetKeyName(4, "1430040769_application-x-executable-script.png");
            this.imgLst.Images.SetKeyName(5, "1430040359_preferences-desktop-user-password.png");
            this.imgLst.Images.SetKeyName(6, "1430040784_preferences-certificates.png");
            this.imgLst.Images.SetKeyName(7, "1430040102_human-folder-txt.png");
            this.imgLst.Images.SetKeyName(8, "1430040890_xfce-system-settings.png");
            this.imgLst.Images.SetKeyName(9, "1430041128_xfce-system-exit.png");
            this.imgLst.Images.SetKeyName(10, "1430041479_human-folder-visiting.png");
            // 
            // btnValidate
            // 
            this.btnValidate.Enabled = false;
            this.btnValidate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnValidate.ImageIndex = 6;
            this.btnValidate.ImageList = this.imgLst;
            this.btnValidate.Location = new System.Drawing.Point(89, 10);
            this.btnValidate.Name = "btnValidate";
            this.btnValidate.Size = new System.Drawing.Size(91, 48);
            this.btnValidate.TabIndex = 1;
            this.btnValidate.Text = "Validar";
            this.btnValidate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnValidate.UseVisualStyleBackColor = true;
            // 
            // btnExec
            // 
            this.btnExec.Enabled = false;
            this.btnExec.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExec.ImageIndex = 4;
            this.btnExec.ImageList = this.imgLst;
            this.btnExec.Location = new System.Drawing.Point(186, 10);
            this.btnExec.Name = "btnExec";
            this.btnExec.Size = new System.Drawing.Size(91, 48);
            this.btnExec.TabIndex = 2;
            this.btnExec.Text = "Ejecutar";
            this.btnExec.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExec.UseVisualStyleBackColor = true;
            // 
            // btnOptions
            // 
            this.btnOptions.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOptions.ImageIndex = 8;
            this.btnOptions.ImageList = this.imgLst;
            this.btnOptions.Location = new System.Drawing.Point(304, 10);
            this.btnOptions.Name = "btnOptions";
            this.btnOptions.Size = new System.Drawing.Size(91, 48);
            this.btnOptions.TabIndex = 3;
            this.btnOptions.Text = "Opciones";
            this.btnOptions.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnOptions.UseVisualStyleBackColor = true;
            this.btnOptions.Click += new System.EventHandler(this.btnOptions_Click);
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExit.ImageIndex = 9;
            this.btnExit.ImageList = this.imgLst;
            this.btnExit.Location = new System.Drawing.Point(555, 10);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(91, 48);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "Salir";
            this.btnExit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLoad.ImageIndex = 10;
            this.btnLoad.ImageList = this.imgLst;
            this.btnLoad.Location = new System.Drawing.Point(12, 10);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(71, 48);
            this.btnLoad.TabIndex = 5;
            this.btnLoad.Text = "Abrir";
            this.btnLoad.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // prgBar
            // 
            this.prgBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.prgBar.Location = new System.Drawing.Point(12, 65);
            this.prgBar.Name = "prgBar";
            this.prgBar.Size = new System.Drawing.Size(634, 26);
            this.prgBar.TabIndex = 6;
            // 
            // opFile
            // 
            this.opFile.DefaultExt = "xlsx";
            this.opFile.Filter = "File Plan Excel|*.xlsx";
            // 
            // lblFileName
            // 
            this.lblFileName.AutoSize = true;
            this.lblFileName.Location = new System.Drawing.Point(13, 98);
            this.lblFileName.Name = "lblFileName";
            this.lblFileName.Size = new System.Drawing.Size(179, 13);
            this.lblFileName.TabIndex = 7;
            this.lblFileName.Text = "No hay archivo de File Plan cargado";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(662, 482);
            this.Controls.Add(this.lblFileName);
            this.Controls.Add(this.prgBar);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnOptions);
            this.Controls.Add(this.btnExec);
            this.Controls.Add(this.btnValidate);
            this.Controls.Add(this.tabGen);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMain";
            this.Text = "File Plan Manager - Content World LLC";
            this.tabGen.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabGen;
        private System.Windows.Forms.TabPage tabFolder;
        private System.Windows.Forms.TabPage tabGroups;
        private System.Windows.Forms.TabPage tabSecurity;
        private System.Windows.Forms.Button btnValidate;
        private System.Windows.Forms.ImageList imgLst;
        private System.Windows.Forms.Button btnExec;
        private System.Windows.Forms.Button btnOptions;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.ProgressBar prgBar;
        private System.Windows.Forms.OpenFileDialog opFile;
        private System.Windows.Forms.Label lblFileName;
    }
}

