namespace Clock
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            label_time.Text = DateTime.Now.ToString("HH:mm:ss");
            label_date.Text = DateTime.UtcNow.Date.ToString("dd/MM/yyyy");
            timer.Enabled = true;
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            label_time.Text = DateTime.Now.ToString("HH:mm:ss");
            label_date.Text = DateTime.UtcNow.Date.ToString("dd/MM/yyyy");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}