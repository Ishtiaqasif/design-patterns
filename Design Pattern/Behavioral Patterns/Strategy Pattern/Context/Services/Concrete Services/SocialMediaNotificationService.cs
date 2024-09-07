namespace Design_Pattern.Behavioral_Patterns
{
    public class SocialMediaNotificationService : NotificationService
    {
        public SocialMediaNotificationService() : base(new WebBasedNotificationStrategy())
        {
        }

        public override void Notify(Notification notification)
        {
            _notificationStrategy.SendNotification(notification);
        }
    }
}