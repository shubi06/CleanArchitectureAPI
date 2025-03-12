# CleanArchitectureAPI - .NET Web API

## 📌 Description
This is a **.NET Web API** project built following the **Clean Architecture** pattern, ensuring modularity, testability, and easy maintenance of the code. The project includes the implementation of the **Prototype Pattern** (Creational) for object cloning and the **Adapter Pattern** (Structural) for adapting data formats.

## 🛠 Technologies Used
- ✅ **.NET 8 Web API**
- ✅ **C# & ASP.NET Core**
- ✅ **Clean Architecture**
- ✅ **Entity Framework Core** (for database)
- ✅ **Swagger UI** (for API documentation)
- ✅ **Dependency Injection** (DI)
- ✅ **Prototype Pattern**
- ✅ **Adapter Pattern**
- ✅ **Unit Tests with xUnit & Moq**


## 🎯 Project Architecture
The **Clean Architecture** separates responsibilities into layers to enhance modularity:

✅ **1. ApplicationCore (Domain Layer)**
- Contains entities, interfaces, and business logic.
- No dependency on external technologies (e.g., databases).
- Implements the **Prototype Pattern**.

✅ **2. Infrastructure (Data Layer)**
- Implements interfaces from the **ApplicationCore**.
- Contains **Repository Pattern** for data access.
- Implements **Adapter Pattern** for data format adaptation.

✅ **3. WebAPI (Presentation Layer)**
- Contains **Controllers** to expose API endpoints.
- Implements **Dependency Injection** for dependencies.
- Configures **Swagger UI** for API documentation.

## 🔄 Implementing Patterns

### 🌀 **Prototype Pattern**
- **Purpose**: Allows cloning of objects without manually creating new instances.
- **Location**: `ApplicationCore/Entities/Product.cs`


### 🔌 **Adapter Pattern**
- **Purpose**: Adapts data to a different format, such as JSON.
- **Location**:  `Infrastructure/Adapters/JsonAdapter.cs`
