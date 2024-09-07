namespace Design_Pattern.Behavioral_Patterns.Strategy_Pattern
{
    public static class StrategyPatternRunner
    {
        public static void Run()
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
}