namespace Design_Pattern.Behavioral_Patterns
{
    public class SMSNotificationService : NotificationService
    {
        public SMSNotificationService() : base(new TextBasedNotificationStrategy())
        {
        }

        public override void Notify(Notification notification)
        {
            _notificationStrategy.SendNotification(notification);
        }
    }
}