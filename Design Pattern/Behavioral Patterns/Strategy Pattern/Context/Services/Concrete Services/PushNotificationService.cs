namespace Design_Pattern.Behavioral_Patterns
{
    public class PushNotificationService : NotificationService
    {
        public PushNotificationService() : base(new PushBasedNotificationStrategy())
        {
        }

        public override void Notify(Notification notification)
        {
            _notificationStrategy.SendNotification(notification);
        }
    }
}