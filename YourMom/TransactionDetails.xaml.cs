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
using System.Windows.Shapes;

namespace YourMom
{
    /// <summary>
    /// Interaction logic for TransactionDetails.xaml
    /// </summary>
    public partial class TransactionDetails : Window
    {

        public DetailTransaction detailTransaction = new DetailTransaction();

        public TransactionDetails()
        {

            InitializeComponent();
        
        }

        private void CloseListDetailBudget_Click(object sender, RoutedEventArgs e)
        {

            this.Close();

        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

            DataContext = detailTransaction;

        }

        private void DeleteButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void EditButton_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}