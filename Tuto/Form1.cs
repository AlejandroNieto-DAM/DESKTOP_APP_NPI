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
         
            this.controller = new Controller();
            this.listener = new LeapEventListener(this);
            controller.AddListener(listener);

            //var bitmap = (Bitmap)Image.FromFile(@"C:\Users\Alejandro\Downloads\cursor1.png");
            //this.Cursor = CreateCursor(bitmap, new Size(bitmap.Width/10, bitmap.Height/10));
        }
        public Cursor CreateCursor(Bitmap bitmap, Size size)
        {
            bitmap = new Bitmap(bitmap, size);
            return new Cursor(bitmap.GetHicon());
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
            //this.richTextBox1.AppendText("KeyTAP DETECTED" + Environment.NewLine);
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
            this.richTextBox1.AppendText("Hemos clickado" + Environment.NewLine);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Language horarioV = new Language();
            horarioV.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            NewHome horarioV = new NewHome();
            horarioV.Show();
            this.Hide();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == (char)Keys.S)
            {
                this.richTextBox2.AppendText("Pulsado S" + Environment.NewLine);
                NewHome.LeftClick(Cursor.Position.X, Cursor.Position.Y);
            }
            else if (e.KeyCode == Keys.L)
            {
                //Some Other Code
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            NewSchedule horarioV = new NewSchedule();
            horarioV.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            MenuComedor menuCom = new MenuComedor();
            menuCom.Show();
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


