using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestaurantAutomation.UI.Forms
{
    public partial class ReportForm : Form
    {
        public ReportForm()
        {
            InitializeComponent();
        }

        private void btnMainMenu_Click(object sender, EventArgs e)
        {
            Program.MainFormInstance.Show();
            this.Hide();
        }

        private void ReportForm_Load(object sender, EventArgs e)
        {

        }
    }
}

//using RestaurantAutomation.Business.Services;
//using RestaurantAutomation.DataAccess.Context;
//using RestaurantAutomation.DataAccess.Repositories;
//using System.Globalization;
//using System.Windows.Forms.DataVisualization.Charting;

//namespace RestaurantAutomation.UI.Forms
//{
//    public partial class ReportForm : Form
//    {
//        private readonly AppDbContext _context;
//        private readonly OrderService _orderService;
//        private readonly OrderRepository _orderRepository;
//        private readonly PaymentService _paymentService;
//        private readonly PaymentRepository _paymentRepository;
//        private readonly MenuItemService _menuItemService;
//        private readonly MenuItemRepository _menuItemRepository;

//        private TabControl tabControl;
//        private DataGridView dgvSales;
//        private Chart salesChart;
//        private Chart productChart;
//        private DateTimePicker dtpStart;
//        private DateTimePicker dtpEnd;

//        public ReportForm()
//        {
//            InitializeComponent();
//            _context = new AppDbContext();
//            _orderRepository = new OrderRepository(_context);
//            _paymentRepository = new PaymentRepository(_context);
//            _menuItemRepository = new MenuItemRepository(_context);

//            _orderService = new OrderService(_orderRepository);
//            _paymentService = new PaymentService(_paymentRepository);
//            _menuItemService = new MenuItemService(_menuItemRepository);

//            InitializeComponents();
//            LoadData();
//        }

//        private void btnMainMenu_Click(object sender, EventArgs e)
//        {
//            Program.MainFormInstance.Show();
//            this.Hide();
//        }

//        private void InitializeComponents()
//        {
//            this.Size = new Size(1200, 800);
//            this.Text = "Business Reports";

//            // Create date range and filter panel
//            var filterPanel = new Panel
//            {
//                Dock = DockStyle.Top,
//                Height = 50
//            };

//            var lblStart = new Label { Text = "Start Date:", Location = new Point(10, 15) };
//            dtpStart = new DateTimePicker
//            {
//                Location = new Point(110, 12),
//                Value = DateTime.Now.AddMonths(-1)
//            };

//            var lblEnd = new Label { Text = "End Date:", Location = new Point(300, 15) };
//            dtpEnd = new DateTimePicker
//            {
//                Location = new Point(400, 12),
//                Value = DateTime.Now
//            };

//            var cmbPeriod = new ComboBox
//            {
//                Location = new Point(600, 12),
//                Width = 120,
//                DropDownStyle = ComboBoxStyle.DropDownList
//            };
//            cmbPeriod.Items.AddRange(new string[] { "Daily", "Weekly", "Monthly", "Yearly" });
//            cmbPeriod.SelectedIndex = 0;

//            var btnRefresh = new Button
//            {
//                Text = "Refresh Reports",
//                Location = new Point(740, 10),
//                Size = new Size(150, 30)
//            };
//            btnRefresh.Click += (s, e) => LoadData();

//            filterPanel.Controls.AddRange(new Control[] { lblStart, dtpStart, lblEnd, dtpEnd, cmbPeriod, btnRefresh });

//            // Create tab control
//            tabControl = new TabControl { Dock = DockStyle.Fill };

//            // Sales Summary Tab
//            var tabSales = new TabPage("Sales Summary");
//            dgvSales = new DataGridView
//            {
//                Dock = DockStyle.Fill,
//                AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill,
//                ReadOnly = true
//            };
//            tabSales.Controls.Add(dgvSales);

//            // Sales Trends Tab
//            var tabSalesTrends = new TabPage("Sales Trends");
//            var salesTrendsLayout = new TableLayoutPanel
//            {
//                Dock = DockStyle.Fill,
//                RowCount = 2,
//                ColumnCount = 2
//            };

//            salesChart = new Chart { Dock = DockStyle.Fill };
//            salesChart.ChartAreas.Add(new ChartArea());
//            salesChart.Titles.Add(new Title("Daily Sales Trend"));

//            var monthlySalesChart = new Chart { Dock = DockStyle.Fill };
//            monthlySalesChart.ChartAreas.Add(new ChartArea());
//            monthlySalesChart.Titles.Add(new Title("Monthly Sales Comparison"));

//            var weeklySalesChart = new Chart { Dock = DockStyle.Fill };
//            weeklySalesChart.ChartAreas.Add(new ChartArea());
//            weeklySalesChart.Titles.Add(new Title("Weekly Sales Analysis"));

//            var yearlyComparisonChart = new Chart { Dock = DockStyle.Fill };
//            yearlyComparisonChart.ChartAreas.Add(new ChartArea());
//            yearlyComparisonChart.Titles.Add(new Title("Year-over-Year Comparison"));

//            salesTrendsLayout.Controls.AddRange(new Control[] {
//        salesChart, monthlySalesChart,
//        weeklySalesChart, yearlyComparisonChart
//    });
//            tabSalesTrends.Controls.Add(salesTrendsLayout);

//            // Product Analysis Tab
//            var tabProducts = new TabPage("Product Analysis");
//            var productLayout = new TableLayoutPanel
//            {
//                Dock = DockStyle.Fill,
//                RowCount = 2,
//                ColumnCount = 2
//            };

//            productChart = new Chart { Dock = DockStyle.Fill };
//            productChart.ChartAreas.Add(new ChartArea());
//            productChart.Titles.Add(new Title("Top 5 Products"));

//            var productTrendsChart = new Chart { Dock = DockStyle.Fill };
//            productTrendsChart.ChartAreas.Add(new ChartArea());
//            productTrendsChart.Titles.Add(new Title("Product Sales Trends"));

//            var categoryChart = new Chart { Dock = DockStyle.Fill };
//            categoryChart.ChartAreas.Add(new ChartArea());
//            categoryChart.Titles.Add(new Title("Sales by Category"));

//            var timeOfDayChart = new Chart { Dock = DockStyle.Fill };
//            timeOfDayChart.ChartAreas.Add(new ChartArea());
//            timeOfDayChart.Titles.Add(new Title("Sales by Time of Day"));

//            productLayout.Controls.AddRange(new Control[] {
//        productChart, productTrendsChart,
//        categoryChart, timeOfDayChart
//    });
//            tabProducts.Controls.Add(productLayout);

//            tabControl.TabPages.AddRange(new TabPage[] { tabSales, tabSalesTrends, tabProducts });
//            this.Controls.AddRange(new Control[] { filterPanel, tabControl });
//        }

//        private void LoadData()
//        {
//            try
//            {
//                LoadSalesSummary();
//                LoadSalesTrends();
//                LoadProductAnalysis();
//            }
//            catch (Exception ex)
//            {
//                MessageBox.Show($"Error loading data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
//            }
//        }

//        private void LoadSalesTrends()
//        {
//            // Daily Sales Trend
//            LoadSalesChart();

//            // Monthly Comparison
//            var monthlySales = _paymentService.GetAll()
//                .Where(p => p.PaymentDate >= dtpStart.Value && p.PaymentDate <= dtpEnd.Value)
//                .GroupBy(p => new { Month = p.PaymentDate.Month, Year = p.PaymentDate.Year })
//                .Select(g => new {
//                    Period = $"{g.Key.Year}-{g.Key.Month}",
//                    Total = g.Sum(x => x.Amount)
//                })
//                .OrderBy(x => x.Period);

//            var monthlyChart = tabControl.TabPages[1].Controls[0].Controls[1] as Chart;
//            monthlyChart.Series.Clear();
//            var monthlySeries = new System.Windows.Forms.DataVisualization.Charting.Series("Monthly Sales") { ChartType = SeriesChartType.Column };
//            foreach (var sale in monthlySales)
//            {
//                monthlySeries.Points.AddXY(sale.Period, sale.Total);
//            }
//            monthlyChart.Series.Add(monthlySeries);

//            // Weekly Analysis
//            var weeklySales = _paymentService.GetAll()
//                .Where(p => p.PaymentDate >= dtpStart.Value && p.PaymentDate <= dtpEnd.Value)
//                .GroupBy(p => ISOWeek.GetWeekOfYear(p.PaymentDate))
//                .Select(g => new {
//                    Week = g.Key,
//                    Total = g.Sum(x => x.Amount)
//                })
//                .OrderBy(x => x.Week);

//            var weeklyChart = tabControl.TabPages[1].Controls[0].Controls[2] as Chart;
//            weeklyChart.Series.Clear();
//            var weeklySeries = new System.Windows.Forms.DataVisualization.Charting.Series("Weekly Sales") { ChartType = SeriesChartType.Line };
//            foreach (var sale in weeklySales)
//            {
//                weeklySeries.Points.AddXY($"Week {sale.Week}", sale.Total);
//            }
//            weeklyChart.Series.Add(weeklySeries);
//        }

//        private void LoadProductAnalysis()
//        {
//            // Top Products (Pie Chart)
//            LoadProductChart();

//            // Product Trends Over Time
//            var productTrendsChart = tabControl.TabPages[2].Controls[0].Controls[1] as Chart;
//            productTrendsChart.Series.Clear();
//            var trendsSeries = new System.Windows.Forms.DataVisualization.Charting.Series("Product Trends") { ChartType = SeriesChartType.Line };

//            var productTrends = from od in _context.OrderDetails
//                                join o in _context.Orders on od.OrderID equals o.ID
//                                join p in _context.Payments on o.ID equals p.OrderID
//                                join mi in _context.MenuItems on od.MenuItemID equals mi.ID
//                                where p.PaymentDate >= dtpStart.Value && p.PaymentDate <= dtpEnd.Value
//                                group od by new
//                                {
//                                    ProductName = mi.Name,
//                                    Month = p.PaymentDate.Month
//                                } into g
//                                select new
//                                {
//                                    g.Key.ProductName,
//                                    g.Key.Month,
//                                    Quantity = g.Sum(x => x.Quantity)
//                                };

//            foreach (var trend in productTrends.OrderBy(x => x.Month))
//            {
//                trendsSeries.Points.AddXY($"{trend.ProductName} ({trend.Month})", trend.Quantity);
//            }
//            productTrendsChart.Series.Add(trendsSeries);

//            // Sales by Category
//            var categoryChart = tabControl.TabPages[2].Controls[0].Controls[2] as Chart;
//            categoryChart.Series.Clear();
//            var categorySeries = new System.Windows.Forms.DataVisualization.Charting.Series("Categories") { ChartType = SeriesChartType.Doughnut };

//            var categoryData = from od in _context.OrderDetails
//                               join mi in _context.MenuItems on od.MenuItemID equals mi.ID
//                               join c in _context.Categories on mi.CategoryID equals c.ID
//                               group od by c.Name into g
//                               select new
//                               {
//                                   CategoryName = g.Key,
//                                   Total = g.Sum(x => x.Quantity)
//                               };

//            foreach (var category in categoryData)
//            {
//                categorySeries.Points.AddXY(category.CategoryName, category.Total);
//            }
//            categoryChart.Series.Add(categorySeries);
//        }

//        private void LoadSalesSummary()
//        {
//            try
//            {
//                var query = from p in _paymentService.GetAll()
//                            join o in _orderService.GetAll() on p.OrderID equals o.ID
//                            where p.PaymentDate >= dtpStart.Value && p.PaymentDate <= dtpEnd.Value
//                            group p by p.PaymentDate.Date into g
//                            select new
//                            {
//                                Date = g.Key,
//                                TotalSales = g.Sum(x => x.Amount),
//                                OrderCount = g.Count(),
//                                AverageOrder = g.Average(x => x.Amount)
//                            };

//                dgvSales.DataSource = query.ToList();

//                // Format the columns
//                if (dgvSales.Columns["Date"] != null)
//                    dgvSales.Columns["Date"].DefaultCellStyle.Format = "dd/MM/yyyy";
//                if (dgvSales.Columns["TotalSales"] != null)
//                    dgvSales.Columns["TotalSales"].DefaultCellStyle.Format = "C2";
//                if (dgvSales.Columns["AverageOrder"] != null)
//                    dgvSales.Columns["AverageOrder"].DefaultCellStyle.Format = "C2";
//            }
//            catch (Exception ex)
//            {
//                MessageBox.Show($"Error loading sales summary: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
//            }
//        }

//        private void LoadSalesChart()
//        {
//            try
//            {
//                salesChart.Series.Clear();
//                var series = new System.Windows.Forms.DataVisualization.Charting.Series("Daily Sales")
//                {
//                    ChartType = SeriesChartType.Column
//                };

//                var payments = _paymentService.GetAll()
//                    .Where(p => p.PaymentDate >= dtpStart.Value && p.PaymentDate <= dtpEnd.Value)
//                    .GroupBy(p => p.PaymentDate.Date)
//                    .Select(g => new { Date = g.Key, Total = g.Sum(p => p.Amount) })
//                    .OrderBy(x => x.Date);

//                foreach (var payment in payments)
//                {
//                    series.Points.AddXY(payment.Date, payment.Total);
//                }

//                salesChart.Series.Add(series);

//                // Customize chart appearance
//                var chartArea = salesChart.ChartAreas[0];
//                chartArea.AxisX.LabelStyle.Format = "dd/MM";
//                chartArea.AxisX.Interval = 1;
//                chartArea.AxisX.Title = "Date";
//                chartArea.AxisY.Title = "Sales Amount";
//                chartArea.AxisY.LabelStyle.Format = "C0";
//            }
//            catch (Exception ex)
//            {
//                MessageBox.Show($"Error loading sales chart: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
//            }
//        }

//        private void LoadProductChart()
//        {
//            try
//            {
//                productChart.Series.Clear();
//                var series = new System.Windows.Forms.DataVisualization.Charting.Series("Top Products")
//                {
//                    ChartType = SeriesChartType.Pie
//                };

//                var topProducts = (from od in _context.OrderDetails
//                                   join o in _context.Orders on od.OrderID equals o.ID
//                                   join p in _context.Payments on o.ID equals p.OrderID
//                                   join mi in _context.MenuItems on od.MenuItemID equals mi.ID
//                                   where p.PaymentDate >= dtpStart.Value && p.PaymentDate <= dtpEnd.Value
//                                   group od by mi.Name into g
//                                   select new
//                                   {
//                                       ProductName = g.Key,
//                                       Quantity = g.Sum(x => x.Quantity)
//                                   })
//                                 .OrderByDescending(x => x.Quantity)
//                                 .Take(5);

//                foreach (var product in topProducts)
//                {
//                    // Add the data point and store its reference
//                    var point = series.Points.Add(product.Quantity);
//                    point.AxisLabel = product.ProductName;
//                    point.IsValueShownAsLabel = true;
//                    point.Label = $"{product.ProductName}\n({product.Quantity})";
//                }

//                productChart.Series.Add(series);

//                // Customize chart appearance
//                series.IsValueShownAsLabel = true;
//                series.Label = "#PERCENT{P1}";
//                series.LegendText = "#VALX";

//                // Add and configure legend if it doesn't exist
//                if (productChart.Legends.Count == 0)
//                {
//                    productChart.Legends.Add(new Legend("Legend")
//                    {
//                        Docking = Docking.Bottom,
//                        Alignment = StringAlignment.Center
//                    });
//                }

//                // Configure chart area
//                if (productChart.ChartAreas.Count > 0)
//                {
//                    var area = productChart.ChartAreas[0];
//                    area.Area3DStyle.Enable3D = true;
//                    area.Area3DStyle.Inclination = 45;
//                }
//            }
//            catch (Exception ex)
//            {
//                MessageBox.Show($"Error loading product chart: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
//            }
//        }





//        //private void InitializeComponents()
//        //{
//        //    this.Size = new Size(1000, 600);
//        //    this.Text = "Business Reports";

//        //    // Create date range selectors
//        //    var datePanel = new Panel
//        //    {
//        //        Dock = DockStyle.Top,
//        //        Height = 50
//        //    };

//        //    var lblStart = new Label { Text = "Start Date:", Location = new Point(10, 15) };
//        //    dtpStart = new DateTimePicker
//        //    {
//        //        Location = new Point(95, 12),
//        //        Value = DateTime.Now.AddMonths(-1)
//        //    };

//        //    var lblEnd = new Label { Text = "End Date:", Location = new Point(300, 15) };
//        //    dtpEnd = new DateTimePicker
//        //    {
//        //        Location = new Point(385, 12),
//        //        Value = DateTime.Now
//        //    };

//        //    var btnRefresh = new Button
//        //    {
//        //        Text = "Refresh Reports",
//        //        Location = new Point(600, 10),
//        //        Size = new Size(135, 30)
//        //    };
//        //    btnRefresh.Click += (s, e) => LoadData();

//        //    datePanel.Controls.AddRange(new Control[] { lblStart, dtpStart, lblEnd, dtpEnd, btnRefresh });

//        //    // Create tab control
//        //    tabControl = new TabControl
//        //    {
//        //        Dock = DockStyle.Fill
//        //    };

//        //    // Sales Summary Tab
//        //    var tabSales = new TabPage("Sales Summary");
//        //    dgvSales = new DataGridView
//        //    {
//        //        Dock = DockStyle.Fill,
//        //        AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill,
//        //        ReadOnly = true
//        //    };
//        //    tabSales.Controls.Add(dgvSales);

//        //    // Sales Chart Tab
//        //    var tabSalesChart = new TabPage("Sales Chart");
//        //    salesChart = new Chart
//        //    {
//        //        Dock = DockStyle.Fill
//        //    };
//        //    salesChart.ChartAreas.Add(new ChartArea());
//        //    tabSalesChart.Controls.Add(salesChart);

//        //    // Product Analysis Tab
//        //    var tabProducts = new TabPage("Product Analysis");
//        //    productChart = new Chart
//        //    {
//        //        Dock = DockStyle.Fill
//        //    };
//        //    productChart.ChartAreas.Add(new ChartArea());
//        //    tabProducts.Controls.Add(productChart);

//        //    tabControl.TabPages.AddRange(new TabPage[] { tabSales, tabSalesChart, tabProducts });

//        //    this.Controls.AddRange(new Control[] { datePanel, tabControl });
//        //}

//        //private void LoadData()
//        //{
//        //    LoadSalesSummary();
//        //    LoadSalesChart();
//        //    LoadProductAnalysis();
//        //}

//        //private void LoadSalesSummary()
//        //{
//        //    var query = from p in _paymentService.GetAll()
//        //                join o in _orderService.GetAll() on p.OrderID equals o.ID
//        //                where p.PaymentDate >= dtpStart.Value && p.PaymentDate <= dtpEnd.Value
//        //                group p by p.PaymentDate.Date into g
//        //                select new
//        //                {
//        //                    Date = g.Key,
//        //                    TotalSales = g.Sum(x => x.Amount),
//        //                    OrderCount = g.Count(),
//        //                    AverageOrder = g.Average(x => x.Amount)
//        //                };

//        //    dgvSales.DataSource = query.ToList();
//        //}

//        //private void LoadSalesChart()
//        //{
//        //    salesChart.Series.Clear();
//        //    var series = new System.Windows.Forms.DataVisualization.Charting.Series("Daily Sales")
//        //    {
//        //        ChartType = SeriesChartType.Column
//        //    };

//        //    var payments = _paymentService.GetAll()
//        //        .Where(p => p.PaymentDate >= dtpStart.Value && p.PaymentDate <= dtpEnd.Value)
//        //        .GroupBy(p => p.PaymentDate.Date)
//        //        .Select(g => new { Date = g.Key, Total = g.Sum(p => p.Amount) });

//        //    foreach (var payment in payments)
//        //    {
//        //        series.Points.AddXY(payment.Date, payment.Total);
//        //    }

//        //    salesChart.Series.Add(series);
//        //}

//        //private void LoadProductAnalysis()
//        //{
//        //    productChart.Series.Clear();
//        //    var series = new System.Windows.Forms.DataVisualization.Charting.Series("Top Products")
//        //    {
//        //        ChartType = SeriesChartType.Pie
//        //    };

//        //    var topProducts = from od in _context.OrderDetails
//        //                      join o in _context.Orders on od.OrderID equals o.ID
//        //                      join p in _context.Payments on o.ID equals p.OrderID
//        //                      join mi in _context.MenuItems on od.MenuItemID equals mi.ID
//        //                      where p.PaymentDate >= dtpStart.Value && p.PaymentDate <= dtpEnd.Value
//        //                      group od by mi.Name into g
//        //                      select new
//        //                      {
//        //                          ProductName = g.Key,
//        //                          Quantity = g.Sum(x => x.Quantity)
//        //                      };

//        //    foreach (var product in topProducts.OrderByDescending(x => x.Quantity).Take(5))
//        //    {
//        //        series.Points.AddXY(product.ProductName, product.Quantity);
//        //    }

//        //    productChart.Series.Add(series);
//        //}

//        protected override void OnFormClosing(FormClosingEventArgs e)
//        {
//            base.OnFormClosing(e);
//            _context?.Dispose();
//        }
//    }
//}

