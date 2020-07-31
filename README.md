# Eau Claire's Salon Stylist and Client Manager

#### Database Basics with C# Exercise for Epicodus 07.31.2020

### By Kate Skorija

## Description

This C# MVC web application for a fictional salon. It was built to help the salon owner track the stylists at the salon, and each of their clients. 

## Specifications

**Behavior**: Program will allow the user to create a stylist.
  * Input: "April Ludgate"
  * Output: April Ludgate is now a new stylist object

**Behavior**: Program will allow the user to track the clients for each stylist added.
  * Input: "Ron Swanson", "Andy Dwyer", "Leslie Knope"
  * Output: Ron Swanson, Andy Dwyer, and Leslie Knope are added as client objects of stylist April Ludgate

**Behavior**: Program will have a homepage where users can choose to view the current list of stylists.
  * Input: *User clicks "View stylists"*
  * Output: User is taken to a page with a list of stylists

**Behavior**: Program will have a link to add a new stylist on the stylist list page. 
  * Input: *User clicks "Add a new stylist"*
  * Output: User is taken to a form to add a new stylist

**Behavior**: Program will return user to the homepage after submission of the stylist form. 
  * Input: *User submits new stylist form*
  * Output: User is taken to the homepage

**Behavior**: Program will have a detail page for each stylist that lists that stylist's clients.
  * Input: *User clicks "April Ludgate"*
  * Output: User is taken to a page with a list of April Ludgate's clients

**Behavior**: Program will have a link to add new clients to a stylist's detail page.
  * Input: *User clicks "Add new client"*
  * Output: User is taken to a page with a form to add another client for April Ludgate

**Behavior**: Program will return user to the stylist detail page after submission of the client form. 
  * Input: *User submits new clientform*
  * Output: User is taken back to stylist detail page

## Setup/Installation Requirements

1.  Navigate to the [HairSalon.Solution respository](https://github.com/kate-skorija/HairSalon.Solution) or open your terminal

2. Clone this project using the GitHub button or the command:
`$ git clone https://github.com/kate-skorija/HairSalon.Solution.git`

3. Navigate to the `HairSalon.Solution` directory in your editor of choice, or use [Visual Studio Code](https://code.visualstudio.com/)

4. Within the project, navigate to the HairSalon directory, and type `dotnet restore`, then `dotnet build`. Once the build is complete, type `dotnet run` into the terminal. Click on the provided local host link in the terminal to view the web application in your browser. 

## Known Bugs

There are no known bugs at this time.

## Support and Contact Details

If there are any issues or questions, please reach out to me through [my GitHub account](https://github.com/kate-skorija).

## Technologies Used

*  [Visual Studio Code](https://code.visualstudio.com/)
*  [Markdown](https://daringfireball.net/projects/markdown/)
*  [C#](https://docs.microsoft.com/en-us/dotnet/csharp/)
*  [.NET-Core 2.2](https://dotnet.microsoft.com/download/dotnet-core/2.2)
*  [ASP.NET Core MVC](https://docs.microsoft.com/en-us/aspnet/core/mvc/overview?view=aspnetcore-3.1)

### License

*This project uses the following license: [MIT](https://opensource.org/licenses/MIT)*

Copyright (c) 2020 **_Kate Skorija_** 