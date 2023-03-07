
namespace Element011.Forms
{
    partial class FormTicketInfo
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelTickets = new System.Windows.Forms.Panel();
            this.panelProducts = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewTickets = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelProducts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTickets)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTickets
            // 
            this.panelTickets.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelTickets.Location = new System.Drawing.Point(0, 0);
            this.panelTickets.Name = "panelTickets";
            this.panelTickets.Size = new System.Drawing.Size(1184, 599);
            this.panelTickets.TabIndex = 0;
            // 
            // panelProducts
            // 
            this.panelProducts.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelProducts.BackColor = System.Drawing.Color.White;
            this.panelProducts.Controls.Add(this.label1);
            this.panelProducts.Controls.Add(this.dataGridViewTickets);
            this.panelProducts.Location = new System.Drawing.Point(61, 40);
            this.panelProducts.Name = "panelProducts";
            this.panelProducts.Size = new System.Drawing.Size(1062, 519);
            this.panelProducts.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(238, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(598, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Displaying the number of tickets in each category, along with the average time to" +
    " resolve each ticket.";
            // 
            // dataGridViewTickets
            // 
            this.dataGridViewTickets.AllowUserToAddRows = false;
            this.dataGridViewTickets.AllowUserToDeleteRows = false;
            this.dataGridViewTickets.AllowUserToResizeColumns = false;
            this.dataGridViewTickets.AllowUserToResizeRows = false;
            this.dataGridViewTickets.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewTickets.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewTickets.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewTickets.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTickets.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewTickets.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTickets.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTickets.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewTickets.GridColor = System.Drawing.Color.White;
            this.dataGridViewTickets.Location = new System.Drawing.Point(41, 78);
            this.dataGridViewTickets.MultiSelect = false;
            this.dataGridViewTickets.Name = "dataGridViewTickets";
            this.dataGridViewTickets.ReadOnly = true;
            this.dataGridViewTickets.RowHeadersVisible = false;
            this.dataGridViewTickets.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridViewTickets.ShowEditingIcon = false;
            this.dataGridViewTickets.Size = new System.Drawing.Size(981, 415);
            this.dataGridViewTickets.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "category_name";
            this.Column1.HeaderText = "Ticket Category";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "num_tickets";
            this.Column2.HeaderText = "Number of Tickets";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "avg_resolution_time";
            this.Column3.HeaderText = "Average Resolution Time (hour)";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // FormTicketInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 599);
            this.Controls.Add(this.panelProducts);
            this.Controls.Add(this.panelTickets);
            this.Name = "FormTicketInfo";
            this.Text = "Support Tickets";
            this.panelProducts.ResumeLayout(false);
            this.panelProducts.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTickets)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTickets;
        private System.Windows.Forms.Panel panelProducts;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewTickets;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
    }
}