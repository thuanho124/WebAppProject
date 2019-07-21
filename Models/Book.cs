﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LibraryManagementSys.Models
{
    // Model for Book with some properties 
    public class Book
    {
        public int BookID { get; set; } // primary key

        [Required]
        [StringLength(60)]
        [Display(Name = "Book Name")]
        public string BookName { get; set; }

        [StringLength(30)]
        public string Author { get; set; }

        [StringLength(5)]
        public string Edition { get; set; }

        [Required]
        public long ISBN { get; set; }

        [StringLength(15)]
        public string Subject { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime PublicDate { get; set; }

        [Required]
        [StringLength(10)]
        public string Format { get; set; }

        public int NumofPages { get; set; }


        // navigation property
        public ICollection<RentedBook> RentedBooks { get; set; }
    }
}