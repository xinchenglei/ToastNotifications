using System.Windows;
using ToastNotifications.Core;
using ToastNotifications.Messages.Core;
using ToastNotifications.Messages.ExeFailed;

namespace ToastNotifications.Messages.Error
{
    public class ExeFailedMessage : MessageBase<ExeFailedDisplayPart>
    {
        public ExeFailedMessage(string message) : this(message, new MessageOptions())
        {
        }

        public ExeFailedMessage(string message, MessageOptions options) : base(message, options)
        {
        }

        protected override ExeFailedDisplayPart CreateDisplayPart()
        {
            return new ExeFailedDisplayPart(this);
        }

        protected override void UpdateDisplayOptions(ExeFailedDisplayPart displayPart, MessageOptions options)
        {

            if (options.FontSize != null)
                displayPart.Text.FontSize = options.FontSize.Value;

            displayPart.CloseButton.Visibility = options.ShowCloseButton ? Visibility.Visible : Visibility.Collapsed;
        }
    }
}