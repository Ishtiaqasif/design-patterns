# Singleton Pattern

## Definition
The **Singleton Pattern** ensures that a class has only one instance and provides a global point of access to that instance.

## Key Components
1. **Private Constructor** – Restricts direct instantiation from outside the class.
2. **Static Instance Variable** – Holds the single instance of the class.
3. **Public Access Method** – Provides global access to the instance.

## Implementation Example (Thread-Unsafe Singleton in C#)
```csharp
public class Singleton
{
    private static Singleton _instance;
    
    private Singleton() 
    {
        Console.WriteLine("Singleton Instance Created");
    }

    public static Singleton GetInstance()
    {
        if (_instance == null)
        {
            _instance = new Singleton();
        }
        return _instance;
    }
}
```

### **Usage**
```csharp
class Program
{
    static void Main()
    {
        Singleton instance1 = Singleton.GetInstance();
        Singleton instance2 = Singleton.GetInstance();

        Console.WriteLine(object.ReferenceEquals(instance1, instance2)); // Should print True
    }
}
```

## Summary
- The **Singleton Pattern** is useful when exactly **one** instance of a class is required throughout the application.
- The thread-unsafe implementation **does not** handle concurrent access properly.
- A **thread-safe** Singleton can be implemented using locks or `Lazy<T>`.

---
✅ *Use Singleton wisely to avoid issues like global state misuse and tight coupling.*
