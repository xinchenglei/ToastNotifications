using System.Windows;
using System.Windows.Controls;
using ToastNotifications.Core;
using ToastNotifications.Messages.Error;

namespace ToastNotifications.Messages.ExeSuccess
{
    /// <summary>
    /// Interaction logic for ExeSuccessDisplayPart.xaml
    /// </summary>
    public partial class ExeSuccessDisplayPart : NotificationDisplayPart
    {



        public ExeSuccessDisplayPart(ExeSuccessMessage exeSuccess)
        {
            InitializeComponent();
            Bind(exeSuccess);
        }

        private void OnClose(object sender, RoutedEventArgs e)
        {
            Notification.Close();
        }

        public ExeSuccessDisplayPart()
        {
            InitializeComponent();
        }
    }
}
