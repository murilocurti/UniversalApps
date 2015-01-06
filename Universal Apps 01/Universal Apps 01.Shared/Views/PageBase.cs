using System;
using System.Collections.Generic;
using System.Text;
using Windows.UI.Xaml.Controls;

#if WINDOWS_PHONE_APP
using Windows.Phone.UI.Input;
#endif

namespace Universal_Apps_01.Views
{
    public class PageBase : Page
    {
        public PageBase()
        {
            #if WINDOWS_PHONE_APP
            HardwareButtons.BackPressed += HardwareButtons_BackPressed;
            #endif
        }

#if WINDOWS_PHONE_APP
        private void HardwareButtons_BackPressed(object sender, BackPressedEventArgs e)
        {
            if (this.Frame.CanGoBack)
            {
                this.Frame.GoBack();
            }

            e.Handled = true;
        }
#endif
    }
}
