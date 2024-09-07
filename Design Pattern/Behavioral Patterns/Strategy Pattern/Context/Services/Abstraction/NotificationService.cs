namespace Design_Pattern.Behavioral_Patterns
{
    public abstract class NotificationService
    {
        protected readonly INotificationStrategy _notificationStrategy;

        protected NotificationService(INotificationStrategy notificationStrategy)
        {
            _notificationStrategy = notificationStrategy;
        }

        public abstract void Notify(Notification notification);
    }
}