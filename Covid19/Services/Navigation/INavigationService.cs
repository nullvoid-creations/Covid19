﻿using System;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Covid19.Services
{
    public interface INavigationService
    {

        void ShowMenu();

        void Quit();

        Task Navigate(Type viewType, bool isModal = false);

        Task Close();

        View GetView(Type viewType);
    }
}
