using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//___________________ usings
using System.IO;


namespace compiler_scanner
{
    public partial class frm_scanner : Form
    {
        public frm_scanner()
        {
            InitializeComponent();
        }

        private void btn_pathKey_Click(object sender, EventArgs e)
        {
            OpenFileDialog openpath = new OpenFileDialog();
            if (openpath.ShowDialog() == DialogResult.OK)
            {
                txt_Keypath.Text = openpath.FileName;
            }
        }

        private void btnReadKey_Click(object sender, EventArgs e)
        {
            if (txt_Keypath.Text.Trim() != "")
            {
                using (StreamReader sr = new StreamReader(txt_Keypath.Text))
                {
                    txt_Keyword.Text = sr.ReadToEnd();
                }
            }
            else
            {
                MessageBox.Show(".لطفا آدرس فایل کلمات کلیدی را وارد کنید ");
            }
        }

        private void txt_Keyword_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_writeKey_Click(object sender, EventArgs e)
        {
            if (txt_Keyword.Text.Trim() != "")
            {
                SaveFileDialog save = new SaveFileDialog();
                if (save.ShowDialog() == DialogResult.OK)
                {
                    using (StreamWriter sw = new StreamWriter(save.FileName))
                    {
                        sw.Write(txt_Keyword.Text);
                    }
                }
            }
            else
            {
                MessageBox.Show(".لطفا داده ها را وارد کنید ");
            }
        }

        private void frm_scanner_Load(object sender, EventArgs e)
        {
            pictureBox1.Visible = false;
        }

        private void btnSearchpath_Click(object sender, EventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            if (op.ShowDialog() == DialogResult.OK)
            {
                txtSearchpath.Text = op.FileName;
            }
        }

        private void btnReadSearch_Click(object sender, EventArgs e)
        {
            if (txtSearchpath.Text.Trim() != "")
            {
                using (StreamReader sr = new StreamReader(txtSearchpath.Text))
                {
                    txt_Search.Text = sr.ReadToEnd();
                }
            }
            else
            {
                MessageBox.Show(".لطفا آدرس فایل کلماتی که میخواهید جستجو کنید را وارد کنید ");
            }
        }

        private void btnWriteserach_Click(object sender, EventArgs e)
        {
            if (txt_Search.Text.Trim() != "")
            {
                SaveFileDialog save = new SaveFileDialog();
                if (save.ShowDialog() == DialogResult.OK)
                {
                    using (StreamWriter sw = new StreamWriter(save.FileName))
                    {
                        sw.Write(txt_Search.Text);
                    }
                }
            }
            else
            {
                MessageBox.Show(".لطفا داده ها را وارد کنید ");
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txt_Search.Text = "";
            txtSearchpath.Text = "";
            txt_Keyword.Text = "";
            txt_Keypath.Text = "";
            lstKeyWord.Text = "";
            lstKeyWord.Items.Clear();
            dataword_operator.Rows.Clear();
            lblcount.Text = "0";
            if (dataword_operator.RowCount != 1)
            {
                dataword_operator.Rows.Remove(dataword_operator.CurrentRow);
            }
            MessageBox.Show("Reset Data.");
        }

        private void btnScane_Click(object sender, EventArgs e)
        {
            lstKeyWord.Items.Clear();
            dataword_operator.Rows.Clear();
            lblcount.Text = "";
            if (txt_Search.Text.Trim() == "")
                MessageBox.Show(".لطفا کلماتی را که میخواهید جستجو کنید را وارد کنید ");
            if (txt_Keyword.Text.Trim() != "")
            {
                int index = 0;
                string[] StrArray1 = txt_Keyword.Text.Split(' ', '\n', ',');
                string[] StrArray2 = txt_Search.Text.Split(' ', '\n', ',');
                foreach (string Str1 in StrArray1)
                {
                    foreach (string Str2 in StrArray2)
                    {
                        //if ( Str1 == "<"  || Str1 == ">" ||
                        //      Str1 == "=<" || Str1 == ">=" || Str1 == "=" ||
                        //      Str1 == "==" || Str1 == "!"  || Str1 == "@" ||
                        //      Str1 == "#"  || Str1 == "$"  || Str1 == "%" ||
                        //      Str1 == "^"  || Str1 == "&"  || Str1 == "*" ||
                        //      Str1 == "("  || Str1 == ")"  || Str1 == "+" ||
                        //      Str1 == "-"  || Str1 == "/"  || Str1 == "0" )
                        //  {
                        //      Str3 = Str1;
                        //  }

                        pictureBox1.Visible = true;
                        if (Str1 == Str2)
                        {
                            lstKeyWord.Items.Add(Str1);
                            index++;
                            dataword_operator.Rows.Add("", Str1);
                            
                        }
                    }
                }
                lblcount.Text = index.ToString();
            }
            else
            {
                MessageBox.Show(".لطفا کلمات کلیدی را وارد کنید");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dataword_operator_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            dataword_operator.Rows[e.RowIndex].Cells[0].Value = e.RowIndex + 1;
        }

        private void dataword_operator_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete && dataword_operator.RowCount != 1)
            {
                dataword_operator.Rows.Remove(dataword_operator.CurrentRow);
            }
        }
    }
}
