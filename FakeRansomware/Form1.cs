namespace FakeRansomware
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();


        }
        int timeLeft = 60;

        private void Form1_Load(object sender, EventArgs e)
        {
            // Timer
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick_1;
            timer1.Start();

            UpdateTimeLabel();
        }

        private void UpdateTimeLabel()
        {
            int minutes = timeLeft / 60;
            int seconds = timeLeft % 60;

            label1.Text = $"{minutes:D2}:{seconds:D2}"; 
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {

            if (timeLeft > 0)
            {
                
                timeLeft--;
                UpdateTimeLabel();
            }
            else
            {
                timer1.Stop();
                label1.Text = "Game over!";
            }
        }
    }
}
