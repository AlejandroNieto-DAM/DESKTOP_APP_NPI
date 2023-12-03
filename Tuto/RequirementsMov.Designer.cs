namespace Tuto
{
    partial class RequirementsMov
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panelInformation = new System.Windows.Forms.Panel();
            this.listRequirements = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.panelInformation.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.Controls.Add(this.panelInformation, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 65);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1200, 627);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // panelInformation
            // 
            this.panelInformation.Controls.Add(this.listRequirements);
            this.panelInformation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelInformation.ForeColor = System.Drawing.Color.Black;
            this.panelInformation.Location = new System.Drawing.Point(184, 99);
            this.panelInformation.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelInformation.Name = "panelInformation";
            this.panelInformation.Size = new System.Drawing.Size(832, 428);
            this.panelInformation.TabIndex = 0;
            // 
            // listRequirements
            // 
            this.listRequirements.AutoSize = true;
            this.listRequirements.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listRequirements.Location = new System.Drawing.Point(0, 0);
            this.listRequirements.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.listRequirements.Name = "listRequirements";
            this.listRequirements.Size = new System.Drawing.Size(51, 20);
            this.listRequirements.TabIndex = 0;
            this.listRequirements.Text = "label1";
            this.listRequirements.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // RequirementsMov
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "RequirementsMov";
            this.Text = "Form5";
            this.Load += new System.EventHandler(this.Form5_Load);
            this.Controls.SetChildIndex(this.tableLayoutPanel1, 0);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panelInformation.ResumeLayout(false);
            this.panelInformation.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panelInformation;
        private System.Windows.Forms.Label listRequirements;
    }
}