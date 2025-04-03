# Product Context

## Why This Project Exists

This playground project exists to demonstrate and explore the implementation of a modern ASP.NET Core service with .NET 9.0 (updated from originally planned .NET 8.0). It serves as a learning and reference platform for developers working with ASP.NET Core applications, particularly focusing on:

1. Basic ASP.NET Core setup and configuration
2. Health monitoring and diagnostics
3. Integration of structured logging
4. Implementation of multi-tenant architecture

## Problems It Solves

- Provides a reference implementation for setting up new ASP.NET Core services
- Demonstrates proper health check configuration for application monitoring
- Shows how to implement structured logging with Serilog (planned)
- Illustrates multi-tenant support in ASP.NET Core applications (planned)
- Offers a starting point for developers new to these technologies

## How It Should Work

The application should:

1. Start with a minimal ASP.NET Core setup
2. Provide health monitoring endpoints for application diagnostics
3. Log application events and information using Serilog (planned)
4. Support multiple tenants through the CMI.Infrastructure.MultiTenancy library (planned) by:
   - Defining an application-specific tenant class
   - Configuring tenants in the application settings
   - Integrating the multi-tenant middleware in the startup process

## User Experience Goals

As this is primarily a reference implementation, the main "users" are developers who will:

1. Be able to understand the codebase easily through clean architecture and good documentation
2. Learn how to properly implement health checks for application monitoring
3. Learn how to properly integrate Serilog for structured logging (planned)
4. Understand the implementation pattern for multi-tenant support (planned)
5. Be able to use this as a template for their own ASP.NET Core services

The application should demonstrate best practices in:

- Code organization
- Configuration management
- Dependency injection
- Middleware integration
- Health monitoring
- Logging
- Multi-tenant architecture
