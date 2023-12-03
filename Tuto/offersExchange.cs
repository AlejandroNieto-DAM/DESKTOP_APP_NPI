using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tuto.Properties;



namespace Tuto
{
    public partial class offersExchange : BasicFormLayout
    {
        bool isNationalExchange;
        List<Marker> markersList = new List<Marker>();
        private Dictionary<Rectangle, Marker> markerRegions = new Dictionary<Rectangle, Marker>();

        // Add markers to the list

        public offersExchange(bool nationalExchange)
        {
            isNationalExchange = nationalExchange;

            InitializeComponent();
            selectMapImage();

            markersList.Add(new Marker(new Point(0, 0), Properties.Resources.point, "Information about location 1"));
            markersList.Add(new Marker(new Point(0, 100), Properties.Resources.point, "Information about location 2"));

            pictureBox1.Paint += pictureBox1_Paint;
            this.Size = FormSize;
            //this.BackColor = Color.Transparent;
            
            //BackgroundImage = Properties.Resources.Pantalla_Background;
            //BackgroundImageLayout = ImageLayout.Zoom;

        }

        private void MostrarVentanaEmergente(string mensaje)
        {
            MessageBox.Show($"Has hecho clic en el botón: {mensaje}", "Ventana emergente");
        }

        private void selectMapImage()
        {
            pictureBox1.Invalidate();
            //Console.WriteLine(isNationalExchange);
            string currentPath = Environment.CurrentDirectory;
            Console.WriteLine("Current Path: " + currentPath);

            if (isNationalExchange)
            {
                pictureBox1.Image = Resources.map_spain;
            }
            else
            {
                pictureBox1.Image = Resources.map_europe;
            }

            if (pictureBox1.Image == null)
            {
                MessageBox.Show("Image is not loaded!"); // Add this for debugging
            }

            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;


            // Configuración de la fila y columna donde deseas colocar el PictureBox
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100));

            // Agregar el PictureBox al TableLayoutPanel
            tableLayoutPanel1.Controls.Add(pictureBox1, 1, 1);

        }


        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            markerRegions.Clear(); // Clear the dictionary before repopulating it

            // Iterate through the markers
            foreach (Marker marker in markersList)
            {
                // Draw the marker image at the specified location relative to the PictureBox
                int adjustedX = marker.Location.X + pictureBox1.Location.X;
                int adjustedY = marker.Location.Y + pictureBox1.Location.Y;

                // Create a rectangle representing the marker's region
                Rectangle markerRegion = new Rectangle(adjustedX, adjustedY, marker.Image.Width, marker.Image.Height);

                // Draw the marker image
                e.Graphics.DrawImage(marker.Image, new Point(adjustedX, adjustedY));

                // Add the marker's region to the dictionary with the corresponding marker
                markerRegions.Add(markerRegion, marker);
            }
        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            // Check if the mouse click occurred within any marker's region
            foreach (var kvp in markerRegions)
            {
                if (kvp.Key.Contains(e.Location))
                {
                    // Invoke the MarkerClicked event for the clicked marker
                    kvp.Value.OnMarkerClicked(EventArgs.Empty);
                    break; // Exit the loop after handling the first clicked marker
                }
            }
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            pictureBox1.MouseClick += pictureBox1_MouseClick;

            // Subscribe to the MarkerClicked event for each marker
            foreach (Marker marker in markersList)
            {
                marker.MarkerClicked += Marker_Clicked;
            }
        }

        private void Marker_Clicked(object sender, EventArgs e)
        {
            // Handle the marker click event here
            Marker clickedMarker = (Marker)sender;

            // Display a pop-up window with marker information
            MessageBox.Show($"Marker clicked! Information: {clickedMarker.Information}", "Marker Clicked");
        }

        private void Form4_Load_1(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
class Marker
{
    public Point Location { get; set; }
    public Image Image { get; set; }
    public string Information { get; set; }

    // Define an event for marker click
    public event EventHandler MarkerClicked;

    public Marker(Point location, Image image, string information, int desiredWidth = 15, int desiredHeight = 15)
    {
        Location = location;
        Image = ResizeImage(image, desiredWidth, desiredHeight);
        Information = information;
    }

    private Image ResizeImage(Image originalImage, int width, int height)
    {
        Bitmap resizedImage = new Bitmap(width, height);
        using (Graphics g = Graphics.FromImage(resizedImage))
        {
            g.DrawImage(originalImage, 0, 0, width, height);
        }
        return resizedImage;
    }

    // Method to raise the MarkerClicked event
    public virtual void OnMarkerClicked(EventArgs e)
    {
        MarkerClicked?.Invoke(this, e);
    }
}



