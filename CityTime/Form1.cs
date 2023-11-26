namespace CityTime
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void SetText(string text)
        {
            TimeZoneInfo t = TimeZoneInfo.FindSystemTimeZoneById(text);
            DateTime localTime = TimeZoneInfo.ConvertTimeToUtc(DateTime.UtcNow, t);
            label1.Text = $"{localTime}";
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(13)) {
                SetText(textBox1.Text);
            }
        }
    }
}
