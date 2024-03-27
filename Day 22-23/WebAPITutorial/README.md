### Day 23
- ASP.Net : Web development framework

#### Web API: Application Programming Interface.
- Material: Miro
- Common interface between two different system
- REST API
- Software API Tools: PostMan, PostMan-VScode, ThunderClient-VSCode, Swagger
    - Use Swagger: localhost:port/swagger
- Add new project: ASP.NET Core Web API
- Create ```./Controllers/CategoryController.cs```, add ```[Route("api/[controller])]``` -> add ```builder.Services.AddCOntroller``` in ```Program.cs```

- DTO: Data Transfer Object: Create a new class```./Models/DTOs/CategoryDTOs.cs```.
    - Package: AutoMapper
        - Create ```./Map/MyMapper.cs```

#### Endpoint
- CRUD:
    - Get All Category : GET localhost:port/api/category
    - Specific Category : GET localhost:port/api/category/id
    - Create Category : POST localhost:port/api/category
    - Update Category : PATCH / PUT localhost:port/api/category/id
    - Delete Category : DELETE localhost:port/api/category/id
- Category :
    - categoryName
    - description 

#### Repository Pattern
- Flexibiilty for changing/adding database type in the future.
- Add one more layer between DataContext and Controller.
- Create ```./Repositories/IRepository.cs``` and ```./Repositories/Repository.cs```.
- Create ```./Repositories/ICategoryRepository.cs``` and ```./Repositories/CategoryRepository.cs```.
- Add ```ICategoryRepository``` inside ```CategoryController.cs```.
- Dependency injection: Register the service in the ```Program.cs```.

- Add async-await