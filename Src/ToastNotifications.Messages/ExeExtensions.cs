using ToastNotifications.Core;
using ToastNotifications.Messages.Core;
using ToastNotifications.Messages.Error;

namespace ToastNotifications.Messages
{
    public static class ExeExtensions
    {
        public static void ShowExeSucceed(this Notifier notifier, string message)
        {
            notifier.Notify(() => new ExeSuccessMessage(message));
        }

        public static void ShowExeSucceed(this Notifier notifier, string message, MessageOptions displayOptions)
        {
            notifier.Notify(() => new ExeSuccessMessage(message, displayOptions));
        }

        public static void ShowExeFailed(this Notifier notifier, string message)
        {
            notifier.Notify(() => new ExeFailedMessage(message));
        }

        public static void ShowExeFailed(this Notifier notifier, string message, MessageOptions displayOptions)
        {
            notifier.Notify(() => new ExeFailedMessage(message, displayOptions));
        }
    }
}
