namespace Design_Pattern.Behavioral_Patterns
{
    public class EmailNotificationService : NotificationService
    {
        public EmailNotificationService() : base(new TextBasedNotificationStrategy())
        {
        }

        public override void Notify(Notification notification)
        {
            _notificationStrategy.SendNotification(notification);
        }
    }
}