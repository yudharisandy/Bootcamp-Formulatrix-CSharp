# Formulatrix C# Bootcamp

The Bootcamp is being conducted at Formulatrix Indonesia, Salatiga City, Indonesia.

## Table of Contents
- [Day 1 Project](https://github.com/yudharisandy/Bootcamp-Formulatrix-C-/tree/main/Day%201)
- [Day 2 Project](https://github.com/yudharisandy/Bootcamp-Formulatrix-CSharp/tree/main/Day%202)
- [Day 3 Project](https://github.com/yudharisandy/Bootcamp-Formulatrix-CSharp/tree/main/Day%203)
- [Day 4 Project](https://github.com/yudharisandy/Bootcamp-Formulatrix-CSharp/tree/main/Day%204)
- [Day 5 Project](https://github.com/yudharisandy/Bootcamp-Formulatrix-CSharp/tree/main/Day%205)
- [Day 6 Project](https://github.com/yudharisandy/Bootcamp-Formulatrix-CSharp/tree/main/Day%206)
- [Day 7-11: AutoChess Project](https://gist.github.com/yudharisandy/7c48a17afb739bb6bedc2a24c9c580d2)
- [Day 12 Project](https://github.com/yudharisandy/Bootcamp-Formulatrix-CSharp/tree/main/Day%2012)
- [Day 13 Project](https://github.com/yudharisandy/Bootcamp-Formulatrix-CSharp/tree/main/Day%2013)
- [Day 14 Project](https://github.com/yudharisandy/Bootcamp-Formulatrix-CSharp/tree/main/Day%2014)
- [Day 15 Project](https://github.com/yudharisandy/Bootcamp-Formulatrix-CSharp/tree/main/Day%2015)
- [Day 16 Project](https://github.com/yudharisandy/Bootcamp-Formulatrix-CSharp/tree/main/Day%2016) 
- [Day 17 Project](https://github.com/yudharisandy/Bootcamp-Formulatrix-CSharp/tree/main/Day%2017)
- [Day 18 Project](https://github.com/yudharisandy/Bootcamp-Formulatrix-CSharp/tree/main/Day%2018)
- [Day 19 Project](https://github.com/yudharisandy/Bootcamp-Formulatrix-CSharp/tree/main/Day%2019)
- [Day 20-21 Project](https://github.com/yudharisandy/Bootcamp-Formulatrix-CSharp/tree/main/Day%2020)
- [Day 22 Project](https://github.com/yudharisandy/Bootcamp-Formulatrix-CSharp/tree/main/Day%2022)
- [Midterm Exercise](https://github.com/yudharisandy/Bootcamp-Formulatrix-CSharp/tree/main/MidTermExercise)
- [Ludo Game Project](https://github.com/yudharisandy/LudoGame)

### Basic Environment Setup
- Install a text editor (ex: [VScode](https://code.visualstudio.com/download))
- Install .NET (ex: [.NET 8.0](https://dotnet.microsoft.com/en-us/download))
- Install C# Plugins in VSCode
- Run the code: ```cd to/your/path``` then simply ```dotnet run```

### Day 1
- Company tour.
- Basic environment setup.
- C# introduction.

### Day 2
- Constructor, Overloading, Composition.
- Memory shared for different data type.
- 2 of 4 OOP Pillars: Inheritance, Encapsulation.
- Access Modifier.

### Day 3
- 2 of 4 OOP Pillars: Polymorphism, Abstraction.
- Upcasting, Downcasting, Overriding.
- Dynamic, Static, Extention Method, Params. 

### Day 4
- Properties.
- Interface.
- Enum.
- Generic.

### Day 5
- Ref, Out, In.
- Delegate.
- Error type, Exception try-catch, Exception Handling.

### Day 6
- Default delegate: Action, Func.
- Anonymous method (Lambda expression).
- Foobar assignment.
- Operator overloading.
- Partial: ```class Program``` method structuring.
- Collection data type: ```Dictionary```, ```ArrayList```, ```List```, ```LinkedList```, ```HashSet```, ```Stack```, ```Queue```. 

### Day 7 - 11
- Create class diagram project: Auto Chess game.
- PLatforms can be used: Mermaid, PlantUML, draw.io.
- Github gist.
- Design pattern reference: Facade.
- Create abstract/interface for every classes.
- Create object/class -> GameController -> Cardinality.

### Day 9 (Quiz)
- 30 problems: 25 multiple choices & 5 essays.
- Multiple choices: each 1 point.
- Essay: each 5 points (add code example - google docs) -> as complete as possible.
- Maximum 50 points.
- Duration: 2 hours (1PM - 3PM).

### Day 12
- Destructor
- Garbage collection
- Memory profiler tool

### Day 13
- Finally.
- Dispose.
- Conditional Compilation.
- Watch run.
- Logging (debug and trace).

### Day 14
- Multi threading.
- Task.
- ThreadExceptionHandling.

### Day 15
- [AsyncGuidance](https://github.com/davidfowl/AspNetCoreDiagnosticScenarios/blob/master/AsyncGuidance.md#prefer-asyncawait-over-directly-returning-task)
- Async await.
- Cancellation token, deadlock, lock mechanism, semaphore.

### Day 16
- File and Serialization (Path, FileStream, JSON Serialization, XML Serialization)

### Day 17
- Practice 5 Solid principles.

### Day 18
- Revise the Ludo Game Project.
- Logging (NLog and log4net).
- Log as descriptive as possible but not too long
- [Structured vs String In](https://habr.com/en/articles/591171/)
- Unit testing (NUnit, XUnit, Moq).
- Final Project Team: Rafif, Yudha, Dayat.
- Logging/Severity level: Trace = 0 | Debug = 1 | Information = 2 | Warning = 3 | Error = 4.
- Better use structured logging than string interpolation.

### Day 19
- [EntityFramework: Database framework](https://miro.com/app/board/uXjVKe03v8M=/).
- [EntityFramework.pdf](./Archive/EntityFramework.pdf)
- Database packages: 
    - ```Microsoft.EntityFrameworkCore```
    - ```Microsoft.EntityFrameworkCore.Sqlite```
    - ```Microsoft.EntityFrameworkCore.Design```

### Day 20 - 21
- Gitflow.
- Design Pattern.

### Day 22
- ASP.Net : Web development framework
    - WebAPI
    - WebMVC
        - ```dotnet new mvc``` or add package ```ASP.NET Core Web App (Model View Controller)```.
        - ```dotnet watch run```: To update changes directly when program is running.
        - Add new pages:
            - Modify ```_layout.cshtml```
            - Create new Category controller in ```./Controller/CategoryController.cs```
            - Create new file ```./Views/Category/Index.cshtml```.
            - Connect with database
                - Inside ```./Models/Category.cs```
                - Inside ```./Models/Product.cs```
                - Create ```./Data/DataContext.cs``` : Assign to database (create file.db)
                - Add new builder ```builder.Service.AddDbContext<DataContext>(options => {options.UseSqlite(builder.Configuration.GetConnectionString("DefaultConnection"))})``` in ```Program.cs```.
                - Modify ```appsettings.json``` to declare the database name and save all credentials name/data (don't be uploaded to public github, assign to```.gitignore```).
                - Add seeding data to database, in ```./Data/DataContext.cs```.
                - Build data context -> Create ```./Migrations``` -> ```dotnet ef migrations add "Initial Create"```
                - ```dotnet ef database update``` -> build database.
                - Add logic of datbase in ```CategoryController.cs``` to gather all of the data.
                - Add receiving logic in ```./Views/Category/Index.cshtml```.
            - Add button in a page (Create button):
                - Add button or other attributes in ```Views/.../Index.cshtml```
                - Add ```./Views/Category/Create.cshtml``` : A new page.
                - Create a new method in ```./Controller/CategoryController.cs``` : Action when the button is pushed.
        - TempData: modify in beckend ```./Controller/CategoryController.cs``` and in ```./Views/Category/Index.cshtmml```.
        - Icon: [getbootstrap](https://icons.getbootstrap.com/). Get the SVG HTML format, paste to the ```Index.html``` inside the ancor ```<a>here</a>```
    - Razor Dages (SPA)

### Day 23
- ASP.Net : Web development framework
    - Web API: Application Programming Interface.
        - Material: Miro
        - Common interface between two different system
        - REST API
        - Software API Tools: PostMan, PostMan-VScode, ThunderClient-VSCode, Swagger
            - Use Swagger: localhost:port/swagger
        - Package: ASP.NET Core Web API
        - Create ```./Controllers/CategoryController.cs```, add ```[Route("api/[controller])]``` -> add ```builder.Services.AddCOntroller``` in ```Program.cs```
        - [More notes](https://github.com/yudharisandy/Bootcamp-Formulatrix-CSharp/blob/main/Day%2022-23/WebAPITutorial/README.md)

### Day 24
- Debugging technique: each person explains three techniques.
- Mine (5th present): 
    - Quick thinking and look
    - Divide and Conquer
    - Change One Thing at a Time
    - [More notes](https://github.com/yudharisandy/Bootcamp-Formulatrix-CSharp/blob/main/Day%2024/README.md)

### Ludo
- [Game project repository](https://github.com/yudharisandy/LudoGame)
- [Class diagram](https://github.com/probabilitynokami/ClassDiagram)


