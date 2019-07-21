﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LibraryManagementSys.Models
{
    // Model for Librarian with some properties 
    public class Librarian
    {
        public int LibrarianID { get; set; } // primary key

        [Required]
        [StringLength(30)]
        public string LibrarianFirstName { get; set; }

        [Required]
        [StringLength(30)]
        public string LibrarianLastName { get; set; }

        [Required]
        [StringLength(30)]
        public string LibrarianEmail { get; set; }
    }
}