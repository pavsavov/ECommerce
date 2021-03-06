﻿using ECommerce.Models.BaseModel;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Models
{
    public class BookAuthor : BaseDbModel
    {
        [Required]
        public Guid AuthorId { get; set; }

        public  Author Author { get; set; }

        [Required]
        public Guid BookId { get; set; }

        public  Book Book { get; set; }

        //Add additional props. for whatever data I will need.
        //...
        //...
        //...
    }
}
