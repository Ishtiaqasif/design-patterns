# Factory Method Pattern - Game Character Factory

## Definition

The **Factory Method Pattern** is a **creational design pattern** that provides an interface for creating objects in a superclass but allows subclasses to alter the type of objects that will be created. This pattern encapsulates object creation logic, enabling the dynamic instantiation of objects based on specific requirements.

## Key Components

1.  **Product Interface (IGameCharacter)**: Defines the interface for the objects that the factory method creates.
2.  **Concrete Products (Warrior, Mage, Archer)**: Implement the Product interface, defining the specific objects created by the factory.
3.  **Creator Interface (IGameCharacterFactory)**: Declares the factory method, which returns an object of type Product.
4.  **Concrete Creators (WarriorFactory, MageFactory, ArcherFactory)**: Override the factory method to return an instance of a Concrete Product.
5.  **Client (GameClient)**: Uses the Creator interface to create objects.

## Implementation Example

In this example, the Factory Method Pattern is used to create different types of game characters based on player selection.

### Components

1.  **IGameCharacter Interface**

    Defines the methods required for all game characters.

2.  **Concrete Classes**

    -   **Warrior**: Implements `IGameCharacter` with warrior-specific behaviors.
    -   **Mage**: Implements `IGameCharacter` with mage-specific behaviors.
    -   **Archer**: Implements `IGameCharacter` with archer-specific behaviors.

3.  **IGameCharacterFactory Interface**

    Defines the `CreateCharacter()` method for creating game characters.

4.  **Concrete Factory Classes**

    -   **WarriorFactory**: Implements `IGameCharacterFactory` to create `Warrior` objects.
    -   **MageFactory**: Implements `IGameCharacterFactory` to create `Mage` objects.
    -   **ArcherFactory**: Implements `IGameCharacterFactory` to create `Archer` objects.

5.  **GameClient Class**

    Uses the appropriate factory to create game characters based on user input.

6.  **FactoryMethodPatternRunner Class**

    Demonstrates the Factory Method Pattern by creating various game characters.

### Example Usage

The `FactoryMethodPatternRunner` class shows how to use different factories to create game characters.

```csharp
public static void Run()
{
    GameClient client = new GameClient();

    // Example of selecting the character type
    client.CreateCharacter("Warrior");    // Warrior attacks with sword! / Warrior defends with shield!
    client.CreateCharacter("Mage");      // Mage casts fireball! / Mage shields with magic barrier!
    client.CreateCharacter("Archer");    // Archer shoots an arrow! / Archer evades with agility!
}