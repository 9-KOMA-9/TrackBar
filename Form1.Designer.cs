namespace TrackBarKontrola
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
            this.tBar = new System.Windows.Forms.TrackBar();
            this.vrijednost = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tBar)).BeginInit();
            this.SuspendLayout();
            // 
            // tBar
            // 
            this.tBar.Location = new System.Drawing.Point(57, 37);
            this.tBar.Name = "tBar";
            this.tBar.Size = new System.Drawing.Size(705, 45);
            this.tBar.TabIndex = 0;
            this.tBar.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // vrijednost
            // 
            this.vrijednost.Location = new System.Drawing.Point(377, 134);
            this.vrijednost.Name = "vrijednost";
            this.vrijednost.Size = new System.Drawing.Size(123, 20);
            this.vrijednost.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(247, 137);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Postavljena vrijednost je:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.vrijednost);
            this.Controls.Add(this.tBar);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.tBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TrackBar tBar;
        private System.Windows.Forms.TextBox vrijednost;
        private System.Windows.Forms.Label label1;
    }
}

