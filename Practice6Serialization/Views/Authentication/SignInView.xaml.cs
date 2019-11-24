﻿using System.Windows.Controls;
using KMA.ProgrammingInCSharp2019.Practice6.Serialization.Tools.Navigation;
using KMA.ProgrammingInCSharp2019.Practice6.Serialization.ViewModels.Authentication;

namespace KMA.ProgrammingInCSharp2019.Practice6.Serialization.Views.Authentication
{
    public partial class SignInView : UserControl,INavigatable
    {
        internal SignInView()
        {
            InitializeComponent();
            DataContext = new SignInViewModel();
        }
    }
}
