using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CycleClockSystem
{
    public partial class Clock : Form
    {
        public static string httpUrl = "https://raw.githubusercontent.com/fchb1239/100-Hour-Clock/main/";
        public static string version = "1.0.0";

        public Clock()
        {
            InitializeComponent();

            StartTimer();

            notUpdatedButton.Visible = false;
            notUpdatedButton.Enabled = false;
            notUpdatedLabel.Visible = false;
            notUpdatedLabel.Enabled = false;

            Start();
        }

        async void Start()
        {
            var response = await GetHttp("Version.txt");

            if (!response.IsSuccessStatusCode)
                return;

            string v = await response.Content.ReadAsStringAsync();
            if (v.TrimEnd(' ', '\n') != version)
            {
                notUpdatedButton.Visible = true;
                notUpdatedButton.Enabled = true;
                notUpdatedLabel.Visible = true;
                notUpdatedLabel.Enabled = true;

                MessageBox.Show("You are on an outdated version! Please visit https://github.com/fchb1239/100-Hour-Clock/releases/latest to update!", "Outdated version", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                Process.Start("https://github.com/fchb1239/100-Hour-Clock/releases/latest");
            }
        }

        void StartTimer()
        {
            Timer timer = new Timer();
            timer.Interval = 10;
            timer.Tick += OnTimeTick;
            timer.Start();
        }

        void OnTimeTick(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            cycleTime.Text = FormatCycle(now);

            Font font = new Font(new FontFamily("Arial"), Clamp((Height + Width / 2) / 7.5f, 40, float.PositiveInfinity));
            cycleTime.Font = font;

            cycleTime.Location = new Point((Width - cycleTime.Width) / 2, (Height - cycleTime.Height) / 2);
        }

        float Clamp(float value, float min, float max)
        {
            if (value < min)
                value = min;

            if (value > max)
                value = max;

            return value;
        }

        private void info_Click(object sender, EventArgs e)
        {
            Process.Start("https://github.com/fchb1239/100-Hour-Clock");
        }

        string FormatCycle(DateTime time)
        {
            string cycles = time.Cycle().ToString();
            string moments = time.Moment().ToString();
            string beats = time.Beat().ToString();

            if (cycles.Length < 2)
                cycles = "0" + cycles;

            if (moments.Length < 2)
                moments = "0" + moments;

            if (beats.Length < 2)
                beats = "0" + beats;

            return $"{cycles}:{moments}:{beats}";
        }

        public static Task<HttpResponseMessage> GetHttp(string path)
        {
            var client = new HttpClient();

            var msg = new HttpRequestMessage()
            {
                RequestUri = new Uri(httpUrl + path),
                Method = HttpMethod.Get
            };

            return client.SendAsync(msg);
        }

        private void notUpdatedButton_Click(object sender, EventArgs e)
        {
            Process.Start("https://github.com/fchb1239/100-Hour-Clock/releases/latest");
        }
    }
}
