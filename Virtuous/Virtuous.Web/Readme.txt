Startup Instructions:

1) Open solution in Visual Studio (Designed in VS 2022 Community)
2) Make sure Virtuous.Web is the startup project
3) Click Tools -> Nuget Package Manager -> Package Manager Console
4) Run the following commands to setup localdb (Requires Localdb to be part of the visual studio installation)
	a) Add-Migration InitialSetup
	b) Update-Database

Frameworks Used:

1) ASP .NET 6
2) C# MVC with Razor Views
3) Javascript/Jquery
4) Twitter Bootstrap

Design Choices Notes:

1) For this example the Delete function didn't make sense, since you can't really delete a donation, hence I didn't implement it. 
2) I did not implement Update function either, as the request wasn't clear on how update would work. It seems to imply a one time donation. 
3) I failed to accomplish a successful joined get in time, I left the index page there to show that data was being added to the db. (This was not in the requirements, but I wanted to make it happen)
4) I did bare minimum styling via twitter bootstrap. Styling can take me the longest time, I inferred that it is more important to show my C# MVC skills than CSS.

Shortcuts taken for speed sake:

1) Unit of Work Pattern not fully followed:
	a) Database models would be in a separate Library (for scaling purposes)
	b) Data layer would be a separate library. (N tier Architecture)
2) Unit Tests need to be written.
3) Logging not implemented.
4) Donation.cs would be split into multiple different files (one for each individual class, to allow for more readability of code)
5) Responsive Design.
6) Validation could be improved.
	a) Improving CC validation
	b) Email validation validates "@" symbol out of the box, but not "@xyz.com"
7) Haven't handled all non nullable properties correctly 
8) Details page is incomplete.
9) Better Model Data Annotations.
10) Javascript Multiplication Precision logic is weird right now. For $5 it multiplies to 5.1449~ instead of 5.145