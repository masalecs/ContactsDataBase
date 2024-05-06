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

namespace DataBase
{
    /// <summary>
    /// Логика взаимодействия для MainPage.xaml
    /// </summary>
    public partial class MainPage : Page
    {
        public MainPage()
        {
            InitializeComponent();
            ContactGrid.ItemsSource = ContactEntities.GetContext().Telephone.ToList();
        }

        private void Button_Edit_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Add_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new AddEditPage());
        }

        private void Button_Delete_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
