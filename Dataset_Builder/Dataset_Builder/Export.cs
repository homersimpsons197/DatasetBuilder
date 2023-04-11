using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dataset_Builder
{
    public partial class Export : Form
    {
        Form1 f;
        SaveFileDialog saveDialog;
        DataObject dataObject;

        public static int rowsCount;

        public Export(Form1 f)
        {
            InitializeComponent();
            this.f = f;
        }

        private void Export_FormClosing(object sender, FormClosingEventArgs e)
        {
            f.Enabled= true;
        }

        private void Export_Load(object sender, EventArgs e)
        {

        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            string ext = cboxext.Text;
            string filename = "";
            switch (ext)
            {
                case ".csv":
                    saveDialog = new SaveFileDialog();
                    saveDialog.Title = "Save As";
                    saveDialog.Filter = "Text Files (*.csv)|*.csv";
                    if (saveDialog.ShowDialog() == DialogResult.OK)
                    {
                        filename = saveDialog.FileName;
                    }
                   
                    dgv.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
                    
                    dgv.SelectAll();
                    dataObject = dgv.GetClipboardContent();
                    File.WriteAllText(filename, dataObject.GetText(TextDataFormat.CommaSeparatedValue));
                    break;
                case ".tsv":
                    saveDialog = new SaveFileDialog();
                    saveDialog.Title = "Save As";
                    saveDialog.Filter = "Text Files (*.tsv)|*.tsv";
                    if (saveDialog.ShowDialog() == DialogResult.OK)
                    {
                        filename = saveDialog.FileName;
                    }

                    dgv.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableWithoutHeaderText;

                    dgv.SelectAll();
                    dataObject = dgv.GetClipboardContent();
                    File.WriteAllText(filename, dataObject.GetText(TextDataFormat.CommaSeparatedValue));
                    break;
                case ".txt":
                    saveDialog = new SaveFileDialog();
                    saveDialog.Title = "Save As";
                    saveDialog.Filter = "Text Files (*.txt)|*.txt";
                    if (saveDialog.ShowDialog() == DialogResult.OK)
                    {
                        filename = saveDialog.FileName;
                    }

                    dgv.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableWithoutHeaderText;

                    dgv.SelectAll();
                    dataObject = dgv.GetClipboardContent();
                    File.WriteAllText(filename, dataObject.GetText(TextDataFormat.CommaSeparatedValue));
                    break;
            }
        }

        private void btnx_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgv_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            rowsCount++;
            lblcount.Text = rowsCount.ToString();
        }

        private void lblclear_Click(object sender, EventArgs e)
        {
            if (dgv.Rows.Count > 0)
            {
                dgv.Rows.Clear();
                dgv.Refresh();
                pnldgv.Height = 27;
                lblcount.Text = "0";
                cboxext.SelectedIndex = -1;
            }
        }
    }
}
