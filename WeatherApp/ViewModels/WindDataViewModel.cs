using System;
using System.Collections.Generic;
using System.Text;
using WeatherApp.Commands;
using WeatherApp.Models;
using WeatherApp.Services;

namespace WeatherApp.ViewModels
{
    public class WindDataViewModel
    {
        IWindDataService service;

        public DelegateCommand<string> GetWindDataCommand { get; set; }
        public WindDataModel CurrentWind { get; set; }

        public WindDataViewModel()
        {
            GetWindDataCommand = new DelegateCommand<string>(GetWindData);
        }

        private void GetWindData(string obj)
        {
            CurrentWind = service.GetData();
        }

        public void SetWindDataService(IWindDataService _service)
        {
            service = _service;
        }
    }
}
