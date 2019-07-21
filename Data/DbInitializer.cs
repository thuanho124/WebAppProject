using LibraryManagementSys.Models;
using System;
using System.Linq;


namespace LibraryManagementSys.Data
{
    public static class DbInitializer
    {
        public static void Initialize(DatabaseContext context)
        {
            context.Database.EnsureCreated();

            // Look for any students.
            if (context.Books.Any())
            {
                return;   // DB has been seeded
            }

            var books = new Book[]
            {
            new Book{BookName="The Hiding Place", Author="Corrie ten Boom", Edition="35th", ISBN= 9780800794057,
                Subject = "Literature", PublicDate = DateTime.Parse("2016-01-01"), Format = "Paperback", NumofPages=144},

            new Book{BookName="The Common Core Mathematics Companion: The Standards Decoded", Author=" Linda M. Gojak", Edition="1st", ISBN= 9781483381602,
                Subject = "Math", PublicDate = DateTime.Parse("2015-07-05"), Format = "Paperback", NumofPages=320}
            };
            foreach (Book b in books)
            {
                context.Books.Add(b);
            }
            context.SaveChanges();



            var students = new Student[]
            {
            new Student{StudentFirstName = "Thuan", StudentLastName = "Ho", StudentEmail = "hot4@uw.edu"},
            new Student{StudentFirstName = "John", StudentLastName = "Henry", StudentEmail = "john1@uw.edu"}
            };
            foreach (Student c in students)
            {
                context.Students.Add(c);
            }
            context.SaveChanges();



            var rentedBooks = new RentedBook[]
            {
                new RentedBook{BookID = 2, StudentID = 2, RentDate = DateTime.Now, ReturnDate = DateTime.Parse("2019-10-02")},
                new RentedBook{BookID = 1, StudentID = 1, RentDate = DateTime.Now, ReturnDate = DateTime.Parse("2019-09-02")}
            };
            foreach (RentedBook r in rentedBooks)
            {
                context.RentedBooks.Add(r);
            }
            context.SaveChanges();



        }
    }
}