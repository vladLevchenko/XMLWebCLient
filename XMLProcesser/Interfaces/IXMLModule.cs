using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Backend.Models;

namespace XMLProcesser.Interfaces
{
    interface IXMLModule
    {
        List<Country> GetAllCountries();
        void AddNewCountry(Country model);
    }
}
