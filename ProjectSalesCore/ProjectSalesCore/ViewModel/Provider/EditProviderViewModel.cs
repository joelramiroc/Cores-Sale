namespace ProjectSalesCore.ViewModel.Provider
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;
    using System.Web;
    using CSales.Database.Models;
    using ProjectSalesCore.DataBase.Models;

    public class EditProviderViewModel
    {
        public long Id { get; set; }

        public IEnumerable<AddressProvider> Addresses { get; set; }

        public IEnumerable<TelephoneProvider> Telephones { get; set; }

        public bool IsActive { get; set; }

        public IEnumerable<CityDistrict> CitiesDistricts { get; set; }

        public string Contact { get; set; }

        public bool IsForeignProvider { get; set; }

        public long IdBusinessName { get; set; }

        public virtual BusinessName BusinessName { get; set; }
    }
}