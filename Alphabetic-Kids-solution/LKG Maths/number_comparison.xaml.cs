using Alphabetic_Kids.Common;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Basic Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234237

namespace Alphabetic_Kids.LKG_Maths
{
    /// <summary>
    /// A basic page that provides characteristics common to most applications.
    /// </summary>
    public sealed partial class number_comparison : Page
    {

        private NavigationHelper navigationHelper;
        private ObservableDictionary defaultViewModel = new ObservableDictionary();

        /// <summary>
        /// This can be changed to a strongly typed view model.
        /// </summary>
        public ObservableDictionary DefaultViewModel
        {
            get { return this.defaultViewModel; }
        }

        /// <summary>
        /// NavigationHelper is used on each page to aid in navigation and 
        /// process lifetime management
        /// </summary>
        public NavigationHelper NavigationHelper
        {
            get { return this.navigationHelper; }
        }


        public number_comparison()
        {
            this.InitializeComponent();
            this.navigationHelper = new NavigationHelper(this);
            this.navigationHelper.LoadState += navigationHelper_LoadState;
            this.navigationHelper.SaveState += navigationHelper_SaveState;
        }

        /// <summary>
        /// Populates the page with content passed during navigation. Any saved state is also
        /// provided when recreating a page from a prior session.
        /// </summary>
        /// <param name="sender">
        /// The source of the event; typically <see cref="NavigationHelper"/>
        /// </param>
        /// <param name="e">Event data that provides both the navigation parameter passed to
        /// <see cref="Frame.Navigate(Type, Object)"/> when this page was initially requested and
        /// a dictionary of state preserved by this page during an earlier
        /// session. The state will be null the first time a page is visited.</param>
        private void navigationHelper_LoadState(object sender, LoadStateEventArgs e)
        {
        }

        /// <summary>
        /// Preserves state associated with this page in case the application is suspended or the
        /// page is discarded from the navigation cache.  Values must conform to the serialization
        /// requirements of <see cref="SuspensionManager.SessionState"/>.
        /// </summary>
        /// <param name="sender">The source of the event; typically <see cref="NavigationHelper"/></param>
        /// <param name="e">Event data that provides an empty dictionary to be populated with
        /// serializable state.</param>
        private void navigationHelper_SaveState(object sender, SaveStateEventArgs e)
        {
        }


        void clear()
        {
            num1_r.Visibility = Visibility.Collapsed;
            num1_w.Visibility = Visibility.Collapsed;
            num2_r.Visibility = Visibility.Collapsed;
            num2_w.Visibility = Visibility.Collapsed;
            num3_r.Visibility = Visibility.Collapsed;
            num3_w.Visibility = Visibility.Collapsed;
            num4_r.Visibility = Visibility.Collapsed;
            num4_w.Visibility = Visibility.Collapsed;
            num5_r.Visibility = Visibility.Collapsed;
            num5_w.Visibility = Visibility.Collapsed;
            num6_r.Visibility = Visibility.Collapsed;
            num6_w.Visibility = Visibility.Collapsed;
            num7_r.Visibility = Visibility.Collapsed;
            num7_w.Visibility = Visibility.Collapsed;
            num8_r.Visibility = Visibility.Collapsed;
            num8_w.Visibility = Visibility.Collapsed;
            num9_r.Visibility = Visibility.Collapsed;
            num9_w.Visibility = Visibility.Collapsed;
            num10_r.Visibility = Visibility.Collapsed;
            num10_w.Visibility = Visibility.Collapsed;
            num11_r.Visibility = Visibility.Collapsed;
            num11_w.Visibility = Visibility.Collapsed;
            num12_r.Visibility = Visibility.Collapsed;
            num12_w.Visibility = Visibility.Collapsed;
        } //collapse all the wrong and right img


        #region NavigationHelper registration

        /// The methods provided in this section are simply used to allow
        /// NavigationHelper to respond to the page's navigation methods.
        /// 
        /// Page specific logic should be placed in event handlers for the  
        /// <see cref="GridCS.Common.NavigationHelper.LoadState"/>
        /// and <see cref="GridCS.Common.NavigationHelper.SaveState"/>.
        /// The navigation parameter is available in the LoadState method 
        /// in addition to page state preserved during an earlier session.

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            navigationHelper.OnNavigatedTo(e);
        }

        protected override void OnNavigatedFrom(NavigationEventArgs e)
        {
            navigationHelper.OnNavigatedFrom(e);
        }

        #endregion

        private void numcom_learn_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                grid_learn.Visibility = Visibility.Visible;
                grid_try.Visibility = Visibility.Collapsed;
            }
            catch { }
        }

        private void numcom_Try_Click(object sender, RoutedEventArgs e)
        {
            grid_try.Visibility = Visibility.Visible;
            grid_learn.Visibility = Visibility.Collapsed;
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            clear();
            try
            {
                if(num1.Text == "=")
                {
                    num1_r.Visibility = Visibility.Visible;
                    num1_w.Visibility = Visibility.Collapsed;
                }
                else
                {
                    num1_w.Visibility = Visibility.Visible;
                    num1_r.Visibility = Visibility.Collapsed;
                }
            }
            catch { }
        }

        private void num2_TextChanged(object sender, TextChangedEventArgs e)
        {
            clear();
            try
            {
                if (num2.Text == "<")
                {
                    num2_r.Visibility = Visibility.Visible;
                    num2_w.Visibility = Visibility.Collapsed;
                }
                else
                {
                    num2_w.Visibility = Visibility.Visible;
                    num2_r.Visibility = Visibility.Collapsed;
                }
            }
            catch { }
        }

        private void num3_TextChanged(object sender, TextChangedEventArgs e)
        {
            clear();
            try
            {
                if (num3.Text == ">")
                {
                    num3_r.Visibility = Visibility.Visible;
                    num3_w.Visibility = Visibility.Collapsed;
                }
                else
                {
                    num3_w.Visibility = Visibility.Visible;
                    num3_r.Visibility = Visibility.Collapsed;
                }
            }
            catch { }
        }

        private void num4_TextChanged(object sender, TextChangedEventArgs e)
        {
            clear();
            try
            {
                if (num4.Text == "<")
                {
                    num4_r.Visibility = Visibility.Visible;
                    num4_w.Visibility = Visibility.Collapsed;
                }
                else
                {
                    num4_w.Visibility = Visibility.Visible;
                    num4_r.Visibility = Visibility.Collapsed;
                }
            }
            catch { }
        }

        private void num5_TextChanged(object sender, TextChangedEventArgs e)
        {
            clear();
            try
            {
                if (num5.Text == ">")
                {
                    num5_r.Visibility = Visibility.Visible;
                    num5_w.Visibility = Visibility.Collapsed;
                }
                else
                {
                    num5_w.Visibility = Visibility.Visible;
                    num5_r.Visibility = Visibility.Collapsed;
                }
            }
            catch { }
        }

        private void num6_TextChanged(object sender, TextChangedEventArgs e)
        {
            clear();
            try
            {
                if (num6.Text == ">")
                {
                    num6_r.Visibility = Visibility.Visible;
                    num6_w.Visibility = Visibility.Collapsed;
                }
                else
                {
                    num6_w.Visibility = Visibility.Visible;
                    num6_r.Visibility = Visibility.Collapsed;
                }
            }
            catch { }
        }

        private void num7_TextChanged(object sender, TextChangedEventArgs e)
        {
            clear();
            try
            {
                if (num7.Text == ">")
                {
                    num7_r.Visibility = Visibility.Visible;
                    num7_w.Visibility = Visibility.Collapsed;
                }
                else
                {
                    num7_w.Visibility = Visibility.Visible;
                    num7_r.Visibility = Visibility.Collapsed;
                }
            }
            catch { }
        }

        private void num8_TextChanged(object sender, TextChangedEventArgs e)
        {
            clear();
            try
            {
                if (num8.Text == "<")
                {
                    num8_r.Visibility = Visibility.Visible;
                    num8_w.Visibility = Visibility.Collapsed;
                }
                else
                {
                    num8_w.Visibility = Visibility.Visible;
                    num8_r.Visibility = Visibility.Collapsed;
                }
            }
            catch { }
        }

        private void num9_TextChanged(object sender, TextChangedEventArgs e)
        {
            clear();
            try
            {
                if (num9.Text == ">")
                {
                    num9_r.Visibility = Visibility.Visible;
                    num9_w.Visibility = Visibility.Collapsed;
                }
                else
                {
                    num9_w.Visibility = Visibility.Visible;
                    num9_r.Visibility = Visibility.Collapsed;
                }
            }
            catch { }
        }

        private void num10_TextChanged(object sender, TextChangedEventArgs e)
        {
            clear();
            try
            {
                if (num1.Text == "<")
                {
                    num10_r.Visibility = Visibility.Visible;
                    num10_w.Visibility = Visibility.Collapsed;
                }
                else
                {
                    num10_w.Visibility = Visibility.Visible;
                    num10_r.Visibility = Visibility.Collapsed;
                }
            }
            catch { }
        }

        private void num11_TextChanged(object sender, TextChangedEventArgs e)
        {
            clear();
            try
            {
                if (num11.Text == "=")
                {
                    num11_r.Visibility = Visibility.Visible;
                    num11_w.Visibility = Visibility.Collapsed;
                }
                else
                {
                    num11_w.Visibility = Visibility.Visible;
                    num11_r.Visibility = Visibility.Collapsed;
                }
            }
            catch { }
        }

        private void num12_TextChanged(object sender, TextChangedEventArgs e)
        {
            clear();
            try
            {
                if (num12.Text == ">")
                {
                    num12_r.Visibility = Visibility.Visible;
                    num12_w.Visibility = Visibility.Collapsed;
                }
                else
                {
                    num12_w.Visibility = Visibility.Visible;
                    num12_r.Visibility = Visibility.Collapsed;
                }
            }
            catch { }
        }
    }
}
