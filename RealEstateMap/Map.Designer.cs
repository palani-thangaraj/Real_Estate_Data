namespace RealEstateMap
{
    partial class Map
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Map));
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.titleLabel = new System.Windows.Forms.Label();
            this.gmap = new GMap.NET.WindowsForms.GMapControl();
            this.mapPanel = new System.Windows.Forms.Panel();
            this.topRegionsLabel = new System.Windows.Forms.Label();
            this.panel9 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.topRegions = new System.Windows.Forms.TextBox();
            this.mapView = new System.Windows.Forms.TrackBar();
            this.mapViewLabel = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.salesVolumeWeight = new System.Windows.Forms.NumericUpDown();
            this.seasonalityWeight = new System.Windows.Forms.NumericUpDown();
            this.millenialsWeight = new System.Windows.Forms.NumericUpDown();
            this.educationWeight = new System.Windows.Forms.NumericUpDown();
            this.incomeWeight = new System.Windows.Forms.NumericUpDown();
            this.populationGrowthWeight = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.weightButton = new System.Windows.Forms.Button();
            this.panel10 = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            this.panel7.SuspendLayout();
            this.mapPanel.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mapView)).BeginInit();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.salesVolumeWeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.seasonalityWeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.millenialsWeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.educationWeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.incomeWeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.populationGrowthWeight)).BeginInit();
            this.panel10.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(12, 110);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(191, 32);
            this.panel2.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(56, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Metrics";
            // 
            // panel7
            // 
            this.panel7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel7.Controls.Add(this.titleLabel);
            this.panel7.Location = new System.Drawing.Point(0, 0);
            this.panel7.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(1793, 74);
            this.panel7.TabIndex = 0;
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.BackColor = System.Drawing.Color.Transparent;
            this.titleLabel.Dock = System.Windows.Forms.DockStyle.Left;
            this.titleLabel.Font = new System.Drawing.Font("Yu Gothic UI", 31.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.titleLabel.Location = new System.Drawing.Point(0, 0);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(419, 71);
            this.titleLabel.TabIndex = 1;
            this.titleLabel.Text = "Real Estate Data";
            // 
            // gmap
            // 
            this.gmap.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gmap.AutoSize = true;
            this.gmap.Bearing = 0F;
            this.gmap.CanDragMap = true;
            this.gmap.EmptyTileColor = System.Drawing.Color.Navy;
            this.gmap.GrayScaleMode = false;
            this.gmap.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.gmap.LevelsKeepInMemmory = 5;
            this.gmap.Location = new System.Drawing.Point(0, 0);
            this.gmap.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gmap.MarkersEnabled = true;
            this.gmap.MaxZoom = 18;
            this.gmap.MinZoom = 4;
            this.gmap.MouseWheelZoomEnabled = true;
            this.gmap.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.gmap.Name = "gmap";
            this.gmap.NegativeMode = false;
            this.gmap.PolygonsEnabled = true;
            this.gmap.RetryLoadTile = 0;
            this.gmap.RoutesEnabled = true;
            this.gmap.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.gmap.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.gmap.ShowTileGridLines = false;
            this.gmap.Size = new System.Drawing.Size(1175, 661);
            this.gmap.TabIndex = 0;
            this.gmap.Zoom = 4D;
            // 
            // mapPanel
            // 
            this.mapPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mapPanel.Controls.Add(this.gmap);
            this.mapPanel.Location = new System.Drawing.Point(224, 81);
            this.mapPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mapPanel.Name = "mapPanel";
            this.mapPanel.Size = new System.Drawing.Size(1175, 661);
            this.mapPanel.TabIndex = 0;
            // 
            // topRegionsLabel
            // 
            this.topRegionsLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.topRegionsLabel.AutoSize = true;
            this.topRegionsLabel.BackColor = System.Drawing.Color.Transparent;
            this.topRegionsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.topRegionsLabel.ForeColor = System.Drawing.Color.Black;
            this.topRegionsLabel.Location = new System.Drawing.Point(111, 6);
            this.topRegionsLabel.Name = "topRegionsLabel";
            this.topRegionsLabel.Size = new System.Drawing.Size(130, 24);
            this.topRegionsLabel.TabIndex = 0;
            this.topRegionsLabel.Text = "Top Regions";
            // 
            // panel9
            // 
            this.panel9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel9.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel9.Controls.Add(this.topRegionsLabel);
            this.panel9.Location = new System.Drawing.Point(1427, 81);
            this.panel9.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(341, 36);
            this.panel9.TabIndex = 3;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.Controls.Add(this.topRegions);
            this.panel3.Location = new System.Drawing.Point(1427, 81);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(341, 661);
            this.panel3.TabIndex = 11;
            // 
            // topRegions
            // 
            this.topRegions.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.topRegions.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.topRegions.Location = new System.Drawing.Point(0, 34);
            this.topRegions.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.topRegions.Multiline = true;
            this.topRegions.Name = "topRegions";
            this.topRegions.ReadOnly = true;
            this.topRegions.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.topRegions.Size = new System.Drawing.Size(343, 626);
            this.topRegions.TabIndex = 0;
            this.topRegions.TabStop = false;
            // 
            // mapView
            // 
            this.mapView.BackColor = System.Drawing.Color.WhiteSmoke;
            this.mapView.Location = new System.Drawing.Point(12, 466);
            this.mapView.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.mapView.Maximum = 1;
            this.mapView.Name = "mapView";
            this.mapView.Size = new System.Drawing.Size(191, 56);
            this.mapView.TabIndex = 13;
            this.mapView.TabStop = false;
            this.mapView.ValueChanged += new System.EventHandler(this.mapView_ValueChanged);
            // 
            // mapViewLabel
            // 
            this.mapViewLabel.AutoSize = true;
            this.mapViewLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mapViewLabel.Location = new System.Drawing.Point(64, 4);
            this.mapViewLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.mapViewLabel.Name = "mapViewLabel";
            this.mapViewLabel.Size = new System.Drawing.Size(56, 24);
            this.mapViewLabel.TabIndex = 14;
            this.mapViewLabel.Text = "View";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel5.Controls.Add(this.mapViewLabel);
            this.panel5.Location = new System.Drawing.Point(12, 434);
            this.panel5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(191, 32);
            this.panel5.TabIndex = 15;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(15, 506);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(58, 17);
            this.label9.TabIndex = 17;
            this.label9.Text = "County";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(163, 506);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(35, 17);
            this.label10.TabIndex = 18;
            this.label10.Text = "City";
            // 
            // salesVolumeWeight
            // 
            this.salesVolumeWeight.Location = new System.Drawing.Point(119, 37);
            this.salesVolumeWeight.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.salesVolumeWeight.Name = "salesVolumeWeight";
            this.salesVolumeWeight.Size = new System.Drawing.Size(68, 22);
            this.salesVolumeWeight.TabIndex = 0;
            // 
            // seasonalityWeight
            // 
            this.seasonalityWeight.Location = new System.Drawing.Point(119, 69);
            this.seasonalityWeight.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.seasonalityWeight.Name = "seasonalityWeight";
            this.seasonalityWeight.Size = new System.Drawing.Size(68, 22);
            this.seasonalityWeight.TabIndex = 1;
            // 
            // millenialsWeight
            // 
            this.millenialsWeight.Location = new System.Drawing.Point(119, 101);
            this.millenialsWeight.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.millenialsWeight.Name = "millenialsWeight";
            this.millenialsWeight.Size = new System.Drawing.Size(68, 22);
            this.millenialsWeight.TabIndex = 2;
            // 
            // educationWeight
            // 
            this.educationWeight.Location = new System.Drawing.Point(119, 133);
            this.educationWeight.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.educationWeight.Name = "educationWeight";
            this.educationWeight.Size = new System.Drawing.Size(68, 22);
            this.educationWeight.TabIndex = 3;
            // 
            // incomeWeight
            // 
            this.incomeWeight.Location = new System.Drawing.Point(119, 165);
            this.incomeWeight.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.incomeWeight.Name = "incomeWeight";
            this.incomeWeight.Size = new System.Drawing.Size(68, 22);
            this.incomeWeight.TabIndex = 4;
            // 
            // populationGrowthWeight
            // 
            this.populationGrowthWeight.Location = new System.Drawing.Point(119, 197);
            this.populationGrowthWeight.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.populationGrowthWeight.Name = "populationGrowthWeight";
            this.populationGrowthWeight.Size = new System.Drawing.Size(68, 22);
            this.populationGrowthWeight.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(4, 41);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 18);
            this.label2.TabIndex = 10;
            this.label2.Text = "Sales Volume";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(4, 73);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 18);
            this.label4.TabIndex = 11;
            this.label4.Text = "Seasonality";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(4, 105);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 18);
            this.label5.TabIndex = 12;
            this.label5.Text = "Millenials";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(4, 137);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 18);
            this.label6.TabIndex = 13;
            this.label6.Text = "Education";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(4, 169);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 18);
            this.label7.TabIndex = 14;
            this.label7.Text = "Income";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(3, 201);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(92, 18);
            this.label8.TabIndex = 15;
            this.label8.Text = "Pop. Growth";
            // 
            // weightButton
            // 
            this.weightButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.weightButton.Location = new System.Drawing.Point(59, 235);
            this.weightButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.weightButton.Name = "weightButton";
            this.weightButton.Size = new System.Drawing.Size(75, 23);
            this.weightButton.TabIndex = 1;
            this.weightButton.Text = "Enter";
            this.weightButton.UseVisualStyleBackColor = true;
            this.weightButton.Click += new System.EventHandler(this.weightButton_Click);
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel10.Controls.Add(this.weightButton);
            this.panel10.Controls.Add(this.label8);
            this.panel10.Controls.Add(this.label7);
            this.panel10.Controls.Add(this.label6);
            this.panel10.Controls.Add(this.label5);
            this.panel10.Controls.Add(this.label4);
            this.panel10.Controls.Add(this.label2);
            this.panel10.Controls.Add(this.populationGrowthWeight);
            this.panel10.Controls.Add(this.incomeWeight);
            this.panel10.Controls.Add(this.educationWeight);
            this.panel10.Controls.Add(this.millenialsWeight);
            this.panel10.Controls.Add(this.seasonalityWeight);
            this.panel10.Controls.Add(this.salesVolumeWeight);
            this.panel10.Location = new System.Drawing.Point(12, 111);
            this.panel10.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(191, 270);
            this.panel10.TabIndex = 10;
            // 
            // Map
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1793, 759);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.mapView);
            this.Controls.Add(this.panel9);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.mapPanel);
            this.Controls.Add(this.panel10);
            this.Controls.Add(this.panel3);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Map";
            this.Text = "Real Estate Markets";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.mapPanel.ResumeLayout(false);
            this.mapPanel.PerformLayout();
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mapView)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.salesVolumeWeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.seasonalityWeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.millenialsWeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.educationWeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.incomeWeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.populationGrowthWeight)).EndInit();
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel7;
        private GMap.NET.WindowsForms.GMapControl gmap;
        private System.Windows.Forms.Panel mapPanel;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label topRegionsLabel;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox topRegions;
        private System.Windows.Forms.TrackBar mapView;
        private System.Windows.Forms.Label mapViewLabel;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.NumericUpDown salesVolumeWeight;
        private System.Windows.Forms.NumericUpDown seasonalityWeight;
        private System.Windows.Forms.NumericUpDown millenialsWeight;
        private System.Windows.Forms.NumericUpDown educationWeight;
        private System.Windows.Forms.NumericUpDown incomeWeight;
        private System.Windows.Forms.NumericUpDown populationGrowthWeight;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button weightButton;
        private System.Windows.Forms.Panel panel10;
    }
}

