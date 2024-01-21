using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Leap;


namespace Tuto
{

    public interface ICerrarForm
    {
        void cerrar();
    }
    public partial class Language : Form, ILeapEventDelegate
    {
        public static int SelectedLanguage = -1;
        public static int FormStates = 0;
        public static Form lastForm;
        public static String className = "";
        private int chage = 0;
        NewHome home;

        private Controller controller;
        private LeapEventListener listener;
        private long currentTime;
        private long previousTime;
        private long timeChange;
        private int waitUntilMoveCursor;
        private float current_radio = 99999;
        private int last_finger_count = 0;
        private int last_hands_count = 0;
        private bool gestoYaManejado = false;

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

            Language.lastForm = null;

            

            //var bitmap = (Bitmap)Image.FromFile(@"C:\Users\Alejandro\Downloads\si.png");
            //this.Cursor = CreateCursor(bitmap, new Size(bitmap.Width, bitmap.Height));

            //MouseCursor.MoveCursor(NewHome.ScreenWidth/2, NewHome.ScreenHeight/2);

            this.controller = new Controller();
            this.listener = new LeapEventListener(this);
            controller.AddListener(listener);
            

            this.label1.Height = this.label1.Height * NewHome.ScreenHeight / NewHome.FormHeight;
            this.label1.Width = this.label1.Width * NewHome.ScreenWidth / NewHome.FormWidth;
            this.label1.Font = new Font("Yu Gothic UI", this.label1.Font.Size * (NewHome.ScreenHeight / NewHome.FormHeight), FontStyle.Bold);

            this.tableLayoutPanel1.Height = this.tableLayoutPanel1.Height * NewHome.ScreenHeight / NewHome.FormHeight;

            this.pictureBox2.Height = this.pictureBox2.Height * NewHome.ScreenHeight / NewHome.FormHeight;
            this.pictureBox2.Width = this.pictureBox2.Width * NewHome.ScreenWidth / NewHome.FormWidth;
            this.pictureBox2.Margin = new Padding(this.pictureBox2.Margin.Left * NewHome.ScreenWidth / NewHome.FormWidth, this.pictureBox2.Margin.Top * NewHome.ScreenHeight / NewHome.FormHeight, this.pictureBox2.Margin.Right * NewHome.ScreenWidth / NewHome.FormWidth, this.pictureBox2.Margin.Bottom * NewHome.ScreenHeight / NewHome.FormHeight);
            this.pictureBox2.Padding = new Padding(this.pictureBox2.Padding.Left * NewHome.ScreenWidth / NewHome.FormWidth, this.pictureBox2.Padding.Top * NewHome.ScreenHeight / NewHome.FormHeight, this.pictureBox2.Padding.Right * NewHome.ScreenWidth / NewHome.FormWidth, this.pictureBox2.Padding.Bottom * NewHome.ScreenHeight / NewHome.FormHeight);

            this.pictureBox3.Height = this.pictureBox3.Height * NewHome.ScreenHeight / NewHome.FormHeight;
            this.pictureBox3.Width = this.pictureBox3.Width * NewHome.ScreenWidth / NewHome.FormWidth;
            this.pictureBox3.Margin = new Padding(this.pictureBox3.Margin.Left * NewHome.ScreenWidth / NewHome.FormWidth, this.pictureBox3.Margin.Top * NewHome.ScreenHeight / NewHome.FormHeight, this.pictureBox3.Margin.Right * NewHome.ScreenWidth / NewHome.FormWidth, this.pictureBox3.Margin.Bottom * NewHome.ScreenHeight / NewHome.FormHeight);
            this.pictureBox3.Padding = new Padding(this.pictureBox3.Padding.Left * NewHome.ScreenWidth / NewHome.FormWidth, this.pictureBox3.Padding.Top * NewHome.ScreenHeight / NewHome.FormHeight, this.pictureBox3.Padding.Right * NewHome.ScreenWidth / NewHome.FormWidth, this.pictureBox3.Padding.Bottom * NewHome.ScreenHeight / NewHome.FormHeight);


            // PictureBox4
            this.pictureBox4.Height = this.pictureBox4.Height * NewHome.ScreenHeight / NewHome.FormHeight;
            this.pictureBox4.Width = this.pictureBox4.Width * NewHome.ScreenWidth / NewHome.FormWidth;
            this.pictureBox4.Margin = new Padding(this.pictureBox4.Margin.Left * NewHome.ScreenWidth / NewHome.FormWidth, this.pictureBox4.Margin.Top * NewHome.ScreenHeight / NewHome.FormHeight, this.pictureBox4.Margin.Right * NewHome.ScreenWidth / NewHome.FormWidth, this.pictureBox4.Margin.Bottom * NewHome.ScreenHeight / NewHome.FormHeight);
            this.pictureBox4.Padding = new Padding(this.pictureBox4.Padding.Left * NewHome.ScreenWidth / NewHome.FormWidth, this.pictureBox4.Padding.Top * NewHome.ScreenHeight / NewHome.FormHeight, this.pictureBox4.Padding.Right * NewHome.ScreenWidth / NewHome.FormWidth, this.pictureBox4.Padding.Bottom * NewHome.ScreenHeight / NewHome.FormHeight);

            // PictureBox5
            this.pictureBox5.Height = this.pictureBox5.Height * NewHome.ScreenHeight / NewHome.FormHeight;
            this.pictureBox5.Width = this.pictureBox5.Width * NewHome.ScreenWidth / NewHome.FormWidth;
            this.pictureBox5.Margin = new Padding(this.pictureBox5.Margin.Left * NewHome.ScreenWidth / NewHome.FormWidth, this.pictureBox5.Margin.Top * NewHome.ScreenHeight / NewHome.FormHeight, this.pictureBox5.Margin.Right * NewHome.ScreenWidth / NewHome.FormWidth, this.pictureBox5.Margin.Bottom * NewHome.ScreenHeight / NewHome.FormHeight);
            this.pictureBox5.Padding = new Padding(this.pictureBox5.Padding.Left * NewHome.ScreenWidth / NewHome.FormWidth, this.pictureBox5.Padding.Top * NewHome.ScreenHeight / NewHome.FormHeight, this.pictureBox5.Padding.Right * NewHome.ScreenWidth / NewHome.FormWidth, this.pictureBox5.Padding.Bottom * NewHome.ScreenHeight / NewHome.FormHeight);

            // PictureBox6
            this.pictureBox6.Height = this.pictureBox6.Height * NewHome.ScreenHeight / NewHome.FormHeight;
            this.pictureBox6.Width = this.pictureBox6.Width * NewHome.ScreenWidth / NewHome.FormWidth;
            this.pictureBox6.Margin = new Padding(this.pictureBox6.Margin.Left * NewHome.ScreenWidth / NewHome.FormWidth, this.pictureBox6.Margin.Top * NewHome.ScreenHeight / NewHome.FormHeight, this.pictureBox6.Margin.Right * NewHome.ScreenWidth / NewHome.FormWidth, this.pictureBox6.Margin.Bottom * NewHome.ScreenHeight / NewHome.FormHeight);
            this.pictureBox6.Padding = new Padding(this.pictureBox6.Padding.Left * NewHome.ScreenWidth / NewHome.FormWidth, this.pictureBox6.Padding.Top * NewHome.ScreenHeight / NewHome.FormHeight, this.pictureBox6.Padding.Right * NewHome.ScreenWidth / NewHome.FormWidth, this.pictureBox6.Padding.Bottom * NewHome.ScreenHeight / NewHome.FormHeight);

            // PictureBox7
            this.pictureBox7.Height = this.pictureBox7.Height * NewHome.ScreenHeight / NewHome.FormHeight;
            this.pictureBox7.Width = this.pictureBox7.Width * NewHome.ScreenWidth / NewHome.FormWidth;
            this.pictureBox7.Margin = new Padding(this.pictureBox7.Margin.Left * NewHome.ScreenWidth / NewHome.FormWidth, this.pictureBox7.Margin.Top * NewHome.ScreenHeight / NewHome.FormHeight, this.pictureBox7.Margin.Right * NewHome.ScreenWidth / NewHome.FormWidth, this.pictureBox7.Margin.Bottom * NewHome.ScreenHeight / NewHome.FormHeight);
            this.pictureBox7.Padding = new Padding(this.pictureBox7.Padding.Left * NewHome.ScreenWidth / NewHome.FormWidth, this.pictureBox7.Padding.Top * NewHome.ScreenHeight / NewHome.FormHeight, this.pictureBox7.Padding.Right * NewHome.ScreenWidth / NewHome.FormWidth, this.pictureBox7.Padding.Bottom * NewHome.ScreenHeight / NewHome.FormHeight);

            // PictureBox8
            this.pictureBox8.Height = this.pictureBox8.Height * NewHome.ScreenHeight / NewHome.FormHeight;
            this.pictureBox8.Width = this.pictureBox8.Width * NewHome.ScreenWidth / NewHome.FormWidth;
            this.pictureBox8.Margin = new Padding(this.pictureBox8.Margin.Left * NewHome.ScreenWidth / NewHome.FormWidth, this.pictureBox8.Margin.Top * NewHome.ScreenHeight / NewHome.FormHeight, this.pictureBox8.Margin.Right * NewHome.ScreenWidth / NewHome.FormWidth, this.pictureBox8.Margin.Bottom * NewHome.ScreenHeight / NewHome.FormHeight);
            this.pictureBox8.Padding = new Padding(this.pictureBox8.Padding.Left * NewHome.ScreenWidth / NewHome.FormWidth, this.pictureBox8.Padding.Top * NewHome.ScreenHeight / NewHome.FormHeight, this.pictureBox8.Padding.Right * NewHome.ScreenWidth / NewHome.FormWidth, this.pictureBox8.Padding.Bottom * NewHome.ScreenHeight / NewHome.FormHeight);

            // PictureBox9
            this.pictureBox9.Height = this.pictureBox9.Height * NewHome.ScreenHeight / NewHome.FormHeight;
            this.pictureBox9.Width = this.pictureBox9.Width * NewHome.ScreenWidth / NewHome.FormWidth;
            this.pictureBox9.Margin = new Padding(this.pictureBox9.Margin.Left * NewHome.ScreenWidth / NewHome.FormWidth, this.pictureBox9.Margin.Top * NewHome.ScreenHeight / NewHome.FormHeight, this.pictureBox9.Margin.Right * NewHome.ScreenWidth / NewHome.FormWidth, this.pictureBox9.Margin.Bottom * NewHome.ScreenHeight / NewHome.FormHeight);
            this.pictureBox9.Padding = new Padding(this.pictureBox9.Padding.Left * NewHome.ScreenWidth / NewHome.FormWidth, this.pictureBox9.Padding.Top * NewHome.ScreenHeight / NewHome.FormHeight, this.pictureBox9.Padding.Right * NewHome.ScreenWidth / NewHome.FormWidth, this.pictureBox9.Padding.Bottom * NewHome.ScreenHeight / NewHome.FormHeight);

            this.pictureBox1.Height = this.pictureBox1.Height * NewHome.ScreenHeight / NewHome.FormHeight;
            this.pictureBox1.Width = this.pictureBox1.Width * NewHome.ScreenWidth / NewHome.FormWidth;
            this.pictureBox1.Margin = new Padding(this.pictureBox1.Margin.Left * NewHome.ScreenWidth / NewHome.FormWidth, this.pictureBox1.Margin.Top * NewHome.ScreenHeight / NewHome.FormHeight, this.pictureBox1.Margin.Right * NewHome.ScreenWidth / NewHome.FormWidth, this.pictureBox1.Margin.Bottom * NewHome.ScreenHeight / NewHome.FormHeight);
            this.pictureBox1.Padding = new Padding(this.pictureBox1.Padding.Left * NewHome.ScreenWidth / NewHome.FormWidth, this.pictureBox1.Padding.Top * NewHome.ScreenHeight / NewHome.FormHeight, this.pictureBox1.Padding.Right * NewHome.ScreenWidth / NewHome.FormWidth, this.pictureBox1.Padding.Bottom * NewHome.ScreenHeight / NewHome.FormHeight);

            this.label2.Height = this.label2.Height * NewHome.ScreenHeight / NewHome.FormHeight;
            this.label2.Width = this.label2.Width * NewHome.ScreenWidth / NewHome.FormWidth;
         
        }

        private void panel1_MouseHover(object sender, EventArgs e)
        {
            //this.panel1.BackColor = Color.Snow;
        }

        private void panel1_MouseLeave(object sender, EventArgs e)
        {
            //this.panel1.BackColor = Color.Transparent;
        }

        private void panel2_MouseHover(object sender, EventArgs e)
        {
            //this.panel2.BackColor = Color.Snow;
        }

        private void panel2_MouseLeave(object sender, EventArgs e)
        {
            //this.panel2.BackColor = Color.Transparent;
        }

        private void panel1_Click(object sender, EventArgs e)
        {
            Language.SelectedLanguage = 1;
            NewHome home = new NewHome();
            home.Show();
            Language.lastForm = this;
            this.Visible = false;
            home.Visible = true;
        }

        private void panel2_Click(object sender, EventArgs e)
        {
            Language.SelectedLanguage = 2;
            NewHome home = new NewHome();
            home.Show();
            Language.lastForm = this;
            this.Visible = false;
            home.Visible = true;
        }

        private void Language_Resize(object sender, EventArgs e)
        {
            //this.panel1.Region = Region.FromHrgn(NewHome.CreateRoundRectRgn(0, 0, panel2.Width,
            //panel1.Height, 20, 20));
            //this.panel2.Region = Region.FromHrgn(NewHome.CreateRoundRectRgn(0, 0, panel2.Width,
            //panel2.Height, 20, 20));
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


            if (timeChange > 10000)
            {


                if (!gestoYaManejado && last_hands_count > 0 && frame.Hands.Count > 0 && last_finger_count == 0 && frame.Fingers.Count > 0)
                {
                    Language.LeftClick(Cursor.Position.X, Cursor.Position.Y);
                    gestoYaManejado = true;
                }

                last_finger_count = frame.Fingers.Count;
                last_hands_count = frame.Hands.Count();


            }

            if (frame.Fingers.Count > 0)
            {
                movingMouse(frame, this.controller);
            }


            previousTime = currentTime;

            GestureList gestures = frame.Gestures();
            for (int i = 0; i < gestures.Count(); i++)
            {
                Gesture gesture = gestures[i];

                if (!gestoYaManejado)
                {

                
                switch (gesture.Type)
                {
                    case Gesture.GestureType.TYPEKEYTAP:

                        break;
                    case Gesture.GestureType.TYPESWIPE:

                        if (Language.lastForm != null)
                        {

                            switch (Language.className)
                            {
                                case "NewHome":
                                    NewHome nh = (NewHome)Language.lastForm;

                                    nh.close_Form();
                                    break;
                                case "Locations":
                                    Locations lc = (Locations)Language.lastForm;

                                    lc.close_Form();
                                    break;
                                case "MostrarImagen":
                                    MostrarImagen mi = (MostrarImagen)Language.lastForm;

                                    mi.close_Form();
                                    break;
                                case "Form2":
                                    Form2 qr = (Form2)Language.lastForm;

                                    qr.close_Form();
                                    break;
                                case "NewSchedule":
                                    NewSchedule ns = (NewSchedule)Language.lastForm;

                                    ns.close_Form();
                                    break;
                            }




                        }

                        gestoYaManejado = true;

                        

                        //this.label1.Text = this.label1.Text + "Cirlce";
                        break;


                }

                }


            }


            if (gestoYaManejado)
            {
                // Inicia un temporizador para restablecer la bandera después de un período de tiempo
                System.Threading.Timer resetTimer = new System.Threading.Timer((state) =>
                {
                    gestoYaManejado = false;
                }, null, 1200, Timeout.Infinite);
            }

            




        }

        private void connectHandler()
        {
            this.controller.EnableGesture(Gesture.GestureType.TYPEKEYTAP);
            this.controller.EnableGesture(Gesture.GestureType.TYPESWIPE);

            this.controller.EnableGesture(Gesture.GestureType.TYPECIRCLE);
        }

        private void movingMouse(Leap.Frame frame, Controller controlador)
        {
            Hand my_hand = frame.Hands[0];


            if (timeChange > 1000)
            {

                if (frame.Hands.Count > 0)
                {


                    var xScreenIntersect = my_hand.StabilizedPalmPosition.x;
                    var yScreenIntersect = my_hand.StabilizedPalmPosition.y;

                    if (xScreenIntersect.ToString() != "NaN")
                    {
                        var x = (int)(xScreenIntersect * System.Windows.Forms.Screen.PrimaryScreen.Bounds.Width) / 100;

                        var y = (int)(System.Windows.Forms.Screen.PrimaryScreen.Bounds.Height - (yScreenIntersect * System.Windows.Forms.Screen.PrimaryScreen.Bounds.Height) / 100) + NewHome.ScreenHeight;

                        

                       
                       MouseCursor.MoveCursor(x, y);
                        
                    }

                }
            }

        }

        private void CenterCursor()
        {
            // Calcular las coordenadas del centro de la pantalla
            int centerX = System.Windows.Forms.Screen.PrimaryScreen.Bounds.Width / 2;
            int centerY = System.Windows.Forms.Screen.PrimaryScreen.Bounds.Height / 2;

            MouseCursor.MoveCursor(centerX, centerY);

        }

        public Cursor CreateCursor(Bitmap bitmap, Size size)
        {
            bitmap = new Bitmap(bitmap, size);
            return new Cursor(bitmap.GetHicon());
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Language.SelectedLanguage = 1;
            NewHome home = new NewHome();
            NewHome.father = this;

            home.Show();
            home.Activate();
            this.Hide();
            //this.Visible = false;
            //home.Visible = true;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Language.SelectedLanguage = 2;
            NewHome home = new NewHome();
            NewHome.father = this;
            home.Show();
            home.Activate();

            this.Hide();
        }

        private void pictureBox3_MouseHover(object sender, EventArgs e)
        {
            this.pictureBox3.Image = Properties.Resources.spanishrounded_bold; 
        }

        private void pictureBox3_MouseLeave(object sender, EventArgs e)
        {
            this.pictureBox3.Image = Properties.Resources.spanishrounded;
        }

        private void pictureBox4_MouseHover(object sender, EventArgs e)
        {
            this.pictureBox4.Image = Properties.Resources.englishrounded_bold;
        }

        private void pictureBox4_MouseLeave(object sender, EventArgs e)
        {
            this.pictureBox4.Image = Properties.Resources.englishrounded;
        }

        private void pictureBox5_MouseHover(object sender, EventArgs e)
        {
            this.pictureBox5.Image = Properties.Resources.poland_bold;
        }

        private void pictureBox5_MouseLeave(object sender, EventArgs e)
        {
            this.pictureBox5.Image = Properties.Resources.poland;
        }

        private void pictureBox6_MouseHover(object sender, EventArgs e)
        {
            this.pictureBox6.Image = Properties.Resources.sweden_bold;
        }

        private void pictureBox6_MouseLeave(object sender, EventArgs e)
        {
            this.pictureBox6.Image = Properties.Resources.sweden;
        }

        private void pictureBox7_MouseHover(object sender, EventArgs e)
        {
            this.pictureBox7.Image = Properties.Resources.netherlands_bold;
        }

        private void pictureBox7_MouseLeave(object sender, EventArgs e)
        {
            this.pictureBox7.Image = Properties.Resources.netherlands;
        }

        private void pictureBox8_MouseHover(object sender, EventArgs e)
        {
            this.pictureBox8.Image = Properties.Resources.german_bold;
        }

        private void pictureBox8_MouseLeave(object sender, EventArgs e)
        {
            this.pictureBox8.Image = Properties.Resources.german;
        }

        private void pictureBox9_MouseHover(object sender, EventArgs e)
        {
            this.pictureBox9.Image = Properties.Resources.italy_bold;
        }

        private void pictureBox9_MouseLeave(object sender, EventArgs e)
        {
            this.pictureBox9.Image = Properties.Resources.italy;
        }

        private void pictureBox2_MouseHover(object sender, EventArgs e)
        {
            this.pictureBox2.Image = Properties.Resources.france_bold;
        }

        private void pictureBox2_MouseLeave(object sender, EventArgs e)
        {
            this.pictureBox2.Image = Properties.Resources.france;
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
