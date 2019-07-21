﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LibraryManagementSys.Models
{
    // Model for Books have been rented by students with some properties
    public class RentedBook
    {
        public int RentedBookID { get; set; } // primary key
        public int StudentID { get; set; } // foreign key
        public int BookID { get; set; } // foreign key

        [Required]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime RentDate { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime ReturnDate { get; set; }

        // navigation properties
        public Student Student { get; set; }
        public Book Book { get; set; }

    }
}
