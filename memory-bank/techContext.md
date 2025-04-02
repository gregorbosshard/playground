# Technical Context

## Technologies Used

### Core Framework

- **.NET 8.0** - Latest version of the .NET platform
- **ASP.NET Core** - Web framework for building web applications

### Logging

- **Serilog** - Structured logging library for .NET applications
  - Provides flexible logging with support for various sinks
  - Enables structured log data for better querying and analysis

### Multi-Tenancy

- **CMI.Infrastructure.MultiTenancy** - Library for implementing multi-tenant support
  - GitHub: <https://github.com/CMInformatik/cmi-infrastructure-multi-tenancy>

## Development Setup

### Required Tools

- **.NET 8.0 SDK** - For building and running the application
- **IDE** - Visual Studio 2022, Visual Studio Code, or JetBrains Rider
- **Git** - For source control

### Development Environment

- Local development environment with .NET 8.0 SDK installed
- Access to NuGet packages for dependency management

## Technical Constraints

- Must use the "ASP.NET Core Empty" template as the starting point
- Must implement logging using Serilog
- Must follow the CMI.Infrastructure.MultiTenancy implementation guidelines:
  1. Define application-specific tenant class
  2. Configure tenants in application settings
  3. Integrate multi-tenant middleware in startup

## Dependencies

### Framework Dependencies

- Microsoft.AspNetCore.App

### External Dependencies

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
- Tenant configuration in dedicated section of appsettings.json
- Serilog configuration in dedicated section of appsettings.json

### Build and Run

- `dotnet build` - Build the application
- `dotnet run` - Run the application
- `dotnet watch run` - Run with hot reload during development
