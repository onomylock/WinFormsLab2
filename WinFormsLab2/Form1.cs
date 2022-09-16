using System.Windows.Forms;
using System;
using System.Windows.Forms.DataVisualization.Charting;
//using System.Windows.Forms.DataVisualisation;

namespace WinFormsLab2
{
	public partial class Form1 : Form
	{
		public BindingSource Data { get; set; }
		public BindingSource DataFile { get; set; }

		public Form1()
		{
			Data = new BindingSource();
			DataFile = new BindingSource();
			//DataFile.Add(new Data() { X = 3, Y = 5 });
			//DataFile.Add(new Data() { X = 2, Y = 5 });
			//DataFile.Add(new Data() { X = 4, Y = 6 });
			Data.Add(new Data() { X = 0, Y = 0 });
			Data.Add(new Data() { X = 1, Y = 1 });
			Data.Add(new Data() { X = 2, Y = 4 });
			InitializeComponent();
			dataGridView1.DataSource = Data;
			dataGridView2.DataSource = DataFile;
			//dataGridView1.DataSource = DataFile;
			this.Invalidated += Form1_Invalidated;
			this.Invalidated += Form1_Invalidated2;

			dataGridView1.RowsRemoved += DataGridView1_RowsRemoved;
			dataGridView1.CellValueChanged += DataGridView1_CellValueChanged;

			dataGridView2.RowsRemoved += DataGridView2_RowsRemoved;
			dataGridView2.CellValueChanged += DataGridView2_CellValueChanged;			
		}

		private void DataGridView1_CellValueChanged(object? sender, DataGridViewCellEventArgs e)
		{
			Invalidate();
		}

		private void DataGridView2_CellValueChanged(object? sender, DataGridViewCellEventArgs e)
		{
			Invalidate();
		}

		private void DataGridView1_RowsRemoved(object? sender, DataGridViewRowsRemovedEventArgs e)
		{
			Invalidate();
		}

		private void DataGridView2_RowsRemoved(object? sender, DataGridViewRowsRemovedEventArgs e)
		{
			Invalidate();
		}

		private void Form1_Invalidated2(object? sender, InvalidateEventArgs e)
		{
			if (comboBox1.SelectedIndex == 0)
			{				
				chart1.Series[1].Points.Clear();
				chart1.Series[1].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
				foreach (Data dataItem in DataFile.List)
				{
					chart1.Series[1].Points.AddXY(dataItem.X, dataItem.Y);
				}
			}
			else if (comboBox1.SelectedIndex == 1)
			{				
				chart1.Series[1].Points.Clear();
				chart1.Series[1].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
				foreach (Data dataItem in DataFile.List)
				{
					chart1.Series[1].Points.AddXY(dataItem.X, dataItem.Y);
				}				
			}
		}

		private void Form1_Invalidated(object? sender, InvalidateEventArgs e)
		{
			if (comboBox1.SelectedIndex == 0)
			{				
				chart1.Series[0].Points.Clear();
				chart1.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
				foreach (Data dataItem in Data.List)
				{
					chart1.Series[0].Points.AddXY(dataItem.X, dataItem.Y);
				}				
			}
			else if (comboBox1.SelectedIndex == 1)
			{				
				chart1.Series[0].Points.Clear();
				chart1.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
				foreach (Data dataItem in Data.List)
				{
					chart1.Series[0].Points.AddXY(dataItem.X, dataItem.Y);
				}				
			}
		}
		
		private void AddButton_Click1(object sender, EventArgs e)
		{
			Data.Add(new Data() { X = 4, Y = 16 });
			Invalidate();
		}

		private void AddButton_Click2(object sender, EventArgs e)
		{
			DataFile.Add(new Data() { X = 4, Y = 16 });
			Invalidate();
		}

		private void ButtonOpen_Click(object sender, EventArgs e)
		{			
			var filePath = string.Empty;
			var stringLine = string.Empty;

			using (OpenFileDialog openFileDialog = new OpenFileDialog())
			{
				openFileDialog.InitialDirectory = "c:\\";
				openFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
				openFileDialog.FilterIndex = 2;
				openFileDialog.RestoreDirectory = true;

				if (openFileDialog.ShowDialog() == DialogResult.OK)
				{									
					filePath = openFileDialog.FileName;					
					var fileStream = openFileDialog.OpenFile();
					Data.Clear();
					using (StreamReader reader = new StreamReader(fileStream))
					{						
						while(!reader.EndOfStream)
						{
							stringLine = reader.ReadLine();
							if(stringLine != null)
							{
								var tmp = stringLine.Split();
								Data.Add(new Data() { X = double.Parse(tmp[0]), Y = double.Parse(tmp[1]) });
							}							
						}
					}
					Invalidate();
				}
			}
		}
		
		private void ButtonOpenChartGrath_Click(object sender, EventArgs e)
		{
			var filePath = string.Empty;
			var stringLine = string.Empty;

			using (OpenFileDialog openFileDialog = new OpenFileDialog())
			{
				openFileDialog.InitialDirectory = "c:\\";
				openFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
				openFileDialog.FilterIndex = 2;
				openFileDialog.RestoreDirectory = true;

				if (openFileDialog.ShowDialog() == DialogResult.OK)
				{
					filePath = openFileDialog.FileName;
					var fileStream = openFileDialog.OpenFile();				

					using (StreamReader reader = new StreamReader(fileStream))
					{
						while (!reader.EndOfStream)
						{
							stringLine = reader.ReadLine();
							if (stringLine != null)
							{
								var tmp = stringLine.Split();
								DataFile.Add(new Data() { X = double.Parse(tmp[0]), Y = double.Parse(tmp[1]) });
							}
						}
					}
					Invalidate();
				}
			}
		}

		private void ButtonSave_Click(object sender, EventArgs e)
		{
			//Stream myStream;
			SaveFileDialog saveFileDialog1 = new SaveFileDialog();

			saveFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
			saveFileDialog1.FilterIndex = 2;
			saveFileDialog1.RestoreDirectory = true;

			if (saveFileDialog1.ShowDialog() == DialogResult.OK)
			{
				using(StreamWriter writer = new StreamWriter(saveFileDialog1.FileName))
				{
					foreach (Data item in Data)
					{
						writer.WriteLine(item.X.ToString() + "\t" + item.Y.ToString());
					}
				}				
			}
		}

		private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
		{
			Invalidate();
		}
	}
	public class Data
	{
		public double X { get; set; }
		public double Y { get; set; }
	}	
}