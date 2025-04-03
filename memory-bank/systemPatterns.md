# System Patterns

## System Architecture

This playground project follows a standard ASP.NET Core architecture with the following components:

1. **ASP.NET Core Empty Template** - Provides the minimal starting point for the application
2. **Health Checks** - Integrated health monitoring endpoint
3. **Serilog Integration** - Planned for structured logging throughout the application
4. **Multi-Tenant Infrastructure** - Planned implementation using CMI.Infrastructure.MultiTenancy

## Key Technical Decisions

1. **Using .NET 9.0** - Leveraging the latest features and improvements in the .NET platform (updated from originally planned .NET 8.0)
2. **Health Checks** - Added for application monitoring and diagnostics
3. **Serilog for Logging** - Chosen for its flexibility, structured logging capabilities, and wide adoption (planned)
4. **CMI.Infrastructure.MultiTenancy** - Selected as the multi-tenancy solution for its specific implementation approach (planned)

## Design Patterns in Use

1. **Middleware Pattern** - Used for the HTTP request pipeline configuration
2. **Dependency Injection** - Core pattern for service registration and consumption
3. **Options Pattern** - For configuration management
4. **Health Check Pattern** - For application monitoring and diagnostics
5. **Repository Pattern** (potentially) - For data access if implemented

## Component Relationships

```text
┌─────────────────────────────────────────────┐
│                ASP.NET Core                 │
├─────────────────────────────────────────────┤
│                                             │
│  ┌─────────────┐    ┌─────────────────────┐ │
│  │             │    │                     │ │
│  │   Serilog   │    │  Multi-Tenant       │ │
│  │   Logging   │    │  Middleware         │ │
│  │  (planned)  │    │    (planned)        │ │
│  └─────────────┘    └─────────────────────┘ │
│                                             │
│  ┌─────────────┐                            │
│  │             │                            │
│  │   Health    │                            │
│  │   Checks    │                            │
│  │             │                            │
│  └─────────────┘                            │
│                                             │
└─────────────────────────────────────────────┘
```

## Critical Implementation Paths

1. **Application Startup**

   - Program.cs configuration
   - Service registration
   - Middleware pipeline setup

2. **HTTP Pipeline**

   - Development-specific error handling
   - Routing configuration
   - Endpoint mapping

3. **Health Monitoring**

   - Health check endpoint configuration
   - Health check service registration

4. **Multi-Tenant Implementation** (planned)

   - Tenant class definition
   - Tenant configuration
   - Middleware integration
   - Tenant resolution during requests

5. **Logging Configuration** (planned)
   - Serilog setup and configuration
   - Log sink configuration
   - Log enrichment with contextual data (including tenant information)

## Architecture Principles

1. **Separation of Concerns** - Each component has a distinct responsibility
2. **Configuration over Convention** - Using explicit configuration where appropriate
3. **Middleware Composition** - Building the HTTP pipeline with focused middleware components
4. **Dependency Injection** - Loose coupling through service registration and consumption
5. **Health-First Design** - Including health monitoring from the beginning

## Implemented Endpoints

1. **Root Endpoint** (`/`)
   - Returns a welcome message
   - Serves as a basic test of application functionality

2. **Info Endpoint** (`/info`)
   - Returns application information including:
     - Application name
     - Framework version
     - Environment
     - Current UTC date/time
   - Useful for diagnostics and version verification

3. **Health Endpoint** (`/health`)
   - Provides application health status
   - Can be extended with additional health checks for dependencies
