using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dataset_Builder
{
    public class Worker
    {
        Form1 f;
        Export ex;

        Regex s, u, you, r, are, y, ur, your, ure, d, ve, ll, space, space_, regx;

        public static List<string> list_ = new List<string>();
        public static List<string> _list = new List<string>();


        public Worker(Form1 f, Export ex)
        {
            this.f = f;
            this.ex = ex;
        }

        public async void Search(List<string> list, string s)
        {            
            
            int s_start = f.rtxt.SelectionStart, startIndex = 0, index;

            while ((index = f.rtxt.Text.IndexOf(s, startIndex)) != -1)
            {
                f.rtxt.Select(index, s.Length);
                f.rtxt.SelectionColor = Color.Red;
                f.rtxt.SelectionBackColor = Color.Yellow;

                startIndex = index + s.Length;
            }

            f.rtxt.SelectionStart = s_start;
            f.rtxt.SelectionLength = 0;
            f.rtxt.SelectionColor = Color.Black;
            f.Lbl().Enabled = false;
        }

        public void ClearSearch(List<string> list)
        {
            f.rtxt.Clear();
            f.rtxt.Lines = list.ToArray();
            list.Clear();
            f.rtxt.Text = Regex.Replace(f.rtxt.Text, @"^\s*$(\n|\r|\r\n)", "", RegexOptions.Multiline);
        }

        public void UploadFiles(List<string> list)
        {
            f.rtxt.Lines = list.ToArray();
        }

        public void PlaceInOrder(List<string> list)
        {
            list.Sort();
            f.rtxt.Clear();
            f.rtxt.Lines = list.ToArray();
            list.Clear();
            f.rtxt.Text = Regex.Replace(f.rtxt.Text, @"^\s*$(\n|\r|\r\n)", "", RegexOptions.Multiline);
        }

        public void RemoveDuplicates(List<string> list)
        {
            _list = list.GroupBy(x => x)
              .Where(g => g.Count() > 1)
              .Select(y => y.Key)
              .ToList();
            list = list.Distinct().ToList();
            f.rtxt.Clear();
            f.rtxt.Lines = list.ToArray();

            list.Clear();
            _list.Clear();
            f.rtxt.Text = Regex.Replace(f.rtxt.Text, @"^\s*$(\n|\r|\r\n)", "", RegexOptions.Multiline);
        }

        public void Tokenize(List<string> list)
        {
            var punct = new Regex(@"[\p{P}\p{S}]");
            var space = new Regex(@"(\s{2,})");
            var space_ = new Regex(@"(^\s)|(\s)+$");

            foreach (var line in list)
            {
                string text = line.ToString().ToLower();
                text = Regex.Replace(text, $@"{punct}", "");
                text = Regex.Replace(text, $@"{space}", " ");
                text = Regex.Replace(text, $@"{space_}", "");
                _list.Add(text);
            }
            f.rtxt.Clear();
            f.rtxt.Lines = _list.ToArray();
            list.Clear();
            _list.Clear();
        }

        public void RegexEdit(List<string> list, bool add, string str1, string str2)
        {
            foreach (var line in list)
            {
                string text = line.ToString();
                text = text.Replace(str1, str2);
                _list.Add(text);
            }
            f.rtxt.Clear();
            _list = _list.Distinct().ToList();
            f.rtxt.Lines = _list.ToArray();
            list.Clear();
            _list.Clear();

        }

        public void RegexAdd(List<string> list, bool add, string str1, string str2)
        {
            regx = new Regex($@"{str1}");
            foreach (var line in list)
            {
                string text = line.ToString();
                _list.Add(text);
                text = Regex.Replace(text, $@"{regx}", @$"{str2}");
                _list.Add(text);
            }
            f.rtxt.Clear();
            _list = _list.Distinct().ToList();
            f.rtxt.Lines = _list.ToArray();
            list.Clear();
            _list.Clear();
        }

        public void DgvSize(List<string> list, string col0)
        {
            int rowCount = ex.dgv.RowCount;
            int dgvheight = ex.dgv.Size.Height;
            int height = 20;

            foreach (var line in list)
            {
                ex.dgv.Rows.Insert(rowCount, col0, line.ToString());
                dgvheight += height;
                ex.pnldgv.Height = dgvheight + 25;
                ex.dgv.Height = dgvheight;
                rowCount++;
            }
        }

        public void Comma(List<string> list)
        {
            s = new Regex(@"(\'s)");
            ure = new Regex(@"(\'re)\s");
            ll = new Regex(@"(\'ll)\s");
            d = new Regex(@"(\'d)\s");
            ve = new Regex(@"(\'ve)\s");
            space = new Regex(@"(\s{2,})");
            space_ = new Regex(@"(^\s)|(\s)+$");

            for (int i = 0; i < list.Count; i++)
            {
                string text = list[i].ToString().ToLower();
                text = Regex.Replace(text, $@"{s}", " is ");
                text = Regex.Replace(text, $@"{ure}", " are ");
                text = Regex.Replace(text, $@"{d}", " would ");
                text = Regex.Replace(text, $@"{ve}", " have ");
                text = Regex.Replace(text, $@"{space}", " ");
                text = Regex.Replace(text, $@"{space_}", "");
                _list.Add(text);
            }
            list_ = list.Concat(_list).ToList();
            list_ = list_.Distinct().ToList();
            f.rtxt.Clear();
            f.rtxt.Lines = list_.ToArray();
        }

        public void Slang(List<string> list)
        {
            r = new Regex(@"^(r)\s|\s(r)\s|\s(r)$");
            are = new Regex(@"^(are)\s|\s(are)\s|\s(are)$");
            u = new Regex(@"^(u)\s|\s(u)\s|\s(u)$");
            ur = new Regex(@"^(ur)\s|\s(ur)\s|\s(ur)$");
            you = new Regex(@"^(you)\s|\s(you)\s|\s(you)$");
            your = new Regex(@"^(your)\s|\s(your)\s|\s(your)$");
            space = new Regex(@"(\s{2,})");
            space_ = new Regex(@"(^\s)|(\s)+$");


            for (int i = 0; i < list.Count; i++)
            {
                string text = list[i].ToString().ToLower();
                text = Regex.Replace(text, $@"{r}", " are ");
                text = Regex.Replace(text, $@"{ur}", " your ");
                text = Regex.Replace(text, $@"{space}", " ");
                text = Regex.Replace(text, $@"{space_}", "");
                _list.Add(text);
            }

            for (int i = 0; i < list.Count; i++)
            {
                string text = list[i].ToString().ToLower();
                text = Regex.Replace(text, $@"{are}", " r ");
                text = Regex.Replace(text, $@"{your}", " ur ");
                text = Regex.Replace(text, $@"{space}", " ");
                text = Regex.Replace(text, $@"{space_}", "");
                _list.Add(text);
            }

            for (int i = 0; i < list.Count; i++)
            {
                string text = list[i].ToString().ToLower();
                text = Regex.Replace(text, $@"{u}", " you ");
                text = Regex.Replace(text, $@"{space}", " ");
                text = Regex.Replace(text, $@"{space_}", "");
                _list.Add(text);
            }
            for (int i = 0; i < list.Count; i++)
            {
                string text = list[i].ToString().ToLower();
                text = Regex.Replace(text, $@"{you}", " u ");
                text = Regex.Replace(text, $@"{space}", " ");
                text = Regex.Replace(text, $@"{space_}", "");
                _list.Add(text);
            }

            list_ = list.Concat(_list).ToList();
            list_ = list_.Distinct().ToList();
            for (int i = 0; i < list.Count; i++)
            {
                string text = list[i].ToString().ToLower();
                text = Regex.Replace(text, $@"{s}", " is ");
                text = Regex.Replace(text, $@"{r}", " are ");
                text = Regex.Replace(text, $@"{are}", " r ");
                text = Regex.Replace(text, $@"{u}", " you ");
                text = Regex.Replace(text, $@"{you}", " u ");
                text = Regex.Replace(text, $@"{ur}", " your ");
                text = Regex.Replace(text, $@"{your}", " ur ");
                text = Regex.Replace(text, $@"{space}", " ");
                text = Regex.Replace(text, $@"{space_}", "");
                _list.Add(text);
            }
            list_ = list.Concat(_list).ToList();
            list_ = list_.Distinct().ToList();
            f.rtxt.Clear();
            f.rtxt.Lines = list_.ToArray();
            list.Clear();
            _list.Clear();
            list_.Clear();
        }
    }
}
