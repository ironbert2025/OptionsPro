using Options.Application.Services;
using Options.Domain.Entities;
using Options.Domain.Enums;
using Options.Infrastructure.Services;

namespace OptionsPro.UI
{
    public partial class MainForm : Form
    {
        private readonly SettingsService _settingsService;
        private readonly WatchlistStorageService _watchlistService;
        public MainForm()
        {
            InitializeComponent();

            _settingsService = new SettingsService();
            _watchlistService = new WatchlistStorageService();

            RegisterEvents();
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            LoadBroker();

            LoadGridMarkets();

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

                string positionSize = rb.Text;
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

                string targetPercent = rb.Text;
                _settingsService.SaveTargetPercent(targetPercent);

                return;
            }

            DrawDefaultControl(ref rb);
        }
        private void LoadBroker()
        {
            string brokerText = _settingsService.GetBroker();

            BrokerType broker = Enum.Parse<BrokerType>(brokerText);

            switch (broker)
            {
                case BrokerType.Schwab:
                    rbSchwab.Checked = true;
                    break;

                case BrokerType.IBKR:
                    rbIBKR.Checked = true;
                    break;

                case BrokerType.ETrade:
                    rbETrade.Checked = true;
                    break;
            }
        }

        private void LoadPositionPercent()
        {
            string positionSize = _settingsService.GetPositionPercent();

            switch (positionSize)
            {
                case "2.5":
                    rbPositionSize25.Checked = true;
                    break;
                case "5":
                    rbPositionSize5.Checked = true;
                    break;
                case "10":
                    rbPositionSize10.Checked = true;
                    break;
            }
        }

        private void LoadTargetPercent()
        {
            string targetPercentString = _settingsService.GetTargetPercent();

            TargetPercent targetPercent = Enum.Parse<TargetPercent>(targetPercentString);

            switch (targetPercent)
            {
                case TargetPercent.Ten:
                    rbTargetPercent10.Checked = true;
                    break;
                case TargetPercent.ThirtyFive:
                    rbTargetPercent35.Checked = true;
                    break;
                case TargetPercent.Hundred:
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

        private void btnSaveMarkets_Click(object sender, EventArgs e)
        {
            SaveGridMarkets();
        }
        private void SaveGridMarkets()
        {
            List<WatchItem> items =
                new List<WatchItem>();

            foreach (DataGridViewRow row in dgvMarkets.Rows)
            {
                if (row.IsNewRow)
                    continue;

                WatchItem item =
                    new WatchItem
                    {
                        Symbol =  row.Cells["Symbol"].Value?.ToString(),

                        LowValue = Convert.ToDouble(row.Cells["LowValue"].Value),

                        HighValue =Convert.ToDouble(row.Cells["HighValue"].Value),

                        ExpDate =row.Cells["ExpDate"].Value?.ToString()
                    };

                items.Add(item);
            }

            _watchlistService.Save(items);
        }
        private void LoadGridMarkets()
        {
            List<WatchItem> items = _watchlistService.Load();

            dgvMarkets.Rows.Clear();

            if (items.Count == 0)
            {
                // Crear 4 filas vacías
                for (int i = 0; i < 4; i++)
                {
                    dgvMarkets.Rows.Add(
                        "",
                        "",
                        "",
                        "");
                }

                return;
            }


            foreach (WatchItem item in items)
            {
                dgvMarkets.Rows.Add(
                    item.Symbol,
                    item.LowValue,
                    item.HighValue,
                    item.ExpDate);
            }
        }
    }
}
