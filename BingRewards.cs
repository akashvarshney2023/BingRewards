using System.Diagnostics;
using System.Runtime.InteropServices;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;


namespace BingRewards
{
    public partial class BingRewards : Form
    {

        private System.Windows.Forms.Timer backspaceTimer;
        private Random random = new Random();
        private Point previousCursorPosition;

        public BingRewards()
        {
            InitializeComponent();
            InitializeTimer();

        }
        private void InitializeTimer()
        {
            backspaceTimer = new System.Windows.Forms.Timer();
            backspaceTimer.Tick += new EventHandler(BackspaceTimer_Tick);

            // Activate the form to bring it to the foreground
            Activate();
            // Set the initial interval (first backspace after 6 seconds)
            SetRandomInterval();
        }

        private void SetRandomInterval()
        {
            // Generate a random interval between 6 and 8 seconds
            int randomInterval = random.Next(6000, 8000);
            backspaceTimer.Interval = randomInterval;
        }

        private void btn_start_Click(object sender, EventArgs e)
        {
            // Store the current cursor position
            previousCursorPosition = Cursor.Position;
            backspaceTimer.Start();

        }

        private void BackspaceTimer_Tick(object sender, EventArgs e)
        {
            // Store the current cursor position
            Point currentCursorPosition = Cursor.Position;

            // Simulate a backspace key press
            SendKeys.Send("{BACKSPACE}");

            // Simulate an Enter key press
            SendKeys.Send("{ENTER}");

            // Set the cursor position back to the stored position
            Cursor.Position = currentCursorPosition;
            BrowserClick.SimulateMouseClick();

        }
    }
}