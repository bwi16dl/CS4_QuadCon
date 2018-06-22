using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.CommandWpf;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Threading;
using System.Windows;
using TestWeatherClient.TestService;

namespace TestWeatherClient.ViewModel
{
    public class MainViewModel : ViewModelBase
    {
        private TestServiceClient client = new TestServiceClient();

        #region PROPERTIES
        public string Name
        {
            get { return client.GetName("Test Weather Source 01"); }
            set { client.SetName("Test Weather Source 01", value); RaisePropertyChanged(); }
        }

        private TestData oneDay;
        public TestData OneDay
        {
            get { return oneDay; }
            set { oneDay = value; RaisePropertyChanged(); }
        }

        private List<TestData> threeDays;
        public List<TestData> ThreeDay
        {
           get { return threeDays; }
           set { threeDays = value; RaisePropertyChanged(); }
        }
        #endregion

        #region COMMANDS
        private RelayCommand click;
        public RelayCommand Trigger
        {
            get { return click; }
            set { click = value; }
        }

        private RelayCommand setServerObject;
        public RelayCommand SetServerObject
        {
            get { return setServerObject; }
            set { setServerObject = value; }
        }

        private RelayCommand getServerObject;
        public RelayCommand GetServerObject
        {
            get { return getServerObject; }
            set { getServerObject = value; }
        }
        #endregion

        public MainViewModel()
        {
            Trigger = new RelayCommand(
                () => { client.Trigger("Test Weather Source 01", "GUI button was pressed"); },
                () => { return true; });

            SetServerObject = new RelayCommand(
                () => { client.SetOneDay("Test Weather Source 01", oneDay); client.SetThreeDays("Test Weather Source 01", threeDays); },
                () => { return true; });

            GetServerObject = new RelayCommand(
                () => { OneDay = client.GetOneDay("Test Weather Source 01"); ThreeDay = client.GetThreeDays("Test Weather Source 01"); },
                () => { return true; });
        }
    }
}