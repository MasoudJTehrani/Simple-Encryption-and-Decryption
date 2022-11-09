namespace Encryption_and_Decryption
{
    partial class Form1
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
            this.Encrypt = new FontAwesome.Sharp.IconButton();
            this.Decrypt = new FontAwesome.Sharp.IconButton();
            this.EncPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.BrowsePtext = new FontAwesome.Sharp.IconButton();
            this.PtextPrevEnc = new System.Windows.Forms.Label();
            this.AngleRight = new FontAwesome.Sharp.IconPictureBox();
            this.PlainTextPrevEnc = new System.Windows.Forms.RichTextBox();
            this.Encbtn = new FontAwesome.Sharp.IconButton();
            this.DownloadCbtn = new FontAwesome.Sharp.IconButton();
            this.CtextPrevEnc = new System.Windows.Forms.Label();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.CryptoTextPrevEnc = new System.Windows.Forms.RichTextBox();
            this.KeyPanel = new System.Windows.Forms.Panel();
            this.keyTpreview = new System.Windows.Forms.RichTextBox();
            this.iconPictureBox2 = new FontAwesome.Sharp.IconPictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.DecPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.BrowseCtext = new FontAwesome.Sharp.IconButton();
            this.label2 = new System.Windows.Forms.Label();
            this.iconPictureBox3 = new FontAwesome.Sharp.IconPictureBox();
            this.CryptoTextPrevDec = new System.Windows.Forms.RichTextBox();
            this.Decbtn = new FontAwesome.Sharp.IconButton();
            this.DownloadPbtn = new FontAwesome.Sharp.IconButton();
            this.label3 = new System.Windows.Forms.Label();
            this.iconPictureBox4 = new FontAwesome.Sharp.IconPictureBox();
            this.PlainTextPrevDec = new System.Windows.Forms.RichTextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.label5 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Cryptanalysispanel = new System.Windows.Forms.Panel();
            this.CAdownloadKey = new FontAwesome.Sharp.IconButton();
            this.CAkeyprev = new System.Windows.Forms.RichTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.FindKeybtn = new FontAwesome.Sharp.IconButton();
            this.CActextprev = new System.Windows.Forms.RichTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.CAbrowseCtext = new FontAwesome.Sharp.IconButton();
            this.CAptextprev = new System.Windows.Forms.RichTextBox();
            this.iconPictureBox5 = new FontAwesome.Sharp.IconPictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.CAbrowsePtext = new FontAwesome.Sharp.IconButton();
            this.iconPictureBox7 = new FontAwesome.Sharp.IconPictureBox();
            this.Analysebtn = new FontAwesome.Sharp.IconButton();
            this.loading = new FontAwesome.Sharp.IconButton();
            this.EncPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AngleRight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            this.KeyPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox2)).BeginInit();
            this.DecPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox4)).BeginInit();
            this.Cryptanalysispanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox7)).BeginInit();
            this.SuspendLayout();
            // 
            // Encrypt
            // 
            this.Encrypt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.Encrypt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Encrypt.FlatAppearance.BorderColor = System.Drawing.Color.Navy;
            this.Encrypt.FlatAppearance.BorderSize = 5;
            this.Encrypt.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Encrypt.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Encrypt.ForeColor = System.Drawing.Color.LimeGreen;
            this.Encrypt.IconChar = FontAwesome.Sharp.IconChar.Lock;
            this.Encrypt.IconColor = System.Drawing.Color.LimeGreen;
            this.Encrypt.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Encrypt.Location = new System.Drawing.Point(369, 12);
            this.Encrypt.Name = "Encrypt";
            this.Encrypt.Size = new System.Drawing.Size(345, 60);
            this.Encrypt.TabIndex = 0;
            this.Encrypt.Text = "Encrypt";
            this.Encrypt.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Encrypt.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Encrypt.UseVisualStyleBackColor = false;
            this.Encrypt.Click += new System.EventHandler(this.Encrypt_Click);
            // 
            // Decrypt
            // 
            this.Decrypt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.Decrypt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Decrypt.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.Decrypt.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Decrypt.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Decrypt.ForeColor = System.Drawing.Color.OrangeRed;
            this.Decrypt.IconChar = FontAwesome.Sharp.IconChar.LockOpen;
            this.Decrypt.IconColor = System.Drawing.Color.OrangeRed;
            this.Decrypt.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Decrypt.Location = new System.Drawing.Point(759, 12);
            this.Decrypt.Name = "Decrypt";
            this.Decrypt.Size = new System.Drawing.Size(315, 60);
            this.Decrypt.TabIndex = 1;
            this.Decrypt.Text = "Decrypt";
            this.Decrypt.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Decrypt.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Decrypt.UseVisualStyleBackColor = false;
            this.Decrypt.Click += new System.EventHandler(this.Decrypt_Click);
            // 
            // EncPanel
            // 
            this.EncPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(60)))));
            this.EncPanel.Controls.Add(this.BrowsePtext);
            this.EncPanel.Controls.Add(this.PtextPrevEnc);
            this.EncPanel.Controls.Add(this.AngleRight);
            this.EncPanel.Controls.Add(this.PlainTextPrevEnc);
            this.EncPanel.Controls.Add(this.Encbtn);
            this.EncPanel.Controls.Add(this.DownloadCbtn);
            this.EncPanel.Controls.Add(this.CtextPrevEnc);
            this.EncPanel.Controls.Add(this.iconPictureBox1);
            this.EncPanel.Controls.Add(this.CryptoTextPrevEnc);
            this.EncPanel.Location = new System.Drawing.Point(12, 78);
            this.EncPanel.Name = "EncPanel";
            this.EncPanel.Padding = new System.Windows.Forms.Padding(20);
            this.EncPanel.Size = new System.Drawing.Size(1062, 353);
            this.EncPanel.TabIndex = 2;
            this.EncPanel.Visible = false;
            // 
            // BrowsePtext
            // 
            this.BrowsePtext.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.BrowsePtext.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BrowsePtext.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BrowsePtext.ForeColor = System.Drawing.Color.White;
            this.BrowsePtext.IconChar = FontAwesome.Sharp.IconChar.FolderOpen;
            this.BrowsePtext.IconColor = System.Drawing.Color.White;
            this.BrowsePtext.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BrowsePtext.Location = new System.Drawing.Point(23, 23);
            this.BrowsePtext.Name = "BrowsePtext";
            this.BrowsePtext.Size = new System.Drawing.Size(170, 97);
            this.BrowsePtext.TabIndex = 0;
            this.BrowsePtext.Text = "Browse \r\nPlain-Text";
            this.BrowsePtext.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.BrowsePtext.UseVisualStyleBackColor = false;
            this.BrowsePtext.Click += new System.EventHandler(this.BrowsePtext_Click);
            // 
            // PtextPrevEnc
            // 
            this.PtextPrevEnc.AutoSize = true;
            this.PtextPrevEnc.Dock = System.Windows.Forms.DockStyle.Left;
            this.PtextPrevEnc.ForeColor = System.Drawing.Color.White;
            this.PtextPrevEnc.Location = new System.Drawing.Point(216, 20);
            this.PtextPrevEnc.Margin = new System.Windows.Forms.Padding(20, 0, 3, 0);
            this.PtextPrevEnc.Name = "PtextPrevEnc";
            this.PtextPrevEnc.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.PtextPrevEnc.Size = new System.Drawing.Size(131, 103);
            this.PtextPrevEnc.TabIndex = 1;
            this.PtextPrevEnc.Text = "Plain-Text preview  \r\nin binary";
            this.PtextPrevEnc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AngleRight
            // 
            this.AngleRight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(60)))));
            this.AngleRight.Dock = System.Windows.Forms.DockStyle.Left;
            this.AngleRight.ForeColor = System.Drawing.Color.LimeGreen;
            this.AngleRight.IconChar = FontAwesome.Sharp.IconChar.AngleRight;
            this.AngleRight.IconColor = System.Drawing.Color.LimeGreen;
            this.AngleRight.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.AngleRight.Location = new System.Drawing.Point(353, 23);
            this.AngleRight.Name = "AngleRight";
            this.AngleRight.Size = new System.Drawing.Size(32, 97);
            this.AngleRight.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.AngleRight.TabIndex = 2;
            this.AngleRight.TabStop = false;
            // 
            // PlainTextPrevEnc
            // 
            this.PlainTextPrevEnc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(90)))));
            this.PlainTextPrevEnc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PlainTextPrevEnc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PlainTextPrevEnc.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlainTextPrevEnc.ForeColor = System.Drawing.Color.White;
            this.PlainTextPrevEnc.Location = new System.Drawing.Point(391, 23);
            this.PlainTextPrevEnc.Name = "PlainTextPrevEnc";
            this.PlainTextPrevEnc.ReadOnly = true;
            this.PlainTextPrevEnc.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.PlainTextPrevEnc.Size = new System.Drawing.Size(611, 97);
            this.PlainTextPrevEnc.TabIndex = 4;
            this.PlainTextPrevEnc.Text = "";
            // 
            // Encbtn
            // 
            this.Encbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.Encbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Encbtn.FlatAppearance.BorderSize = 3;
            this.Encbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Encbtn.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Encbtn.ForeColor = System.Drawing.Color.LimeGreen;
            this.Encbtn.IconChar = FontAwesome.Sharp.IconChar.AngleDown;
            this.Encbtn.IconColor = System.Drawing.Color.LimeGreen;
            this.Encbtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Encbtn.Location = new System.Drawing.Point(620, 143);
            this.Encbtn.Margin = new System.Windows.Forms.Padding(600, 20, 200, 20);
            this.Encbtn.Name = "Encbtn";
            this.Encbtn.Padding = new System.Windows.Forms.Padding(5);
            this.Encbtn.Size = new System.Drawing.Size(152, 70);
            this.Encbtn.TabIndex = 5;
            this.Encbtn.Text = "Encrypt";
            this.Encbtn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.Encbtn.UseVisualStyleBackColor = false;
            this.Encbtn.Click += new System.EventHandler(this.Encbtn_Click);
            // 
            // DownloadCbtn
            // 
            this.DownloadCbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.DownloadCbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DownloadCbtn.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DownloadCbtn.ForeColor = System.Drawing.Color.White;
            this.DownloadCbtn.IconChar = FontAwesome.Sharp.IconChar.Download;
            this.DownloadCbtn.IconColor = System.Drawing.Color.White;
            this.DownloadCbtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.DownloadCbtn.Location = new System.Drawing.Point(23, 236);
            this.DownloadCbtn.Name = "DownloadCbtn";
            this.DownloadCbtn.Size = new System.Drawing.Size(170, 97);
            this.DownloadCbtn.TabIndex = 6;
            this.DownloadCbtn.Text = "Download Crypto-Text";
            this.DownloadCbtn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.DownloadCbtn.UseVisualStyleBackColor = false;
            this.DownloadCbtn.Click += new System.EventHandler(this.DownloadCbtn_Click);
            // 
            // CtextPrevEnc
            // 
            this.CtextPrevEnc.AutoSize = true;
            this.CtextPrevEnc.Dock = System.Windows.Forms.DockStyle.Left;
            this.CtextPrevEnc.ForeColor = System.Drawing.Color.White;
            this.CtextPrevEnc.Location = new System.Drawing.Point(216, 233);
            this.CtextPrevEnc.Margin = new System.Windows.Forms.Padding(20, 0, 3, 0);
            this.CtextPrevEnc.Name = "CtextPrevEnc";
            this.CtextPrevEnc.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.CtextPrevEnc.Size = new System.Drawing.Size(133, 103);
            this.CtextPrevEnc.TabIndex = 7;
            this.CtextPrevEnc.Text = "Crypto-Text preview\r\nin binary";
            this.CtextPrevEnc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(60)))));
            this.iconPictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.iconPictureBox1.ForeColor = System.Drawing.Color.LimeGreen;
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.AngleRight;
            this.iconPictureBox1.IconColor = System.Drawing.Color.LimeGreen;
            this.iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox1.Location = new System.Drawing.Point(355, 236);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(32, 97);
            this.iconPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.iconPictureBox1.TabIndex = 8;
            this.iconPictureBox1.TabStop = false;
            // 
            // CryptoTextPrevEnc
            // 
            this.CryptoTextPrevEnc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(90)))));
            this.CryptoTextPrevEnc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CryptoTextPrevEnc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CryptoTextPrevEnc.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CryptoTextPrevEnc.ForeColor = System.Drawing.Color.White;
            this.CryptoTextPrevEnc.Location = new System.Drawing.Point(393, 236);
            this.CryptoTextPrevEnc.Name = "CryptoTextPrevEnc";
            this.CryptoTextPrevEnc.ReadOnly = true;
            this.CryptoTextPrevEnc.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.CryptoTextPrevEnc.Size = new System.Drawing.Size(609, 97);
            this.CryptoTextPrevEnc.TabIndex = 9;
            this.CryptoTextPrevEnc.Text = "";
            // 
            // KeyPanel
            // 
            this.KeyPanel.Controls.Add(this.keyTpreview);
            this.KeyPanel.Controls.Add(this.iconPictureBox2);
            this.KeyPanel.Controls.Add(this.label1);
            this.KeyPanel.Controls.Add(this.iconButton1);
            this.KeyPanel.Location = new System.Drawing.Point(12, 437);
            this.KeyPanel.Name = "KeyPanel";
            this.KeyPanel.Size = new System.Drawing.Size(1062, 109);
            this.KeyPanel.TabIndex = 3;
            // 
            // keyTpreview
            // 
            this.keyTpreview.BackColor = System.Drawing.Color.Olive;
            this.keyTpreview.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.keyTpreview.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.keyTpreview.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.keyTpreview.ForeColor = System.Drawing.Color.White;
            this.keyTpreview.Location = new System.Drawing.Point(416, 23);
            this.keyTpreview.Name = "keyTpreview";
            this.keyTpreview.ReadOnly = true;
            this.keyTpreview.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.keyTpreview.Size = new System.Drawing.Size(609, 67);
            this.keyTpreview.TabIndex = 10;
            this.keyTpreview.Text = "";
            // 
            // iconPictureBox2
            // 
            this.iconPictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.iconPictureBox2.ForeColor = System.Drawing.Color.Gold;
            this.iconPictureBox2.IconChar = FontAwesome.Sharp.IconChar.AngleDoubleRight;
            this.iconPictureBox2.IconColor = System.Drawing.Color.Gold;
            this.iconPictureBox2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox2.Location = new System.Drawing.Point(378, 50);
            this.iconPictureBox2.Name = "iconPictureBox2";
            this.iconPictureBox2.Size = new System.Drawing.Size(32, 32);
            this.iconPictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.iconPictureBox2.TabIndex = 9;
            this.iconPictureBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Gold;
            this.label1.Location = new System.Drawing.Point(214, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Key preview in binary";
            // 
            // iconButton1
            // 
            this.iconButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.iconButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconButton1.FlatAppearance.BorderColor = System.Drawing.Color.Goldenrod;
            this.iconButton1.FlatAppearance.BorderSize = 3;
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton1.ForeColor = System.Drawing.Color.Gold;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.Key;
            this.iconButton1.IconColor = System.Drawing.Color.Gold;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.Location = new System.Drawing.Point(24, 23);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(170, 67);
            this.iconButton1.TabIndex = 0;
            this.iconButton1.Text = "Browse Key";
            this.iconButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.iconButton1.UseVisualStyleBackColor = false;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // DecPanel
            // 
            this.DecPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(60)))));
            this.DecPanel.Controls.Add(this.BrowseCtext);
            this.DecPanel.Controls.Add(this.label2);
            this.DecPanel.Controls.Add(this.iconPictureBox3);
            this.DecPanel.Controls.Add(this.CryptoTextPrevDec);
            this.DecPanel.Controls.Add(this.Decbtn);
            this.DecPanel.Controls.Add(this.DownloadPbtn);
            this.DecPanel.Controls.Add(this.label3);
            this.DecPanel.Controls.Add(this.iconPictureBox4);
            this.DecPanel.Controls.Add(this.PlainTextPrevDec);
            this.DecPanel.Location = new System.Drawing.Point(12, 78);
            this.DecPanel.Name = "DecPanel";
            this.DecPanel.Padding = new System.Windows.Forms.Padding(20);
            this.DecPanel.Size = new System.Drawing.Size(1062, 353);
            this.DecPanel.TabIndex = 10;
            this.DecPanel.Visible = false;
            // 
            // BrowseCtext
            // 
            this.BrowseCtext.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.BrowseCtext.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BrowseCtext.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BrowseCtext.ForeColor = System.Drawing.Color.White;
            this.BrowseCtext.IconChar = FontAwesome.Sharp.IconChar.FolderOpen;
            this.BrowseCtext.IconColor = System.Drawing.Color.White;
            this.BrowseCtext.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BrowseCtext.Location = new System.Drawing.Point(23, 23);
            this.BrowseCtext.Name = "BrowseCtext";
            this.BrowseCtext.Size = new System.Drawing.Size(170, 97);
            this.BrowseCtext.TabIndex = 0;
            this.BrowseCtext.Text = "Browse \r\nCrypto-Text";
            this.BrowseCtext.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.BrowseCtext.UseVisualStyleBackColor = false;
            this.BrowseCtext.Click += new System.EventHandler(this.BrowseCtext_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Left;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(216, 20);
            this.label2.Margin = new System.Windows.Forms.Padding(20, 0, 3, 0);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(133, 103);
            this.label2.TabIndex = 1;
            this.label2.Text = "Crypto-Text preview\r\nin binary";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // iconPictureBox3
            // 
            this.iconPictureBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(60)))));
            this.iconPictureBox3.Dock = System.Windows.Forms.DockStyle.Left;
            this.iconPictureBox3.ForeColor = System.Drawing.Color.OrangeRed;
            this.iconPictureBox3.IconChar = FontAwesome.Sharp.IconChar.AngleRight;
            this.iconPictureBox3.IconColor = System.Drawing.Color.OrangeRed;
            this.iconPictureBox3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox3.Location = new System.Drawing.Point(355, 23);
            this.iconPictureBox3.Name = "iconPictureBox3";
            this.iconPictureBox3.Size = new System.Drawing.Size(32, 97);
            this.iconPictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.iconPictureBox3.TabIndex = 2;
            this.iconPictureBox3.TabStop = false;
            // 
            // CryptoTextPrevDec
            // 
            this.CryptoTextPrevDec.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(90)))));
            this.CryptoTextPrevDec.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CryptoTextPrevDec.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.CryptoTextPrevDec.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CryptoTextPrevDec.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CryptoTextPrevDec.ForeColor = System.Drawing.Color.White;
            this.CryptoTextPrevDec.Location = new System.Drawing.Point(393, 23);
            this.CryptoTextPrevDec.Name = "CryptoTextPrevDec";
            this.CryptoTextPrevDec.ReadOnly = true;
            this.CryptoTextPrevDec.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.CryptoTextPrevDec.Size = new System.Drawing.Size(611, 97);
            this.CryptoTextPrevDec.TabIndex = 4;
            this.CryptoTextPrevDec.Text = "";
            // 
            // Decbtn
            // 
            this.Decbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.Decbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Decbtn.FlatAppearance.BorderSize = 3;
            this.Decbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Decbtn.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Decbtn.ForeColor = System.Drawing.Color.OrangeRed;
            this.Decbtn.IconChar = FontAwesome.Sharp.IconChar.AngleDown;
            this.Decbtn.IconColor = System.Drawing.Color.OrangeRed;
            this.Decbtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Decbtn.Location = new System.Drawing.Point(620, 143);
            this.Decbtn.Margin = new System.Windows.Forms.Padding(600, 20, 200, 20);
            this.Decbtn.Name = "Decbtn";
            this.Decbtn.Padding = new System.Windows.Forms.Padding(5);
            this.Decbtn.Size = new System.Drawing.Size(152, 70);
            this.Decbtn.TabIndex = 5;
            this.Decbtn.Text = "Decrypt";
            this.Decbtn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.Decbtn.UseVisualStyleBackColor = false;
            this.Decbtn.Click += new System.EventHandler(this.Decbtn_Click);
            // 
            // DownloadPbtn
            // 
            this.DownloadPbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.DownloadPbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DownloadPbtn.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DownloadPbtn.ForeColor = System.Drawing.Color.White;
            this.DownloadPbtn.IconChar = FontAwesome.Sharp.IconChar.Download;
            this.DownloadPbtn.IconColor = System.Drawing.Color.White;
            this.DownloadPbtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.DownloadPbtn.Location = new System.Drawing.Point(23, 236);
            this.DownloadPbtn.Name = "DownloadPbtn";
            this.DownloadPbtn.Size = new System.Drawing.Size(170, 97);
            this.DownloadPbtn.TabIndex = 6;
            this.DownloadPbtn.Text = "Download Plain-Text";
            this.DownloadPbtn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.DownloadPbtn.UseVisualStyleBackColor = false;
            this.DownloadPbtn.Click += new System.EventHandler(this.DownloadPbtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Left;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(216, 233);
            this.label3.Margin = new System.Windows.Forms.Padding(20, 0, 3, 0);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label3.Size = new System.Drawing.Size(131, 103);
            this.label3.TabIndex = 7;
            this.label3.Text = "Plain-Text preview  \r\nin binary";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // iconPictureBox4
            // 
            this.iconPictureBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(60)))));
            this.iconPictureBox4.Dock = System.Windows.Forms.DockStyle.Left;
            this.iconPictureBox4.ForeColor = System.Drawing.Color.OrangeRed;
            this.iconPictureBox4.IconChar = FontAwesome.Sharp.IconChar.AngleRight;
            this.iconPictureBox4.IconColor = System.Drawing.Color.OrangeRed;
            this.iconPictureBox4.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox4.Location = new System.Drawing.Point(353, 236);
            this.iconPictureBox4.Name = "iconPictureBox4";
            this.iconPictureBox4.Size = new System.Drawing.Size(32, 97);
            this.iconPictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.iconPictureBox4.TabIndex = 8;
            this.iconPictureBox4.TabStop = false;
            // 
            // PlainTextPrevDec
            // 
            this.PlainTextPrevDec.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(90)))));
            this.PlainTextPrevDec.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PlainTextPrevDec.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.PlainTextPrevDec.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PlainTextPrevDec.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlainTextPrevDec.ForeColor = System.Drawing.Color.White;
            this.PlainTextPrevDec.Location = new System.Drawing.Point(391, 236);
            this.PlainTextPrevDec.Name = "PlainTextPrevDec";
            this.PlainTextPrevDec.ReadOnly = true;
            this.PlainTextPrevDec.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.PlainTextPrevDec.Size = new System.Drawing.Size(609, 97);
            this.PlainTextPrevDec.TabIndex = 9;
            this.PlainTextPrevDec.Text = "";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Cyan;
            this.label5.Location = new System.Drawing.Point(238, 6);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(510, 21);
            this.label5.TabIndex = 12;
            this.label5.Text = "Try to find the Key by analysing Crypto-text and Plain-text";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Cyan;
            this.panel2.ForeColor = System.Drawing.Color.Cyan;
            this.panel2.Location = new System.Drawing.Point(0, 28);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1061, 6);
            this.panel2.TabIndex = 13;
            // 
            // Cryptanalysispanel
            // 
            this.Cryptanalysispanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(60)))));
            this.Cryptanalysispanel.Controls.Add(this.CAdownloadKey);
            this.Cryptanalysispanel.Controls.Add(this.CAkeyprev);
            this.Cryptanalysispanel.Controls.Add(this.label8);
            this.Cryptanalysispanel.Controls.Add(this.FindKeybtn);
            this.Cryptanalysispanel.Controls.Add(this.CActextprev);
            this.Cryptanalysispanel.Controls.Add(this.panel2);
            this.Cryptanalysispanel.Controls.Add(this.label5);
            this.Cryptanalysispanel.Controls.Add(this.label7);
            this.Cryptanalysispanel.Controls.Add(this.CAbrowseCtext);
            this.Cryptanalysispanel.Controls.Add(this.CAptextprev);
            this.Cryptanalysispanel.Controls.Add(this.iconPictureBox5);
            this.Cryptanalysispanel.Controls.Add(this.label6);
            this.Cryptanalysispanel.Controls.Add(this.CAbrowsePtext);
            this.Cryptanalysispanel.Controls.Add(this.iconPictureBox7);
            this.Cryptanalysispanel.Location = new System.Drawing.Point(12, 78);
            this.Cryptanalysispanel.Name = "Cryptanalysispanel";
            this.Cryptanalysispanel.Size = new System.Drawing.Size(1062, 353);
            this.Cryptanalysispanel.TabIndex = 14;
            this.Cryptanalysispanel.Visible = false;
            // 
            // CAdownloadKey
            // 
            this.CAdownloadKey.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.CAdownloadKey.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CAdownloadKey.FlatAppearance.BorderColor = System.Drawing.Color.Goldenrod;
            this.CAdownloadKey.FlatAppearance.BorderSize = 3;
            this.CAdownloadKey.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CAdownloadKey.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CAdownloadKey.ForeColor = System.Drawing.Color.Gold;
            this.CAdownloadKey.IconChar = FontAwesome.Sharp.IconChar.Download;
            this.CAdownloadKey.IconColor = System.Drawing.Color.Gold;
            this.CAdownloadKey.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.CAdownloadKey.Location = new System.Drawing.Point(746, 268);
            this.CAdownloadKey.Name = "CAdownloadKey";
            this.CAdownloadKey.Size = new System.Drawing.Size(170, 67);
            this.CAdownloadKey.TabIndex = 11;
            this.CAdownloadKey.Text = "Download Key";
            this.CAdownloadKey.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.CAdownloadKey.UseVisualStyleBackColor = false;
            this.CAdownloadKey.Click += new System.EventHandler(this.CAdownloadKey_Click);
            // 
            // CAkeyprev
            // 
            this.CAkeyprev.BackColor = System.Drawing.Color.Olive;
            this.CAkeyprev.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CAkeyprev.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.CAkeyprev.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CAkeyprev.ForeColor = System.Drawing.Color.White;
            this.CAkeyprev.Location = new System.Drawing.Point(619, 112);
            this.CAkeyprev.Name = "CAkeyprev";
            this.CAkeyprev.ReadOnly = true;
            this.CAkeyprev.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.CAkeyprev.Size = new System.Drawing.Size(405, 133);
            this.CAkeyprev.TabIndex = 19;
            this.CAkeyprev.Text = "";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.Gold;
            this.label8.Location = new System.Drawing.Point(755, 68);
            this.label8.Margin = new System.Windows.Forms.Padding(20, 0, 3, 0);
            this.label8.Name = "label8";
            this.label8.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label8.Size = new System.Drawing.Size(142, 17);
            this.label8.TabIndex = 18;
            this.label8.Text = "Key preview in binary";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FindKeybtn
            // 
            this.FindKeybtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.FindKeybtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FindKeybtn.FlatAppearance.BorderColor = System.Drawing.Color.Teal;
            this.FindKeybtn.FlatAppearance.BorderSize = 3;
            this.FindKeybtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FindKeybtn.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FindKeybtn.ForeColor = System.Drawing.Color.Gold;
            this.FindKeybtn.IconChar = FontAwesome.Sharp.IconChar.AngleRight;
            this.FindKeybtn.IconColor = System.Drawing.Color.Gold;
            this.FindKeybtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.FindKeybtn.IconSize = 35;
            this.FindKeybtn.Location = new System.Drawing.Point(429, 159);
            this.FindKeybtn.Name = "FindKeybtn";
            this.FindKeybtn.Size = new System.Drawing.Size(168, 71);
            this.FindKeybtn.TabIndex = 17;
            this.FindKeybtn.Text = "Find the key";
            this.FindKeybtn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.FindKeybtn.UseVisualStyleBackColor = false;
            this.FindKeybtn.Click += new System.EventHandler(this.FindKeybtn_Click);
            // 
            // CActextprev
            // 
            this.CActextprev.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(90)))));
            this.CActextprev.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CActextprev.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CActextprev.ForeColor = System.Drawing.Color.White;
            this.CActextprev.Location = new System.Drawing.Point(239, 233);
            this.CActextprev.Name = "CActextprev";
            this.CActextprev.ReadOnly = true;
            this.CActextprev.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.CActextprev.Size = new System.Drawing.Size(170, 111);
            this.CActextprev.TabIndex = 16;
            this.CActextprev.Text = "";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(248, 156);
            this.label7.Margin = new System.Windows.Forms.Padding(20, 0, 3, 0);
            this.label7.Name = "label7";
            this.label7.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label7.Size = new System.Drawing.Size(141, 34);
            this.label7.TabIndex = 12;
            this.label7.Text = "Crypto-Text preview  \r\nin binary";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CAbrowseCtext
            // 
            this.CAbrowseCtext.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.CAbrowseCtext.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CAbrowseCtext.FlatAppearance.BorderColor = System.Drawing.Color.Teal;
            this.CAbrowseCtext.FlatAppearance.BorderSize = 3;
            this.CAbrowseCtext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CAbrowseCtext.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CAbrowseCtext.ForeColor = System.Drawing.Color.LimeGreen;
            this.CAbrowseCtext.IconChar = FontAwesome.Sharp.IconChar.Folder;
            this.CAbrowseCtext.IconColor = System.Drawing.Color.DarkTurquoise;
            this.CAbrowseCtext.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.CAbrowseCtext.Location = new System.Drawing.Point(239, 68);
            this.CAbrowseCtext.Name = "CAbrowseCtext";
            this.CAbrowseCtext.Size = new System.Drawing.Size(170, 67);
            this.CAbrowseCtext.TabIndex = 11;
            this.CAbrowseCtext.Text = "Browse Crypto-text";
            this.CAbrowseCtext.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.CAbrowseCtext.UseVisualStyleBackColor = false;
            this.CAbrowseCtext.Click += new System.EventHandler(this.CAbrowseCtext_Click);
            // 
            // CAptextprev
            // 
            this.CAptextprev.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(90)))));
            this.CAptextprev.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CAptextprev.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CAptextprev.ForeColor = System.Drawing.Color.White;
            this.CAptextprev.Location = new System.Drawing.Point(26, 233);
            this.CAptextprev.Name = "CAptextprev";
            this.CAptextprev.ReadOnly = true;
            this.CAptextprev.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.CAptextprev.Size = new System.Drawing.Size(170, 111);
            this.CAptextprev.TabIndex = 10;
            this.CAptextprev.Text = "";
            // 
            // iconPictureBox5
            // 
            this.iconPictureBox5.BackColor = System.Drawing.Color.Transparent;
            this.iconPictureBox5.ForeColor = System.Drawing.Color.Teal;
            this.iconPictureBox5.IconChar = FontAwesome.Sharp.IconChar.AngleDown;
            this.iconPictureBox5.IconColor = System.Drawing.Color.Teal;
            this.iconPictureBox5.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox5.IconSize = 37;
            this.iconPictureBox5.Location = new System.Drawing.Point(82, 193);
            this.iconPictureBox5.Name = "iconPictureBox5";
            this.iconPictureBox5.Size = new System.Drawing.Size(43, 37);
            this.iconPictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.iconPictureBox5.TabIndex = 9;
            this.iconPictureBox5.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(38, 156);
            this.label6.Margin = new System.Windows.Forms.Padding(20, 0, 3, 0);
            this.label6.Name = "label6";
            this.label6.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label6.Size = new System.Drawing.Size(131, 34);
            this.label6.TabIndex = 2;
            this.label6.Text = "Plain-Text preview  \r\nin binary";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CAbrowsePtext
            // 
            this.CAbrowsePtext.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.CAbrowsePtext.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CAbrowsePtext.FlatAppearance.BorderColor = System.Drawing.Color.Teal;
            this.CAbrowsePtext.FlatAppearance.BorderSize = 3;
            this.CAbrowsePtext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CAbrowsePtext.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CAbrowsePtext.ForeColor = System.Drawing.Color.White;
            this.CAbrowsePtext.IconChar = FontAwesome.Sharp.IconChar.FolderOpen;
            this.CAbrowsePtext.IconColor = System.Drawing.Color.DarkTurquoise;
            this.CAbrowsePtext.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.CAbrowsePtext.Location = new System.Drawing.Point(26, 68);
            this.CAbrowsePtext.Name = "CAbrowsePtext";
            this.CAbrowsePtext.Size = new System.Drawing.Size(170, 67);
            this.CAbrowsePtext.TabIndex = 1;
            this.CAbrowsePtext.Text = "Browse Plain-text";
            this.CAbrowsePtext.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.CAbrowsePtext.UseVisualStyleBackColor = false;
            this.CAbrowsePtext.Click += new System.EventHandler(this.CAbrowsePtext_Click);
            // 
            // iconPictureBox7
            // 
            this.iconPictureBox7.BackColor = System.Drawing.Color.Transparent;
            this.iconPictureBox7.ForeColor = System.Drawing.Color.Teal;
            this.iconPictureBox7.IconChar = FontAwesome.Sharp.IconChar.AngleDown;
            this.iconPictureBox7.IconColor = System.Drawing.Color.Teal;
            this.iconPictureBox7.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox7.IconSize = 37;
            this.iconPictureBox7.Location = new System.Drawing.Point(300, 193);
            this.iconPictureBox7.Name = "iconPictureBox7";
            this.iconPictureBox7.Size = new System.Drawing.Size(43, 37);
            this.iconPictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.iconPictureBox7.TabIndex = 15;
            this.iconPictureBox7.TabStop = false;
            // 
            // Analysebtn
            // 
            this.Analysebtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.Analysebtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Analysebtn.FlatAppearance.BorderColor = System.Drawing.Color.Navy;
            this.Analysebtn.FlatAppearance.BorderSize = 5;
            this.Analysebtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Analysebtn.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Analysebtn.ForeColor = System.Drawing.Color.Cyan;
            this.Analysebtn.IconChar = FontAwesome.Sharp.IconChar.Brain;
            this.Analysebtn.IconColor = System.Drawing.Color.Cyan;
            this.Analysebtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Analysebtn.Location = new System.Drawing.Point(12, 12);
            this.Analysebtn.Name = "Analysebtn";
            this.Analysebtn.Size = new System.Drawing.Size(315, 60);
            this.Analysebtn.TabIndex = 15;
            this.Analysebtn.Text = "CryptAnalysis";
            this.Analysebtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Analysebtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Analysebtn.UseVisualStyleBackColor = false;
            this.Analysebtn.Click += new System.EventHandler(this.Analysebtn_Click);
            // 
            // loading
            // 
            this.loading.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.loading.BackColor = System.Drawing.Color.Silver;
            this.loading.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loading.IconChar = FontAwesome.Sharp.IconChar.BatteryHalf;
            this.loading.IconColor = System.Drawing.Color.Green;
            this.loading.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.loading.Location = new System.Drawing.Point(450, 250);
            this.loading.Name = "loading";
            this.loading.Size = new System.Drawing.Size(159, 88);
            this.loading.TabIndex = 16;
            this.loading.Text = "Processing...\r\n-- Please Wait! --";
            this.loading.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.loading.UseVisualStyleBackColor = false;
            this.loading.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(20)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(1087, 553);
            this.Controls.Add(this.loading);
            this.Controls.Add(this.Analysebtn);
            this.Controls.Add(this.KeyPanel);
            this.Controls.Add(this.Decrypt);
            this.Controls.Add(this.Encrypt);
            this.Controls.Add(this.EncPanel);
            this.Controls.Add(this.DecPanel);
            this.Controls.Add(this.Cryptanalysispanel);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Encryption And Decryption";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.EncPanel.ResumeLayout(false);
            this.EncPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AngleRight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            this.KeyPanel.ResumeLayout(false);
            this.KeyPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox2)).EndInit();
            this.DecPanel.ResumeLayout(false);
            this.DecPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox4)).EndInit();
            this.Cryptanalysispanel.ResumeLayout(false);
            this.Cryptanalysispanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox7)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private FontAwesome.Sharp.IconButton Encrypt;
        private FontAwesome.Sharp.IconButton Decrypt;
        private System.Windows.Forms.FlowLayoutPanel EncPanel;
        private FontAwesome.Sharp.IconButton BrowsePtext;
        private System.Windows.Forms.Label PtextPrevEnc;
        private FontAwesome.Sharp.IconPictureBox AngleRight;
        private System.Windows.Forms.RichTextBox PlainTextPrevEnc;
        private FontAwesome.Sharp.IconButton Encbtn;
        private FontAwesome.Sharp.IconButton DownloadCbtn;
        private System.Windows.Forms.Label CtextPrevEnc;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private System.Windows.Forms.RichTextBox CryptoTextPrevEnc;
        private System.Windows.Forms.Panel KeyPanel;
        private FontAwesome.Sharp.IconButton iconButton1;
        private System.Windows.Forms.RichTextBox keyTpreview;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel DecPanel;
        private FontAwesome.Sharp.IconButton BrowseCtext;
        private System.Windows.Forms.Label label2;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox3;
        private System.Windows.Forms.RichTextBox CryptoTextPrevDec;
        private FontAwesome.Sharp.IconButton Decbtn;
        private FontAwesome.Sharp.IconButton DownloadPbtn;
        private System.Windows.Forms.Label label3;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox4;
        private System.Windows.Forms.RichTextBox PlainTextPrevDec;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel Cryptanalysispanel;
        private System.Windows.Forms.RichTextBox CAptextprev;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox5;
        private System.Windows.Forms.Label label6;
        private FontAwesome.Sharp.IconButton CAbrowsePtext;
        private FontAwesome.Sharp.IconButton Analysebtn;
        private FontAwesome.Sharp.IconButton CAdownloadKey;
        private System.Windows.Forms.RichTextBox CAkeyprev;
        private System.Windows.Forms.Label label8;
        private FontAwesome.Sharp.IconButton FindKeybtn;
        private System.Windows.Forms.RichTextBox CActextprev;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox7;
        private System.Windows.Forms.Label label7;
        private FontAwesome.Sharp.IconButton CAbrowseCtext;
        private FontAwesome.Sharp.IconButton loading;
    }
}

