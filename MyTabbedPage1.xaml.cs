﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FirstApp02
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MyTabbedPage1 : TabbedPage
    {
        public MyTabbedPage1()
        {
            //InitializeComponent();
            Children.Add(new MainPage());
            Children.Add(new MainPage2());
        }
    }
}