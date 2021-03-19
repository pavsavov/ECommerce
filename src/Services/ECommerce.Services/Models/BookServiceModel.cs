
using ECommerce.Models.BaseModel;
using ECommerce.Services.AutoMapper;
using ECommerce.Models;
using System;
using System.Collections.Generic;
using AutoMapper;

namespace ECommerce.Services.Models
{
    public class BookServiceModel : ServiceModel, IMapTo<Book>,IMapFrom<Book>//,IHaveCustomMappings
    {
        public string Title { get; set; }

        public string ISBN { get; set; }

        public decimal PriceTag { get; set; }

        public string Currency { get; set; }

        public string EAN { get; set; }

        public int NumberOfPages { get; set; }

        public string YearPublished { get; set; }

        public string PublisherName { get; set; }

        public IEnumerable<string> AuthorsNames { get; set; }

        public IEnumerable<string> Categories { get; set; }

        //public void CreateMappings(IProfileExpression configuration)
        //{
        //    configuration.CreateMap<Book, BookServiceModel>()
        //        .ForMember(,csm => new Price { PriceTag = csm.PriceTag,Currency = csm.Currency });
        //}



        //Custom Mappings here
    }
}
