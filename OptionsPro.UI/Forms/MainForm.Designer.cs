
namespace OptionsPro.UI
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tabMainTab = new TabControl();
            tabPage1 = new TabPage();
            tabPage2 = new TabPage();
            groupBox4 = new GroupBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label3 = new Label();
            label2 = new Label();
            radioButton5 = new RadioButton();
            radioButton6 = new RadioButton();
            groupBox3 = new GroupBox();
            rbTargetPercent100 = new RadioButton();
            rbTargetPercent35 = new RadioButton();
            rbTargetPercent10 = new RadioButton();
            groupBox2 = new GroupBox();
            rbPositionSize10 = new RadioButton();
            rbPositionSize5 = new RadioButton();
            rbPositionSize25 = new RadioButton();
            groupBox1 = new GroupBox();
            label1 = new Label();
            btnSaveMarkets = new Button();
            dgvMarkets = new DataGridView();
            gbBrokers = new GroupBox();
            rbETrade = new RadioButton();
            rbIBKR = new RadioButton();
            rbSchwab = new RadioButton();
            Symbol = new DataGridViewTextBoxColumn();
            LowValue = new DataGridViewTextBoxColumn();
            HighValue = new DataGridViewTextBoxColumn();
            ExpDate = new DataGridViewTextBoxColumn();
            tabMainTab.SuspendLayout();
            tabPage2.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMarkets).BeginInit();
            gbBrokers.SuspendLayout();
            SuspendLayout();
            // 
            // tabMainTab
            // 
            tabMainTab.Controls.Add(tabPage1);
            tabMainTab.Controls.Add(tabPage2);
            tabMainTab.Location = new Point(0, 12);
            tabMainTab.Name = "tabMainTab";
            tabMainTab.SelectedIndex = 0;
            tabMainTab.Size = new Size(935, 639);
            tabMainTab.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(927, 611);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Option Chains";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(groupBox4);
            tabPage2.Controls.Add(groupBox3);
            tabPage2.Controls.Add(groupBox2);
            tabPage2.Controls.Add(groupBox1);
            tabPage2.Controls.Add(gbBrokers);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(927, 611);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Settings";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(textBox2);
            groupBox4.Controls.Add(textBox1);
            groupBox4.Controls.Add(label3);
            groupBox4.Controls.Add(label2);
            groupBox4.Controls.Add(radioButton5);
            groupBox4.Controls.Add(radioButton6);
            groupBox4.Location = new Point(738, 19);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(150, 222);
            groupBox4.TabIndex = 10;
            groupBox4.TabStop = false;
            groupBox4.Text = "Accounts";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(35, 111);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 6;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(35, 49);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label3.ForeColor = Color.FromArgb(255, 128, 0);
            label3.Location = new Point(47, 89);
            label3.Name = "label3";
            label3.Size = new Size(49, 19);
            label3.TabIndex = 4;
            label3.Text = "Demo";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label2.ForeColor = Color.Green;
            label2.Location = new Point(51, 28);
            label2.Name = "label2";
            label2.Size = new Size(36, 19);
            label2.TabIndex = 3;
            label2.Text = "Live";
            // 
            // radioButton5
            // 
            radioButton5.AutoSize = true;
            radioButton5.Location = new Point(16, 112);
            radioButton5.Name = "radioButton5";
            radioButton5.Size = new Size(37, 19);
            radioButton5.TabIndex = 1;
            radioButton5.TabStop = true;
            radioButton5.Text = "35";
            radioButton5.UseVisualStyleBackColor = true;
            // 
            // radioButton6
            // 
            radioButton6.AutoSize = true;
            radioButton6.Location = new Point(16, 50);
            radioButton6.Name = "radioButton6";
            radioButton6.Size = new Size(37, 19);
            radioButton6.TabIndex = 0;
            radioButton6.TabStop = true;
            radioButton6.Text = "10";
            radioButton6.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(rbTargetPercent100);
            groupBox3.Controls.Add(rbTargetPercent35);
            groupBox3.Controls.Add(rbTargetPercent10);
            groupBox3.Location = new Point(611, 19);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(108, 222);
            groupBox3.TabIndex = 9;
            groupBox3.TabStop = false;
            groupBox3.Text = "Target (%)";
            // 
            // rbTargetPercent100
            // 
            rbTargetPercent100.AutoSize = true;
            rbTargetPercent100.Location = new Point(19, 75);
            rbTargetPercent100.Name = "rbTargetPercent100";
            rbTargetPercent100.Size = new Size(43, 19);
            rbTargetPercent100.TabIndex = 2;
            rbTargetPercent100.TabStop = true;
            rbTargetPercent100.Text = "100";
            rbTargetPercent100.UseVisualStyleBackColor = true;
            // 
            // rbTargetPercent35
            // 
            rbTargetPercent35.AutoSize = true;
            rbTargetPercent35.Location = new Point(19, 50);
            rbTargetPercent35.Name = "rbTargetPercent35";
            rbTargetPercent35.Size = new Size(37, 19);
            rbTargetPercent35.TabIndex = 1;
            rbTargetPercent35.TabStop = true;
            rbTargetPercent35.Text = "35";
            rbTargetPercent35.UseVisualStyleBackColor = true;
            // 
            // rbTargetPercent10
            // 
            rbTargetPercent10.AutoSize = true;
            rbTargetPercent10.Location = new Point(19, 25);
            rbTargetPercent10.Name = "rbTargetPercent10";
            rbTargetPercent10.Size = new Size(37, 19);
            rbTargetPercent10.TabIndex = 0;
            rbTargetPercent10.TabStop = true;
            rbTargetPercent10.Text = "10";
            rbTargetPercent10.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(rbPositionSize10);
            groupBox2.Controls.Add(rbPositionSize5);
            groupBox2.Controls.Add(rbPositionSize25);
            groupBox2.Location = new Point(478, 19);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(108, 222);
            groupBox2.TabIndex = 8;
            groupBox2.TabStop = false;
            groupBox2.Text = "Position Size (%)";
            // 
            // rbPositionSize10
            // 
            rbPositionSize10.AutoSize = true;
            rbPositionSize10.Location = new Point(19, 75);
            rbPositionSize10.Name = "rbPositionSize10";
            rbPositionSize10.Size = new Size(37, 19);
            rbPositionSize10.TabIndex = 2;
            rbPositionSize10.TabStop = true;
            rbPositionSize10.Text = "10";
            rbPositionSize10.UseVisualStyleBackColor = true;
            // 
            // rbPositionSize5
            // 
            rbPositionSize5.AutoSize = true;
            rbPositionSize5.Location = new Point(19, 50);
            rbPositionSize5.Name = "rbPositionSize5";
            rbPositionSize5.Size = new Size(31, 19);
            rbPositionSize5.TabIndex = 1;
            rbPositionSize5.TabStop = true;
            rbPositionSize5.Text = "5";
            rbPositionSize5.UseVisualStyleBackColor = true;
            // 
            // rbPositionSize25
            // 
            rbPositionSize25.AutoSize = true;
            rbPositionSize25.Location = new Point(19, 25);
            rbPositionSize25.Name = "rbPositionSize25";
            rbPositionSize25.Size = new Size(40, 19);
            rbPositionSize25.TabIndex = 0;
            rbPositionSize25.TabStop = true;
            rbPositionSize25.Text = "2.5";
            rbPositionSize25.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(btnSaveMarkets);
            groupBox1.Controls.Add(dgvMarkets);
            groupBox1.Location = new Point(191, 19);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(260, 222);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            groupBox1.Text = "Markets";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label1.ForeColor = Color.Green;
            label1.Location = new Point(106, 182);
            label1.Name = "label1";
            label1.Size = new Size(41, 15);
            label1.TabIndex = 2;
            label1.Text = "Saved";
            // 
            // btnSaveMarkets
            // 
            btnSaveMarkets.Location = new Point(15, 178);
            btnSaveMarkets.Name = "btnSaveMarkets";
            btnSaveMarkets.Size = new Size(75, 23);
            btnSaveMarkets.TabIndex = 1;
            btnSaveMarkets.Text = "Save";
            btnSaveMarkets.UseVisualStyleBackColor = true;
            btnSaveMarkets.Click += btnSaveMarkets_Click;
            // 
            // dgvMarkets
            // 
            dgvMarkets.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMarkets.Columns.AddRange(new DataGridViewColumn[] { Symbol, LowValue, HighValue, ExpDate });
            dgvMarkets.Location = new Point(6, 25);
            dgvMarkets.Name = "dgvMarkets";
            dgvMarkets.RowHeadersVisible = false;
            dgvMarkets.Size = new Size(248, 134);
            dgvMarkets.TabIndex = 0;
            // 
            // gbBrokers
            // 
            gbBrokers.Controls.Add(rbETrade);
            gbBrokers.Controls.Add(rbIBKR);
            gbBrokers.Controls.Add(rbSchwab);
            gbBrokers.Location = new Point(25, 19);
            gbBrokers.Name = "gbBrokers";
            gbBrokers.Size = new Size(149, 222);
            gbBrokers.TabIndex = 6;
            gbBrokers.TabStop = false;
            gbBrokers.Text = "Brokers";
            // 
            // rbETrade
            // 
            rbETrade.AutoSize = true;
            rbETrade.Location = new Point(19, 75);
            rbETrade.Name = "rbETrade";
            rbETrade.Size = new Size(60, 19);
            rbETrade.TabIndex = 2;
            rbETrade.TabStop = true;
            rbETrade.Text = "ETrade";
            rbETrade.UseVisualStyleBackColor = true;
            rbETrade.CheckedChanged += rbBroker_CheckedChanged;
            // 
            // rbIBKR
            // 
            rbIBKR.AutoSize = true;
            rbIBKR.Location = new Point(19, 50);
            rbIBKR.Name = "rbIBKR";
            rbIBKR.Size = new Size(49, 19);
            rbIBKR.TabIndex = 1;
            rbIBKR.TabStop = true;
            rbIBKR.Text = "IBKR";
            rbIBKR.UseVisualStyleBackColor = true;
            rbIBKR.CheckedChanged += rbBroker_CheckedChanged;
            // 
            // rbSchwab
            // 
            rbSchwab.AutoSize = true;
            rbSchwab.Location = new Point(19, 25);
            rbSchwab.Name = "rbSchwab";
            rbSchwab.Size = new Size(66, 19);
            rbSchwab.TabIndex = 0;
            rbSchwab.TabStop = true;
            rbSchwab.Text = "Schwab";
            rbSchwab.UseVisualStyleBackColor = true;
            rbSchwab.CheckedChanged += rbBroker_CheckedChanged;
            // 
            // Symbol
            // 
            Symbol.HeaderText = "Symbol";
            Symbol.Name = "Symbol";
            Symbol.Width = 50;
            // 
            // LowValue
            // 
            LowValue.HeaderText = "LowValue";
            LowValue.Name = "LowValue";
            LowValue.Width = 50;
            // 
            // HighValue
            // 
            HighValue.HeaderText = "HighValue";
            HighValue.Name = "HighValue";
            HighValue.Width = 65;
            // 
            // ExpDate
            // 
            ExpDate.HeaderText = "ExpDate";
            ExpDate.Name = "ExpDate";
            ExpDate.Width = 50;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(987, 663);
            Controls.Add(tabMainTab);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += MainForm_Load;
            tabMainTab.ResumeLayout(false);
            tabPage2.ResumeLayout(false);
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMarkets).EndInit();
            gbBrokers.ResumeLayout(false);
            gbBrokers.PerformLayout();
            ResumeLayout(false);
        }



        #endregion

        private TabControl tabMainTab;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private GroupBox groupBox4;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label3;
        private Label label2;
        private RadioButton radioButton5;
        private RadioButton radioButton6;
        private GroupBox groupBox3;
        private RadioButton rbTargetPercent100;
        private RadioButton rbTargetPercent35;
        private RadioButton rbTargetPercent10;
        private GroupBox groupBox2;
        private RadioButton rbPositionSize10;
        private RadioButton rbPositionSize5;
        private RadioButton rbPositionSize25;
        private GroupBox groupBox1;
        private Label label1;
        private Button btnSaveMarkets;
        private DataGridView dgvMarkets;
        private GroupBox gbBrokers;
        private RadioButton rbETrade;
        private RadioButton rbIBKR;
        private RadioButton rbSchwab;
        private DataGridViewTextBoxColumn Symbol;
        private DataGridViewTextBoxColumn LowValue;
        private DataGridViewTextBoxColumn HighValue;
        private DataGridViewTextBoxColumn ExpDate;
    }
}
