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
using static TrackingProgressInDevEducationUI.Defines;

namespace TrackingProgressInDevEducationUI.Pages
{
    /// <summary>
    /// Interaction logic for Home.xaml
    /// </summary>
    public partial class Home : PageFunction<String>
    {
        public Home()
        {
            InitializeComponent();
            //Welcome();
        }

        private void Welcome(string name)
        {
            WelcomeBlock.Text = $"{Welcome2}{Sep}{name}";
        }

        private void Logo_Click(object sender, RoutedEventArgs e)
        {
            // Нужно добавить обновление страницы
        }
    }
}