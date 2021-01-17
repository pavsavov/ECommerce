using ECommerce.Models.BaseModel;
using System;
using System.ComponentModel.DataAnnotations;

namespace ECommerce.Models
{
    public class BookCategory : BaseDbModel
    {
        [Required]
        public Guid BookId { get; set; }
        public Book Book { get; set; }

        [Required]
        public Guid CategoryId { get; set; }
        public Category Category { get; set; }

        //Add additional props. for whatever data I will need.
        //...
        //...
        //...
    }
}
