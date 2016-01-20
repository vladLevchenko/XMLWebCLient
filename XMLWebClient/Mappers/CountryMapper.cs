using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Backend.Models;
using XMLWebClient.Models;

namespace XMLWebClient.Mappers
{
    public static class CountryMapper
    {        
        public static CountryViewModel ToViewModel(Country domainModel)
        {
            return new CountryViewModel
            {
                Name = domainModel.Name,
                Capital = domainModel.Capital,
                Population = domainModel.Population
            };
        }
        
        public static Country ToDomainModel(CountryViewModel viewModel)
        {
            return new Country
            {
                Id = Guid.NewGuid(),
                Name = viewModel.Name,
                Capital = viewModel.Capital,
                Population = viewModel.Population
            };
        }
    }
}