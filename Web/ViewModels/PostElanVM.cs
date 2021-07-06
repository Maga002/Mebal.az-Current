using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web.ViewModels
{
    public class PostElanVM
    {
        public string Name { get; set; }
        public string Description{ get; set; }
        public string Address { get; set; }
        public string WpPhone { get; set; }
        public string Email { get; set; }
        public decimal? Price{ get; set; }
        public bool IsNew { get; set; }
        public decimal? Width { get; set; }
        public decimal? Length { get; set; }
        public decimal? Depth { get; set; }
        public int? CategoryId { get; set; }
        public int? CityId{ get; set; }
        public int? StoreId { get; set; }
        public List<Category> Categories { get; set; }
        public List<City> Cities { get; set; }
        public List<Store> Stores { get; set; }
        public List<AdvertisementPicture> AdvertisementPictures { get; set; }
    }
}
