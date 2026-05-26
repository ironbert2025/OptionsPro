using Options.Application.Services;

namespace OptionsPro.UI
{
    public partial class MainForm : Form
    {
        private readonly SettingsService _settingsService;
        public MainForm()
        {
            InitializeComponent();

            _settingsService = new SettingsService();

            RegisterEvents();
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            LoadBroker();

            LoadPositionPercent();

            LoadTargetPercent();


        }
        private void RegisterEvents()
        {
            rbPositionSize25.CheckedChanged += rbPositionSize_CheckedChanged;
            rbPositionSize5.CheckedChanged += rbPositionSize_CheckedChanged;
            rbPositionSize10.CheckedChanged += rbPositionSize_CheckedChanged;

            rbTargetPercent10.CheckedChanged += rbTargetPercent_CheckedChanged;
            rbTargetPercent35.CheckedChanged += rbTargetPercent_CheckedChanged;
            rbTargetPercent100.CheckedChanged += rbTargetPercent_CheckedChanged;
        }


        private void rbPositionSize_CheckedChanged(object? sender, EventArgs e)
        {
            RadioButton rb = (RadioButton)sender;

            if (rb.Checked)
            {
                DrawGreenControl(ref rb);

                double positionSize = Convert.ToDouble (rb.Text);
                _settingsService.SavePositionPercent(positionSize);

                return;
            }

            DrawDefaultControl(ref rb);

        }
        private void rbTargetPercent_CheckedChanged(object? sender, EventArgs e)
        {
            RadioButton rb = (RadioButton)sender;

            if (rb.Checked)
            {
                //rb.Font = new Font(rb.Font.FontFamily, 10f, FontStyle.Bold);
                //rb.ForeColor = Color.DarkGreen;

                DrawGreenControl(ref rb);

                int targetPercent = Convert.ToInt32(rb.Text);
                _settingsService.SaveTargetPercent(targetPercent);

                return;
            }

            DrawDefaultControl(ref rb);
        }
        private void LoadBroker()
        {
            string broker = _settingsService.GetBroker();

            switch (broker)
            {
                case "Schwab":
                    rbSchwab.Checked = true;
                    break;

                case "IBKR":
                    rbIBKR.Checked = true;
                    break;

                case "ETrade":
                    rbETrade.Checked = true;
                    break;
            }
        }

        private void LoadPositionPercent()
        {
            double positionSize = _settingsService.GetPositionPercent();

            switch (positionSize)
            {
                case 2.5:
                    rbPositionSize25.Checked = true;
                    break;
                case 5:
                    rbPositionSize5.Checked = true;
                    break;
                case 10:
                    rbPositionSize10.Checked = true;
                    break;
            }
        }

        private void LoadTargetPercent()
        {
            double targetPercent = _settingsService.GetTargetPercent();

            switch (targetPercent)
            {
                case 10:
                    rbTargetPercent10.Checked = true;
                    break;
                case 35:
                    rbTargetPercent35.Checked = true;
                    break;
                case 100:
                    rbTargetPercent100.Checked = true;
                    break;
            }
        }


        private void rbBroker_CheckedChanged(object sender, EventArgs e)
        {

            RadioButton rb = (RadioButton)sender;
            

            if (rb.Checked)
            {
                DrawGreenControl(ref rb);

                string broker = rb.Text;
                _settingsService.SaveBroker(broker);               

                return;
            }


            DrawDefaultControl(ref rb);
        }

        private void DrawGreenControl(ref RadioButton rb)
        {
            rb.Font = new Font(rb.Font.FontFamily, 10f, FontStyle.Bold);
            rb.ForeColor = Color.DarkGreen;
        }
        private void DrawDefaultControl(ref RadioButton rb)
        {
            rb.Font = new Font(rb.Font.FontFamily, 9f, FontStyle.Regular);
            rb.ForeColor = SystemColors.ControlText;
        }
    }
}
