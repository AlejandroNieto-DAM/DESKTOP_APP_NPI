using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Leap;

namespace Tuto
{

    public partial class Form1 : Form, ILeapEventDelegate
    {

        private Controller controller;
        private LeapEventListener listener;
        private long currentTime;
        private long previousTime;
        private long timeChange;
        private int waitUntilMoveCursor;

        public Form1()
        {
            InitializeComponent();
            //loadImage();
            this.controller = new Controller();
            this.listener = new LeapEventListener(this);
            controller.AddListener(listener);
        }


        delegate void LeapEventDelegate(string EventName);
        public void LeapEventNotification(string EventName)
        {
            if (!this.InvokeRequired)
            {
                switch (EventName)
                {
                    case "onInit":
                        //MessageBox.Show("Initialize");
                        break;
                    case "onConnect":
                        //MessageBox.Show("Connected"); 
                        connectHandler();
                        break;
                    case "onFrame":

                        //MessageBox.Show("Frame");
                        //SetCursorPos(1, 2);
                        detectGesture(this.controller.Frame());
                        //movingMouse(this.controller.Frame(), this.controller);
                        break;
                }
            }
            else
            {
                BeginInvoke(new LeapEventDelegate(LeapEventNotification), new object[] { EventName });
            }
        }

        private void detectGesture(Leap.Frame frame)
        {

            currentTime = frame.Timestamp;
            timeChange = currentTime - previousTime;

            GestureList gestures = frame.Gestures();
            for(int i = 0; i < gestures.Count(); i++)
            {
                Gesture gesture = gestures[i];
                switch (gesture.Type) {
                    case Gesture.GestureType.TYPEKEYTAP:
                        this.richTextBox1.AppendText("KeyTAP DETECTED" + Environment.NewLine);
                        
                        if(this.button1.BackColor == Color.Green)
                        {
                            this.richTextBox1.AppendText("BOTON PULSADO" + Environment.NewLine);
                        }
                        break;
                    
                }
            }

            if (gestures.Count() > 0)  
            {
                waitUntilMoveCursor = 35;
            }

            if(waitUntilMoveCursor == 0)
            {
                movingMouse(frame, this.controller);
            } else
            {
                waitUntilMoveCursor -= 1;
            }
            
        }

        private void connectHandler()
        {
            this.controller.EnableGesture(Gesture.GestureType.TYPEKEYTAP);
        }

        private void movingMouse(Leap.Frame frame, Controller controlador)
        {


            currentTime = frame.Timestamp;
            timeChange = currentTime - previousTime;

            if (timeChange > 10000)
            {
                if (frame.Hands.Count > 0)
                {
                    Finger finger = frame.Fingers[0];
                    // Get the closest screen intercepting a ray projecting from the finger
                    Leap.Screen screen  = controlador.LocatedScreens.ClosestScreenHit(finger);

                    if (screen != null && screen.IsValid)
                    {
                        // Get the velocity of the finger tip
                        var tipVelocity = (int)finger.TipVelocity.Magnitude;

                        // Use tipVelocity to reduce jitters when attempting to hold
                        // the cursor steady
                        if (tipVelocity > 70)
                        {
                            var xScreenIntersect = screen.Intersect(finger, true).x;
                            var yScreenIntersect = screen.Intersect(finger, true).y;

                            if (xScreenIntersect.ToString() != "NaN")
                            {
                                var x = (int)(xScreenIntersect * screen.WidthPixels);
                                var y = (int)(screen.HeightPixels - (yScreenIntersect * screen.HeightPixels));

                                Console.WriteLine("Screen intersect X: " + xScreenIntersect.ToString());
                                Console.WriteLine("Screen intersect Y: " + yScreenIntersect.ToString());
                                Console.WriteLine("Width pixels: " + screen.WidthPixels.ToString());
                                Console.WriteLine("Height pixels: " + screen.HeightPixels.ToString());

                                Console.WriteLine("\n");

                                Console.WriteLine("x: " + x.ToString());
                                Console.WriteLine("y: " + y.ToString());

                                Console.WriteLine("\n");

                                Console.WriteLine("Tip velocity: " + tipVelocity.ToString());

                                // Move the cursor
                                MouseCursor.MoveCursor(x, y);

                                Console.WriteLine("\n" + new String('=', 40) + "\n");
                            }

                        }
                    }
                }
            }

            foreach (Finger finger in frame.Fingers)
            {
                richTextBox2.AppendText("Finger id " + finger.Id + Environment.NewLine);

            }
        }

        private void loadImage()
        {
            //Comentari
            string rutaImagen = @"C:\Users\Alejandro\Documents\4to\NPI\Leap Motion\UNI.png"; // Reemplaza "nombreDeTuArchivo.jpg" con el nombre real de tu archivo de imagen.
            //string rutaImagen = @"C:\Users\Alejandro\Documents\4to\NPI\Leap Motion\MODELOETSIIT.skp"; // Reemplaza "nombreDeTuArchivo.jpg" con el nombre real de tu archivo de imagen.

            try
            {
                // Carga la imagen desde la ruta especificada
                Image imagen = Image.FromFile(rutaImagen);

                // Asigna la imagen al PictureBox pictureBox2
                pictureBox2.Image = imagen;

                MessageBox.Show("Imagen cargada correctamente.");
            }
            catch (Exception ex)
            {
                // Manejo de errores
                MessageBox.Show("Error al cargar la imagen: " + ex.Message);
            }
        }


        private void button1_MouseHover(object sender, EventArgs e)
        {
            this.button1.BackColor = Color.Green;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            this.button1.BackColor = Color.Transparent;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonQR_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Home homeWindow = new Home();
            homeWindow.Show();
            this.Hide();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            Horario horarioV = new Horario();
            horarioV.Show();
            this.Hide();
        }
    }

    class MouseCursor
    {
        [DllImport("user32.dll")]

        private static extern bool SetCursorPos(int x, int y);
     

        public static void MoveCursor(int x, int y)
        {
            SetCursorPos(x, y);
        }

    }
    public interface ILeapEventDelegate
    {
        void LeapEventNotification(string EventName);
    }

    public class LeapEventListener : Listener
    {
        ILeapEventDelegate eventDelegate;

        public LeapEventListener(ILeapEventDelegate delegateObject)
        {
            this.eventDelegate = delegateObject;
        }
        public override void OnInit(Controller controller)
        {
            this.eventDelegate.LeapEventNotification("onInit");
        }
        public override void OnConnect(Controller controller)
        {
            this.eventDelegate.LeapEventNotification("onConnect");
        }
        public override void OnFrame(Controller cntrlr)
        {
            this.eventDelegate.LeapEventNotification("onFrame");        
        }
        public override void OnExit(Controller controller)
        {
            this.eventDelegate.LeapEventNotification("onExit");
        }
        public override void OnDisconnect(Controller controller)
        {
            this.eventDelegate.LeapEventNotification("onDisconnect");
        }
    }
}


