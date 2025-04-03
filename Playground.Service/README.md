# Playground.Service

This is an ASP.NET Core Empty project created with .NET 9.0. It serves as the foundation for implementing structured logging with Serilog and multi-tenant support using CMI.Infrastructure.MultiTenancy.

## Project Structure

- **Program.cs**: Contains the application startup logic and HTTP pipeline configuration
- **appsettings.json**: Application configuration settings
- **appsettings.Development.json**: Development-specific configuration settings

## Available Endpoints

- **GET /**: Returns a welcome message
- **GET /info**: Returns basic information about the application
- **GET /health**: Health check endpoint to verify the application is running

## How to Run

```bash
# Navigate to the project directory
cd Playground.Service

# Build the project
dotnet build

# Run the project
dotnet run
```

## Next Steps

1. Integrate Serilog for structured logging
2. Implement multi-tenant support using CMI.Infrastructure.MultiTenancy
