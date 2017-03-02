namespace compiler_scanner
{
    partial class frm_scanner
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
            this.txt_Keypath = new System.Windows.Forms.TextBox();
            this.btn_pathKey = new System.Windows.Forms.Button();
            this.txt_Keyword = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnReadKey = new System.Windows.Forms.Button();
            this.btn_writeKey = new System.Windows.Forms.Button();
            this.txtSearchpath = new System.Windows.Forms.TextBox();
            this.btnSearchpath = new System.Windows.Forms.Button();
            this.txt_Search = new System.Windows.Forms.TextBox();
            this.Adress_search = new System.Windows.Forms.Label();
            this.btnReadSearch = new System.Windows.Forms.Button();
            this.btnWriteserach = new System.Windows.Forms.Button();
            this.lstKeyWord = new System.Windows.Forms.ListBox();
            this.ListKeyWord = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnScane = new System.Windows.Forms.Button();
            this.lblcount = new System.Windows.Forms.Label();
            this.dataword_operator = new System.Windows.Forms.DataGridView();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.keyword = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataword_operator)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_Keypath
            // 
            this.txt_Keypath.Location = new System.Drawing.Point(12, 12);
            this.txt_Keypath.Name = "txt_Keypath";
            this.txt_Keypath.Size = new System.Drawing.Size(152, 22);
            this.txt_Keypath.TabIndex = 0;
            // 
            // btn_pathKey
            // 
            this.btn_pathKey.Location = new System.Drawing.Point(170, 12);
            this.btn_pathKey.Name = "btn_pathKey";
            this.btn_pathKey.Size = new System.Drawing.Size(74, 24);
            this.btn_pathKey.TabIndex = 1;
            this.btn_pathKey.Text = "path_key";
            this.btn_pathKey.UseVisualStyleBackColor = true;
            this.btn_pathKey.Click += new System.EventHandler(this.btn_pathKey_Click);
            // 
            // txt_Keyword
            // 
            this.txt_Keyword.Location = new System.Drawing.Point(12, 66);
            this.txt_Keyword.Multiline = true;
            this.txt_Keyword.Name = "txt_Keyword";
            this.txt_Keyword.Size = new System.Drawing.Size(152, 318);
            this.txt_Keyword.TabIndex = 2;
            this.txt_Keyword.TextChanged += new System.EventHandler(this.txt_Keyword_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Adress_Key";
            // 
            // btnReadKey
            // 
            this.btnReadKey.Location = new System.Drawing.Point(170, 174);
            this.btnReadKey.Name = "btnReadKey";
            this.btnReadKey.Size = new System.Drawing.Size(75, 23);
            this.btnReadKey.TabIndex = 4;
            this.btnReadKey.Text = "ReadKey";
            this.btnReadKey.UseVisualStyleBackColor = true;
            this.btnReadKey.Click += new System.EventHandler(this.btnReadKey_Click);
            // 
            // btn_writeKey
            // 
            this.btn_writeKey.Location = new System.Drawing.Point(170, 204);
            this.btn_writeKey.Name = "btn_writeKey";
            this.btn_writeKey.Size = new System.Drawing.Size(75, 23);
            this.btn_writeKey.TabIndex = 5;
            this.btn_writeKey.Text = "WriteKey";
            this.btn_writeKey.UseVisualStyleBackColor = true;
            this.btn_writeKey.Click += new System.EventHandler(this.btn_writeKey_Click);
            // 
            // txtSearchpath
            // 
            this.txtSearchpath.Location = new System.Drawing.Point(262, 12);
            this.txtSearchpath.Name = "txtSearchpath";
            this.txtSearchpath.Size = new System.Drawing.Size(152, 22);
            this.txtSearchpath.TabIndex = 7;
            // 
            // btnSearchpath
            // 
            this.btnSearchpath.Location = new System.Drawing.Point(420, 12);
            this.btnSearchpath.Name = "btnSearchpath";
            this.btnSearchpath.Size = new System.Drawing.Size(84, 23);
            this.btnSearchpath.TabIndex = 8;
            this.btnSearchpath.Text = "path_search";
            this.btnSearchpath.UseVisualStyleBackColor = true;
            this.btnSearchpath.Click += new System.EventHandler(this.btnSearchpath_Click);
            // 
            // txt_Search
            // 
            this.txt_Search.Location = new System.Drawing.Point(251, 66);
            this.txt_Search.Multiline = true;
            this.txt_Search.Name = "txt_Search";
            this.txt_Search.Size = new System.Drawing.Size(163, 318);
            this.txt_Search.TabIndex = 9;
            // 
            // Adress_search
            // 
            this.Adress_search.AutoSize = true;
            this.Adress_search.Location = new System.Drawing.Point(314, 37);
            this.Adress_search.Name = "Adress_search";
            this.Adress_search.Size = new System.Drawing.Size(88, 15);
            this.Adress_search.TabIndex = 10;
            this.Adress_search.Text = "Adress_Search";
            // 
            // btnReadSearch
            // 
            this.btnReadSearch.Location = new System.Drawing.Point(420, 174);
            this.btnReadSearch.Name = "btnReadSearch";
            this.btnReadSearch.Size = new System.Drawing.Size(84, 23);
            this.btnReadSearch.TabIndex = 11;
            this.btnReadSearch.Text = "ReadSearch";
            this.btnReadSearch.UseVisualStyleBackColor = true;
            this.btnReadSearch.Click += new System.EventHandler(this.btnReadSearch_Click);
            // 
            // btnWriteserach
            // 
            this.btnWriteserach.Location = new System.Drawing.Point(421, 204);
            this.btnWriteserach.Name = "btnWriteserach";
            this.btnWriteserach.Size = new System.Drawing.Size(83, 23);
            this.btnWriteserach.TabIndex = 12;
            this.btnWriteserach.Text = "WriteSearch";
            this.btnWriteserach.UseVisualStyleBackColor = true;
            this.btnWriteserach.Click += new System.EventHandler(this.btnWriteserach_Click);
            // 
            // lstKeyWord
            // 
            this.lstKeyWord.FormattingEnabled = true;
            this.lstKeyWord.ItemHeight = 15;
            this.lstKeyWord.Location = new System.Drawing.Point(510, 65);
            this.lstKeyWord.Name = "lstKeyWord";
            this.lstKeyWord.Size = new System.Drawing.Size(169, 319);
            this.lstKeyWord.TabIndex = 13;
            this.lstKeyWord.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // ListKeyWord
            // 
            this.ListKeyWord.AutoSize = true;
            this.ListKeyWord.Location = new System.Drawing.Point(510, 37);
            this.ListKeyWord.Name = "ListKeyWord";
            this.ListKeyWord.Size = new System.Drawing.Size(76, 15);
            this.ListKeyWord.TabIndex = 14;
            this.ListKeyWord.Text = "ListKeyWord";
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(421, 233);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(83, 23);
            this.btnReset.TabIndex = 15;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnScane
            // 
            this.btnScane.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnScane.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnScane.ForeColor = System.Drawing.Color.Black;
            this.btnScane.Location = new System.Drawing.Point(421, 66);
            this.btnScane.Name = "btnScane";
            this.btnScane.Size = new System.Drawing.Size(83, 29);
            this.btnScane.TabIndex = 16;
            this.btnScane.Text = "Search";
            this.btnScane.UseVisualStyleBackColor = false;
            this.btnScane.Click += new System.EventHandler(this.btnScane_Click);
            // 
            // lblcount
            // 
            this.lblcount.AutoSize = true;
            this.lblcount.Location = new System.Drawing.Point(611, 37);
            this.lblcount.Name = "lblcount";
            this.lblcount.Size = new System.Drawing.Size(14, 15);
            this.lblcount.TabIndex = 17;
            this.lblcount.Text = "0";
            // 
            // dataword_operator
            // 
            this.dataword_operator.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataword_operator.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column2,
            this.keyword,
            this.Column1});
            this.dataword_operator.Location = new System.Drawing.Point(697, 65);
            this.dataword_operator.Name = "dataword_operator";
            this.dataword_operator.Size = new System.Drawing.Size(286, 318);
            this.dataword_operator.TabIndex = 20;
            this.dataword_operator.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataword_operator_CellFormatting);
            this.dataword_operator.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dataword_operator_KeyDown);
            // 
            // Column2
            // 
            this.Column2.HeaderText = "#";
            this.Column2.Name = "Column2";
            this.Column2.Width = 25;
            // 
            // keyword
            // 
            this.keyword.HeaderText = "keyword";
            this.keyword.Name = "keyword";
            this.keyword.Width = 83;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "operator";
            this.Column1.Name = "Column1";
            this.Column1.Width = 60;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Fuchsia;
            this.button1.Location = new System.Drawing.Point(964, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(39, 22);
            this.button1.TabIndex = 21;
            this.button1.Text = "Exit";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Red;
            this.pictureBox1.Image = global::compiler_scanner.Properties.Resources.Pimg;
            this.pictureBox1.Location = new System.Drawing.Point(430, 101);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(65, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            // 
            // frm_scanner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(1004, 396);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataword_operator);
            this.Controls.Add(this.lblcount);
            this.Controls.Add(this.btnScane);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.ListKeyWord);
            this.Controls.Add(this.lstKeyWord);
            this.Controls.Add(this.btnWriteserach);
            this.Controls.Add(this.btnReadSearch);
            this.Controls.Add(this.Adress_search);
            this.Controls.Add(this.txt_Search);
            this.Controls.Add(this.btnSearchpath);
            this.Controls.Add(this.txtSearchpath);
            this.Controls.Add(this.btn_writeKey);
            this.Controls.Add(this.btnReadKey);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_Keyword);
            this.Controls.Add(this.btn_pathKey);
            this.Controls.Add(this.txt_Keypath);
            this.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Name = "frm_scanner";
            this.Text = "Scanner";
            this.Load += new System.EventHandler(this.frm_scanner_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataword_operator)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_Keypath;
        private System.Windows.Forms.Button btn_pathKey;
        private System.Windows.Forms.TextBox txt_Keyword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnReadKey;
        private System.Windows.Forms.Button btn_writeKey;
        private System.Windows.Forms.TextBox txtSearchpath;
        private System.Windows.Forms.Button btnSearchpath;
        private System.Windows.Forms.TextBox txt_Search;
        private System.Windows.Forms.Label Adress_search;
        private System.Windows.Forms.Button btnReadSearch;
        private System.Windows.Forms.Button btnWriteserach;
        private System.Windows.Forms.ListBox lstKeyWord;
        private System.Windows.Forms.Label ListKeyWord;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnScane;
        private System.Windows.Forms.Label lblcount;
        private System.Windows.Forms.DataGridView dataword_operator;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn keyword;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

