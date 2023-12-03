namespace Tuto
{
    partial class administrativeMenu
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
        public void InitializeComponent()
        {
            this.dayLabel = new System.Windows.Forms.Label();
            this.hourLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.buttonOffers = new System.Windows.Forms.Button();
            this.buttonCalendar = new System.Windows.Forms.Button();
            this.buttonRequirements = new System.Windows.Forms.Button();
            this.labelTitle = new System.Windows.Forms.Label();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dayLabel
            // 
            this.dayLabel.AutoSize = true;
            this.dayLabel.Location = new System.Drawing.Point(562, 0);
            this.dayLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.dayLabel.Name = "dayLabel";
            this.dayLabel.Size = new System.Drawing.Size(0, 13);
            this.dayLabel.TabIndex = 0;
            // 
            // hourLabel
            // 
            this.hourLabel.AutoSize = true;
            this.hourLabel.Location = new System.Drawing.Point(682, 0);
            this.hourLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.hourLabel.Name = "hourLabel";
            this.hourLabel.Size = new System.Drawing.Size(28, 13);
            this.hourLabel.TabIndex = 1;
            this.hourLabel.Text = "hour";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.Controls.Add(this.buttonOffers, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.buttonCalendar, 1, 4);
            this.tableLayoutPanel2.Controls.Add(this.buttonRequirements, 1, 6);
            this.tableLayoutPanel2.Controls.Add(this.labelTitle, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 42);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 8;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(345, 546);
            this.tableLayoutPanel2.TabIndex = 3;
            // 
            // buttonOffers
            // 
            this.buttonOffers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonOffers.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.buttonOffers.Location = new System.Drawing.Point(37, 84);
            this.buttonOffers.Name = "buttonOffers";
            this.buttonOffers.Size = new System.Drawing.Size(270, 103);
            this.buttonOffers.TabIndex = 0;
            this.buttonOffers.Text = "Ofertas";
            this.buttonOffers.UseVisualStyleBackColor = true;
            this.buttonOffers.Click += new System.EventHandler(this.buttonOffers_Click_1);
            // 
            // buttonCalendar
            // 
            this.buttonCalendar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonCalendar.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.buttonCalendar.Location = new System.Drawing.Point(37, 220);
            this.buttonCalendar.Name = "buttonCalendar";
            this.buttonCalendar.Size = new System.Drawing.Size(270, 103);
            this.buttonCalendar.TabIndex = 1;
            this.buttonCalendar.Text = "Calendario";
            this.buttonCalendar.UseVisualStyleBackColor = true;
            this.buttonCalendar.Click += new System.EventHandler(this.buttonCalendar_Click);
            // 
            // buttonRequirements
            // 
            this.buttonRequirements.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonRequirements.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.buttonRequirements.Location = new System.Drawing.Point(37, 356);
            this.buttonRequirements.Name = "buttonRequirements";
            this.buttonRequirements.Size = new System.Drawing.Size(270, 103);
            this.buttonRequirements.TabIndex = 2;
            this.buttonRequirements.Text = "Requisitos";
            this.buttonRequirements.UseVisualStyleBackColor = true;
            this.buttonRequirements.Click += new System.EventHandler(this.buttonRequirements_Click_1);
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelTitle.Font = new System.Drawing.Font("Yu Gothic UI", 32.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelTitle.Location = new System.Drawing.Point(37, 0);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(270, 54);
            this.labelTitle.TabIndex = 3;
            this.labelTitle.Text = "Trámites";
            this.labelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // administrativeMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(345, 588);
            this.Controls.Add(this.tableLayoutPanel2);
            this.DoubleBuffered = true;
            this.Name = "administrativeMenu";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.Controls.SetChildIndex(this.tableLayoutPanel2, 0);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label dayLabel;
        private System.Windows.Forms.Label hourLabel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button buttonOffers;
        private System.Windows.Forms.Button buttonCalendar;
        private System.Windows.Forms.Button buttonRequirements;
        private System.Windows.Forms.Label labelTitle;
    }
}