﻿using System.Windows;
using System.Windows.Controls;
using System.Collections.Generic;
using System.Windows.Documents;
using TrackingProgressInDevEducationBLL.BLLModels.Bases;
using TrackingProgressInDevEducationDAL;
using TrackingProgressInDevEducationDAL.Models.Bases;
using TrackingProgressInDevEducationDAL.Models.Results;

namespace TrackingProgressInDevEducationUI.Pages.TestsPages
{
    /// <summary>
    /// Логика взаимодействия для QueriesTests.xaml
    /// </summary>
    public partial class QueriesTests : Page
    {
        private MainForm _mainForm;
        public City tCity;
        public QueriesTests(MainForm mainForm)
        {
            InitializeComponent();
            _mainForm = mainForm;
            tCity = new City("Вологдар");
        }

        private void SendQueries_Click(object sender, RoutedEventArgs e)
        {
            IEnumerable<Student> students;
            if (GetStudentsRadioButton.IsChecked == true)
            {
                FacadeManager f = new FacadeManager();
                var citys = f.Cities.GetAllCities();
                //students = f.Students.GetAllStudents();
                foreach (var student in citys)
                {
                    RequestViewTextBox.Text += $"{student.Name}\n";
                }
            }

            if (GetStudentsByIdRadioButton.IsChecked == true)
            {
                //Student sss = FacadeStudent.GetByIdStudent(1);
                //RequestViewTextBox.Text += $"{sss.Name} {sss.Surname} {sss.Rate}\n";
                //
                //BCity tBCity = new BCity(tCity);

                FacadeManager f = new FacadeManager();
                //AResult aResult = f.Cities.SetNewCity("Пирва");
                //RequestViewTextBox.Text += $"Вы добавили город по id {aResult.Id}";

                //Comment city = f.Comments.SetNewComment("Привет", 1, 1, 1, 1);
                //RequestViewTextBox.Text += $"{city.Name}";

                List<BCity> BCities = new BCity().GetCities(new List<City>(f.Cities.GetAllCities()));
                foreach (var bcity in BCities)
                {
                    RequestViewTextBox.Text += $"Вы добавили город в лист BLL моделей {bcity.Name}";
                }

                BCity tmpCity = new BCity().GetCity(tCity);
                RequestViewTextBox.Text += $"Вы добавили город в лист BLL моделей {tmpCity.Name}";
            }
        }
    }
}
