using System.Windows.Forms.DataVisualization.Charting;

namespace WinFormsLab2
{
	partial class Form1
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
			
			chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
			chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();

			legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
			legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();

			series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
			series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
			
			//this.chartAreas.Add(chartArea1);
			//this.chartAreas.Add(chartArea2);
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.dataGridView2 = new System.Windows.Forms.DataGridView();

			this.addButton = new System.Windows.Forms.Button();
			this.buttonOpen = new System.Windows.Forms.Button();
			this.buttonSave = new System.Windows.Forms.Button();
			this.buttonOpenChartGrath = new System.Windows.Forms.Button();
			
			this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();			
			
			this.comboBox1 = new ComboBox();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
			this.SuspendLayout();
			
			// 
			// dataGridView1
			// 
			this.dataGridView1.ColumnHeadersHeightSizeMode =
			System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(521, 57);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.Size = new System.Drawing.Size(240, 150);
			this.dataGridView1.TabIndex = 0;

			this.dataGridView2.ColumnHeadersHeightSizeMode =
			System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView2.Location = new System.Drawing.Point(821, 57);
			this.dataGridView2.Name = "dataGridView2";
			this.dataGridView2.Size = new System.Drawing.Size(240, 150);
			this.dataGridView2.TabIndex = 0;
			// 
			// addButton
			// 
			this.addButton.Location = new System.Drawing.Point(686, 213);
			this.addButton.Name = "addButton";
			this.addButton.Size = new System.Drawing.Size(75, 23);
			this.addButton.TabIndex = 1;
			this.addButton.Text = "Add";
			this.addButton.UseVisualStyleBackColor = true;
			this.addButton.Click += new System.EventHandler(this.AddButton_Click);
			// 
			// ButtonOpen
			// 
			this.buttonOpen.Location = new System.Drawing.Point(686, 241);
			this.buttonOpen.Name = "addButton";
			this.buttonOpen.Size = new System.Drawing.Size(75, 23);
			this.buttonOpen.TabIndex = 1;
			this.buttonOpen.Text = "Open";
			this.buttonOpen.UseVisualStyleBackColor = true;
			this.buttonOpen.Click += new System.EventHandler(this.ButtonOpen_Click);
			// 
			// ButtonSave
			// 
			this.buttonSave.Location = new System.Drawing.Point(686, 269);
			this.buttonSave.Name = "addButton";
			this.buttonSave.Size = new System.Drawing.Size(75, 23);
			this.buttonSave.TabIndex = 1;
			this.buttonSave.Text = "Save";
			this.buttonSave.UseVisualStyleBackColor = true;
			this.buttonSave.Click += new System.EventHandler(this.ButtonSave_Click);
			// 
			// ButtonOpenChartGrath
			// 
			this.buttonOpenChartGrath.Location = new System.Drawing.Point(686, 292);
			this.buttonOpenChartGrath.Name = "ChartGrath";
			this.buttonOpenChartGrath.Size = new System.Drawing.Size(75, 23);
			this.buttonOpenChartGrath.TabIndex = 1;
			this.buttonOpenChartGrath.Text = "ChartGrath";
			this.buttonOpenChartGrath.UseVisualStyleBackColor = true;
			this.buttonOpenChartGrath.Click += new System.EventHandler(this.ButtonOpenChartGrath_Click);
			// 
			// chart1
			// 
			chartArea1.Name = "ChartArea1";
			this.chart1.ChartAreas.Add(chartArea1);
			legend1.Enabled = true;
			legend1.Name = "Legend1";
			this.chart1.Legends.Add(legend1);			
			this.chart1.Location = new System.Drawing.Point(12, 16);
			this.chart1.Name = "chart1";
			series1.ChartArea = "ChartArea1";
			series1.Legend = "Legend1";
			series1.Name = "Series1";
			series1.XValueMember = "X";
			series1.YValueMembers = "Y";
			this.chart1.Series.Add(series1);
			this.chart1.Size = new System.Drawing.Size(500, 300);
			this.chart1.TabIndex = 2;
			this.chart1.Text = "chart1";			
			//
			// ComboBox
			//
			this.comboBox1.Location = new System.Drawing.Point(521, 250);
			this.comboBox1.Name = "ComboBox";			
			this.comboBox1.Items.Add("Lines");
			this.comboBox1.Items.Add("Spline");
			this.comboBox1.SelectedIndex = 0;
			this.comboBox1.SelectedIndexChanged += ComboBox1_SelectedIndexChanged;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1200, 600);
			//this.Controls.Add(this.button2);
			//this.Controls.Add(this.button1);
			this.Controls.Add(this.comboBox1);
			this.Controls.Add(this.chart1);
			this.Controls.Add(this.addButton);
			this.Controls.Add(this.buttonSave);
			this.Controls.Add(this.buttonOpen);
			this.Controls.Add(this.buttonOpenChartGrath);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.dataGridView2);
			this.Name = "Form1";
			this.Text = "Form1";
			((System.ComponentModel.ISupportInitialize)(dataGridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(dataGridView2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
			this.ResumeLayout(false);

		}


		#endregion
		//private System.Windows.Forms.DataVisualization.Charting.ChartAreaCollection chartAreas;
		private System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1;
		private System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2;

		private System.Windows.Forms.DataVisualization.Charting.Legend legend1;
		private System.Windows.Forms.DataVisualization.Charting.Legend legend2;

		private System.Windows.Forms.DataVisualization.Charting.Series series1;
		private System.Windows.Forms.DataVisualization.Charting.Series series2;

		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.DataGridView dataGridView2;

		private System.Windows.Forms.Button addButton;
		private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
		//private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
		private System.Windows.Forms.Button buttonOpen;
		private System.Windows.Forms.Button buttonSave;
		private System.Windows.Forms.Button buttonOpenChartGrath;
		private System.Windows.Forms.ComboBox comboBox1;
	}
}