namespace Hello_World
{
    partial class frmHelloWorld
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
            this.lblHelloWord = new System.Windows.Forms.Label();
            this.btnShow = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblHelloWord
            // 
            this.lblHelloWord.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblHelloWord.AutoSize = true;
            this.lblHelloWord.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblHelloWord.Font = new System.Drawing.Font("Segoe Script", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHelloWord.ForeColor = System.Drawing.Color.Red;
            this.lblHelloWord.Location = new System.Drawing.Point(72, 104);
            this.lblHelloWord.Name = "lblHelloWord";
            this.lblHelloWord.Size = new System.Drawing.Size(0, 61);
            this.lblHelloWord.TabIndex = 0;
            this.lblHelloWord.Click += new System.EventHandler(this.lblHelloWord_Click);
            // 
            // btnShow
            // 
            this.btnShow.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnShow.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnShow.Location = new System.Drawing.Point(117, 296);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(113, 23);
            this.btnShow.TabIndex = 1;
            this.btnShow.Text = "Show Hello World";
            this.btnShow.UseVisualStyleBackColor = false;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // frmHelloWorld
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(390, 331);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.lblHelloWord);
            this.MinimumSize = new System.Drawing.Size(380, 340);
            this.Name = "frmHelloWorld";
            this.Text = "Hello World";
            this.Load += new System.EventHandler(this.frmHelloWorld_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHelloWord;
        private System.Windows.Forms.Button btnShow;
    }
}

