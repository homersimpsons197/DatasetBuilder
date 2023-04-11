using System.Windows.Forms;

namespace Dataset_Builder
{
    public partial class Form1 : Form
    {
        Worker w;
        Export ex;
        
        private bool dragging;
        private Point dragCursorPoint;
        private Point dragFormPoint;

        public static bool cAdd;
        public static bool cRep;

        public static List<string> flist= new List<string>();
        public static List<string> list= new List<string>();

        public Form1()
        {
            InitializeComponent();
            rtxt.EnableContextMenu();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ex = new Export(this);
            w = new Worker(this, ex);
            

            txt1.Enabled= false;
            txt2.Enabled= false;
        }

        private void pnlHeader_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            dragCursorPoint = Cursor.Position;
            dragFormPoint = this.Location;
        }

        private void pnlHeader_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point dif = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                this.Location = Point.Add(dragFormPoint, new Size(dif));
            }
        }

        private void pnlHeader_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

        private void btnx_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnupload_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog
            {
                InitialDirectory = @"C:\",
                Title = "Choose files",
            };

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    foreach (string file in ofd.FileNames)
                    {
                        using (var sr = new StreamReader(file))
                        {
                            list = System.IO.File.ReadLines(file).ToList();
                        }
                        w.UploadFiles(list);
                    }
                }
                catch 
                {
                
                }
            }
        }

        private void lblsearch_Click(object sender, EventArgs e)
        {
            if (txtsearch.Text != string.Empty && txtsearch.Text != null)
            {
                w.Search(list, txtsearch.Text);
            }

        }

        private void lblclear_Click(object sender, EventArgs e)
        {
            list = rtxt.Text.Split('\n').ToList();
            w.ClearSearch(list);
            txtsearch.Text = string.Empty;
            if (list != null && list.Count > 0)
            {
                list.Clear();
            }
        }

        private void rtxt_TextChanged(object sender, EventArgs e)
        {
            int lineCount = rtxt.Lines.Count();
            lblcount.Text = lineCount.ToString();
        }

        private void chAdd_CheckedChanged(object sender, EventArgs e)
        {
            cAdd = !cAdd;
            if(cAdd)
            {
                txt1.Enabled= true;
                txt2.Enabled= true;
                chRep.Checked = false;
            }
            else if(!cAdd && !cRep)
            {
                txt1.Enabled= false;
                txt2.Enabled= false;
            }
        }

        private void chRep_CheckedChanged(object sender, EventArgs e)
        {
            cRep= !cRep;
            if(cRep )
            {
                txt1.Enabled = true;
                txt2.Enabled = true;
                chAdd.Checked = false;
            }
            else if (!cAdd && !cRep)
            {
                txt1.Enabled = false;
                txt2.Enabled = false;
            }
        }

        private void btnorder_Click(object sender, EventArgs e)
        {
            list = rtxt.Text.Split('\n').ToList();
            w.PlaceInOrder(list);
            if (list != null && list.Count > 0)
            {
                list.Clear();
            }
        }

        private void btnremdup_Click(object sender, EventArgs e)
        {
            list = rtxt.Text.Split('\n').ToList();
            w.RemoveDuplicates(list);
            if (list != null && list.Count > 0)
            {
                list.Clear();
            }
        }

        private void btntoken_Click(object sender, EventArgs e)
        {
            list = rtxt.Text.Split('\n').ToList();
            w.Tokenize(list);
            if (list != null && list.Count > 0)
            {
                list.Clear();
            }
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            if(rtxt != null && rtxt.Text != string.Empty)
            {
                rtxt.Text = "";
            }
            if(list != null && list.Count > 0)
            {
                list.Clear();
            }
            lblcount.Text = "0";
        }

        private void btnproceedrgx_Click(object sender, EventArgs e)
        {
            list = rtxt.Text.Split('\n').ToList();
            if(cAdd)
            {                
                w.RegexAdd(list, cAdd, txt1.Text, txt2.Text);                
            }
            else if (cRep)
            {
                w.RegexEdit(list, cAdd, txt1.Text, txt2.Text);
            }
            txt1.Clear();
            txt2.Clear();
            if (list != null && list.Count > 0)
            {
                list.Clear();
            }
        }

        private void btnslang_Click(object sender, EventArgs e)
        {
            list = rtxt.Text.Split('\n').ToList();
            w.Comma(list);
            w.Slang(list);
            if (list != null && list.Count > 0)
            {
                list.Clear();
            }
        }

        private void btnex_Click(object sender, EventArgs e)
        {
            if(txtcol0.Text != string.Empty && txtcol0.Text != null)
            {
                ex.Show();
                this.Enabled = false;

                list = rtxt.Text.Split('\n').ToList();
                w.DgvSize(list, txtcol0.Text);
            }
            else
            {
                MessageBox.Show("Fill required fields.");
                txtcol0.Focus();
            }
        } 
        
        public Label Lbl()
        {
            return lblsearch;
        }
    }
}