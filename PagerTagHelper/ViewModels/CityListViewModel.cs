using PagerTagHelper.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PagerTagHelper.ViewModels
{
    public class CityListViewModel
    {
        public List<City> CityList { get; set; }
        public int PageCount { get; set; }
        public int CurrentPageNo { get; set; }
        public int PageSize { get; set; }
    }
}
