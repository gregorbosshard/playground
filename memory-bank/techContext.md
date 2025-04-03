# Technical Context

## Technologies Used

### Core Framework

- **.NET 9.0** - Latest version of the .NET platform (updated from originally planned .NET 8.0)
- **ASP.NET Core** - Web framework for building web applications

### Logging

- **Serilog** - Structured logging library for .NET applications (planned)
  - Provides flexible logging with support for various sinks
  - Enables structured log data for better querying and analysis

### Multi-Tenancy

- **CMI.Infrastructure.MultiTenancy** - Library for implementing multi-tenant support (planned)
  - GitHub: <https://github.com/CMInformatik/cmi-infrastructure-multi-tenancy>

## Development Setup

### Required Tools

- **.NET 9.0 SDK** - For building and running the application
- **IDE** - Visual Studio 2022, Visual Studio Code, or JetBrains Rider
- **Git** - For source control

### Development Environment

- Local development environment with .NET 9.0 SDK installed
- Access to NuGet packages for dependency management
- GitHub repository for version control and issue tracking

## Technical Constraints

- Started with the "ASP.NET Core Empty" template as the starting point
- Will implement logging using Serilog
- Will follow the CMI.Infrastructure.MultiTenancy implementation guidelines:
  1. Define application-specific tenant class
  2. Configure tenants in application settings
  3. Integrate multi-tenant middleware in startup

## Dependencies

### Framework Dependencies

- Microsoft.AspNetCore.App

### Current Dependencies

- Microsoft.AspNetCore.App (included by default)
- Microsoft.AspNetCore.Diagnostics.HealthChecks (via Microsoft.AspNetCore.App)

### Planned Dependencies

- Serilog
- Serilog.AspNetCore
- Serilog.Settings.Configuration
- Serilog.Sinks.Console (and potentially other sinks as needed)
- CMI.Infrastructure.MultiTenancy

## Tool Usage Patterns

### Dependency Management

- NuGet for package management
- Commands used to add dependencies:

  ```zsh
  dotnet add package Serilog
  dotnet add package Serilog.AspNetCore
  dotnet add package Serilog.Settings.Configuration
  dotnet add package Serilog.Sinks.Console
  dotnet add package CMI.Infrastructure.MultiTenancy
  ```

### Configuration Management

- appsettings.json for application configuration
- Tenant configuration in dedicated section of appsettings.json (planned)
- Serilog configuration in dedicated section of appsettings.json (planned)

### Build and Run

- `dotnet build` - Build the application
- `dotnet run` - Run the application
- `dotnet watch run` - Run with hot reload during development

### Git Workflow

- Feature branches following pattern: `<type>/<issue-number>-<short-description>`
- Commit messages following format: `<type>(<scope>): <subject>`
- Pull requests for code review and merging into main branch
