namespace Tuto
{
    partial class Form2
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
            this.components = new System.ComponentModel.Container();
            this.botonStart = new System.Windows.Forms.Button();
            this.txtQRcode = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.buttonExit = new System.Windows.Forms.Button();
            this.hourLabelTable = new System.Windows.Forms.TableLayoutPanel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.dayLabelTable = new System.Windows.Forms.TableLayoutPanel();
            this.dispositivo = new System.Windows.Forms.ComboBox();
            this.hourLabel = new System.Windows.Forms.Label();
            this.dayLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.hourLabelTable.SuspendLayout();
            this.dayLabelTable.SuspendLayout();
            this.SuspendLayout();
            // 
            // botonStart
            // 
            this.botonStart.Location = new System.Drawing.Point(178, 651);
            this.botonStart.Name = "botonStart";
            this.botonStart.Size = new System.Drawing.Size(75, 23);
            this.botonStart.TabIndex = 0;
            this.botonStart.Text = "&Start";
            this.botonStart.UseVisualStyleBackColor = true;
            this.botonStart.Click += new System.EventHandler(this.botonStart_Click);
            // 
            // txtQRcode
            // 
            this.txtQRcode.Location = new System.Drawing.Point(283, 692);
            this.txtQRcode.Multiline = true;
            this.txtQRcode.Name = "txtQRcode";
            this.txtQRcode.Size = new System.Drawing.Size(91, 77);
            this.txtQRcode.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Location = new System.Drawing.Point(178, 692);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(75, 70);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(12, 787);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(75, 23);
            this.buttonExit.TabIndex = 5;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // hourLabelTable
            // 
            this.hourLabelTable.ColumnCount = 1;
            this.hourLabelTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.hourLabelTable.Controls.Add(this.hourLabel, 0, 0);
            this.hourLabelTable.Location = new System.Drawing.Point(364, 1);
            this.hourLabelTable.Name = "hourLabelTable";
            this.hourLabelTable.RowCount = 1;
            this.hourLabelTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.hourLabelTable.Size = new System.Drawing.Size(57, 49);
            this.hourLabelTable.TabIndex = 6;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(138, 271);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(147, 76);
            this.textBox1.TabIndex = 7;
            this.textBox1.Text = "Para acceder necesitas tu código QR personal de la UGR\r\n\r\n";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(125, 606);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(185, 22);
            this.textBox2.TabIndex = 8;
            this.textBox2.Text = "Escanea tu código QR aquí";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "ES",
            "EN"});
            this.comboBox1.Location = new System.Drawing.Point(364, 787);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(47, 24);
            this.comboBox1.TabIndex = 9;
            this.comboBox1.Text = "ES";
            // 
            // dayLabelTable
            // 
            this.dayLabelTable.ColumnCount = 1;
            this.dayLabelTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.dayLabelTable.Controls.Add(this.dayLabel, 0, 0);
            this.dayLabelTable.Location = new System.Drawing.Point(299, 1);
            this.dayLabelTable.Name = "dayLabelTable";
            this.dayLabelTable.RowCount = 1;
            this.dayLabelTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.dayLabelTable.Size = new System.Drawing.Size(59, 49);
            this.dayLabelTable.TabIndex = 10;
            // 
            // dispositivo
            // 
            this.dispositivo.FormattingEnabled = true;
            this.dispositivo.Location = new System.Drawing.Point(130, 651);
            this.dispositivo.Name = "dispositivo";
            this.dispositivo.Size = new System.Drawing.Size(42, 24);
            this.dispositivo.TabIndex = 11;
            // 
            // hourLabel
            // 
            this.hourLabel.AutoSize = true;
            this.hourLabel.Location = new System.Drawing.Point(3, 0);
            this.hourLabel.Name = "hourLabel";
            this.hourLabel.Size = new System.Drawing.Size(44, 16);
            this.hourLabel.TabIndex = 0;
            this.hourLabel.Text = "label1";
            // 
            // dayLabel
            // 
            this.dayLabel.AutoSize = true;
            this.dayLabel.Location = new System.Drawing.Point(3, 0);
            this.dayLabel.Name = "dayLabel";
            this.dayLabel.Size = new System.Drawing.Size(44, 16);
            this.dayLabel.TabIndex = 0;
            this.dayLabel.Text = "label1";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(423, 822);
            this.Controls.Add(this.dispositivo);
            this.Controls.Add(this.dayLabelTable);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.hourLabelTable);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtQRcode);
            this.Controls.Add(this.botonStart);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QR Code";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form2_FormClosing);
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.hourLabelTable.ResumeLayout(false);
            this.hourLabelTable.PerformLayout();
            this.dayLabelTable.ResumeLayout(false);
            this.dayLabelTable.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button botonStart;
        private System.Windows.Forms.TextBox txtQRcode;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.TableLayoutPanel hourLabelTable;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TableLayoutPanel dayLabelTable;
        private System.Windows.Forms.ComboBox dispositivo;
        private System.Windows.Forms.Label hourLabel;
        private System.Windows.Forms.Label dayLabel;
    }
}