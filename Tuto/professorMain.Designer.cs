namespace Tuto
{
    partial class professorMain
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
            this.labeltitle = new System.Windows.Forms.Label();
            this.buttonsearch = new System.Windows.Forms.Button();
            this.labelname = new System.Windows.Forms.Label();
            this.labelresult = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.Controls.Add(this.labeltitle, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.buttonsearch, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.labelname, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.labelresult, 1, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 42);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(540, 918);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // labeltitle
            // 
            this.labeltitle.AutoSize = true;
            this.labeltitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labeltitle.Font = new System.Drawing.Font("Yu Gothic UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeltitle.ForeColor = System.Drawing.Color.White;
            this.labeltitle.Location = new System.Drawing.Point(57, 0);
            this.labeltitle.Name = "labeltitle";
            this.labeltitle.Size = new System.Drawing.Size(426, 91);
            this.labeltitle.TabIndex = 1;
            this.labeltitle.Text = "PROFESORES";
            this.labeltitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonsearch
            // 
            this.buttonsearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonsearch.Font = new System.Drawing.Font("Yu Gothic UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonsearch.Location = new System.Drawing.Point(69, 106);
            this.buttonsearch.Margin = new System.Windows.Forms.Padding(15);
            this.buttonsearch.Name = "buttonsearch";
            this.buttonsearch.Size = new System.Drawing.Size(402, 61);
            this.buttonsearch.TabIndex = 0;
            this.buttonsearch.Text = "BUSCAR";
            this.buttonsearch.UseVisualStyleBackColor = true;
            this.buttonsearch.Click += new System.EventHandler(this.button1_Click);
            // 
            // labelname
            // 
            this.labelname.AutoSize = true;
            this.labelname.BackColor = System.Drawing.Color.White;
            this.labelname.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelname.Font = new System.Drawing.Font("Yu Gothic UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelname.Location = new System.Drawing.Point(69, 197);
            this.labelname.Margin = new System.Windows.Forms.Padding(15);
            this.labelname.Name = "labelname";
            this.labelname.Size = new System.Drawing.Size(402, 61);
            this.labelname.TabIndex = 2;
            // 
            // labelresult
            // 
            this.labelresult.AutoSize = true;
            this.labelresult.BackColor = System.Drawing.Color.White;
            this.labelresult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelresult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelresult.Font = new System.Drawing.Font("Yu Gothic UI", 20F);
            this.labelresult.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelresult.Location = new System.Drawing.Point(69, 288);
            this.labelresult.Margin = new System.Windows.Forms.Padding(15);
            this.labelresult.Name = "labelresult";
            this.labelresult.Size = new System.Drawing.Size(402, 520);
            this.labelresult.TabIndex = 3;
            this.labelresult.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // professorMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(540, 960);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "professorMain";
            this.Text = "professorMain";
            this.Controls.SetChildIndex(this.tableLayoutPanel1, 0);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label labeltitle;
        private System.Windows.Forms.Button buttonsearch;
        private System.Windows.Forms.Label labelname;
        private System.Windows.Forms.Label labelresult;
    }
}