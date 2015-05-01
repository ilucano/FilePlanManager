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

namespace FilePlanManager
{
    public partial class frmOptions : Form
    {

        Dictionary<string, string> mysettings = new Dictionary<string, string>();

        public frmOptions()
        {
            InitializeComponent();
        }

        private void frmOptions_Load(object sender, EventArgs e)
        {
            LoadParameters();
            FillParameters();
        }

        private void LoadParameters() {

            string contents = String.Empty;
            using (FileStream fs = File.Open("myConfig.txt", FileMode.Open ))
            using (StreamReader reader = new StreamReader(fs))
            {
                contents = reader.ReadToEnd();
            }

            if (contents.Length > 0)
            {
                string[] lines = contents.Split(new char[] { '\n' });
                foreach (string line in lines)
                {
                    string[] keyAndValue = line.Split(new char[] { '=' });
                    mysettings.Add(keyAndValue[0].Trim(), keyAndValue[1].Trim());
                }
            }
            
        }
        private void FillParameters() {

            chkValidateExcel.Checked = Convert.ToBoolean(mysettings["ValidateExcel"]);
            if (chkValidateExcel.Checked == true)
            {
                txtControlSheetName.Enabled = true;
                lblControlSheet.Enabled = true;
            }
            else
            {
                txtControlSheetName.Enabled = false;
                lblControlSheet.Enabled = false;
            }
            txtControlSheetName.Text = mysettings["ControlSheetName"];

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void chkValidateExcel_CheckedChanged(object sender, EventArgs e)
        {
            if (chkValidateExcel.Checked == true)
            {
                txtControlSheetName.Enabled = true; 
                lblControlSheet.Enabled = true;
            } else {
                txtControlSheetName.Enabled = false;
                lblControlSheet.Enabled = false;
            }
        }

        private void chkValidaLargoCarp_CheckedChanged(object sender, EventArgs e)
        {
            if (chkValidaLargoCarp.Checked == true)
            {
                txtCarpLargo.Enabled = true;
                lblLenghtField.Enabled = true;
            }
            else
            {
                txtCarpLargo.Enabled = false;
                lblLenghtField.Enabled = false;
            }
        }

        private void chkCharsCarp_CheckedChanged(object sender, EventArgs e)
        {
            if (chkCharsCarp.Checked == true)
            {
                txtCharsCarp.Enabled = true;
                lblCarNoPerm.Enabled = true;
            }
            else
            {
                txtCharsCarp.Enabled = false;
                lblCarNoPerm.Enabled = false;
            }
        }

        private void chkValidaLargoGrupo_CheckedChanged(object sender, EventArgs e)
        {
            if (chkValidaLargoGrupo.Checked == true)
            {
                txtGrupLargo.Enabled = true;
                lblLargoCampo.Enabled = true;
            }
            else
            {
                txtGrupLargo.Enabled = false;
                lblLargoCampo.Enabled = false;
            }
        }

        private void chkCharsGrup_CheckedChanged(object sender, EventArgs e)
        {
            if (chkCharsGrup.Checked == true)
            {
                txtCharsGrup.Enabled = true;
                lblCharsNoPerm.Enabled = true;
            }
            else
            {
                txtCharsGrup.Enabled = false;
                lblCharsNoPerm.Enabled = false;
            }
        }
    }
}
