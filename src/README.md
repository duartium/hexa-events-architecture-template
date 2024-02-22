# Application Architecture

## 🎸 Domain

This is the main star of the show, the heart of your application. Here is where you define the business logic and the rules that make your application unique. Think of this as the message or the story your band wants to tell. It includes:

- **Entities**: Objects with an identity that remains constant over time.
- **Value Objects**: Objects that do not have an identity and are immutable; they define characteristics.
- **Aggregates**: A collection of objects (entities and value objects) that are treated as a single unit for data operations.
- **Domain Events**: Significant things that happen within the domain.

## 🎤 Application

This is the band's manager, coordinating everything but not taking the credit. It takes care of the application logic that orchestrates how the domain is used, defining the high-level operations that can be performed. Here you'll find:

- **Use Cases or Commands**: Specifications of business operations that can be executed, based on users' needs.
- **Event Handlers**: Logic to handle events and orchestrate reactions to them.
- **DTOs (Data Transfer Objects)**: Used to transfer data between the application layer and the client or external layers, without revealing the internal domain model.

## 🎹 Infrastructure

The technical crew behind the scenes, responsible for everything that makes the show possible but is not directly visible on stage. This layer provides technical support to the Application and Domain layers, such as data persistence, network communications, and infrastructure configurations. It includes:

- **ORMs**: For mapping your entities to a database.
- **Repositories**: Concrete implementations for accessing the database.
- **External Services**: Integrations with third-party services (external APIs, messaging services, etc.).
