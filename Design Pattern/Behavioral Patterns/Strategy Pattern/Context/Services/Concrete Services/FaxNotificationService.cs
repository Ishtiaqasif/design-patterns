namespace Design_Pattern.Behavioral_Patterns
{
    public class FaxNotificationService : NotificationService
    {
        public FaxNotificationService() : base(new DocumentBasedNotificationStrategy())
        {
        }

        public override void Notify(Notification notification)
        {
            _notificationStrategy.SendNotification(notification);
        }
    }
}