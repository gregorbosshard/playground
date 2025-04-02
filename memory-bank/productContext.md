# Product Context

## Why This Project Exists

This playground project exists to demonstrate and explore the implementation of a modern ASP.NET Core service with .NET 8.0. It serves as a learning and reference platform for developers working with ASP.NET Core applications, particularly focusing on:

1. Basic ASP.NET Core setup and configuration
2. Integration of structured logging
3. Implementation of multi-tenant architecture

## Problems It Solves

- Provides a reference implementation for setting up new ASP.NET Core services
- Demonstrates proper logging configuration with Serilog
- Shows how to implement multi-tenant support in ASP.NET Core applications
- Offers a starting point for developers new to these technologies

## How It Should Work

The application should:

1. Start with a minimal ASP.NET Core setup
2. Log application events and information using Serilog
3. Support multiple tenants through the CMI.Infrastructure.MultiTenancy library by:
   - Defining an application-specific tenant class
   - Configuring tenants in the application settings
   - Integrating the multi-tenant middleware in the startup process

## User Experience Goals

As this is primarily a reference implementation, the main "users" are developers who will:

1. Be able to understand the codebase easily through clean architecture and good documentation
2. Learn how to properly integrate Serilog for structured logging
3. Understand the implementation pattern for multi-tenant support
4. Be able to use this as a template for their own ASP.NET Core services

The application should demonstrate best practices in:

- Code organization
- Configuration management
- Dependency injection
- Middleware integration
- Logging
- Multi-tenant architecture
