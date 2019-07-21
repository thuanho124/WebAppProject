# WebAppProject - Online Library Management System

## Overview:
The Online Library Management System is used to manage all textbooks at the library and all textbooks rented by student. It will have CRUD methods, and be able to give a list of rented books, and overdue textbooks. Also, it can check the the textbook reserved by student to pick up. Maybe, if a textbook is available in pdf format, it will give students a link to download it.
Students may have their own textbook rental dashboard that helps them keep track of textbook's return date. Also, they may reserve a textbook online and come to pick it up at the library, and a controller will tell make a text book as reserved status in the database.

## How it works?
As a librarian:
  * Be able to create, update, read, and delete textbooks
  * Be able to check a list of rented textbooks, a list of overdue textbooks, and a list of reserved textbooks
  * Send an email to a student to remind them to return the textbook
  * thinking more ....

As a student:
  * Be able to see what they are renting and the return date.
  * Get a notification if they have a overdue textbook
  * Reserve a textbook online. Within 1 day, if they don't pick up, the reservation will be cancelled.
  * Search for textbooks and maybe get a link to download it if it is a free pdf file.
  * Extend the textbook rental if there are more than 3 same textbooks available.
  
## Database Context:
Student Table - DbSet<> Student
  * StudentID - int
  * StudentFirstName - strintg
  * StudentLastName - string
  * StudentEmail - string
  
Librarian Table - DbSet<> Librarian
  * LibrarianID - int
  * LibrarianFirstName - string
  * LibrarianLastName - string
  * LibrarianEmail - string
  * LibrarianPassword - string (for log in and security purpose)
  
Librarian Book - DbSet<> Book
  * BookID - string
  * BookName - string
  * Author - string
  * Edition - string
  * ISBN - long
  * Subject - string
  * PublicDate - DateTime
  * Format - String
  * NumOfpages - int
  
 Librarian RentedBook - DbSet<> RentedBook
  * Student ID - int
  * BookID - int
  * IssueDate - DateTime
  * ReturnDate - DateTime
  
  There may be more tables as the progress continues
  
  ## WebApp1b - Updated (07/20/2019):
  What's done:
  * Almost completed the front-end
    * Please note: the search bar is displayed visually, but still not functional
  * Implemented CRUD methods for book database as librarian
  * Student now can check what they are renting
  * Created tables for database
  
  For Student page, the current student on the dashboard is #ID 2, which is John. To get the student ID with ID# 1 show up, you may need to change asp-route-id=1 on the navigation bar at _Layout.cshtml (Views/Shared/_Layout.cshtml).
Therefore, the For Students need a login page for each student to manage their own textbook rental.
  
