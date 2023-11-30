using System.Drawing;
using System.Windows.Forms;

namespace Tuto
{
    partial class MenuComedor
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
            this.MenuPanel1 = new System.Windows.Forms.Panel();
            this.Preorder1 = new System.Windows.Forms.Button();
            this.Menu1 = new System.Windows.Forms.Label();
            this.Collapse1 = new System.Windows.Forms.Button();
            this.CollapseTimer1 = new System.Windows.Forms.Timer(this.components);
            this.week1Panel = new System.Windows.Forms.FlowLayoutPanel();
            this.week1 = new System.Windows.Forms.Button();
            this.MenuPanel0 = new System.Windows.Forms.Panel();
            this.Preorder0 = new System.Windows.Forms.Button();
            this.Menu0 = new System.Windows.Forms.Label();
            this.Collapse0 = new System.Windows.Forms.Button();
            this.MenuPanel2 = new System.Windows.Forms.Panel();
            this.Preorder2 = new System.Windows.Forms.Button();
            this.Menu2 = new System.Windows.Forms.Label();
            this.Collapse2 = new System.Windows.Forms.Button();
            this.MenuPanel3 = new System.Windows.Forms.Panel();
            this.Preorder3 = new System.Windows.Forms.Button();
            this.Menu3 = new System.Windows.Forms.Label();
            this.Collapse3 = new System.Windows.Forms.Button();
            this.MenuPanel4 = new System.Windows.Forms.Panel();
            this.Preorder4 = new System.Windows.Forms.Button();
            this.Menu4 = new System.Windows.Forms.Label();
            this.Collapse4 = new System.Windows.Forms.Button();
            this.MenuPanel5 = new System.Windows.Forms.Panel();
            this.Preorder5 = new System.Windows.Forms.Button();
            this.Menu5 = new System.Windows.Forms.Label();
            this.Collapse5 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.MenuPanel1.SuspendLayout();
            this.week1Panel.SuspendLayout();
            this.MenuPanel0.SuspendLayout();
            this.MenuPanel2.SuspendLayout();
            this.MenuPanel3.SuspendLayout();
            this.MenuPanel4.SuspendLayout();
            this.MenuPanel5.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // MenuPanel1
            // 
            this.MenuPanel1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.MenuPanel1.Controls.Add(this.Preorder1);
            this.MenuPanel1.Controls.Add(this.Menu1);
            this.MenuPanel1.Controls.Add(this.Collapse1);
            this.MenuPanel1.Location = new System.Drawing.Point(29, 78);
            this.MenuPanel1.Margin = new System.Windows.Forms.Padding(29, 2, 29, 2);
            this.MenuPanel1.MaximumSize = new System.Drawing.Size(245, 194);
            this.MenuPanel1.MinimumSize = new System.Drawing.Size(245, 30);
            this.MenuPanel1.Name = "MenuPanel1";
            this.MenuPanel1.Size = new System.Drawing.Size(245, 30);
            this.MenuPanel1.TabIndex = 3;
            this.MenuPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // Preorder1
            // 
            this.Preorder1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Preorder1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Preorder1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Preorder1.FlatAppearance.BorderSize = 0;
            this.Preorder1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Preorder1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Preorder1.Location = new System.Drawing.Point(23, 160);
            this.Preorder1.Margin = new System.Windows.Forms.Padding(0);
            this.Preorder1.Name = "Preorder1";
            this.Preorder1.Size = new System.Drawing.Size(199, 28);
            this.Preorder1.TabIndex = 5;
            this.Preorder1.Text = "button2";
            this.Preorder1.UseVisualStyleBackColor = false;
            // 
            // Menu1
            // 
            this.Menu1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Menu1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Menu1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Menu1.Location = new System.Drawing.Point(23, 39);
            this.Menu1.Margin = new System.Windows.Forms.Padding(0);
            this.Menu1.Name = "Menu1";
            this.Menu1.Size = new System.Drawing.Size(199, 112);
            this.Menu1.TabIndex = 4;
            this.Menu1.Text = "label1";
            this.Menu1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Menu1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // Collapse1
            // 
            this.Collapse1.BackColor = System.Drawing.Color.Transparent;
            this.Collapse1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Collapse1.Dock = System.Windows.Forms.DockStyle.Top;
            this.Collapse1.FlatAppearance.BorderSize = 0;
            this.Collapse1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Collapse1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Collapse1.Image = global::Tuto.Properties.Resources.dropRightTrans;
            this.Collapse1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Collapse1.Location = new System.Drawing.Point(0, 0);
            this.Collapse1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Collapse1.MaximumSize = new System.Drawing.Size(245, 30);
            this.Collapse1.Name = "Collapse1";
            this.Collapse1.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.Collapse1.Size = new System.Drawing.Size(245, 30);
            this.Collapse1.TabIndex = 4;
            this.Collapse1.Text = "Tuesday";
            this.Collapse1.UseVisualStyleBackColor = false;
            this.Collapse1.Click += new System.EventHandler(this.Collapse1_Click);
            // 
            // CollapseTimer1
            // 
            this.CollapseTimer1.Interval = 5;
            this.CollapseTimer1.Tick += new System.EventHandler(this.CollapseTimer_Tick);
            // 
            // week1Panel
            // 
            this.week1Panel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.week1Panel.Controls.Add(this.week1);
            this.week1Panel.Controls.Add(this.MenuPanel0);
            this.week1Panel.Controls.Add(this.MenuPanel1);
            this.week1Panel.Controls.Add(this.MenuPanel2);
            this.week1Panel.Controls.Add(this.MenuPanel3);
            this.week1Panel.Controls.Add(this.MenuPanel4);
            this.week1Panel.Controls.Add(this.MenuPanel5);
            this.week1Panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.week1Panel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.week1Panel.Location = new System.Drawing.Point(208, 247);
            this.week1Panel.Margin = new System.Windows.Forms.Padding(0);
            this.week1Panel.Name = "week1Panel";
            this.week1Panel.Size = new System.Drawing.Size(307, 615);
            this.week1Panel.TabIndex = 0;
            // 
            // week1
            // 
            this.week1.BackColor = System.Drawing.Color.Transparent;
            this.week1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.week1.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.week1.FlatAppearance.BorderSize = 0;
            this.week1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.week1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.week1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.week1.ImageKey = "(none)";
            this.week1.Location = new System.Drawing.Point(16, 2);
            this.week1.Margin = new System.Windows.Forms.Padding(16, 2, 16, 2);
            this.week1.Name = "week1";
            this.week1.Size = new System.Drawing.Size(271, 38);
            this.week1.TabIndex = 4;
            this.week1.Text = "This week";
            this.week1.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.week1.UseVisualStyleBackColor = false;
            this.week1.Click += new System.EventHandler(this.week1_Click);
            // 
            // MenuPanel0
            // 
            this.MenuPanel0.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.MenuPanel0.Controls.Add(this.Preorder0);
            this.MenuPanel0.Controls.Add(this.Menu0);
            this.MenuPanel0.Controls.Add(this.Collapse0);
            this.MenuPanel0.Location = new System.Drawing.Point(29, 44);
            this.MenuPanel0.Margin = new System.Windows.Forms.Padding(29, 2, 29, 2);
            this.MenuPanel0.MaximumSize = new System.Drawing.Size(245, 194);
            this.MenuPanel0.MinimumSize = new System.Drawing.Size(245, 30);
            this.MenuPanel0.Name = "MenuPanel0";
            this.MenuPanel0.Size = new System.Drawing.Size(245, 30);
            this.MenuPanel0.TabIndex = 6;
            // 
            // Preorder0
            // 
            this.Preorder0.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Preorder0.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Preorder0.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Preorder0.FlatAppearance.BorderSize = 0;
            this.Preorder0.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Preorder0.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Preorder0.Location = new System.Drawing.Point(23, 160);
            this.Preorder0.Margin = new System.Windows.Forms.Padding(0);
            this.Preorder0.Name = "Preorder0";
            this.Preorder0.Size = new System.Drawing.Size(199, 28);
            this.Preorder0.TabIndex = 5;
            this.Preorder0.Text = "Preorder";
            this.Preorder0.UseVisualStyleBackColor = false;
            // 
            // Menu0
            // 
            this.Menu0.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Menu0.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Menu0.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Menu0.Location = new System.Drawing.Point(23, 39);
            this.Menu0.Margin = new System.Windows.Forms.Padding(0);
            this.Menu0.Name = "Menu0";
            this.Menu0.Size = new System.Drawing.Size(199, 112);
            this.Menu0.TabIndex = 4;
            this.Menu0.Text = "Menu 1: - Rancho canario - Fritura de pescado";
            this.Menu0.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Collapse0
            // 
            this.Collapse0.BackColor = System.Drawing.Color.Transparent;
            this.Collapse0.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Collapse0.Dock = System.Windows.Forms.DockStyle.Top;
            this.Collapse0.FlatAppearance.BorderSize = 0;
            this.Collapse0.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Collapse0.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Collapse0.Image = global::Tuto.Properties.Resources.dropRightTrans;
            this.Collapse0.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Collapse0.Location = new System.Drawing.Point(0, 0);
            this.Collapse0.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Collapse0.MaximumSize = new System.Drawing.Size(245, 30);
            this.Collapse0.Name = "Collapse0";
            this.Collapse0.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.Collapse0.Size = new System.Drawing.Size(245, 30);
            this.Collapse0.TabIndex = 4;
            this.Collapse0.Text = "Monday";
            this.Collapse0.UseVisualStyleBackColor = false;
            this.Collapse0.Click += new System.EventHandler(this.Collapse0_Click);
            // 
            // MenuPanel2
            // 
            this.MenuPanel2.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.MenuPanel2.Controls.Add(this.Preorder2);
            this.MenuPanel2.Controls.Add(this.Menu2);
            this.MenuPanel2.Controls.Add(this.Collapse2);
            this.MenuPanel2.Location = new System.Drawing.Point(29, 112);
            this.MenuPanel2.Margin = new System.Windows.Forms.Padding(29, 2, 29, 2);
            this.MenuPanel2.MaximumSize = new System.Drawing.Size(245, 194);
            this.MenuPanel2.MinimumSize = new System.Drawing.Size(245, 30);
            this.MenuPanel2.Name = "MenuPanel2";
            this.MenuPanel2.Size = new System.Drawing.Size(245, 30);
            this.MenuPanel2.TabIndex = 6;
            // 
            // Preorder2
            // 
            this.Preorder2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Preorder2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Preorder2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Preorder2.FlatAppearance.BorderSize = 0;
            this.Preorder2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Preorder2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Preorder2.Location = new System.Drawing.Point(23, 160);
            this.Preorder2.Margin = new System.Windows.Forms.Padding(0);
            this.Preorder2.Name = "Preorder2";
            this.Preorder2.Size = new System.Drawing.Size(199, 28);
            this.Preorder2.TabIndex = 5;
            this.Preorder2.Text = "Preorder";
            this.Preorder2.UseVisualStyleBackColor = false;
            // 
            // Menu2
            // 
            this.Menu2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Menu2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Menu2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Menu2.Location = new System.Drawing.Point(23, 39);
            this.Menu2.Margin = new System.Windows.Forms.Padding(0);
            this.Menu2.Name = "Menu2";
            this.Menu2.Size = new System.Drawing.Size(199, 112);
            this.Menu2.TabIndex = 4;
            this.Menu2.Text = "label1";
            this.Menu2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Collapse2
            // 
            this.Collapse2.BackColor = System.Drawing.Color.Transparent;
            this.Collapse2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Collapse2.Dock = System.Windows.Forms.DockStyle.Top;
            this.Collapse2.FlatAppearance.BorderSize = 0;
            this.Collapse2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Collapse2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Collapse2.Image = global::Tuto.Properties.Resources.dropRightTrans;
            this.Collapse2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Collapse2.Location = new System.Drawing.Point(0, 0);
            this.Collapse2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Collapse2.MaximumSize = new System.Drawing.Size(245, 30);
            this.Collapse2.Name = "Collapse2";
            this.Collapse2.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.Collapse2.Size = new System.Drawing.Size(245, 30);
            this.Collapse2.TabIndex = 4;
            this.Collapse2.Text = "Wednesday";
            this.Collapse2.UseVisualStyleBackColor = false;
            this.Collapse2.Click += new System.EventHandler(this.Collapse2_Click);
            // 
            // MenuPanel3
            // 
            this.MenuPanel3.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.MenuPanel3.Controls.Add(this.Preorder3);
            this.MenuPanel3.Controls.Add(this.Menu3);
            this.MenuPanel3.Controls.Add(this.Collapse3);
            this.MenuPanel3.Location = new System.Drawing.Point(29, 146);
            this.MenuPanel3.Margin = new System.Windows.Forms.Padding(29, 2, 29, 2);
            this.MenuPanel3.MaximumSize = new System.Drawing.Size(245, 194);
            this.MenuPanel3.MinimumSize = new System.Drawing.Size(245, 30);
            this.MenuPanel3.Name = "MenuPanel3";
            this.MenuPanel3.Size = new System.Drawing.Size(245, 30);
            this.MenuPanel3.TabIndex = 7;
            // 
            // Preorder3
            // 
            this.Preorder3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Preorder3.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Preorder3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Preorder3.FlatAppearance.BorderSize = 0;
            this.Preorder3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Preorder3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Preorder3.Location = new System.Drawing.Point(23, 160);
            this.Preorder3.Margin = new System.Windows.Forms.Padding(0);
            this.Preorder3.Name = "Preorder3";
            this.Preorder3.Size = new System.Drawing.Size(199, 28);
            this.Preorder3.TabIndex = 5;
            this.Preorder3.Text = "Preorder";
            this.Preorder3.UseVisualStyleBackColor = false;
            // 
            // Menu3
            // 
            this.Menu3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Menu3.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Menu3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Menu3.Location = new System.Drawing.Point(23, 39);
            this.Menu3.Margin = new System.Windows.Forms.Padding(0);
            this.Menu3.Name = "Menu3";
            this.Menu3.Size = new System.Drawing.Size(199, 112);
            this.Menu3.TabIndex = 4;
            this.Menu3.Text = "label1";
            this.Menu3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Collapse3
            // 
            this.Collapse3.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.Collapse3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Collapse3.Dock = System.Windows.Forms.DockStyle.Top;
            this.Collapse3.FlatAppearance.BorderSize = 0;
            this.Collapse3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Collapse3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Collapse3.Image = global::Tuto.Properties.Resources.dropRightTrans;
            this.Collapse3.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Collapse3.Location = new System.Drawing.Point(0, 0);
            this.Collapse3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Collapse3.MaximumSize = new System.Drawing.Size(245, 30);
            this.Collapse3.Name = "Collapse3";
            this.Collapse3.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.Collapse3.Size = new System.Drawing.Size(245, 30);
            this.Collapse3.TabIndex = 4;
            this.Collapse3.Text = "Thursday";
            this.Collapse3.UseVisualStyleBackColor = false;
            this.Collapse3.Click += new System.EventHandler(this.Collapse3_Click);
            // 
            // MenuPanel4
            // 
            this.MenuPanel4.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.MenuPanel4.Controls.Add(this.Preorder4);
            this.MenuPanel4.Controls.Add(this.Menu4);
            this.MenuPanel4.Controls.Add(this.Collapse4);
            this.MenuPanel4.Location = new System.Drawing.Point(29, 180);
            this.MenuPanel4.Margin = new System.Windows.Forms.Padding(29, 2, 29, 2);
            this.MenuPanel4.MaximumSize = new System.Drawing.Size(245, 194);
            this.MenuPanel4.MinimumSize = new System.Drawing.Size(245, 30);
            this.MenuPanel4.Name = "MenuPanel4";
            this.MenuPanel4.Size = new System.Drawing.Size(245, 30);
            this.MenuPanel4.TabIndex = 8;
            // 
            // Preorder4
            // 
            this.Preorder4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Preorder4.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Preorder4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Preorder4.FlatAppearance.BorderSize = 0;
            this.Preorder4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Preorder4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Preorder4.Location = new System.Drawing.Point(23, 160);
            this.Preorder4.Margin = new System.Windows.Forms.Padding(0);
            this.Preorder4.Name = "Preorder4";
            this.Preorder4.Size = new System.Drawing.Size(199, 28);
            this.Preorder4.TabIndex = 5;
            this.Preorder4.Text = "Preorder";
            this.Preorder4.UseVisualStyleBackColor = false;
            // 
            // Menu4
            // 
            this.Menu4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Menu4.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Menu4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Menu4.Location = new System.Drawing.Point(23, 39);
            this.Menu4.Margin = new System.Windows.Forms.Padding(0);
            this.Menu4.Name = "Menu4";
            this.Menu4.Size = new System.Drawing.Size(199, 112);
            this.Menu4.TabIndex = 4;
            this.Menu4.Text = "label3";
            this.Menu4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Menu4.Click += new System.EventHandler(this.Menu4_Click);
            // 
            // Collapse4
            // 
            this.Collapse4.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.Collapse4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Collapse4.Dock = System.Windows.Forms.DockStyle.Top;
            this.Collapse4.FlatAppearance.BorderSize = 0;
            this.Collapse4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Collapse4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Collapse4.Image = global::Tuto.Properties.Resources.dropRightTrans;
            this.Collapse4.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Collapse4.Location = new System.Drawing.Point(0, 0);
            this.Collapse4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Collapse4.MaximumSize = new System.Drawing.Size(245, 30);
            this.Collapse4.Name = "Collapse4";
            this.Collapse4.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.Collapse4.Size = new System.Drawing.Size(245, 30);
            this.Collapse4.TabIndex = 4;
            this.Collapse4.Text = "Friday";
            this.Collapse4.UseVisualStyleBackColor = false;
            this.Collapse4.Click += new System.EventHandler(this.Collapse4_Click);
            // 
            // MenuPanel5
            // 
            this.MenuPanel5.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.MenuPanel5.Controls.Add(this.Preorder5);
            this.MenuPanel5.Controls.Add(this.Menu5);
            this.MenuPanel5.Controls.Add(this.Collapse5);
            this.MenuPanel5.Location = new System.Drawing.Point(29, 214);
            this.MenuPanel5.Margin = new System.Windows.Forms.Padding(29, 2, 29, 2);
            this.MenuPanel5.MaximumSize = new System.Drawing.Size(245, 194);
            this.MenuPanel5.MinimumSize = new System.Drawing.Size(245, 30);
            this.MenuPanel5.Name = "MenuPanel5";
            this.MenuPanel5.Size = new System.Drawing.Size(245, 30);
            this.MenuPanel5.TabIndex = 8;
            // 
            // Preorder5
            // 
            this.Preorder5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Preorder5.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Preorder5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Preorder5.FlatAppearance.BorderSize = 0;
            this.Preorder5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Preorder5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Preorder5.Location = new System.Drawing.Point(23, 160);
            this.Preorder5.Margin = new System.Windows.Forms.Padding(0);
            this.Preorder5.Name = "Preorder5";
            this.Preorder5.Size = new System.Drawing.Size(199, 28);
            this.Preorder5.TabIndex = 5;
            this.Preorder5.Text = "Preorder";
            this.Preorder5.UseVisualStyleBackColor = false;
            // 
            // Menu5
            // 
            this.Menu5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Menu5.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Menu5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Menu5.Location = new System.Drawing.Point(23, 42);
            this.Menu5.Margin = new System.Windows.Forms.Padding(0);
            this.Menu5.Name = "Menu5";
            this.Menu5.Size = new System.Drawing.Size(199, 112);
            this.Menu5.TabIndex = 4;
            this.Menu5.Text = "label2";
            this.Menu5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Menu5.Click += new System.EventHandler(this.Menu5_Click);
            // 
            // Collapse5
            // 
            this.Collapse5.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.Collapse5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Collapse5.Dock = System.Windows.Forms.DockStyle.Top;
            this.Collapse5.FlatAppearance.BorderSize = 0;
            this.Collapse5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Collapse5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Collapse5.Image = global::Tuto.Properties.Resources.dropRightTrans;
            this.Collapse5.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Collapse5.Location = new System.Drawing.Point(0, 0);
            this.Collapse5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Collapse5.MaximumSize = new System.Drawing.Size(245, 30);
            this.Collapse5.Name = "Collapse5";
            this.Collapse5.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.Collapse5.Size = new System.Drawing.Size(245, 30);
            this.Collapse5.TabIndex = 4;
            this.Collapse5.Text = "Saturday";
            this.Collapse5.UseVisualStyleBackColor = false;
            this.Collapse5.Click += new System.EventHandler(this.Collapse5_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(68, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(296, 51);
            this.label1.TabIndex = 1;
            this.label1.Text = "¡Bienvenidos!";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 208F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 184F));
            this.tableLayoutPanel1.Controls.Add(this.week1Panel, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.button1, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 1, 4);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 187F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 81.78571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18.21428F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(699, 1055);
            this.tableLayoutPanel1.TabIndex = 2;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(211, 190);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(301, 54);
            this.button1.TabIndex = 1;
            this.button1.Text = "Bienvenid@";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(211, 893);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(301, 22);
            this.panel1.TabIndex = 4;
            // 
            // button2
            // 
            this.button2.Dock = System.Windows.Forms.DockStyle.Right;
            this.button2.Location = new System.Drawing.Point(226, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 22);
            this.button2.TabIndex = 0;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Dock = System.Windows.Forms.DockStyle.Left;
            this.button3.Location = new System.Drawing.Point(0, 0);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 22);
            this.button3.TabIndex = 1;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // MenuComedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(699, 1055);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MenuComedor";
            this.Text = "MenuComedor";
            this.Load += new System.EventHandler(this.MenuComedor_Load);
            this.MenuPanel1.ResumeLayout(false);
            this.week1Panel.ResumeLayout(false);
            this.MenuPanel0.ResumeLayout(false);
            this.MenuPanel2.ResumeLayout(false);
            this.MenuPanel3.ResumeLayout(false);
            this.MenuPanel4.ResumeLayout(false);
            this.MenuPanel5.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer CollapseTimer1;
        private System.Windows.Forms.Button Collapse1;
        private System.Windows.Forms.Label Menu1;
        protected internal System.Windows.Forms.Panel MenuPanel1;
        private System.Windows.Forms.Button Preorder1;
        private System.Windows.Forms.FlowLayoutPanel week1Panel;
        private System.Windows.Forms.Button week1;
        protected internal System.Windows.Forms.Panel MenuPanel2;
        private System.Windows.Forms.Button Preorder2;
        private System.Windows.Forms.Label Menu2;
        private System.Windows.Forms.Button Collapse2;
        protected internal System.Windows.Forms.Panel MenuPanel0;
        private System.Windows.Forms.Button Preorder0;
        private System.Windows.Forms.Label Menu0;
        private System.Windows.Forms.Button Collapse0;
        protected internal System.Windows.Forms.Panel MenuPanel3;
        private System.Windows.Forms.Button Preorder3;
        private System.Windows.Forms.Label Menu3;
        private System.Windows.Forms.Button Collapse3;
        protected internal System.Windows.Forms.Panel MenuPanel4;
        private System.Windows.Forms.Button Preorder4;
        private System.Windows.Forms.Label Menu4;
        private System.Windows.Forms.Button Collapse4;
        protected internal System.Windows.Forms.Panel MenuPanel5;
        private System.Windows.Forms.Button Preorder5;
        private System.Windows.Forms.Label Menu5;
        private System.Windows.Forms.Button Collapse5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer SlideTimer;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private Button button1;
        private Panel panel1;
        private Button button3;
        private Button button2;
    }
}