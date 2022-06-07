using System;
using System.Collections.Generic;
using System.Windows.Forms;
using LiveCharts;
using System.Linq;
using LiveCharts.Wpf;
using System.Threading.Tasks;
using DesktopApp.Data;

namespace DesktopApp
{
    public partial class myStock : Form
    {
        private User user;
        private Commands commands;


        public myStock(User user)
        {
            this.commands = new Commands();
            this.user = user;
            InitializeComponent();

        }

        private void myStock_Load(object sender, EventArgs e)
        {

            dataGrid.DataSource = new List<Stock>();
            chart.AxisX.Add(new LiveCharts.Wpf.Axis
            {
                Title = "Time"
            });
            chart.AxisY.Add(new LiveCharts.Wpf.Axis
            {
                Title = "Money"
            });
            chart.LegendLocation = LiveCharts.LegendLocation.Right;
        }


        private void button1_Click_1(object sender, EventArgs e)
        {
            favoriteList.Visible = false;
            input.Visible = true;
            infoLable.Text = "Write down stock";
            chart.Series.Clear();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private async void addToFavoritButton_Click(object sender, EventArgs e)
        {
            dataGrid.Visible = false;
            chart.Visible = false;
         
            input.Visible = true;
            infoLable.Text = "What stock would you like to add to favorite list";
            favoriteList.Visible = true;
            List<string> list = await Input.Read();
            favoriteList.DataSource = list;
        }

        private async void input_KeyDown(object sender, KeyEventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            if ((infoLable.Text == "Write down stock" || infoLable.Text.Contains("Current")) && e.KeyCode == Keys.Enter)
            {
                dataGrid.Visible = true;
                chart.Visible = true;

                //infoLable.Text = commands.CurrentStock(user, input.Text.ToUpper());
                dataGrid.DataSource = await commands.HistoryOfStockAsync(user, input.Text.ToUpper());
                infoLable.Text = (from o in dataGrid.DataSource as List<Stock>
                                  select "Current cost of " + o.Name + " stock is " + o.ClosePrice + "$").First().ToString();
                DisplayChart();
            }
            
            else if ((infoLable.Text == "What stock would you like to add to favorite list" || infoLable.Text.Contains("was added") || infoLable.Text.Contains("already there")) && e.KeyCode == Keys.Enter)
            {
                infoLable.Text = await commands.addToFavouritesAsync(user, input.Text.ToUpper());
            }
            else if ((infoLable.Text == "Select stock for deleting from favorites" || infoLable.Text.Contains("was successfully deleted") || infoLable.Text.Contains("there is no")) && e.KeyCode == Keys.Enter)
            {
                infoLable.Text = await commands.DeleteStockFromFavouritesAsync(user, input.Text.ToUpper());
                List<string> list = await commands.DisplayFavouritesAsync(user);
                favoriteList.DataSource = list;
            }
            this.Cursor = Cursors.Default;
        }



        private  void DisplayChart()
        {

            chart.Series.Clear();
            SeriesCollection series = new SeriesCollection();


            var stockNames = (from o in dataGrid.DataSource as List<Stock>
                              select new { Stock = o.Name }).Distinct();

            foreach (var stockName in stockNames)
            {
                List<decimal> values = new List<decimal>();

                foreach (var o in dataGrid.DataSource as List<Stock>)
                {
                    values.Add(o.ClosePrice);
                }


                series.Add(new LineSeries()
                {
                    Values = new ChartValues<decimal>(values),
                    Title = stockName.Stock.ToString()
                });
            }

            chart.Series = series;
        }

        private async void displayFavoritesButton_Click_1(object sender, EventArgs e)
        {
            dataGrid.Visible = false;
            chart.Visible = false;
            favoriteList.Visible = true;
            infoLable.Text = "All favorites stoks";
            input.Visible = false;
            List<string> list = await commands.DisplayFavouritesAsync(user);
            favoriteList.DataSource = list;

        }

        private async void deleteStockButton_Click_1(object sender, EventArgs e)
        {
            dataGrid.Visible = false;
            chart.Visible = false;
            infoLable.Text = "Select stock for deleting from favorites";
            input.Visible = true;
            favoriteList.Visible = true;
            List<string> list = await commands.DisplayFavouritesAsync(user);
            favoriteList.DataSource = list;
        }
    }
}
