namespace FilePlanManager
{
    partial class frmOptions
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmOptions));
            this.btnCancel = new System.Windows.Forms.Button();
            this.imgLst = new System.Windows.Forms.ImageList(this.components);
            this.btnSave = new System.Windows.Forms.Button();
            this.grpGeneral = new System.Windows.Forms.GroupBox();
            this.lblControlSheet = new System.Windows.Forms.Label();
            this.txtControlSheetName = new System.Windows.Forms.TextBox();
            this.chkValidateExcel = new System.Windows.Forms.CheckBox();
            this.grpCarpetas = new System.Windows.Forms.GroupBox();
            this.lblCarNoPerm = new System.Windows.Forms.Label();
            this.txtCharsCarp = new System.Windows.Forms.TextBox();
            this.chkCharsCarp = new System.Windows.Forms.CheckBox();
            this.lblLenghtField = new System.Windows.Forms.Label();
            this.txtCarpLargo = new System.Windows.Forms.TextBox();
            this.chkValidaLargoCarp = new System.Windows.Forms.CheckBox();
            this.chkRepeatedFolders = new System.Windows.Forms.CheckBox();
            this.chkLevelCheck = new System.Windows.Forms.CheckBox();
            this.grpGrupos = new System.Windows.Forms.GroupBox();
            this.lblCharsNoPerm = new System.Windows.Forms.Label();
            this.txtCharsGrup = new System.Windows.Forms.TextBox();
            this.chkCharsGrup = new System.Windows.Forms.CheckBox();
            this.lblLargoCampo = new System.Windows.Forms.Label();
            this.txtGrupLargo = new System.Windows.Forms.TextBox();
            this.chkValidaLargoGrupo = new System.Windows.Forms.CheckBox();
            this.chkGrupoRepetido = new System.Windows.Forms.CheckBox();
            this.grpPermisos = new System.Windows.Forms.GroupBox();
            this.chkErrorFaltaACL = new System.Windows.Forms.CheckBox();
            this.chkCompletitud = new System.Windows.Forms.CheckBox();
            this.chkDatosRepetidos = new System.Windows.Forms.CheckBox();
            this.grpGeneral.SuspendLayout();
            this.grpCarpetas.SuspendLayout();
            this.grpGrupos.SuspendLayout();
            this.grpPermisos.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancel.ImageIndex = 1;
            this.btnCancel.ImageList = this.imgLst;
            this.btnCancel.Location = new System.Drawing.Point(395, 483);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(91, 48);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // imgLst
            // 
            this.imgLst.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgLst.ImageStream")));
            this.imgLst.TransparentColor = System.Drawing.Color.White;
            this.imgLst.Images.SetKeyName(0, "1430085177_document-save.png");
            this.imgLst.Images.SetKeyName(1, "1430085211_dialog-error.png");
            // 
            // btnSave
            // 
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.ImageIndex = 0;
            this.btnSave.ImageList = this.imgLst;
            this.btnSave.Location = new System.Drawing.Point(308, 483);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(81, 48);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "Grabar";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // grpGeneral
            // 
            this.grpGeneral.Controls.Add(this.lblControlSheet);
            this.grpGeneral.Controls.Add(this.txtControlSheetName);
            this.grpGeneral.Controls.Add(this.chkValidateExcel);
            this.grpGeneral.Location = new System.Drawing.Point(12, 12);
            this.grpGeneral.Name = "grpGeneral";
            this.grpGeneral.Size = new System.Drawing.Size(474, 69);
            this.grpGeneral.TabIndex = 7;
            this.grpGeneral.TabStop = false;
            this.grpGeneral.Text = "General";
            // 
            // lblControlSheet
            // 
            this.lblControlSheet.AutoSize = true;
            this.lblControlSheet.Location = new System.Drawing.Point(37, 40);
            this.lblControlSheet.Name = "lblControlSheet";
            this.lblControlSheet.Size = new System.Drawing.Size(146, 13);
            this.lblControlSheet.TabIndex = 2;
            this.lblControlSheet.Text = "Nombre de la Hoja de Control";
            // 
            // txtControlSheetName
            // 
            this.txtControlSheetName.Location = new System.Drawing.Point(189, 37);
            this.txtControlSheetName.Name = "txtControlSheetName";
            this.txtControlSheetName.Size = new System.Drawing.Size(236, 20);
            this.txtControlSheetName.TabIndex = 1;
            // 
            // chkValidateExcel
            // 
            this.chkValidateExcel.AutoSize = true;
            this.chkValidateExcel.Location = new System.Drawing.Point(6, 19);
            this.chkValidateExcel.Name = "chkValidateExcel";
            this.chkValidateExcel.Size = new System.Drawing.Size(134, 17);
            this.chkValidateExcel.TabIndex = 0;
            this.chkValidateExcel.Text = "Validar Hoja de Control";
            this.chkValidateExcel.UseVisualStyleBackColor = true;
            this.chkValidateExcel.CheckedChanged += new System.EventHandler(this.chkValidateExcel_CheckedChanged);
            // 
            // grpCarpetas
            // 
            this.grpCarpetas.Controls.Add(this.lblCarNoPerm);
            this.grpCarpetas.Controls.Add(this.txtCharsCarp);
            this.grpCarpetas.Controls.Add(this.chkCharsCarp);
            this.grpCarpetas.Controls.Add(this.lblLenghtField);
            this.grpCarpetas.Controls.Add(this.txtCarpLargo);
            this.grpCarpetas.Controls.Add(this.chkValidaLargoCarp);
            this.grpCarpetas.Controls.Add(this.chkRepeatedFolders);
            this.grpCarpetas.Controls.Add(this.chkLevelCheck);
            this.grpCarpetas.Location = new System.Drawing.Point(12, 87);
            this.grpCarpetas.Name = "grpCarpetas";
            this.grpCarpetas.Size = new System.Drawing.Size(474, 157);
            this.grpCarpetas.TabIndex = 8;
            this.grpCarpetas.TabStop = false;
            this.grpCarpetas.Text = "Carpetas";
            // 
            // lblCarNoPerm
            // 
            this.lblCarNoPerm.AutoSize = true;
            this.lblCarNoPerm.Location = new System.Drawing.Point(37, 127);
            this.lblCarNoPerm.Name = "lblCarNoPerm";
            this.lblCarNoPerm.Size = new System.Drawing.Size(123, 13);
            this.lblCarNoPerm.TabIndex = 11;
            this.lblCarNoPerm.Text = "Caracteres no permitidos";
            // 
            // txtCharsCarp
            // 
            this.txtCharsCarp.Location = new System.Drawing.Point(189, 124);
            this.txtCharsCarp.Name = "txtCharsCarp";
            this.txtCharsCarp.Size = new System.Drawing.Size(236, 20);
            this.txtCharsCarp.TabIndex = 10;
            // 
            // chkCharsCarp
            // 
            this.chkCharsCarp.AutoSize = true;
            this.chkCharsCarp.Location = new System.Drawing.Point(6, 106);
            this.chkCharsCarp.Name = "chkCharsCarp";
            this.chkCharsCarp.Size = new System.Drawing.Size(166, 17);
            this.chkCharsCarp.TabIndex = 9;
            this.chkCharsCarp.Text = "Validar Caracteres Especiales";
            this.chkCharsCarp.UseVisualStyleBackColor = true;
            this.chkCharsCarp.CheckedChanged += new System.EventHandler(this.chkCharsCarp_CheckedChanged);
            // 
            // lblLenghtField
            // 
            this.lblLenghtField.AutoSize = true;
            this.lblLenghtField.Location = new System.Drawing.Point(37, 86);
            this.lblLenghtField.Name = "lblLenghtField";
            this.lblLenghtField.Size = new System.Drawing.Size(87, 13);
            this.lblLenghtField.TabIndex = 8;
            this.lblLenghtField.Text = "Largo del Campo";
            // 
            // txtCarpLargo
            // 
            this.txtCarpLargo.Location = new System.Drawing.Point(189, 83);
            this.txtCarpLargo.Name = "txtCarpLargo";
            this.txtCarpLargo.Size = new System.Drawing.Size(47, 20);
            this.txtCarpLargo.TabIndex = 7;
            // 
            // chkValidaLargoCarp
            // 
            this.chkValidaLargoCarp.AutoSize = true;
            this.chkValidaLargoCarp.Location = new System.Drawing.Point(6, 65);
            this.chkValidaLargoCarp.Name = "chkValidaLargoCarp";
            this.chkValidaLargoCarp.Size = new System.Drawing.Size(139, 17);
            this.chkValidaLargoCarp.TabIndex = 6;
            this.chkValidaLargoCarp.Text = "Validar Largo de Campo";
            this.chkValidaLargoCarp.UseVisualStyleBackColor = true;
            this.chkValidaLargoCarp.CheckedChanged += new System.EventHandler(this.chkValidaLargoCarp_CheckedChanged);
            // 
            // chkRepeatedFolders
            // 
            this.chkRepeatedFolders.AutoSize = true;
            this.chkRepeatedFolders.Location = new System.Drawing.Point(6, 42);
            this.chkRepeatedFolders.Name = "chkRepeatedFolders";
            this.chkRepeatedFolders.Size = new System.Drawing.Size(153, 17);
            this.chkRepeatedFolders.TabIndex = 5;
            this.chkRepeatedFolders.Text = "Error en carpetas repetidas";
            this.chkRepeatedFolders.UseVisualStyleBackColor = true;
            // 
            // chkLevelCheck
            // 
            this.chkLevelCheck.AutoSize = true;
            this.chkLevelCheck.Location = new System.Drawing.Point(6, 19);
            this.chkLevelCheck.Name = "chkLevelCheck";
            this.chkLevelCheck.Size = new System.Drawing.Size(205, 17);
            this.chkLevelCheck.TabIndex = 4;
            this.chkLevelCheck.Text = "Verificacion de Nivel Real con Campo";
            this.chkLevelCheck.UseVisualStyleBackColor = true;
            // 
            // grpGrupos
            // 
            this.grpGrupos.Controls.Add(this.lblCharsNoPerm);
            this.grpGrupos.Controls.Add(this.txtCharsGrup);
            this.grpGrupos.Controls.Add(this.chkCharsGrup);
            this.grpGrupos.Controls.Add(this.lblLargoCampo);
            this.grpGrupos.Controls.Add(this.txtGrupLargo);
            this.grpGrupos.Controls.Add(this.chkValidaLargoGrupo);
            this.grpGrupos.Controls.Add(this.chkGrupoRepetido);
            this.grpGrupos.Location = new System.Drawing.Point(12, 250);
            this.grpGrupos.Name = "grpGrupos";
            this.grpGrupos.Size = new System.Drawing.Size(474, 132);
            this.grpGrupos.TabIndex = 9;
            this.grpGrupos.TabStop = false;
            this.grpGrupos.Text = "Grupos";
            // 
            // lblCharsNoPerm
            // 
            this.lblCharsNoPerm.AutoSize = true;
            this.lblCharsNoPerm.Location = new System.Drawing.Point(37, 102);
            this.lblCharsNoPerm.Name = "lblCharsNoPerm";
            this.lblCharsNoPerm.Size = new System.Drawing.Size(123, 13);
            this.lblCharsNoPerm.TabIndex = 11;
            this.lblCharsNoPerm.Text = "Caracteres no permitidos";
            // 
            // txtCharsGrup
            // 
            this.txtCharsGrup.Location = new System.Drawing.Point(189, 99);
            this.txtCharsGrup.Name = "txtCharsGrup";
            this.txtCharsGrup.Size = new System.Drawing.Size(236, 20);
            this.txtCharsGrup.TabIndex = 10;
            // 
            // chkCharsGrup
            // 
            this.chkCharsGrup.AutoSize = true;
            this.chkCharsGrup.Location = new System.Drawing.Point(6, 81);
            this.chkCharsGrup.Name = "chkCharsGrup";
            this.chkCharsGrup.Size = new System.Drawing.Size(166, 17);
            this.chkCharsGrup.TabIndex = 9;
            this.chkCharsGrup.Text = "Validar Caracteres Especiales";
            this.chkCharsGrup.UseVisualStyleBackColor = true;
            this.chkCharsGrup.CheckedChanged += new System.EventHandler(this.chkCharsGrup_CheckedChanged);
            // 
            // lblLargoCampo
            // 
            this.lblLargoCampo.AutoSize = true;
            this.lblLargoCampo.Location = new System.Drawing.Point(37, 61);
            this.lblLargoCampo.Name = "lblLargoCampo";
            this.lblLargoCampo.Size = new System.Drawing.Size(87, 13);
            this.lblLargoCampo.TabIndex = 8;
            this.lblLargoCampo.Text = "Largo del Campo";
            // 
            // txtGrupLargo
            // 
            this.txtGrupLargo.Location = new System.Drawing.Point(189, 58);
            this.txtGrupLargo.Name = "txtGrupLargo";
            this.txtGrupLargo.Size = new System.Drawing.Size(47, 20);
            this.txtGrupLargo.TabIndex = 7;
            // 
            // chkValidaLargoGrupo
            // 
            this.chkValidaLargoGrupo.AutoSize = true;
            this.chkValidaLargoGrupo.Location = new System.Drawing.Point(6, 40);
            this.chkValidaLargoGrupo.Name = "chkValidaLargoGrupo";
            this.chkValidaLargoGrupo.Size = new System.Drawing.Size(139, 17);
            this.chkValidaLargoGrupo.TabIndex = 6;
            this.chkValidaLargoGrupo.Text = "Validar Largo de Campo";
            this.chkValidaLargoGrupo.UseVisualStyleBackColor = true;
            this.chkValidaLargoGrupo.CheckedChanged += new System.EventHandler(this.chkValidaLargoGrupo_CheckedChanged);
            // 
            // chkGrupoRepetido
            // 
            this.chkGrupoRepetido.AutoSize = true;
            this.chkGrupoRepetido.Location = new System.Drawing.Point(6, 17);
            this.chkGrupoRepetido.Name = "chkGrupoRepetido";
            this.chkGrupoRepetido.Size = new System.Drawing.Size(144, 17);
            this.chkGrupoRepetido.TabIndex = 5;
            this.chkGrupoRepetido.Text = "Error en grupos repetidos";
            this.chkGrupoRepetido.UseVisualStyleBackColor = true;
            // 
            // grpPermisos
            // 
            this.grpPermisos.Controls.Add(this.chkErrorFaltaACL);
            this.grpPermisos.Controls.Add(this.chkCompletitud);
            this.grpPermisos.Controls.Add(this.chkDatosRepetidos);
            this.grpPermisos.Location = new System.Drawing.Point(12, 388);
            this.grpPermisos.Name = "grpPermisos";
            this.grpPermisos.Size = new System.Drawing.Size(474, 89);
            this.grpPermisos.TabIndex = 12;
            this.grpPermisos.TabStop = false;
            this.grpPermisos.Text = "Permisos";
            // 
            // chkErrorFaltaACL
            // 
            this.chkErrorFaltaACL.AutoSize = true;
            this.chkErrorFaltaACL.Location = new System.Drawing.Point(6, 63);
            this.chkErrorFaltaACL.Name = "chkErrorFaltaACL";
            this.chkErrorFaltaACL.Size = new System.Drawing.Size(163, 17);
            this.chkErrorFaltaACL.TabIndex = 9;
            this.chkErrorFaltaACL.Text = "Error si Falta Cargar Permisos";
            this.chkErrorFaltaACL.UseVisualStyleBackColor = true;
            // 
            // chkCompletitud
            // 
            this.chkCompletitud.AutoSize = true;
            this.chkCompletitud.Location = new System.Drawing.Point(6, 40);
            this.chkCompletitud.Name = "chkCompletitud";
            this.chkCompletitud.Size = new System.Drawing.Size(204, 17);
            this.chkCompletitud.TabIndex = 6;
            this.chkCompletitud.Text = "Error en conteo de Grupos y Carpetas";
            this.chkCompletitud.UseVisualStyleBackColor = true;
            // 
            // chkDatosRepetidos
            // 
            this.chkDatosRepetidos.AutoSize = true;
            this.chkDatosRepetidos.Location = new System.Drawing.Point(6, 17);
            this.chkDatosRepetidos.Name = "chkDatosRepetidos";
            this.chkDatosRepetidos.Size = new System.Drawing.Size(138, 17);
            this.chkDatosRepetidos.TabIndex = 5;
            this.chkDatosRepetidos.Text = "Error en datos repetidos";
            this.chkDatosRepetidos.UseVisualStyleBackColor = true;
            // 
            // frmOptions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(498, 539);
            this.Controls.Add(this.grpPermisos);
            this.Controls.Add(this.grpGrupos);
            this.Controls.Add(this.grpCarpetas);
            this.Controls.Add(this.grpGeneral);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmOptions";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "File Plan Manager - Options";
            this.Load += new System.EventHandler(this.frmOptions_Load);
            this.grpGeneral.ResumeLayout(false);
            this.grpGeneral.PerformLayout();
            this.grpCarpetas.ResumeLayout(false);
            this.grpCarpetas.PerformLayout();
            this.grpGrupos.ResumeLayout(false);
            this.grpGrupos.PerformLayout();
            this.grpPermisos.ResumeLayout(false);
            this.grpPermisos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ImageList imgLst;
        private System.Windows.Forms.GroupBox grpGeneral;
        private System.Windows.Forms.Label lblControlSheet;
        private System.Windows.Forms.TextBox txtControlSheetName;
        private System.Windows.Forms.CheckBox chkValidateExcel;
        private System.Windows.Forms.GroupBox grpCarpetas;
        private System.Windows.Forms.Label lblCarNoPerm;
        private System.Windows.Forms.TextBox txtCharsCarp;
        private System.Windows.Forms.CheckBox chkCharsCarp;
        private System.Windows.Forms.Label lblLenghtField;
        private System.Windows.Forms.TextBox txtCarpLargo;
        private System.Windows.Forms.CheckBox chkValidaLargoCarp;
        private System.Windows.Forms.CheckBox chkRepeatedFolders;
        private System.Windows.Forms.CheckBox chkLevelCheck;
        private System.Windows.Forms.GroupBox grpGrupos;
        private System.Windows.Forms.Label lblCharsNoPerm;
        private System.Windows.Forms.TextBox txtCharsGrup;
        private System.Windows.Forms.CheckBox chkCharsGrup;
        private System.Windows.Forms.Label lblLargoCampo;
        private System.Windows.Forms.TextBox txtGrupLargo;
        private System.Windows.Forms.CheckBox chkValidaLargoGrupo;
        private System.Windows.Forms.CheckBox chkGrupoRepetido;
        private System.Windows.Forms.GroupBox grpPermisos;
        private System.Windows.Forms.CheckBox chkErrorFaltaACL;
        private System.Windows.Forms.CheckBox chkCompletitud;
        private System.Windows.Forms.CheckBox chkDatosRepetidos;
    }
}