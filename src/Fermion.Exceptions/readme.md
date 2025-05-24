# Fermion.Domain.Exceptions

Fermion.Exceptions is a library that provides a comprehensive exception handling system for .NET applications. It includes predefined exception types and interfaces for standardized error handling across your application.

## Features

- Predefined exception types for common scenarios
- Standardized exception interfaces
- HTTP status code mapping
- Validation error handling
- Business rule violation handling
- Entity not found handling
- User-friendly error messages
- Correlation ID support
- Log level specification

## Installation

```bash
   dotnet add package Fermion.Exceptions
```

## Content

### Exception Types

#### Base Exception
- `AppException`: Base exception class with common properties and behaviors
  - Error code
  - Error details
  - Timestamp
  - Correlation ID
  - Log level

#### Domain Exceptions
- `AppEntityNotFoundException`: Thrown when an entity is not found
  - Entity type
  - Entity ID
  - Search criteria
  - Custom message

- `AppBusinessException`: Thrown when business rules are violated
  - Business rule code
  - Business rule message
  - Additional context

- `AppValidationException`: Thrown when validation fails
  - Validation errors collection
  - Field-specific errors
  - Custom validation messages

- `AppAuthorizationException`: Thrown when authorization fails
  - Required permissions
  - Access denied reason
  - User context

- `AppUserFriendlyException`: Thrown for user-friendly error messages
  - User-friendly message
  - Technical details (optional)
  - Suggested actions

### Exception Interfaces

#### Core Interfaces
- `IHasErrorCode`: Interface for exceptions with error codes
- `IHasErrorDetails`: Interface for exceptions with detailed error information
- `IHasTimestamp`: Interface for exceptions with timestamp information
- `IHasCorrelationId`: Interface for exceptions with correlation ID tracking
- `IHasLogLevel`: Interface for exceptions with log level specification
- `IHasStatusCode`: Interface for exceptions with HTTP status codes
- `IHasValidationErrors`: Interface for exceptions with validation errors

## Usage

### Basic Exception Usage

```csharp
// Entity not found
throw new AppEntityNotFoundException(typeof(User), userId);

// Business rule violation
throw new AppBusinessException("USER_INACTIVE", "User account is inactive");

// Authorization error
throw new AppAuthorizationException("ADMIN_REQUIRED", "Admin access required");

// User-friendly error
throw new AppUserFriendlyException(
    "Unable to process your request at this time",
    "Please try again later or contact support"
);
```

### AppException Methods

`AppException` provides a fluent API for configuring exception properties:

```csharp
// Basic usage
throw new AppBusinessException("User account is inactive")
    .WithCode("USER:INACTIVE:1001")
    .WithDetails("Account was deactivated by admin")
    .WithLogLevel(LogLevel.Warning)
    .WithStatusCode(400)
    .WithCorrelationId("corr-123")
    .WithData("UserId", userId)
    .AppendData(new Dictionary<string, object>
    {
        { "LastLoginDate", lastLoginDate },
        { "DeactivationReason", reason }
    });
```

#### Available Methods

- `WithData(string name, object value)`: Adds a single key-value pair to exception data
- `AppendData(IDictionary<string, object> data)`: Adds multiple key-value pairs to exception data
- `WithCode(string code)`: Sets the error code
- `WithDetails(string details)`: Sets the error details
- `WithLogLevel(LogLevel logLevel)`: Sets the log level
- `WithStatusCode(int statusCode)`: Sets the HTTP status code
- `WithCorrelationId(string correlationId)`: Sets the correlation ID

## Features

- Standardized exception handling
- HTTP status code mapping
- Validation error collection
- Business rule violation handling
- Entity not found handling
- User-friendly messages
- Correlation tracking
- Log level control