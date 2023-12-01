using System;
using System.Collections.Generic;
using System.Collections.Specialized;
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
    public partial class Language : Form, ILeapEventDelegate
    {
        public static int SelectedLanguage = -1;
        public static int FormStates = 0;
        public static Form actualForm;
        NewHome home;

        private Controller controller;
        private LeapEventListener listener;
        private long currentTime;
        private long previousTime;
        private long timeChange;
        private int waitUntilMoveCursor;
        private float current_radio = 99999;
        private int last_finger_count = 0;


        [DllImport("user32.dll")]
        static extern void mouse_event(int dwFlags, int dx, int dy,
                     int dwData, int dwExtraInfo);

        [Flags]
        public enum MouseEventFlags
        {
            LEFTDOWN = 0x00000002,
            LEFTUP = 0x00000004,
            MIDDLEDOWN = 0x00000020,
            MIDDLEUP = 0x00000040,
            MOVE = 0x00000001,
            ABSOLUTE = 0x00008000,
            RIGHTDOWN = 0x00000008,
            RIGHTUP = 0x00000010
        }

        public static void LeftClick(int x, int y)
        {
            Cursor.Position = new System.Drawing.Point(x, y);
            mouse_event((int)(MouseEventFlags.LEFTDOWN), 0, 0, 0, 0);
            mouse_event((int)(MouseEventFlags.LEFTUP), 0, 0, 0, 0);
        }

        public Language()
        {
            InitializeComponent();

            Language.actualForm = this;

            

            //var bitmap = (Bitmap)Image.FromFile(@"C:\Users\Alejandro\Downloads\si.png");
            //this.Cursor = CreateCursor(bitmap, new Size(bitmap.Width, bitmap.Height));

            //MouseCursor.MoveCursor(NewHome.ScreenWidth/2, NewHome.ScreenHeight/2);

            this.controller = new Controller();
            this.listener = new LeapEventListener(this);
            controller.AddListener(listener);
            

            this.label1.Height = this.label1.Height * NewHome.ScreenHeight / NewHome.FormHeight;
            this.label1.Width = this.label1.Width * NewHome.ScreenWidth / NewHome.FormWidth;
            this.label1.Font = new Font("Yu Gothic UI", this.label1.Font.Size + (NewHome.ScreenHeight / NewHome.FormHeight), FontStyle.Bold);

            this.tableLayoutPanel1.Height = this.tableLayoutPanel1.Height * NewHome.ScreenHeight / NewHome.FormHeight;
            
            this.panel1.Height = this.panel1.Height * NewHome.ScreenHeight / NewHome.FormHeight;
            this.panel1.Width = this.panel1.Width * NewHome.ScreenWidth / NewHome.FormWidth;
            this.panel1.Margin = new Padding(this.panel1.Margin.Left * NewHome.ScreenWidth / NewHome.FormWidth, this.panel1.Margin.Top * NewHome.ScreenHeight / NewHome.FormHeight, this.panel1.Margin.Right * NewHome.ScreenWidth / NewHome.FormWidth, this.panel1.Margin.Bottom * NewHome.ScreenHeight / NewHome.FormHeight);
            this.panel1.Padding = new Padding(this.panel1.Padding.Left * NewHome.ScreenWidth / NewHome.FormWidth, this.panel1.Padding.Top * NewHome.ScreenHeight / NewHome.FormHeight, this.panel1.Padding.Right * NewHome.ScreenWidth / NewHome.FormWidth, this.panel1.Padding.Bottom * NewHome.ScreenHeight / NewHome.FormHeight);
            this.pictureBox1.Height = this.pictureBox1.Height * NewHome.ScreenHeight / NewHome.FormHeight;
            

            this.panel2.Height = this.panel2.Height * NewHome.ScreenHeight / NewHome.FormHeight;
            this.panel2.Width = this.panel2.Width * NewHome.ScreenWidth / NewHome.FormWidth;
            this.panel2.Margin = new Padding(this.panel2.Margin.Left * NewHome.ScreenWidth / NewHome.FormWidth, this.panel2.Margin.Top * NewHome.ScreenHeight / NewHome.FormHeight, this.panel2.Margin.Right * NewHome.ScreenWidth / NewHome.FormWidth, this.panel2.Margin.Bottom * NewHome.ScreenHeight / NewHome.FormHeight);
            this.panel2.Padding = new Padding(this.panel2.Padding.Left * NewHome.ScreenWidth / NewHome.FormWidth, this.panel2.Padding.Top * NewHome.ScreenHeight / NewHome.FormHeight, this.panel2.Padding.Right * NewHome.ScreenWidth / NewHome.FormWidth, this.panel2.Padding.Bottom * NewHome.ScreenHeight / NewHome.FormHeight);
            this.pictureBox2.Height = this.pictureBox2.Height * NewHome.ScreenHeight / NewHome.FormHeight;
          
            

            this.panel1.Region = Region.FromHrgn(NewHome.CreateRoundRectRgn(0, 0, panel2.Width,
            panel1.Height, 20, 20));
            this.panel2.Region = Region.FromHrgn(NewHome.CreateRoundRectRgn(0, 0, panel2.Width,
            panel2.Height, 20, 20));
        }

        private void panel1_MouseHover(object sender, EventArgs e)
        {
            this.panel1.BackColor = Color.Snow;
        }

        private void panel1_MouseLeave(object sender, EventArgs e)
        {
            this.panel1.BackColor = Color.Transparent;
        }

        private void panel2_MouseHover(object sender, EventArgs e)
        {
            this.panel2.BackColor = Color.Snow;
        }

        private void panel2_MouseLeave(object sender, EventArgs e)
        {
            this.panel2.BackColor = Color.Transparent;
        }

        private void panel1_Click(object sender, EventArgs e)
        {
            Language.SelectedLanguage = 1;
            Language.FormStates = 1;
            NewHome home = new NewHome();
            home.Show();
            Language.actualForm = home;
            this.Visible = false;
            home.Visible = true;
        }

        private void panel2_Click(object sender, EventArgs e)
        {
            Language.SelectedLanguage = 2;
            Language.FormStates = 1;
            NewHome home = new NewHome();
            home.Show();
            Language.actualForm = home;
            this.Visible = false;
            home.Visible = true;
        }

        private void Language_Resize(object sender, EventArgs e)
        {
            this.panel1.Region = Region.FromHrgn(NewHome.CreateRoundRectRgn(0, 0, panel2.Width,
            panel1.Height, 20, 20));
            this.panel2.Region = Region.FromHrgn(NewHome.CreateRoundRectRgn(0, 0, panel2.Width,
            panel2.Height, 20, 20));
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

                        detectGesture(this.controller.Frame());

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

            Hand my_hand = frame.Hands[0];

            currentTime = frame.Timestamp;
            timeChange = currentTime - previousTime;
            float new_radio = my_hand.SphereRadius;


            GestureList gestures = frame.Gestures();
            for (int i = 0; i < gestures.Count(); i++)
            {
                Gesture gesture = gestures[i];
                switch (gesture.Type)
                {
                    case Gesture.GestureType.TYPEKEYTAP:

                        break;
                    case Gesture.GestureType.TYPESWIPE:

                        if (Language.FormStates == 2)
                        {

                            Language.FormStates = 1;
                            NewHome home = new NewHome();
                            home.Show();
                            Language.actualForm = home;
                            this.Visible = false;
                            home.Visible = true;

                        }
                        else if (Language.FormStates == 1)
                        {

                            this.Visible = true;
                            actualForm.Visible = false;
                            actualForm = this;
                            Language.FormStates = 0;



                        }

                        home.printGesture();
                        break;
                }
            }



            if (timeChange > 1000000)
            {

                
                if (frame.Hands.Count > 0 && last_finger_count == 0 && frame.Fingers.Count > 0)
                {
                    Language.LeftClick(Cursor.Position.X, Cursor.Position.Y);
                }

                last_finger_count = frame.Fingers.Count;


            }

            movingMouse(frame, this.controller);


        }

        private void connectHandler()
        {
            this.controller.EnableGesture(Gesture.GestureType.TYPEKEYTAP);
            this.controller.EnableGesture(Gesture.GestureType.TYPESWIPE);
        }

        private void movingMouse(Leap.Frame frame, Controller controlador)
        {
            Hand my_hand = frame.Hands[0];

            currentTime = frame.Timestamp;
            timeChange = currentTime - previousTime;

            if (timeChange > 100000)
            {

                if (frame.Hands.Count > 0)
                {


                    var xScreenIntersect = my_hand.StabilizedPalmPosition.x;
                    var yScreenIntersect = my_hand.StabilizedPalmPosition.y;

                    if (xScreenIntersect.ToString() != "NaN")
                    {
                        var x = (int)(xScreenIntersect * System.Windows.Forms.Screen.PrimaryScreen.Bounds.Width) / 100;
                        
                        var y = (int)(System.Windows.Forms.Screen.PrimaryScreen.Bounds.Height - (yScreenIntersect * System.Windows.Forms.Screen.PrimaryScreen.Bounds.Height) / 100) + NewHome.ScreenHeight/2;

                        MouseCursor.MoveCursor(x, y);

                    }
                    
                }
            }
           
        }

        public Cursor CreateCursor(Bitmap bitmap, Size size)
        {
            bitmap = new Bitmap(bitmap, size);
            return new Cursor(bitmap.GetHicon());
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

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
