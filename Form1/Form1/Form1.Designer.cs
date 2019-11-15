namespace Form1
{
    partial class AAAAAAAAAA
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
            this.NameLbl = new System.Windows.Forms.Label();
            this.ClickMe = new System.Windows.Forms.Button();
            this.txtBox = new System.Windows.Forms.TextBox();
            this.AAAAAAAAA = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.AAAAAAAAA)).BeginInit();
            this.SuspendLayout();
            // 
            // NameLbl
            // 
            this.NameLbl.AutoSize = true;
            this.NameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameLbl.Location = new System.Drawing.Point(463, 335);
            this.NameLbl.Name = "NameLbl";
            this.NameLbl.Size = new System.Drawing.Size(89, 24);
            this.NameLbl.TabIndex = 0;
            this.NameLbl.Text = "Enter text";
            this.NameLbl.Click += new System.EventHandler(this.NameLbl_Click);
            // 
            // ClickMe
            // 
            this.ClickMe.BackColor = System.Drawing.Color.Red;
            this.ClickMe.Location = new System.Drawing.Point(445, 385);
            this.ClickMe.Name = "ClickMe";
            this.ClickMe.Size = new System.Drawing.Size(123, 73);
            this.ClickMe.TabIndex = 2;
            this.ClickMe.Text = "Click me";
            this.ClickMe.UseVisualStyleBackColor = false;
            this.ClickMe.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtBox
            // 
            this.txtBox.Location = new System.Drawing.Point(457, 362);
            this.txtBox.Name = "txtBox";
            this.txtBox.Size = new System.Drawing.Size(100, 20);
            this.txtBox.TabIndex = 0;
            this.txtBox.TextChanged += new System.EventHandler(this.txtBox_TextChanged);
            // 
            // AAAAAAAAA
            // 
            this.AAAAAAAAA.Image = global::Form1.Properties.Resources.AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA1;
            this.AAAAAAAAA.Location = new System.Drawing.Point(356, 72);
            this.AAAAAAAAA.Name = "AAAAAAAAA";
            this.AAAAAAAAA.Size = new System.Drawing.Size(325, 177);
            this.AAAAAAAAA.TabIndex = 3;
            this.AAAAAAAAA.TabStop = false;
            // 
            // AAAAAAAAAA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1289, 760);
            this.Controls.Add(this.txtBox);
            this.Controls.Add(this.AAAAAAAAA);
            this.Controls.Add(this.ClickMe);
            this.Controls.Add(this.NameLbl);
            this.Name = "AAAAAAAAAA";
            this.Text = "AAAAAAAAAA";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.AAAAAAAAA)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NameLbl;
        private System.Windows.Forms.Button ClickMe;
        private System.Windows.Forms.PictureBox AAAAAAAAA;
        private System.Windows.Forms.TextBox txtBox;
    }
}

