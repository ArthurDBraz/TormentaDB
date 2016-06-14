namespace TormentaDB
{
    partial class ResultsForm
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
            this.ResultsHTMLBox = new System.Windows.Forms.WebBrowser();
            this.SuspendLayout();
            // 
            // ResultsHTMLBox
            // 
            this.ResultsHTMLBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ResultsHTMLBox.Location = new System.Drawing.Point(0, 0);
            this.ResultsHTMLBox.MinimumSize = new System.Drawing.Size(20, 20);
            this.ResultsHTMLBox.Name = "ResultsHTMLBox";
            this.ResultsHTMLBox.Size = new System.Drawing.Size(664, 508);
            this.ResultsHTMLBox.TabIndex = 0;
            // 
            // ResultsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(664, 508);
            this.Controls.Add(this.ResultsHTMLBox);
            this.Name = "ResultsForm";
            this.Text = "Results";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.WebBrowser ResultsHTMLBox;
    }
}