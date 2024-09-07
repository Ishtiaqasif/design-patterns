# Strategy Pattern

## Definition

The **Strategy Pattern** is a behavioral design pattern that allows an object to select and change its algorithm at runtime. It defines a family of algorithms, encapsulates each one, and makes them interchangeable. The Strategy Pattern enables an algorithm to vary independently from clients that use it.

### Key Components

1. **Strategy**: An interface or abstract class that declares a method for executing the algorithm. It defines a common interface for all concrete strategies.
2. **Concrete Strategies**: Implementations of the `Strategy` interface or abstract class, each providing a different implementation of the algorithm.
3. **Context**: Maintains a reference to the `Strategy` object and can use it to execute the algorithm. The `Context` can also change the `Strategy` object at runtime.

## Implementation Example

In this example, the Strategy Pattern is applied to handle different types of notification services. Each notification service uses a distinct strategy for delivering notifications.

### Components

1. **INotificationStrategy Interface**
   - Defines the method for sending notifications, allowing different strategies to be used interchangeably.

2. **Concrete Strategies**
   - **Document-Based Notification Strategy**: Implements notification delivery methods for documents, such as fax or postal mail.
   - **Push-Based Notification Strategy**: Implements notification delivery using push technology for real-time updates.
   - **Text-Based Notification Strategy**: Implements notification delivery via text messages (SMS).
   - **Voice-Based Notification Strategy**: Implements notification delivery using voice calls.
   - **Web-Based Notification Strategy**: Implements notification delivery through web technologies, like browser notifications.

3. **Notification Class**
   - Represents the details of a notification, including the recipient and the message content.

4. **NotificationService Abstract Class**
   - Provides a base for specific notification services. It holds a reference to an `INotificationStrategy` object and delegates the notification sending to this strategy.

5. **Concrete Notification Services**
   - **Email Notification Service**: Uses the `TextBasedNotificationStrategy` to send email notifications.
   - **Fax Notification Service**: Uses the `DocumentBasedNotificationStrategy` to send fax notifications.
   - **In-App Notification Service**: Uses the `PushBasedNotificationStrategy` to send in-app notifications.
   - **Postal Mail Notification Service**: Uses the `DocumentBasedNotificationStrategy` to send postal mail notifications.
   - **Push Notification Service**: Uses the `PushBasedNotificationStrategy` to send push notifications.
   - **SMS Notification Service**: Uses the `TextBasedNotificationStrategy` to send SMS notifications.
   - **Social Media Notification Service**: Uses the `WebBasedNotificationStrategy` to send notifications via social media platforms.
   - **Voice Call Notification Service**: Uses the `VoiceBasedNotificationStrategy` to send voice call notifications.

### Example Usage

The `StrategyPatternRunner` class demonstrates how to use various notification services to send messages through different channels. Each service uses its associated strategy to handle notification delivery.

```csharp
public class StrategyPatternRunner
{
    public void Run() 
    {
        // Create instances of different notification services
        NotificationService notificationService;

        // Email Notification
        notificationService = new EmailNotificationService();
        notificationService.Notify(new Notification()
        {
            Recipient = "example@example.com",
            Message = "Hello from the other side"
        });

        // SMS Notification
        notificationService = new SMSNotificationService();
        notificationService.Notify(new Notification()
        {
            Recipient = "+1234567890",
            Message = "Your OTP is 123456"
        });

        // Push Notification
        notificationService = new PushNotificationService();
        notificationService.Notify(new Notification()
        {
            Recipient = "user_device_token",
            Message = "You have a new message"
        });

        // In-App Notification
        notificationService = new InAppNotificationService();
        notificationService.Notify(new Notification()
        {
            Recipient = "user_id",
            Message = "You have a new friend request"
        });

        // Voice Call Notification
        notificationService = new VoiceCallNotificationService();
        notificationService.Notify(new Notification()
        {
            Recipient = "+1234567890",
            Message = "Your appointment is confirmed"
        });

        // Fax Notification
        notificationService = new FaxNotificationService();
        notificationService.Notify(new Notification()
        {
            Recipient = "fax_number",
            Message = "Please review the attached document"
        });

        // Postal Mail Notification
        notificationService = new PostalMailNotificationService();
        notificationService.Notify(new Notification()
        {
            Recipient = "address@example.com",
            Message = "Your package is on its way"
        });

        // Social Media Notification
        notificationService = new SocialMediaNotificationService();
        notificationService.Notify(new Notification()
        {
            Recipient = "social_media_user_id",
            Message = "You've been tagged in a photo"
        });
    }
}
```
## Summary
This documentation provides an overview of the Strategy Pattern and demonstrates its application through various notification services. By encapsulating the notification algorithms in separate strategy classes, we achieve flexibility and extensibility in handling different notification methods. This approach illustrates how strategies can be easily swapped or extended to meet evolving requirements.

Feel free to adapt and extend this example to fit your specific use cases. The Strategy Pattern offers a powerful way to manage and vary algorithmic behavior in a clean and maintainable manner.