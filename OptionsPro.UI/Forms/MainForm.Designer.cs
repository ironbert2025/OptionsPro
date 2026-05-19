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
            gbBrokers = new GroupBox();
            rbBroker1 = new RadioButton();
            rbBroker2 = new RadioButton();
            rdBroker3 = new RadioButton();
            groupBox1 = new GroupBox();
            dgvMarkets = new DataGridView();
            btnSaveMarkets = new Button();
            label1 = new Label();
            groupBox2 = new GroupBox();
            rbPositionSize3 = new RadioButton();
            rbPositionSize2 = new RadioButton();
            rbPositionSize1 = new RadioButton();
            groupBox3 = new GroupBox();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton3 = new RadioButton();
            groupBox4 = new GroupBox();
            radioButton5 = new RadioButton();
            radioButton6 = new RadioButton();
            label2 = new Label();
            label3 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            tabMainTab.SuspendLayout();
            tabPage1.SuspendLayout();
            gbBrokers.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMarkets).BeginInit();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
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
            tabPage1.Controls.Add(groupBox4);
            tabPage1.Controls.Add(groupBox3);
            tabPage1.Controls.Add(groupBox2);
            tabPage1.Controls.Add(groupBox1);
            tabPage1.Controls.Add(gbBrokers);
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
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(927, 611);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Settings";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // gbBrokers
            // 
            gbBrokers.Controls.Add(rdBroker3);
            gbBrokers.Controls.Add(rbBroker2);
            gbBrokers.Controls.Add(rbBroker1);
            gbBrokers.Location = new Point(20, 20);
            gbBrokers.Name = "gbBrokers";
            gbBrokers.Size = new Size(149, 222);
            gbBrokers.TabIndex = 0;
            gbBrokers.TabStop = false;
            gbBrokers.Text = "Brokers";
            // 
            // rbBroker1
            // 
            rbBroker1.AutoSize = true;
            rbBroker1.Location = new Point(19, 25);
            rbBroker1.Name = "rbBroker1";
            rbBroker1.Size = new Size(108, 19);
            rbBroker1.TabIndex = 0;
            rbBroker1.TabStop = true;
            rbBroker1.Text = "Charles Schwab";
            rbBroker1.UseVisualStyleBackColor = true;
            // 
            // rbBroker2
            // 
            rbBroker2.AutoSize = true;
            rbBroker2.Location = new Point(19, 50);
            rbBroker2.Name = "rbBroker2";
            rbBroker2.Size = new Size(117, 19);
            rbBroker2.TabIndex = 1;
            rbBroker2.TabStop = true;
            rbBroker2.Text = "Interactive Broker";
            rbBroker2.UseVisualStyleBackColor = true;
            // 
            // rdBroker3
            // 
            rdBroker3.AutoSize = true;
            rdBroker3.Location = new Point(19, 75);
            rdBroker3.Name = "rdBroker3";
            rdBroker3.Size = new Size(65, 19);
            rdBroker3.TabIndex = 2;
            rdBroker3.TabStop = true;
            rdBroker3.Text = "E-Trade";
            rdBroker3.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(btnSaveMarkets);
            groupBox1.Controls.Add(dgvMarkets);
            groupBox1.Location = new Point(192, 20);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(260, 222);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Markets";
            // 
            // dgvMarkets
            // 
            dgvMarkets.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMarkets.Location = new Point(6, 22);
            dgvMarkets.Name = "dgvMarkets";
            dgvMarkets.Size = new Size(234, 134);
            dgvMarkets.TabIndex = 0;
            // 
            // btnSaveMarkets
            // 
            btnSaveMarkets.Location = new Point(15, 178);
            btnSaveMarkets.Name = "btnSaveMarkets";
            btnSaveMarkets.Size = new Size(75, 23);
            btnSaveMarkets.TabIndex = 1;
            btnSaveMarkets.Text = "Save";
            btnSaveMarkets.UseVisualStyleBackColor = true;
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
            // groupBox2
            // 
            groupBox2.Controls.Add(rbPositionSize3);
            groupBox2.Controls.Add(rbPositionSize2);
            groupBox2.Controls.Add(rbPositionSize1);
            groupBox2.Location = new Point(470, 20);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(108, 222);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            groupBox2.Text = "Position Size (%)";
            // 
            // rbPositionSize3
            // 
            rbPositionSize3.AutoSize = true;
            rbPositionSize3.Location = new Point(19, 75);
            rbPositionSize3.Name = "rbPositionSize3";
            rbPositionSize3.Size = new Size(37, 19);
            rbPositionSize3.TabIndex = 2;
            rbPositionSize3.TabStop = true;
            rbPositionSize3.Text = "10";
            rbPositionSize3.UseVisualStyleBackColor = true;
            // 
            // rbPositionSize2
            // 
            rbPositionSize2.AutoSize = true;
            rbPositionSize2.Location = new Point(19, 50);
            rbPositionSize2.Name = "rbPositionSize2";
            rbPositionSize2.Size = new Size(31, 19);
            rbPositionSize2.TabIndex = 1;
            rbPositionSize2.TabStop = true;
            rbPositionSize2.Text = "5";
            rbPositionSize2.UseVisualStyleBackColor = true;
            // 
            // rbPositionSize1
            // 
            rbPositionSize1.AutoSize = true;
            rbPositionSize1.Location = new Point(19, 25);
            rbPositionSize1.Name = "rbPositionSize1";
            rbPositionSize1.Size = new Size(40, 19);
            rbPositionSize1.TabIndex = 0;
            rbPositionSize1.TabStop = true;
            rbPositionSize1.Text = "2.5";
            rbPositionSize1.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(radioButton1);
            groupBox3.Controls.Add(radioButton2);
            groupBox3.Controls.Add(radioButton3);
            groupBox3.Location = new Point(593, 20);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(108, 222);
            groupBox3.TabIndex = 4;
            groupBox3.TabStop = false;
            groupBox3.Text = "Target (%)";
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(19, 75);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(43, 19);
            radioButton1.TabIndex = 2;
            radioButton1.TabStop = true;
            radioButton1.Text = "100";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(19, 50);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(37, 19);
            radioButton2.TabIndex = 1;
            radioButton2.TabStop = true;
            radioButton2.Text = "35";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Location = new Point(19, 25);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(37, 19);
            radioButton3.TabIndex = 0;
            radioButton3.TabStop = true;
            radioButton3.Text = "10";
            radioButton3.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(textBox2);
            groupBox4.Controls.Add(textBox1);
            groupBox4.Controls.Add(label3);
            groupBox4.Controls.Add(label2);
            groupBox4.Controls.Add(radioButton5);
            groupBox4.Controls.Add(radioButton6);
            groupBox4.Location = new Point(717, 20);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(150, 222);
            groupBox4.TabIndex = 5;
            groupBox4.TabStop = false;
            groupBox4.Text = "Accounts";
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
            // textBox1
            // 
            textBox1.Location = new Point(35, 49);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 5;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(35, 111);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 6;
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
            tabMainTab.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            gbBrokers.ResumeLayout(false);
            gbBrokers.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMarkets).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabMainTab;
        private TabPage tabPage1;
        private GroupBox gbBrokers;
        private RadioButton rbBroker1;
        private TabPage tabPage2;
        private GroupBox groupBox1;
        private Label label1;
        private Button btnSaveMarkets;
        private DataGridView dgvMarkets;
        private RadioButton rdBroker3;
        private RadioButton rbBroker2;
        private GroupBox groupBox4;
        private Label label3;
        private Label label2;
        private RadioButton radioButton5;
        private RadioButton radioButton6;
        private GroupBox groupBox3;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private RadioButton radioButton3;
        private GroupBox groupBox2;
        private RadioButton rbPositionSize3;
        private RadioButton rbPositionSize2;
        private RadioButton rbPositionSize1;
        private TextBox textBox2;
        private TextBox textBox1;
    }
}
