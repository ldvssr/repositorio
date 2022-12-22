namespace CronometroForm
{
    using System;
    using System.Windows.Forms;
    public partial class frmCronometro : Form
    {
        private readonly Cronometro _cronometro;

        public frmCronometro()
        {
            InitializeComponent();
            _cronometro = new Cronometro();
        }

        private void ButtonOnOff_Click(object sender, EventArgs e)
        {
            if (_cronometro.ClockState())
            {
                _cronometro.StopClock();
                ButtonOnOff.Text = "Liga";
                TimerRelogio.Enabled = false;
                //LabelContador.Text = _cronometro.GetTimeSpan().ToString();
            }
            else
            {
                _cronometro.StartClock();
                ButtonOnOff.Text = "Desliga";
                TimerRelogio.Enabled = true;
            }
        }

        private void UpdateLabel()
        {
            var tempo = DateTime.Now - _cronometro.StartTime();

            LabelContador.Text = string.Format("{0:D2}:{1:D2}:{2:D2}:{3}", tempo.Hours, tempo.Minutes, tempo.Seconds, tempo.Milliseconds);
        }

        private void TimerRelogio_Tick(object sender, EventArgs e)
        {
            UpdateLabel();
        }
    }
}