using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using XMLProcesser.Interfaces;
using System.Xml.Linq;

namespace XMLProcesser.Implementations
{
    public class DefaultXMLModule:IXMLModule
    {
        private XDocument _document;
        private string _location;

       
        public DefaultXMLModule(string filename)
        {
            //use current application directory
            
            var directory = Directory.GetCurrentDirectory();
            
            _location = directory + filename;

            //check if specified file exists, if no - create new
            if (File.Exists(_location))
                _document = XDocument.Load(_location);
            else
                _document = new XDocument(new XElement("countryList"));
        }

        public List<Backend.Models.Country> GetAllCountries()
        {
            
            var res = new List<Backend.Models.Country>();

            var xmlModels = _document.Root.Elements("country");

            foreach(var node in xmlModels)
            {
                res.Add(new Backend.Models.Country
                {
                    Id = new Guid(node.Element("id").Value),
                    Name = node.Element("name").Value,
                    Capital = node.Element("capital").Value,
                    Population = Convert.ToInt32(node.Element("population").Value)
                });
            }

            return res;
        }

        public void AddNewCountry(Backend.Models.Country model)
        {
            XElement node = new XElement("country");

            node.Add(new XElement("id", model.Id));
            node.Add(new XElement("name",model.Name));
            node.Add(new XElement("capital",model.Capital));
            node.Add(new XElement("population", model.Population));

            _document.Root.Add(node);            
        }

        public void SaveChanges()
        {
            _document.Save(_location);
        }

        public string XMLFileName { get; set; }

    }
}
