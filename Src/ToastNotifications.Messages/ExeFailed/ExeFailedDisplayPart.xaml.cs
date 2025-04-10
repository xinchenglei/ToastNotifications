using System.Windows;
using ToastNotifications.Core;
using ToastNotifications.Messages.Error;

namespace ToastNotifications.Messages.ExeFailed
{
    /// <summary>
    /// Interaction logic for ExeFailedDisplayPart.xaml
    /// </summary>
    public partial class ExeFailedDisplayPart : NotificationDisplayPart
    {

        public ExeFailedDisplayPart(ExeFailedMessage exeFailed)
        {
            InitializeComponent();
            Bind(exeFailed);
        }

        private void OnClose(object sender, RoutedEventArgs e)
        {
            Notification.Close();
        }

        public ExeFailedDisplayPart()
        {
            InitializeComponent();
        }
    }
}
