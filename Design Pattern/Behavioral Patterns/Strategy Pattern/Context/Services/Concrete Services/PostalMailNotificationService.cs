namespace Design_Pattern.Behavioral_Patterns
{
    public class PostalMailNotificationService : NotificationService
    {
        public PostalMailNotificationService() : base(new DocumentBasedNotificationStrategy())
        {
        }

        public override void Notify(Notification notification)
        {
            _notificationStrategy.SendNotification(notification);
        }
    }
}