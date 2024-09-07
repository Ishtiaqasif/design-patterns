namespace Design_Pattern.Behavioral_Patterns
{
    public class InAppNotificationService : NotificationService
    {
        public InAppNotificationService() : base(new PushBasedNotificationStrategy())
        {
        }

        public override void Notify(Notification notification)
        {
            _notificationStrategy.SendNotification(notification);
        }
    }
}