﻿namespace Z70.SQLServerOcenkOneToMany
{
    partial class ModalessOtstapuvanjePredmeti
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.lvOtstapuvanjePredmeti = new System.Windows.Forms.ListView();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // lvOtstapuvanjePredmeti
            // 
            this.lvOtstapuvanjePredmeti.HideSelection = false;
            this.lvOtstapuvanjePredmeti.Location = new System.Drawing.Point(12, 25);
            this.lvOtstapuvanjePredmeti.Name = "lvOtstapuvanjePredmeti";
            this.lvOtstapuvanjePredmeti.Size = new System.Drawing.Size(1440, 270);
            this.lvOtstapuvanjePredmeti.TabIndex = 3;
            this.lvOtstapuvanjePredmeti.UseCompatibleStateImageBehavior = false;
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(48, 317);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Ucenici";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(1348, 300);
            this.chart1.TabIndex = 4;
            this.chart1.Text = "chart1";
            this.chart1.Click += new System.EventHandler(this.chart1_Click);
            // 
            // ModalessOtstapuvanjePredmeti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1454, 668);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.lvOtstapuvanjePredmeti);
            this.Name = "ModalessOtstapuvanjePredmeti";
            this.Text = "ModalessOtstapuvanjePredmeti";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lvOtstapuvanjePredmeti;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    }
}