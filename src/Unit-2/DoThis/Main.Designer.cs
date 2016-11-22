namespace ChartApp
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.sysChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.cpuToggleButton = new System.Windows.Forms.Button();
            this.ramToggleButton = new System.Windows.Forms.Button();
            this.diskToggleButton = new System.Windows.Forms.Button();
            this.rotationButton = new System.Windows.Forms.Button();
            this.pauseButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.sysChart)).BeginInit();
            this.SuspendLayout();
            // 
            // sysChart
            // 
            chartArea2.Name = "ChartArea1";
            this.sysChart.ChartAreas.Add(chartArea2);
            this.sysChart.Dock = System.Windows.Forms.DockStyle.Fill;
            legend2.Name = "Legend1";
            this.sysChart.Legends.Add(legend2);
            this.sysChart.Location = new System.Drawing.Point(0, 0);
            this.sysChart.Name = "sysChart";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.sysChart.Series.Add(series2);
            this.sysChart.Size = new System.Drawing.Size(684, 446);
            this.sysChart.TabIndex = 0;
            this.sysChart.Text = "sysChart";
            // 
            // cpuToggleButton
            // 
            this.cpuToggleButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cpuToggleButton.Location = new System.Drawing.Point(597, 355);
            this.cpuToggleButton.Name = "cpuToggleButton";
            this.cpuToggleButton.Size = new System.Drawing.Size(75, 23);
            this.cpuToggleButton.TabIndex = 1;
            this.cpuToggleButton.Text = "CPU (ON)";
            this.cpuToggleButton.UseVisualStyleBackColor = true;
            this.cpuToggleButton.Click += new System.EventHandler(this.cpuToggleButton_Click);
            // 
            // ramToggleButton
            // 
            this.ramToggleButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ramToggleButton.Location = new System.Drawing.Point(597, 384);
            this.ramToggleButton.Name = "ramToggleButton";
            this.ramToggleButton.Size = new System.Drawing.Size(75, 23);
            this.ramToggleButton.TabIndex = 2;
            this.ramToggleButton.Text = "RAM (ON)";
            this.ramToggleButton.UseVisualStyleBackColor = true;
            this.ramToggleButton.Click += new System.EventHandler(this.ramToggleButton_Click);
            // 
            // diskToggleButton
            // 
            this.diskToggleButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.diskToggleButton.Location = new System.Drawing.Point(597, 411);
            this.diskToggleButton.Name = "diskToggleButton";
            this.diskToggleButton.Size = new System.Drawing.Size(75, 23);
            this.diskToggleButton.TabIndex = 3;
            this.diskToggleButton.Text = "DISK (ON)";
            this.diskToggleButton.UseVisualStyleBackColor = true;
            this.diskToggleButton.Click += new System.EventHandler(this.diskToggleButton_Click);
            // 
            // rotationButton
            // 
            this.rotationButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.rotationButton.Location = new System.Drawing.Point(597, 296);
            this.rotationButton.Name = "rotationButton";
            this.rotationButton.Size = new System.Drawing.Size(75, 53);
            this.rotationButton.TabIndex = 4;
            this.rotationButton.Text = "???";
            this.rotationButton.UseVisualStyleBackColor = true;
            this.rotationButton.Click += new System.EventHandler(this.rotationButton_Click);
            // 
            // pauseButton
            // 
            this.pauseButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pauseButton.Location = new System.Drawing.Point(597, 267);
            this.pauseButton.Name = "pauseButton";
            this.pauseButton.Size = new System.Drawing.Size(75, 23);
            this.pauseButton.TabIndex = 5;
            this.pauseButton.Text = "PAUSE ||";
            this.pauseButton.UseVisualStyleBackColor = true;
            this.pauseButton.Click += new System.EventHandler(this.pauseButton_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 446);
            this.Controls.Add(this.pauseButton);
            this.Controls.Add(this.rotationButton);
            this.Controls.Add(this.diskToggleButton);
            this.Controls.Add(this.ramToggleButton);
            this.Controls.Add(this.cpuToggleButton);
            this.Controls.Add(this.sysChart);
            this.Name = "Main";
            this.Text = "System Metrics";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_FormClosing);
            this.Load += new System.EventHandler(this.Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sysChart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart sysChart;
        private System.Windows.Forms.Button cpuToggleButton;
        private System.Windows.Forms.Button ramToggleButton;
        private System.Windows.Forms.Button diskToggleButton;
        private System.Windows.Forms.Button rotationButton;
        private System.Windows.Forms.Button pauseButton;
    }
}

