namespace CryptograhicEncryption
{
    partial class Cryptography
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
            this.button2 = new System.Windows.Forms.Button();
            this.buttonBreateAsmKeys_Click = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.openFileDialog2 = new System.Windows.Forms.OpenFileDialog();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(79, 79);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(115, 50);
            this.button2.TabIndex = 1;
            this.button2.Text = "Encypt File";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.ButtonEncryptFile_Click);
            // 
            // buttonBreateAsmKeys_Click
            // 
            this.buttonBreateAsmKeys_Click.Location = new System.Drawing.Point(79, 16);
            this.buttonBreateAsmKeys_Click.Name = "buttonBreateAsmKeys_Click";
            this.buttonBreateAsmKeys_Click.Size = new System.Drawing.Size(115, 57);
            this.buttonBreateAsmKeys_Click.TabIndex = 0;
            this.buttonBreateAsmKeys_Click.Text = "Create Keys";
            this.buttonBreateAsmKeys_Click.UseVisualStyleBackColor = true;
            this.buttonBreateAsmKeys_Click.Click += new System.EventHandler(this.ButtonCreateAsmKeys_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(283, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Key not set";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // openFileDialog2
            // 
            this.openFileDialog2.FileName = "openFileDialog2";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(79, 135);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(115, 39);
            this.button1.TabIndex = 4;
            this.button1.Text = "Decrypt File";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.ButtonDecryptFile_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(79, 180);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(115, 51);
            this.button3.TabIndex = 5;
            this.button3.Text = "Export Public Key";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.ButtonExportPublicKey_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(79, 237);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(115, 58);
            this.button4.TabIndex = 6;
            this.button4.Text = "Import Public Key";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.ButtonImportPublicKey_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(79, 301);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(115, 43);
            this.button5.TabIndex = 7;
            this.button5.Text = "Get Private Key";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.ButtonGetPrivateKey_Click);
            // 
            // Cryptography
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(455, 369);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.buttonBreateAsmKeys_Click);
            this.Name = "Cryptography";
            this.Text = "Cryptography";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button buttonBreateAsmKeys_Click;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
    }
}