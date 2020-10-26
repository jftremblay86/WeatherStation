using System;
using System.Collections.Generic;
using System.Text;

namespace WeatherApp.Services
{
    public interface IDataService<T>
    {
        public List<T> GetAll();
    }
}
