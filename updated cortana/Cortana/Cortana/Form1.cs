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

namespace Cortana
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        static Int64 i = 0;

        static void WalkDirectoryTree(System.IO.DirectoryInfo root, Dictionary<Int64, FileInfo> file)
        {

            List<System.IO.DirectoryInfo> store = new List<DirectoryInfo>();
            foreach (FileInfo z in root.GetFiles("*.*"))
            {
                file.Add(i, z);
                i++;
            }
            foreach (DirectoryInfo d in root.GetDirectories())
            {
                if ((d.Attributes & FileAttributes.System) != FileAttributes.System)
                {
                    store.Add(d);
                }
            }


            foreach (System.IO.DirectoryInfo dirInfo in store)
            {
                WalkDirectoryTree(dirInfo, file);
            }

        }

        private void path_TextChanged(object sender, EventArgs e)
        {

        }

        private void Next_Click(object sender, EventArgs e)
        {
            Dictionary<Int64, FileInfo> file = new Dictionary<Int64, FileInfo>();
            DirectoryInfo b = new DirectoryInfo(path.Text);
            WalkDirectoryTree(b, file);
            Dictionary<Int64, string> check = new Dictionary<Int64, string>();
            Dictionary<string, Int32> duplicate = new Dictionary<string, Int32>();
            foreach (KeyValuePair<Int64, FileInfo> x in file)
            {
                Int64 exist = 0;
                foreach (KeyValuePair<Int64, string> y in check)
                {
                    if (x.Value.Length == y.Key)
                    {
                        Duplicates.Visible = true;
                        selectall.Visible = true;
                        Delete.Visible = true;
                        Duplicates.Items.Add(x.Value.FullName);
                        duplicate.Add(x.Value.FullName, 0);
                        exist = 1;
                        break;
                    }

                }
                if (exist == 0)
                {
                    check.Add(x.Value.Length, x.Value.FullName);
                }

            }


        }

        private void ExitApp_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Duplicates_Enter(object sender, EventArgs e)
        {

        }

        private void Duplicates_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Delete_Click(object sender, EventArgs e)
        {
            i = 0;
            Dictionary<Int64, object> tobedel = new Dictionary<Int64, object>();

            foreach (object a in Duplicates.CheckedItems)
            {
                tobedel.Add(i, a);
                i++;
            }
            foreach (KeyValuePair<Int64, object> a in tobedel)
            {
                File.Delete(a.Value.ToString());
                Duplicates.Items.Remove(a);
            }
            Duplicates.Visible = false;
            path.Visible = false;
            Next.Visible = false;
            Delete.Visible = false;
            textBox2.Visible = false;
            richTextBox1.Visible = false;
            selectall.Visible = false;
            done.Visible = true;
            done.Text = "      DONE!!! Your files have been successfully deleted.";
            Duplicates.Refresh();

        }

        private void selectall_CheckedChanged(object sender, EventArgs e)
        {
            if (selectall.Checked)
            {
                for (int x = 0; x < Duplicates.Items.Count; x++)
                {
                    Duplicates.SetItemChecked(x, true);

                }
            }
            if (selectall.Checked==false)
            {
                for (int x = 0; x < Duplicates.Items.Count; x++)
                {
                    Duplicates.SetItemChecked(x, false);

                }
            }
        }

        private void done_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
