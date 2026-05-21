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
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            LoadBroker();
            
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
        
        
        private void rbBroker_CheckedChanged(object sender, EventArgs e)
        {

            RadioButton rb = (RadioButton)sender;
            

            if (rb.Checked)
            {
                rb.Font = new Font(rb.Font.FontFamily, 10f, FontStyle.Bold);
                rb.ForeColor = Color.DarkGreen;

                string broker = rb.Text;
                _settingsService.SaveBroker(broker);               

                return;
            }
            
                rb.Font = new Font(rb.Font.FontFamily, 9f, FontStyle.Regular);
                rb.ForeColor = SystemColors.ControlText;
            
        }
    }
}
