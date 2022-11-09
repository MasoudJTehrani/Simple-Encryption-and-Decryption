using FontAwesome.Sharp;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;
namespace Encryption_and_Decryption
{
    public partial class Form1 : Form
    {
        private IconButton currentBtn;
        private Panel bottomBorderBtn;
        private int keyLength = 4; // Key length in bytes
        private int blockLength = 128; // Block length in bytes
        private int[] Key = new int[] { };
        static StringBuilder outPut = new StringBuilder();
        public Form1()
        {
            InitializeComponent();
            bottomBorderBtn = new Panel();
            bottomBorderBtn.Size = new Size(516, 7);
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            DecPanel.Location = EncPanel.Location;
            Cryptanalysispanel.Location = EncPanel.Location;
        }
        // Design Methods \\
        //
        private void ActivateButton(object senderBtn, Color color)
        {
            if (senderBtn != null)
            {
                DisableButton();
                //Button
                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = Color.FromArgb(37, 36, 81);
                currentBtn.Controls.Add(bottomBorderBtn);
                //bottom border button
                bottomBorderBtn.BackColor = color;
                bottomBorderBtn.Location = new Point(2, 53);
                bottomBorderBtn.Visible = true;
                bottomBorderBtn.BringToFront();

            }
        }
        private void DisableButton()
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = Color.FromArgb(31, 30, 68);
            }
        }
        private void Decrypt_Click(object sender, EventArgs e)
        {
            Cryptanalysispanel.Visible = false;
            EncPanel.Visible = false;
            DecPanel.Visible = true;
            KeyPanel.Visible = true;
            ActivateButton(sender, Color.OrangeRed);
        }

        private void Encrypt_Click(object sender, EventArgs e)
        {
            Cryptanalysispanel.Visible = false;
            EncPanel.Visible = true;
            DecPanel.Visible = false;
            KeyPanel.Visible = true;
            ActivateButton(sender, Color.LimeGreen);
        }

        private void Analysebtn_Click(object sender, EventArgs e)
        {
            Cryptanalysispanel.Visible = true;
            EncPanel.Visible = false;
            DecPanel.Visible = false;
            KeyPanel.Visible = false;
            ActivateButton(sender, Color.Cyan);
        }
        // \\ End of design methods //
        //
        // Start of Coding methods and functions \\
        //
        // Opening a file
        private string openFile()
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string fileName = openFileDialog1.FileName;
                byte[] fileBytes = File.ReadAllBytes(fileName);
                StringBuilder sb = new StringBuilder();
                foreach (byte b in fileBytes)
                {
                    sb.Append(Convert.ToString(b, 2).PadLeft(8, '0'));
                }
                return sb.ToString();
            }
            else
            {
                return "";
            }
        }

        // Downloading a file
        private void downloadFile(RichTextBox prevName)
        {
            if (prevName.Text == "")
            {
                MessageBox.Show("There is nothing to save");
                return;
            }

            var data = GetBytesFromBinaryString(prevName.Text);
            saveFileDialog1.Filter = "Text files (*.txt)|*.txt|Image file(*.jpg)|*.jpg|All files (*.*)|*.*";
            saveFileDialog1.FilterIndex = 1;
            saveFileDialog1.Title = "Save The Selected text";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllBytes(saveFileDialog1.FileName, data);
            }
        }

        // Convert string to binary
        public Byte[] GetBytesFromBinaryString(String binary)
        {
            var list = new List<Byte>();

            for (int i = 0; i < binary.Length; i += 8)
            {
                String t = binary.Substring(i, 8);

                list.Add(Convert.ToByte(t, 2));
            }

            return list.ToArray();
        }

        // The Transformation Class
        public class Transformation
        {
            public int blockLength;
            int count = 0; // For the key to iterate
            int[] memory = new int[8];
            StringBuilder trasformedBlock = new StringBuilder();
            
            public Transformation(int blockLength)
            {
                this.blockLength = blockLength;
                outPut = new StringBuilder();
            }
            
            public void transform(string inputSource, string transformType, int[] inputKey)
            {
                Block_reader(inputSource, transformType, inputKey);
                
                void Block_reader(string src, string type, int[] key)
                {
                    while(src.Length >= blockLength * 8){
                        Block_transformer(src.Substring(0, (blockLength * 8)), key , type);
                        src = src.Remove(0, (blockLength * 8));
                    }
                    if(src.Length > 0)
                    {
                        Block_transformer(src, key, type);
                    }
                }

                void Block_transformer(string S, int[] theKey, string theType)
                {
                    Byte_reader(S, theKey, theType);
                    Block_writer(trasformedBlock);
                    trasformedBlock = new StringBuilder();

                    void Byte_reader(string block, int[] key, string type)
                    {
                        while(block.Length >= 8)
                        {
                            Byte_transformer(block.Substring(0, 8), key, type);
                            block = block.Remove(0, 8);
                        }
                    }

                    void Byte_transformer(string Byte, int[] key,string type){
                        int[] byteOutput = new int[8];
                        BT2(BT1(Byte));
                        Byte_writer(byteOutput);

                        string BT1(string theByte)
                        {
                            StringBuilder BT1output = new StringBuilder();
                            for (int i = 0; i < 8; i++)
                            {
                                BT1output.Append(Int32.Parse(theByte[i].ToString()) ^ memory[i]);
                            }
                            return BT1output.ToString();
                        }

                        void BT2(string thebyte)
                        {
                            for (int i = 0; i < 8; i++)
                            {
                                byteOutput[i] = Int32.Parse(thebyte[i].ToString()) ^ key[i + (count * 8)];
                                if (type == "enc")
                                {
                                    memory[i] = byteOutput[i];
                                }
                                else
                                {
                                    memory[i] = Int32.Parse(Byte[i].ToString());
                                }
                            }
                            
                            count++;
                            if (count == 4)
                            {
                                count = 0;
                            }
                        }

                    }
                    void Byte_writer(int[] byteOutput)
                    {
                        for(int i = 0; i < 8; i++)
                        {
                            trasformedBlock.Append(byteOutput[i]);
                        }
                    }
                }

                void Block_writer(StringBuilder T)
                {
                    outPut.Append(T);
                }
            }
            
        }

        // the Hack class
        public class Hack
        {
            int keyLength;
            int[] memory = new int[8];
            public Hack(int keyLength)
            {
                this.keyLength = keyLength;
            }

            public string findKey(string plainText, string cryptoText)
            {
                StringBuilder key = new StringBuilder();
                Block_reader(plainText, cryptoText);
                void Block_reader(string ptext, string ctext)
                {
                    Block_cracker(ptext.Substring(0,(keyLength * 8)), ctext.Substring(0, (keyLength * 8)));
                }

                void Block_cracker(string ptext, string ctext)
                {
                    Byte_reader(ptext, ctext);

                    void Byte_reader(string pBytes, string cBytes){
                        while (pBytes.Length > 0)
                        {
                            Byte_cracker(pBytes.Substring(0, 8), cBytes.Substring(0, 8));
                            pBytes = pBytes.Remove(0, 8);
                            cBytes = cBytes.Remove(0, 8);
                        }
                    }

                    void Byte_cracker(string pBytes, string cBytes)
                    {
                        int[] byteOutput = new int[8];
                        for (int i = 0; i < 8; i++)
                        {
                            byteOutput[i] = Int32.Parse(pBytes[i].ToString()) ^ Int32.Parse(cBytes[i].ToString()) ^ memory[i];
                            memory[i] = Int32.Parse(cBytes[i].ToString());
                        }
                        Byte_writer(byteOutput);
                    }

                    void Byte_writer(int[] byteOutput)
                    {
                        for (int i = 0; i < 8; i++)
                        {
                            key.Append(byteOutput[i]);
                        }
                    }
                }

                return key.ToString();
            }
        }
        // \\ End of Coding methods and functions //
        //
        // Start of Form methods \\
        //
        // Open plain-text file
        private void BrowsePtext_Click(object sender, EventArgs e)
        {
            loading.Visible = true;
            PlainTextPrevEnc.Text = openFile();
            loading.Visible = false;
        }

        // Open crypto-text file
        private void BrowseCtext_Click(object sender, EventArgs e)
        {
            loading.Visible = true;
            CryptoTextPrevDec.Text = openFile();
            loading.Visible = false;
        }

        // Open key file
        private void iconButton1_Click(object sender, EventArgs e)
        {
            loading.Visible = true;
            try
            {
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    string fileName = openFileDialog1.FileName;
                    string fileText = File.ReadAllText(fileName);
                    if (fileText.Length == keyLength * 8)
                    {
                        Key = new int[keyLength * 8];
                        for (int i = 0; i < keyLength * 8; i++)
                        {
                            Key[i] = Int32.Parse(fileText[i].ToString());
                        }
                        keyTpreview.Text = fileText;
                    }
                    else
                    {
                        MessageBox.Show("Your key length is not valid.\nPlease make sure your key is 32 bits");
                    }

                }
            }
            catch
            {
                MessageBox.Show("There was an error loading your key.\nPlease make sure your key is 32 bits and is" +
                    "in binary format in a .txt file");
            }
            loading.Visible = false;
        }

        // Download Plain-text button clicked
        private void DownloadPbtn_Click(object sender, EventArgs e)
        {
            downloadFile(PlainTextPrevDec);
        }

        // Download Crypto-text button clicked
        private void DownloadCbtn_Click(object sender, EventArgs e)
        {
            downloadFile(CryptoTextPrevEnc);
        }

        // Encryption button clicked
        private void Encbtn_Click(object sender, EventArgs e)
        {
            if (Key.Length == 0 || Key == null)
            {
                MessageBox.Show("Please insert the Key first");
                return;
            }
            if (PlainTextPrevEnc.Text == "")
            {
                MessageBox.Show("There is nothing to Encrypt. Please insert the\n" +
                    "plain-text first");
                return;
            }
            Transformation enc = new Transformation(blockLength);
            enc.transform(PlainTextPrevEnc.Text, "enc", Key);
            CryptoTextPrevEnc.Text = outPut.ToString();
        }

        // Decryption button clicked
        private void Decbtn_Click(object sender, EventArgs e)
        {
            if (Key.Length == 0 || Key == null)
            {
                MessageBox.Show("Please insert the Key first");
                return;
            }
            if (CryptoTextPrevDec.Text == "")
            {
                MessageBox.Show("There is nothing to Decrypt. Please insert the\n" +
                    "Crypto-text first");
                return;
            }
            Transformation dec = new Transformation(blockLength);
            dec.transform(CryptoTextPrevDec.Text, "dec", Key);
            PlainTextPrevDec.Text = outPut.ToString();
        }
        // Open Plain-text to hack and extract key
        private void CAbrowsePtext_Click(object sender, EventArgs e)
        {
            loading.Visible = true;
            CAptextprev.Text = openFile();
            loading.Visible = false;
        }

        // Open Crypto-text to hack and extract key
        private void CAbrowseCtext_Click(object sender, EventArgs e)
        {
            loading.Visible = true;
            CActextprev.Text = openFile();
            loading.Visible = false;
        }
        // Find-the-key button clicked
        private void FindKeybtn_Click(object sender, EventArgs e)
        {
            if (CActextprev.Text == "" || CAptextprev.Text == "")
            {
                MessageBox.Show("Please insert the Plain-text and the Crypto-text first");
                return;
            }
            Hack hack = new Hack(keyLength);
            CAkeyprev.Text = hack.findKey(CAptextprev.Text, CActextprev.Text);
        }
        // Download the hacked key
        private void CAdownloadKey_Click(object sender, EventArgs e)
        {
            if (CAkeyprev.Text == "")
            {
                MessageBox.Show("There is nothing to save");
                return;
            }
            saveFileDialog1.Filter = "Text files (*.txt)|*.txt";
            saveFileDialog1.FilterIndex = 1;
            saveFileDialog1.Title = "Save The Key";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(saveFileDialog1.FileName, CAkeyprev.Text);
            }
        }

    }
}
