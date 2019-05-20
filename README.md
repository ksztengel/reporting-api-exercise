# reporting-api-exercise

### WHAT YOU NEED
Visual Studio 2019 is required to run this repo.

### MY APPROACH
* Deal with the data first.  I decided to use Json files because a database with C# would involve Entity Framework and could be difficult to run.
* Deal with the Json.  Deserialize and create C# DTO's so that I could start to work with the data.
* Get things wired up.  This was after all an API exercise.  I put in the simplest route and made sure something would go from the files to the browser.
* What's in these objects.  I played around to make sure I could grab what I needed out of the objects and then loop thru them.
* Time for the logic.  Started with LCP and worked thru the other too reports.
* Send it to the front.  Put the results of the logic into the ReportDTOs, serialize and send it back.
### WHAT WENT WELL
* Great exercise for me.  I have a new appreciation of what it takes to build something from scratch and of what my current application provides for me to work with.
* Had some fun and frustration and I got thru it.
### WHAT DIDN'T GO WELL
* Changing IDEs when it's an important project.  Visual Studio for Mac is NOT created equal to the enterprise version I'm used to.
* Unit Tests.  I added the setup for Unit Tests in an early commit and had an issue with an Assembly that I didn't get back to.
* Everything takes longer than you think and my api is definitely MVP.  



