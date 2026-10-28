# Book Management API

A RESTful Web API built with **ASP.NET Core** and **Entity Framework Core** to manage book records using CRUD operations and a SQL Server database.

This project is part of my journey in learning backend development with C# and ASP.NET Core.

## Features

- Create a new book
- Retrieve all books
- Retrieve a book by ID
- Update an existing book
- Delete a book
- Store and manage data using SQL Server
- Use Entity Framework Core for database operations

## Tech Stack

- **Language:** C#
- **Framework:** ASP.NET Core Web API
- **ORM:** Entity Framework Core
- **Database:** Microsoft SQL Server
- **Version Control:** Git and GitHub

## Project Structure

```text
FirstAPI/
├── Controllers/
│   ├── BooksController.cs
│   └── WeatherForecastController.cs
├── Data/
│   └── FirstAPIContext.cs
├── Migrations/
├── Model/
│   └── Books.cs
├── Properties/
├── FirstAPI.http
├── Program.cs
├── appsettings.json
├── FirstAPI.csproj
└── README.md
```

## Getting Started

### Prerequisites

Make sure you have the following installed:

- .NET SDK compatible with the project
- Microsoft SQL Server
- SQL Server Management Studio (SSMS), recommended for database management
- Git

### 1. Clone the Repository

```bash
git clone https://github.com/kaungtayzahtooktzh-ship-it/BookManagementAPI.git
```

### 2. Navigate to the Project Directory

```bash
cd BookManagementAPI
```

### 3. Configure the Database Connection

Configure the `DefaultConnection` connection string using ASP.NET Core User Secrets.

From the directory containing `FirstAPI.csproj`, run:

```bash
dotnet user-secrets set "ConnectionStrings:DefaultConnection" "Server=YOUR_SERVER_NAME;Database=FirstAPI_data;Trusted_Connection=True;TrustServerCertificate=True;"
```

Replace `YOUR_SERVER_NAME` with your own SQL Server instance name.

Make sure your SQL Server service is running before starting the API.

### 4. Apply Database Migrations

```bash
dotnet ef database update
```

If the EF Core command is unavailable, install the EF Core command-line tool and ensure the required Entity Framework Core packages are installed.

### 5. Run the API

```bash
dotnet run
```

The terminal will display the local URLs where the API is running.

## API Endpoints

| Method | Endpoint | Description |
|---|---|---|
| GET | `/api/books` | Retrieve all books |
| GET | `/api/books/{id}` | Retrieve a book by ID |
| POST | `/api/books` | Create a new book |
| PUT | `/api/books/{id}` | Update an existing book |
| DELETE | `/api/books/{id}` | Delete a book |

Use the included `FirstAPI.http` file to test the endpoints with a compatible HTTP client, such as the REST Client extension in Visual Studio Code.

## Security

- Database connection details are configured through User Secrets for local development.
- Local build output and development-specific configuration files are excluded using `.gitignore`.
- Never commit passwords, access tokens, or production connection strings to a public repository.

## What I Learned

- Building RESTful APIs with ASP.NET Core
- Implementing CRUD operations
- Working with C# models and controllers
- Connecting an API to SQL Server
- Using Entity Framework Core and database migrations
- Managing source code with Git and GitHub
- Keeping local configuration separate from source code

## Future Improvements

- Add input validation and more consistent error handling
- Implement pagination and search functionality
- Add authentication and authorization
- Write unit and integration tests
- Improve API documentation

## Author

**Kaung Tayza Htoo**

CSE Student | Aspiring Backend Developer

GitHub: [@kaungtayzahtooktzh-ship-it](https://github.com/kaungtayzahtooktzh-ship-it)

---

*Built as a hands-on project while learning C# and ASP.NET Core backend development.*
