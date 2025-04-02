# System Patterns

## System Architecture

This playground project follows a standard ASP.NET Core architecture with the following components:

1. **ASP.NET Core Empty Template** - Provides the minimal starting point for the application
2. **Serilog Integration** - Handles structured logging throughout the application
3. **Multi-Tenant Infrastructure** - Implements tenant isolation using CMI.Infrastructure.MultiTenancy

## Key Technical Decisions

1. **Using .NET 8.0** - Leveraging the latest features and improvements in the .NET platform
2. **Serilog for Logging** - Chosen for its flexibility, structured logging capabilities, and wide adoption
3. **CMI.Infrastructure.MultiTenancy** - Selected as the multi-tenancy solution for its specific implementation approach

## Design Patterns in Use

1. **Middleware Pattern** - Used for the multi-tenant implementation in the HTTP request pipeline
2. **Dependency Injection** - Core pattern for service registration and consumption
3. **Options Pattern** - For configuration management
4. **Repository Pattern** (potentially) - For data access if implemented

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
│  │             │    │                     │ │
│  └─────────────┘    └─────────────────────┘ │
│                                             │
└─────────────────────────────────────────────┘
```

## Critical Implementation Paths

1. **Application Startup**

   - Program.cs configuration
   - Service registration
   - Middleware pipeline setup

2. **Multi-Tenant Implementation**

   - Tenant class definition
   - Tenant configuration
   - Middleware integration
   - Tenant resolution during requests

3. **Logging Configuration**
   - Serilog setup and configuration
   - Log sink configuration
   - Log enrichment with contextual data (including tenant information)

## Architecture Principles

1. **Separation of Concerns** - Each component has a distinct responsibility
2. **Configuration over Convention** - Using explicit configuration where appropriate
3. **Middleware Composition** - Building the HTTP pipeline with focused middleware components
4. **Dependency Injection** - Loose coupling through service registration and consumption
