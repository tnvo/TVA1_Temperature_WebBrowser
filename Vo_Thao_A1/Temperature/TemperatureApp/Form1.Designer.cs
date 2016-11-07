namespace TemperatureApp
{
    partial class TemperatureForm
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
            this.f2cResultLabel = new System.Windows.Forms.Label();
            this.c2fResultLabel = new System.Windows.Forms.Label();
            this.f2cButton = new System.Windows.Forms.Button();
            this.c2fButton = new System.Windows.Forms.Button();
            this.f2cText = new System.Windows.Forms.TextBox();
            this.c2fText = new System.Windows.Forms.TextBox();
            this.f2cLabel = new System.Windows.Forms.Label();
            this.c2fLabel = new System.Windows.Forms.Label();
            this.helloLabel = new System.Windows.Forms.Label();
            this.infoLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // f2cResultLabel
            // 
            this.f2cResultLabel.AutoSize = true;
            this.f2cResultLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.f2cResultLabel.ForeColor = System.Drawing.Color.Red;
            this.f2cResultLabel.Location = new System.Drawing.Point(206, 212);
            this.f2cResultLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.f2cResultLabel.Name = "f2cResultLabel";
            this.f2cResultLabel.Size = new System.Drawing.Size(28, 24);
            this.f2cResultLabel.TabIndex = 20;
            this.f2cResultLabel.Text = "...";
            // 
            // c2fResultLabel
            // 
            this.c2fResultLabel.AutoSize = true;
            this.c2fResultLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.c2fResultLabel.ForeColor = System.Drawing.Color.Red;
            this.c2fResultLabel.Location = new System.Drawing.Point(206, 115);
            this.c2fResultLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.c2fResultLabel.Name = "c2fResultLabel";
            this.c2fResultLabel.Size = new System.Drawing.Size(28, 24);
            this.c2fResultLabel.TabIndex = 18;
            this.c2fResultLabel.Text = "...";
            // 
            // f2cButton
            // 
            this.f2cButton.Location = new System.Drawing.Point(308, 157);
            this.f2cButton.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.f2cButton.Name = "f2cButton";
            this.f2cButton.Size = new System.Drawing.Size(74, 23);
            this.f2cButton.TabIndex = 17;
            this.f2cButton.Text = "Convert";
            this.f2cButton.UseVisualStyleBackColor = true;
            this.f2cButton.Click += new System.EventHandler(this.f2cButton_Click);
            // 
            // c2fButton
            // 
            this.c2fButton.Location = new System.Drawing.Point(308, 61);
            this.c2fButton.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.c2fButton.Name = "c2fButton";
            this.c2fButton.Size = new System.Drawing.Size(74, 23);
            this.c2fButton.TabIndex = 16;
            this.c2fButton.Text = "Convert";
            this.c2fButton.UseVisualStyleBackColor = true;
            this.c2fButton.Click += new System.EventHandler(this.c2fButton_Click);
            // 
            // f2cText
            // 
            this.f2cText.Location = new System.Drawing.Point(179, 162);
            this.f2cText.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.f2cText.Name = "f2cText";
            this.f2cText.Size = new System.Drawing.Size(100, 20);
            this.f2cText.TabIndex = 15;
            // 
            // c2fText
            // 
            this.c2fText.Location = new System.Drawing.Point(179, 64);
            this.c2fText.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.c2fText.Name = "c2fText";
            this.c2fText.Size = new System.Drawing.Size(100, 20);
            this.c2fText.TabIndex = 14;
            // 
            // f2cLabel
            // 
            this.f2cLabel.AutoSize = true;
            this.f2cLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.f2cLabel.Location = new System.Drawing.Point(52, 165);
            this.f2cLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.f2cLabel.Name = "f2cLabel";
            this.f2cLabel.Size = new System.Drawing.Size(121, 13);
            this.f2cLabel.TabIndex = 13;
            this.f2cLabel.Text = "Convert from F to C:";
            // 
            // c2fLabel
            // 
            this.c2fLabel.AutoSize = true;
            this.c2fLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.c2fLabel.Location = new System.Drawing.Point(52, 66);
            this.c2fLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.c2fLabel.Name = "c2fLabel";
            this.c2fLabel.Size = new System.Drawing.Size(121, 13);
            this.c2fLabel.TabIndex = 12;
            this.c2fLabel.Text = "Convert from C to F:";
            // 
            // helloLabel
            // 
            this.helloLabel.AutoSize = true;
            this.helloLabel.ForeColor = System.Drawing.Color.Blue;
            this.helloLabel.Location = new System.Drawing.Point(74, 20);
            this.helloLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.helloLabel.Name = "helloLabel";
            this.helloLabel.Size = new System.Drawing.Size(330, 13);
            this.helloLabel.TabIndex = 11;
            this.helloLabel.Text = "Hello, let\'s convert temperature! Please enter a numeric value below:";
            // 
            // infoLabel
            // 
            this.infoLabel.AutoSize = true;
            this.infoLabel.Location = new System.Drawing.Point(122, 266);
            this.infoLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.infoLabel.Name = "infoLabel";
            this.infoLabel.Size = new System.Drawing.Size(233, 13);
            this.infoLabel.TabIndex = 22;
            this.infoLabel.Text = "Please note that all temperature will be rounded.";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.nameLabel.Location = new System.Drawing.Point(410, 289);
            this.nameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(62, 13);
            this.nameLabel.TabIndex = 23;
            this.nameLabel.Text = "Thao N. Vo";
            // 
            // TemperatureForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 311);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.infoLabel);
            this.Controls.Add(this.f2cResultLabel);
            this.Controls.Add(this.c2fResultLabel);
            this.Controls.Add(this.f2cButton);
            this.Controls.Add(this.c2fButton);
            this.Controls.Add(this.f2cText);
            this.Controls.Add(this.c2fText);
            this.Controls.Add(this.f2cLabel);
            this.Controls.Add(this.c2fLabel);
            this.Controls.Add(this.helloLabel);
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "TemperatureForm";
            this.Text = "Temperature Conversion";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label f2cResultLabel;
        private System.Windows.Forms.Label c2fResultLabel;
        private System.Windows.Forms.Button f2cButton;
        private System.Windows.Forms.Button c2fButton;
        private System.Windows.Forms.TextBox f2cText;
        private System.Windows.Forms.TextBox c2fText;
        private System.Windows.Forms.Label f2cLabel;
        private System.Windows.Forms.Label c2fLabel;
        private System.Windows.Forms.Label helloLabel;
        private System.Windows.Forms.Label infoLabel;
        private System.Windows.Forms.Label nameLabel;
    }
}

