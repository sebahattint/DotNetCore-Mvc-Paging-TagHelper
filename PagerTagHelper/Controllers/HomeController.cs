using Microsoft.AspNetCore.Mvc;
using PagerTagHelper.Models;
using PagerTagHelper.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PagerTagHelper.Controllers
{
    public class HomeController : Controller
    {
        private int pageSize = 3;

        public IActionResult Index(int page)
        {
            List<City> cityList = GetCityList(); // Get dummy data.

            CityListViewModel cityListmodel = new CityListViewModel()
            {
                CityList = cityList.Skip((page - 1) * pageSize).Take(pageSize).ToList(),
                CurrentPageNo = page,
                PageCount = (int)Math.Ceiling(cityList.Count / (double)pageSize),
                PageSize = pageSize
            };

            return View(cityListmodel);
        }

        /// <summary>
        /// Dummy Data
        /// </summary>
        /// <returns></returns>
        private List<City> GetCityList()
        {
            List<City> cities = new List<City>
            {
                new City() { OrderNo = 1, CityName = "İstanbul", CountryName = "Turkey" },
                new City() { OrderNo = 2, CityName = "Ankara", CountryName = "Turkey" },
                new City() { OrderNo = 3, CityName = "Giresun", CountryName = "Turkey" },
                new City() { OrderNo = 4, CityName = "Ordu", CountryName = "Turkey" },
                new City() { OrderNo = 5, CityName = "Rize", CountryName = "Turkey" },
                new City() { OrderNo = 6, CityName = "Trabzon", CountryName = "Turkey" },
                new City() { OrderNo = 7, CityName = "Gümüşhane", CountryName = "Turkey" },
                new City() { OrderNo = 8, CityName = "Sivas", CountryName = "Turkey" },
                new City() { OrderNo = 9, CityName = "Amasya", CountryName = "Turkey" },
                new City() { OrderNo = 10, CityName = "Bolu", CountryName = "Turkey" }
            };

            return cities;
        }
    }
}
