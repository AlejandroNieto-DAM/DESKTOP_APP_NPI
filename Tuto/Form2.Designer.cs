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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.buttonExit = new System.Windows.Forms.Button();
            this.hourLabelTable = new System.Windows.Forms.TableLayoutPanel();
            this.hourLabel = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.dispositivo = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dayLabel = new System.Windows.Forms.Label();
            this.dayLabelTable = new System.Windows.Forms.TableLayoutPanel();
            this.hourLabelTable.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.dayLabelTable.SuspendLayout();
            this.SuspendLayout();
            // 
            // botonStart
            // 
            this.botonStart.BackColor = System.Drawing.Color.Snow;
            this.botonStart.Font = new System.Drawing.Font("Yu Gothic UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonStart.Location = new System.Drawing.Point(137, 678);
            this.botonStart.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.botonStart.Name = "botonStart";
            this.botonStart.Size = new System.Drawing.Size(56, 19);
            this.botonStart.TabIndex = 0;
            this.botonStart.Text = "&Start";
            this.botonStart.UseVisualStyleBackColor = false;
            this.botonStart.Click += new System.EventHandler(this.botonStart_Click);
            // 
            // txtQRcode
            // 
            this.txtQRcode.Location = new System.Drawing.Point(353, 754);
            this.txtQRcode.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtQRcode.Multiline = true;
            this.txtQRcode.Name = "txtQRcode";
            this.txtQRcode.Size = new System.Drawing.Size(69, 63);
            this.txtQRcode.TabIndex = 3;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // buttonExit
            // 
            this.buttonExit.BackColor = System.Drawing.Color.Snow;
            this.buttonExit.Location = new System.Drawing.Point(24, 817);
            this.buttonExit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(56, 19);
            this.buttonExit.TabIndex = 5;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = false;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // hourLabelTable
            // 
            this.hourLabelTable.BackColor = System.Drawing.Color.Transparent;
            this.hourLabelTable.ColumnCount = 1;
            this.hourLabelTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.hourLabelTable.Controls.Add(this.hourLabel, 0, 0);
            this.hourLabelTable.Location = new System.Drawing.Point(420, 1);
            this.hourLabelTable.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.hourLabelTable.Name = "hourLabelTable";
            this.hourLabelTable.RowCount = 1;
            this.hourLabelTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.hourLabelTable.Size = new System.Drawing.Size(95, 40);
            this.hourLabelTable.TabIndex = 6;
            // 
            // hourLabel
            // 
            this.hourLabel.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hourLabel.Location = new System.Drawing.Point(2, 0);
            this.hourLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.hourLabel.Name = "hourLabel";
            this.hourLabel.Size = new System.Drawing.Size(91, 40);
            this.hourLabel.TabIndex = 0;
            this.hourLabel.Text = "label1";
            this.hourLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "ES",
            "EN"});
            this.comboBox1.Location = new System.Drawing.Point(465, 811);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(36, 25);
            this.comboBox1.TabIndex = 9;
            this.comboBox1.Text = "ES";
            // 
            // dispositivo
            // 
            this.dispositivo.BackColor = System.Drawing.Color.Snow;
            this.dispositivo.FormattingEnabled = true;
            this.dispositivo.Location = new System.Drawing.Point(101, 676);
            this.dispositivo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dispositivo.Name = "dispositivo";
            this.dispositivo.Size = new System.Drawing.Size(32, 21);
            this.dispositivo.TabIndex = 11;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Snow;
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Location = new System.Drawing.Point(55, 102);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(418, 459);
            this.panel1.TabIndex = 12;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(42, 254);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 147);
            this.label1.TabIndex = 1;
            this.label1.Text = "To log in you need your personal UGR QR code. \r\nYou can find it in your UGR App p" +
    "rofile!";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(254, 265);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 55);
            this.label2.TabIndex = 2;
            this.label2.Text = "Do not have the UGR App?";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Snow;
            this.label3.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(101, 609);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(322, 65);
            this.label3.TabIndex = 13;
            this.label3.Text = "Scan your QR code here";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Tuto.Properties.Resources.maps_icon;
            this.pictureBox3.Location = new System.Drawing.Point(269, 323);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(74, 65);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 3;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Tuto.Properties.Resources.QR_icon;
            this.pictureBox2.Location = new System.Drawing.Point(147, 31);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(141, 202);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Location = new System.Drawing.Point(192, 718);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(151, 99);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // dayLabel
            // 
            this.dayLabel.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dayLabel.Location = new System.Drawing.Point(2, 0);
            this.dayLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.dayLabel.Name = "dayLabel";
            this.dayLabel.Size = new System.Drawing.Size(86, 40);
            this.dayLabel.TabIndex = 0;
            this.dayLabel.Text = "label1";
            this.dayLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dayLabelTable
            // 
            this.dayLabelTable.BackColor = System.Drawing.Color.Transparent;
            this.dayLabelTable.ColumnCount = 1;
            this.dayLabelTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.dayLabelTable.Controls.Add(this.dayLabel, 0, 0);
            this.dayLabelTable.Location = new System.Drawing.Point(332, 1);
            this.dayLabelTable.Margin = new System.Windows.Forms.Padding(2);
            this.dayLabelTable.Name = "dayLabelTable";
            this.dayLabelTable.RowCount = 1;
            this.dayLabelTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.dayLabelTable.Size = new System.Drawing.Size(90, 40);
            this.dayLabelTable.TabIndex = 10;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = global::Tuto.Properties.Resources.Pantalla_Background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(524, 857);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dispositivo);
            this.Controls.Add(this.dayLabelTable);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.hourLabelTable);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtQRcode);
            this.Controls.Add(this.botonStart);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QR Code";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form2_FormClosing);
            this.Load += new System.EventHandler(this.Form2_Load);
            this.hourLabelTable.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.dayLabelTable.ResumeLayout(false);
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
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox dispositivo;
        private System.Windows.Forms.Label hourLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label dayLabel;
        private System.Windows.Forms.TableLayoutPanel dayLabelTable;
    }
}