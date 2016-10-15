using System;
using System.Windows.Forms;
using System.IO;
using System.Linq;

namespace transformCSV
{
    public partial class frmCSVtoDT : Form
    {
        public frmCSVtoDT() { InitializeComponent(); }

        string fileName = "", filePath = "";
        char value = '\t';

        string SelectFile()
        {
            using (OpenFileDialog oFile = new OpenFileDialog())
            {
                oFile.Filter = "Select CSV file|*.csv";
                oFile.ShowDialog();
                if (oFile.FileName.Trim() != "")
                {
                    fileName = oFile.SafeFileName;
                    return oFile.FileName;
                }
            }
            return null;
        }

        string SelectPath()
        {
            using (FolderBrowserDialog oFolder = new FolderBrowserDialog())
            {
                oFolder.ShowDialog();
                if (oFolder.SelectedPath.Trim() != "")
                    return oFolder.SelectedPath;

            }
            return null;
        }

        void updateOutput(string extenstion)
        {
            try
            {
                txtOutput.Text =
                    System.IO.Directory.GetParent(filePath).ToString()
                    + "\\" + fileName.Replace(".csv", extenstion);
                txtOutput.SelectionStart = txtOutput.TextLength;
            }
            catch (Exception) { }

        }

        private void btnSelectCSV_Click(object sender, EventArgs e)
        {
            txtInput.Clear();
            txtInput.Text = filePath = SelectFile();
            txtInput.SelectionStart = txtInput.TextLength;

            updateOutput(".tsv");
        }

        private void changeExtension_CheckedChanged(object sender, EventArgs e)
        {
            if (radColon.Checked) { updateOutput("1.csv"); value = ':'; }
            if (radSemiCol.Checked) { updateOutput(".scsv"); value = ';'; }
            if (radTab.Checked) { updateOutput(".tsv"); value = '\t'; }
            if (radPipe.Checked) { updateOutput(".psv"); value = '|'; }
            if (radOther.Checked) { updateOutput(".txt"); }
        }

        private void btnOutputPath_Click(object sender, EventArgs e)
        {
            txtOutput.Text = filePath = SelectPath();
            txtOutput.SelectionStart = txtOutput.TextLength;

            radTab.Checked = true;
            updateOutput(".tsv");
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            try
            {
                File.WriteAllLines(
                    txtOutput.Text,
                    File
                     .ReadAllLines(txtInput.Text)
                     .Select(line => line.Replace(',', value))
                     );
                MessageBox.Show("Conversion Process Completed");
            }
            catch (Exception)
            {
                MessageBox.Show("Error in Conversion Process");
            }

        }

        private void txtDelimiter_TextChanged(object sender, EventArgs e)
        {
            if (txtDelimiter.Text.Trim().Length != 0)
                value = Convert.ToChar(txtDelimiter.Text);
        }





    }
}
