using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tuto
{
    public class BasicFormLayout: Form
    {
        private TableLayoutPanel dayInfoPanel;
        private Label dayLabel;
        private Label hourLabel;
        private Timer timer;

        public string Language { get; set; }
        //public Image BackgroundImageBasic { get; set; }
        public Color BackgroundColor { get; set; }
        public Size FormSize { get; set; } 
        // Add other settings as needed

        public float diffwidth, diffheight;

        public BasicFormLayout()
        {
            InitializeComponent();
            // Set default values
            Language = "es";
            FormSize = new Size(540, 960); // Default form size

            timer = new Timer();
            timer.Interval = 1000; // Set the interval in milliseconds (1000 ms = 1 second)
            timer.Tick += time_Tick;

            timer.Start();

        }

        private void time_Tick(object sender, EventArgs e)
        {
            // Update the Label's text with the current time
            hourLabel.Text = DateTime.Now.ToString("HH:mm");
            dayLabel.Text = DateTime.Now.ToString("dd.MM.yy");

        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BasicFormLayout));
            this.dayInfoPanel = new System.Windows.Forms.TableLayoutPanel();
            this.dayLabel = new System.Windows.Forms.Label();
            this.hourLabel = new System.Windows.Forms.Label();
            this.dayInfoPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // dayInfoPanel
            // 
            this.dayInfoPanel.BackColor = System.Drawing.Color.Transparent;
            this.dayInfoPanel.ColumnCount = 3;
            this.dayInfoPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.dayInfoPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.dayInfoPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.dayInfoPanel.Controls.Add(this.dayLabel, 1, 0);
            this.dayInfoPanel.Controls.Add(this.hourLabel, 2, 0);
            this.dayInfoPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.dayInfoPanel.Location = new System.Drawing.Point(0, 0);
            this.dayInfoPanel.Margin = new System.Windows.Forms.Padding(2);
            this.dayInfoPanel.Name = "dayInfoPanel";
            this.dayInfoPanel.RowCount = 1;
            this.dayInfoPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.dayInfoPanel.Size = new System.Drawing.Size(540, 42);
            this.dayInfoPanel.TabIndex = 2;
            this.dayInfoPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.dayInfoPanel_Paint);
            // 
            // dayLabel
            // 
            this.dayLabel.AutoSize = true;
            this.dayLabel.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dayLabel.ForeColor = System.Drawing.Color.White;
            this.dayLabel.Location = new System.Drawing.Point(380, 0);
            this.dayLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.dayLabel.Name = "dayLabel";
            this.dayLabel.Size = new System.Drawing.Size(44, 22);
            this.dayLabel.TabIndex = 0;
            this.dayLabel.Text = "day";
            // 
            // hourLabel
            // 
            this.hourLabel.AutoSize = true;
            this.hourLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hourLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.hourLabel.Location = new System.Drawing.Point(461, 0);
            this.hourLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.hourLabel.Name = "hourLabel";
            this.hourLabel.Size = new System.Drawing.Size(53, 24);
            this.hourLabel.TabIndex = 1;
            this.hourLabel.Text = "hour";
            // 
            // BasicFormLayout
            // 
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(540, 960);
            this.Controls.Add(this.dayInfoPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BasicFormLayout";
            this.Load += new System.EventHandler(this.BasicFormLayout_Load);
            this.dayInfoPanel.ResumeLayout(false);
            this.dayInfoPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        private void BasicFormLayout_SizeChanged(object sender, EventArgs e)
        {
            // Calculate the multiplier for adapting screen size
            float widthMultiplier = (float)this.Width / 540;
            float heightMultiplier = (float)this.Height / 960;


 
            // Adjust your UI elements based on the multipliers
            dayInfoPanel.Size = new Size((int)(dayInfoPanel.Size.Width * widthMultiplier), dayInfoPanel.Size.Height);
            dayLabel.Font = new Font(dayLabel.Font.FontFamily, dayLabel.Font.Size * widthMultiplier);
            hourLabel.Font = new Font(hourLabel.Font.FontFamily, hourLabel.Font.Size * widthMultiplier);
        }

        private void BasicFormLayout_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;

            float widthMultiplier = (float)this.Width / 540;
            float heightMultiplier = (float)this.Height / 960;

            diffheight = widthMultiplier;
            diffheight = heightMultiplier;
        }

        private void dayInfoPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
