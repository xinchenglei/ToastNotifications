using System.Windows;
using ToastNotifications.Core;
using ToastNotifications.Messages.Core;
using ToastNotifications.Messages.ExeSuccess;

namespace ToastNotifications.Messages.Error
{
    public class ExeSuccessMessage : MessageBase<ExeSuccessDisplayPart>
    {
        public ExeSuccessMessage(string message) : this(message, new MessageOptions())
        {
        }

        public ExeSuccessMessage(string message, MessageOptions options) : base(message, options)
        {
        }

        protected override ExeSuccessDisplayPart CreateDisplayPart()
        {
            return new ExeSuccessDisplayPart(this);
        }

        protected override void UpdateDisplayOptions(ExeSuccessDisplayPart displayPart, MessageOptions options)
        {
            if (options.FontSize != null)
                displayPart.Text.FontSize = options.FontSize.Value;

            displayPart.CloseButton.Visibility = options.ShowCloseButton ? Visibility.Visible : Visibility.Collapsed;
        }
    }
}