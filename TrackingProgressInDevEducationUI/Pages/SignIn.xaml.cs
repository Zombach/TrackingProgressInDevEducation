﻿using System.Windows;
using System.Windows.Controls;
using TrackingProgressInDevEducationDAL;

namespace TrackingProgressInDevEducationUI.Pages
{
    /// <summary>
    /// Логика взаимодействия для SignIn.xaml
    /// </summary>
    // ReSharper disable once RedundantExtendsListEntry
    public partial class SignIn : Page
    {
        private readonly MainForm _mainForm;
        private readonly FacadeManager _manager = new();
        public SignIn(MainForm mainForm)
        {
            InitializeComponent();
            _mainForm = mainForm;
        }

        private void SignIn_Click(object sender, RoutedEventArgs e)
        {
            _manager.Lectors.GetLectorById(1);

            MainMenu menu = new MainMenu(_mainForm);
            _mainForm.Content = menu;
        }

        private void Registration_Click(object sender, RoutedEventArgs e)
        {
            Registration registration = new Registration(_mainForm);
            _mainForm.Content = registration;
        }
    }
}
