
namespace Element011.Forms
{
    partial class FormTickets
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
            this.panelTickets = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // panelTickets
            // 
            this.panelTickets.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelTickets.Location = new System.Drawing.Point(0, 0);
            this.panelTickets.Name = "panelTickets";
            this.panelTickets.Size = new System.Drawing.Size(800, 450);
            this.panelTickets.TabIndex = 0;
            // 
            // FormTickets
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelTickets);
            this.Name = "FormTickets";
            this.Text = "Support Tickets";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTickets;
    }
}