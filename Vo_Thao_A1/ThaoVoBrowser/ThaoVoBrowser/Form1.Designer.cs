namespace ThaoVoBrowser
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
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.txtURL = new System.Windows.Forms.TextBox();
            this.btnGo = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.encryptBtn = new System.Windows.Forms.Button();
            this.msgResultLabel = new System.Windows.Forms.Label();
            this.msgLabel = new System.Windows.Forms.Label();
            this.stockLabel = new System.Windows.Forms.Label();
            this.StockMsgLabel = new System.Windows.Forms.Label();
            this.stockResultLabel = new System.Windows.Forms.Label();
            this.checkStockBtn = new System.Windows.Forms.Button();
            this.stockTextBox = new System.Windows.Forms.TextBox();
            this.encryptTxtResult = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // webBrowser1
            // 
            this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser1.Location = new System.Drawing.Point(0, 0);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(704, 601);
            this.webBrowser1.TabIndex = 0;
            // 
            // txtURL
            // 
            this.txtURL.Location = new System.Drawing.Point(35, 13);
            this.txtURL.Name = "txtURL";
            this.txtURL.Size = new System.Drawing.Size(550, 20);
            this.txtURL.TabIndex = 1;
            this.txtURL.Text = "http://";
            // 
            // btnGo
            // 
            this.btnGo.Location = new System.Drawing.Point(602, 10);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(75, 23);
            this.btnGo.TabIndex = 2;
            this.btnGo.Text = "Go";
            this.btnGo.UseVisualStyleBackColor = true;
            this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(455, 455);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(199, 20);
            this.textBox1.TabIndex = 3;
            // 
            // encryptBtn
            // 
            this.encryptBtn.Location = new System.Drawing.Point(455, 481);
            this.encryptBtn.Name = "encryptBtn";
            this.encryptBtn.Size = new System.Drawing.Size(110, 23);
            this.encryptBtn.TabIndex = 4;
            this.encryptBtn.Text = "Encrypt Now";
            this.encryptBtn.UseVisualStyleBackColor = true;
            this.encryptBtn.Click += new System.EventHandler(this.encryptBtn_Click);
            // 
            // msgResultLabel
            // 
            this.msgResultLabel.AutoSize = true;
            this.msgResultLabel.Location = new System.Drawing.Point(455, 535);
            this.msgResultLabel.Name = "msgResultLabel";
            this.msgResultLabel.Size = new System.Drawing.Size(0, 13);
            this.msgResultLabel.TabIndex = 6;
            // 
            // msgLabel
            // 
            this.msgLabel.AutoSize = true;
            this.msgLabel.Location = new System.Drawing.Point(455, 436);
            this.msgLabel.Name = "msgLabel";
            this.msgLabel.Size = new System.Drawing.Size(199, 13);
            this.msgLabel.TabIndex = 7;
            this.msgLabel.Text = "Please type your message in the text box";
            // 
            // stockLabel
            // 
            this.stockLabel.AutoSize = true;
            this.stockLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stockLabel.Location = new System.Drawing.Point(12, 433);
            this.stockLabel.Name = "stockLabel";
            this.stockLabel.Size = new System.Drawing.Size(102, 16);
            this.stockLabel.TabIndex = 8;
            this.stockLabel.Text = "Stock Update";
            // 
            // StockMsgLabel
            // 
            this.StockMsgLabel.AutoSize = true;
            this.StockMsgLabel.Location = new System.Drawing.Point(15, 458);
            this.StockMsgLabel.Name = "StockMsgLabel";
            this.StockMsgLabel.Size = new System.Drawing.Size(227, 13);
            this.StockMsgLabel.TabIndex = 9;
            this.StockMsgLabel.Text = "Please enter a stock symbol (E.g: IBM, GOOG)";
            // 
            // stockResultLabel
            // 
            this.stockResultLabel.AutoSize = true;
            this.stockResultLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stockResultLabel.Location = new System.Drawing.Point(81, 535);
            this.stockResultLabel.Name = "stockResultLabel";
            this.stockResultLabel.Size = new System.Drawing.Size(33, 25);
            this.stockResultLabel.TabIndex = 10;
            this.stockResultLabel.Text = "...";
            // 
            // checkStockBtn
            // 
            this.checkStockBtn.Location = new System.Drawing.Point(47, 507);
            this.checkStockBtn.Name = "checkStockBtn";
            this.checkStockBtn.Size = new System.Drawing.Size(122, 23);
            this.checkStockBtn.TabIndex = 11;
            this.checkStockBtn.Text = "Check Stock Price";
            this.checkStockBtn.UseVisualStyleBackColor = true;
            this.checkStockBtn.Click += new System.EventHandler(this.checkStockBtn_Click);
            // 
            // stockTextBox
            // 
            this.stockTextBox.Location = new System.Drawing.Point(57, 481);
            this.stockTextBox.Name = "stockTextBox";
            this.stockTextBox.Size = new System.Drawing.Size(100, 20);
            this.stockTextBox.TabIndex = 12;
            // 
            // encryptTxtResult
            // 
            this.encryptTxtResult.Location = new System.Drawing.Point(455, 535);
            this.encryptTxtResult.Name = "encryptTxtResult";
            this.encryptTxtResult.Size = new System.Drawing.Size(100, 20);
            this.encryptTxtResult.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 601);
            this.Controls.Add(this.encryptTxtResult);
            this.Controls.Add(this.stockTextBox);
            this.Controls.Add(this.checkStockBtn);
            this.Controls.Add(this.stockResultLabel);
            this.Controls.Add(this.StockMsgLabel);
            this.Controls.Add(this.stockLabel);
            this.Controls.Add(this.msgLabel);
            this.Controls.Add(this.msgResultLabel);
            this.Controls.Add(this.encryptBtn);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnGo);
            this.Controls.Add(this.txtURL);
            this.Controls.Add(this.webBrowser1);
            this.Name = "Form1";
            this.Text = "Thao Vo\'s Web Browser";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.TextBox txtURL;
        private System.Windows.Forms.Button btnGo;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button encryptBtn;
        private System.Windows.Forms.Label msgResultLabel;
        private System.Windows.Forms.Label msgLabel;
        private System.Windows.Forms.Label stockLabel;
        private System.Windows.Forms.Label StockMsgLabel;
        private System.Windows.Forms.Label stockResultLabel;
        private System.Windows.Forms.Button checkStockBtn;
        private System.Windows.Forms.TextBox stockTextBox;
        private System.Windows.Forms.TextBox encryptTxtResult;
    }
}

