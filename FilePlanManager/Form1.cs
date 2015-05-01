using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using log4net;
using Excel = Microsoft.Office.Interop.Excel;
using System.IO;

[assembly: log4net.Config.XmlConfigurator(Watch = true)]

namespace FilePlanManager
{
    public partial class frmMain : Form
    {

        // Public variable declaration
        public string strFile;

        // Private variable declaration
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        private Excel.Application excelApp = new Excel.Application();
        private Excel.Workbook excelWorkbook;
        Dictionary<string, string> mysettings = new Dictionary<string, string>();

        public frmMain()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            //TODO: If execution is on process, not allow to exit

            // User exit the application
            log.Info("Application Exit");
            Application.Exit();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            // Shows Open file Dialog
            if (opFile.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                // Open file dialog was OK, set strFile variable
                strFile = opFile.FileName;
                log.Info("User Open File: " + strFile);

                // Check if the excel can be opened
                if (fExOpen())
                {
                    log.Debug("Opening File Ok: " + strFile);

                    // Show filename to user and enable/disable buttons
                    lblFileName.Text = strFile;
                    fButOpen();

                    // Open Sheets
                    Excel.Sheets excelSheets = excelWorkbook.Worksheets;

                    // Find Control Sheet?
                    if (mysettings["ValidateExcel"] == "true")
                    {
                        string currentSheet = mysettings["ControlSheetName"];
                        try
                        {
                            Excel.Worksheet excelWorksheet = (Excel.Worksheet)excelSheets.get_Item(currentSheet);
                        }
                        catch (Exception ex)
                        {
                            log.Error("Error Finding Control Sheet on File: " + strFile);
                            MessageBox.Show("No Control Sheet on file '" + strFile + "'", "File Plan Manager", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }

                    
                }
                else {
                    // Error opening excel
                    log.Error("Error Opening File: " + strFile);
                    strFile = "";
                    MessageBox.Show("Error when loading file '" + strFile + "'. Aborted", "File Plan Manager", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else {
                // Error or cancel in File Open Dialog
                log.Warn("User cancel open operation");
                strFile = "";
                lblFileName.Text = "No hay archivo de File Plan cargado";
            }
            
        }

        private void LoadParameters()
        {

            string contents = String.Empty;
            using (FileStream fs = File.Open("myConfig.txt", FileMode.Open))
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

                //string test = mysettings["USERID"]; // example of getting userid
            }
        }

        private bool fExOpen()
        {
            try
            {
                // Create the workbook object
                excelWorkbook = excelApp.Workbooks.Open(strFile,
                        0, false, 5, "", "",false, Excel.XlPlatform.xlWindows, "",
                        true, false, 0,true, false, false);
            }
            catch (Exception ex)
            {
                log.Error("Error Opening File", ex);
            }
            return true;
        }

#region Buttons

        private void fButLoad() {
            btnLoad.Enabled = true ;
            btnValidate.Enabled = false ;
            btnOptions.Enabled = false;
            btnExec.Enabled = false;
            strFile = "";
            lblFileName.Text = "No hay archivo de File Plan cargado";
        }

        private void fButOpen(){
            btnLoad.Enabled = false;
            btnValidate.Enabled = true;
            btnOptions.Enabled = false;
            btnExec.Enabled = false;
        }

#endregion

        private void btnOptions_Click(object sender, EventArgs e)
        {
            frmOptions frmO = new frmOptions();
            frmO.ShowDialog();
        }

    }
}
