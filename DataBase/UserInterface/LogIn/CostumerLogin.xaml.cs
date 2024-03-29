﻿using System;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using Logic_Layer.Log_in;
using UserInterface.Main;

namespace UserInterface.LogIn
{
    /// <summary>
    /// Interaction logic for costumersLogin.xaml
    /// </summary>
    public partial class costumersLogin : Window
    {
        private LogIn_costumers log = new LogIn_costumers();
        public costumersLogin()
        {
            InitializeComponent();
        }

        private void Register_Click(object sender, RoutedEventArgs e)
        {
            costumersReg reg = new();
            reg.Show();
        }
        private async void Login_Click(object sender, RoutedEventArgs e)
        {
            if (passwordText.Password.Length < 8 || passwordText.Password.Length > 12)
            {
                MessageBox.Show("Password Must be between 8-12 characters! ");
                passwordText.Clear();
                this.Title = "Employee Log-In";
            }
            else
            {
                try
                {
                    foreach (var Tbox in WinGrid.Children.OfType<TextBox>())
                    {
                        if (Tbox.Text == string.Empty)
                        {
                            MessageBox.Show("Email and Password Cannot be empty");
                            return;
                        }
                    }
                    var costumers = await log.LogInAsync(Email_Text.Text, passwordText.Password);
                    if (costumers!=null)
                    {
                        costumersMain main = new(log.costumers, costumers);
                        main.Show();
                        this.Close();
                        
                    }
                    else
                    {
                        MessageBox.Show("Email and Password combination is incorrect,please try again", "Information Error", MessageBoxButton.OK);
                    }
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
