namespace Tuto
{
    partial class Home
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
            this.welcomeLabel = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.placeButton = new System.Windows.Forms.Button();
            this.tableLayoutOptions = new System.Windows.Forms.TableLayoutPanel();
            this.scheduleButton = new System.Windows.Forms.Button();
            this.menuButton = new System.Windows.Forms.Button();
            this.professorsButton = new System.Windows.Forms.Button();
            this.adminButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.button6 = new System.Windows.Forms.Button();
            this.languageBox = new System.Windows.Forms.ComboBox();
            this.welcomePanel = new System.Windows.Forms.Panel();
            this.dayInfoPanel = new System.Windows.Forms.TableLayoutPanel();
            this.dayLabel = new System.Windows.Forms.Label();
            this.hourLabel = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutOptions.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.welcomePanel.SuspendLayout();
            this.dayInfoPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // welcomeLabel
            // 
            this.welcomeLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.welcomeLabel.AutoSize = true;
            this.welcomeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 31.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcomeLabel.ForeColor = System.Drawing.Color.White;
            this.welcomeLabel.Location = new System.Drawing.Point(3, 0);
            this.welcomeLabel.Name = "welcomeLabel";
            this.welcomeLabel.Size = new System.Drawing.Size(316, 61);
            this.welcomeLabel.TabIndex = 0;
            this.welcomeLabel.Text = "Bienvenidos";
            this.welcomeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.welcomeLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.tableLayoutPanel2);
            this.panel2.Controls.Add(this.welcomePanel);
            this.panel2.Controls.Add(this.dayInfoPanel);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(521, 1055);
            this.panel2.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.tableLayoutPanel3);
            this.panel4.Controls.Add(this.tableLayoutOptions);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 123);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(521, 832);
            this.panel4.TabIndex = 4;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 3;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 76F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12F));
            this.tableLayoutPanel3.Controls.Add(this.placeButton, 1, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 460);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.Padding = new System.Windows.Forms.Padding(10, 0, 10, 10);
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(521, 135);
            this.tableLayoutPanel3.TabIndex = 1;
            this.tableLayoutPanel3.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel3_Paint);
            // 
            // placeButton
            // 
            this.placeButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.placeButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.placeButton.Location = new System.Drawing.Point(73, 3);
            this.placeButton.Name = "placeButton";
            this.placeButton.Size = new System.Drawing.Size(374, 119);
            this.placeButton.TabIndex = 0;
            this.placeButton.Text = "Buscar lugar";
            this.placeButton.UseVisualStyleBackColor = true;
            this.placeButton.Click += new System.EventHandler(this.button5_Click);
            // 
            // tableLayoutOptions
            // 
            this.tableLayoutOptions.ColumnCount = 5;
            this.tableLayoutOptions.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12F));
            this.tableLayoutOptions.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 32F));
            this.tableLayoutOptions.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12F));
            this.tableLayoutOptions.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 32F));
            this.tableLayoutOptions.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12F));
            this.tableLayoutOptions.Controls.Add(this.scheduleButton, 1, 0);
            this.tableLayoutOptions.Controls.Add(this.menuButton, 3, 0);
            this.tableLayoutOptions.Controls.Add(this.professorsButton, 1, 2);
            this.tableLayoutOptions.Controls.Add(this.adminButton, 3, 2);
            this.tableLayoutOptions.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutOptions.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutOptions.Name = "tableLayoutOptions";
            this.tableLayoutOptions.Padding = new System.Windows.Forms.Padding(10);
            this.tableLayoutOptions.RowCount = 4;
            this.tableLayoutOptions.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 177F));
            this.tableLayoutOptions.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tableLayoutOptions.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 177F));
            this.tableLayoutOptions.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tableLayoutOptions.Size = new System.Drawing.Size(521, 460);
            this.tableLayoutOptions.TabIndex = 0;
            this.tableLayoutOptions.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // scheduleButton
            // 
            this.scheduleButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scheduleButton.Location = new System.Drawing.Point(70, 10);
            this.scheduleButton.Margin = new System.Windows.Forms.Padding(0);
            this.scheduleButton.Name = "scheduleButton";
            this.scheduleButton.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.scheduleButton.Size = new System.Drawing.Size(160, 177);
            this.scheduleButton.TabIndex = 0;
            this.scheduleButton.Text = "Mi horario";
            this.scheduleButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.scheduleButton.UseVisualStyleBackColor = true;
            // 
            // menuButton
            // 
            this.menuButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.menuButton.Location = new System.Drawing.Point(293, 13);
            this.menuButton.Name = "menuButton";
            this.menuButton.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.menuButton.Size = new System.Drawing.Size(154, 171);
            this.menuButton.TabIndex = 3;
            this.menuButton.Text = "Menú cafeteria";
            this.menuButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.menuButton.UseVisualStyleBackColor = true;
            // 
            // professorsButton
            // 
            this.professorsButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.professorsButton.Location = new System.Drawing.Point(73, 235);
            this.professorsButton.Name = "professorsButton";
            this.professorsButton.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.professorsButton.Size = new System.Drawing.Size(154, 171);
            this.professorsButton.TabIndex = 4;
            this.professorsButton.Text = "Información profesores";
            this.professorsButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.professorsButton.UseVisualStyleBackColor = true;
            // 
            // adminButton
            // 
            this.adminButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.adminButton.Location = new System.Drawing.Point(293, 235);
            this.adminButton.Name = "adminButton";
            this.adminButton.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.adminButton.Size = new System.Drawing.Size(154, 171);
            this.adminButton.TabIndex = 5;
            this.adminButton.Text = "Procesos administrativos";
            this.adminButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.adminButton.UseVisualStyleBackColor = true;
            this.adminButton.Click += new System.EventHandler(this.button4_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 44F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 44F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12F));
            this.tableLayoutPanel2.Controls.Add(this.button6, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.languageBox, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 955);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.Padding = new System.Windows.Forms.Padding(10);
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(521, 100);
            this.tableLayoutPanel2.TabIndex = 3;
            // 
            // button6
            // 
            this.button6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button6.Location = new System.Drawing.Point(130, 13);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(97, 36);
            this.button6.TabIndex = 0;
            this.button6.Text = "logOutButton";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // languageBox
            // 
            this.languageBox.AccessibleDescription = "Language selection";
            this.languageBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.languageBox.FormattingEnabled = true;
            this.languageBox.Items.AddRange(new object[] {
            "ES",
            "EN"});
            this.languageBox.Location = new System.Drawing.Point(371, 13);
            this.languageBox.Name = "languageBox";
            this.languageBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.languageBox.Size = new System.Drawing.Size(76, 24);
            this.languageBox.TabIndex = 1;
            this.languageBox.Text = "ES";
            this.languageBox.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // welcomePanel
            // 
            this.welcomePanel.Controls.Add(this.welcomeLabel);
            this.welcomePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.welcomePanel.Location = new System.Drawing.Point(0, 52);
            this.welcomePanel.Name = "welcomePanel";
            this.welcomePanel.Size = new System.Drawing.Size(521, 71);
            this.welcomePanel.TabIndex = 2;
            // 
            // dayInfoPanel
            // 
            this.dayInfoPanel.ColumnCount = 3;
            this.dayInfoPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.dayInfoPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.dayInfoPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.dayInfoPanel.Controls.Add(this.dayLabel, 1, 0);
            this.dayInfoPanel.Controls.Add(this.hourLabel, 2, 0);
            this.dayInfoPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.dayInfoPanel.Location = new System.Drawing.Point(0, 0);
            this.dayInfoPanel.Name = "dayInfoPanel";
            this.dayInfoPanel.RowCount = 1;
            this.dayInfoPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.dayInfoPanel.Size = new System.Drawing.Size(521, 52);
            this.dayInfoPanel.TabIndex = 1;
            this.dayInfoPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.dayInfoPanel_Paint);
            // 
            // dayLabel
            // 
            this.dayLabel.AutoSize = true;
            this.dayLabel.Location = new System.Drawing.Point(367, 0);
            this.dayLabel.Name = "dayLabel";
            this.dayLabel.Size = new System.Drawing.Size(0, 16);
            this.dayLabel.TabIndex = 0;
            this.dayLabel.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // hourLabel
            // 
            this.hourLabel.AutoSize = true;
            this.hourLabel.Location = new System.Drawing.Point(445, 0);
            this.hourLabel.Name = "hourLabel";
            this.hourLabel.Size = new System.Drawing.Size(33, 16);
            this.hourLabel.TabIndex = 1;
            this.hourLabel.Text = "hour";
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(127)))), ((int)(((byte)(121)))));
            this.ClientSize = new System.Drawing.Size(417, 844);
            this.Controls.Add(this.panel2);
            this.Name = "Home";
            this.Text = "Home";
            this.Load += new System.EventHandler(this.Home_Load);
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutOptions.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.welcomePanel.ResumeLayout(false);
            this.welcomePanel.PerformLayout();
            this.dayInfoPanel.ResumeLayout(false);
            this.dayInfoPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label welcomeLabel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutOptions;
        private System.Windows.Forms.TableLayoutPanel dayInfoPanel;
        private System.Windows.Forms.Panel welcomePanel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label dayLabel;
        private System.Windows.Forms.Label hourLabel;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Button placeButton;
        private System.Windows.Forms.Button scheduleButton;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.ComboBox languageBox;
        private System.Windows.Forms.Button menuButton;
        private System.Windows.Forms.Button professorsButton;
        private System.Windows.Forms.Button adminButton;
    }
}