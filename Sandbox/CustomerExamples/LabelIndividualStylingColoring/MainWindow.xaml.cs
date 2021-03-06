﻿using System.Collections.Generic;
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

namespace LabelIndividualStylingColoring
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            xAxis.LabelProvider = new ColorLabelProvider(new ColorGenerator(Colors.GreenYellow, Colors.Aqua));
            yAxis.LabelProvider = new ColorLabelProvider(new ColorGenerator(Colors.OrangeRed, Colors.BlueViolet));
        }
    }
}
