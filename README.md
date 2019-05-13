# reporting-api-exercise

Visual Studio 2019 is required to run this repo.

The api-reporting-exercise required getting Json data from an existing api.  I chose to put these in flat files, create corresponding DTO's, extract the data from the flat files and then deserialize the Json to work with the data in C#.  I created an api endpoint that takes a business_id and returns (at this point) TotalSales for that id. 

Although I didn't complete the exercise, I learned a lot.  I used Visual Studio for Mac which was enough different than VisualStudio for windows it slowed me down.  I also learned that working on legacy code, which is what I normally do, has it's benefits because there are so many examples of what to do and not to do.

I also have new respect for the serialization and deserialization of Json in C#.  And sql databases.  I think if I were to try to build this endpoint again, I would definitely spend the time to build a database and deal with EntityFramework.
