﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ПР53_Осокин
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public List<Classes.PointInfo> pointsInfo = new List<Classes.PointInfo>();
        public enum pages
        {
            main, chart
        }
        public MainWindow()
        {
            InitializeComponent();
        }
        public void OpenPages(pages _pages)
        {
            if (_pages == pages.main) frame.Navigate(new Pages.Main(this));
            else if (_pages == pages.chart) frame.Navigate(new Pages.Chart(this, new ChartContext()));
        }
    }
}
