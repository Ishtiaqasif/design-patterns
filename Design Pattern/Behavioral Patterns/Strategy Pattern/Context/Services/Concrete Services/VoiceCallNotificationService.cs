namespace Design_Pattern.Behavioral_Patterns
{
    public class VoiceCallNotificationService : NotificationService
    {
        public VoiceCallNotificationService() : base(new VoiceBasedNotificationStrategy())
        {
        }

        public override void Notify(Notification notification)
        {
            _notificationStrategy.SendNotification(notification);
        }
    }
}