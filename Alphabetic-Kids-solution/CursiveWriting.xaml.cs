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

namespace Alphabetic_Kids
{
    /// <summary>
    /// A basic page that provides characteristics common to most applications.
    /// </summary>
    public sealed partial class CursiveWriting : Page
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


        public CursiveWriting()
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

        #region pointer entered
        private void gif_a_PointerEntered(object sender, PointerRoutedEventArgs e)
        {
            gif_a.Play();
        }

        private void gif_b_PointerEntered(object sender, PointerRoutedEventArgs e)
        {
            gif_b.Play();
        }

        private void gif_c_PointerEntered(object sender, PointerRoutedEventArgs e)
        {
            gif_c.Play();
        }

        private void gif_d_PointerEntered(object sender, PointerRoutedEventArgs e)
        {
            gif_d.Play();
        }

        private void gif_e_PointerEntered(object sender, PointerRoutedEventArgs e)
        {
            gif_e.Play();
        }

        private void gif_f_PointerEntered(object sender, PointerRoutedEventArgs e)
        {
            gif_f.Play();
        }

        private void gif_g_PointerEntered(object sender, PointerRoutedEventArgs e)
        {
            gif_g.Play();
        }

        private void gif_h_PointerEntered(object sender, PointerRoutedEventArgs e)
        {
            gif_h.Play();
        }

        private void gif_i_PointerEntered(object sender, PointerRoutedEventArgs e)
        {
            gif_i.Play();
        }

        private void gif_j_PointerEntered(object sender, PointerRoutedEventArgs e)
        {
            gif_j.Play();
        }

        private void gif_k_PointerEntered(object sender, PointerRoutedEventArgs e)
        {
            gif_k.Play();
        }

        private void gif_l_PointerEntered(object sender, PointerRoutedEventArgs e)
        {
            gif_l.Play();
        }

        private void gif_m_PointerEntered(object sender, PointerRoutedEventArgs e)
        {
            gif_m.Play();
        }

        private void gif_n_PointerEntered(object sender, PointerRoutedEventArgs e)
        {
            gif_n.Play();
        }

        private void gif_o_PointerEntered(object sender, PointerRoutedEventArgs e)
        {
            gif_o.Play();
        }

        private void gif_p_PointerEntered(object sender, PointerRoutedEventArgs e)
        {
            gif_p.Play();
        }

        private void gif_q_PointerEntered(object sender, PointerRoutedEventArgs e)
        {
            gif_q.Play();
        }

        private void gif_r_PointerEntered(object sender, PointerRoutedEventArgs e)
        {
            gif_r.Play();
        }

        private void gif_s_PointerEntered(object sender, PointerRoutedEventArgs e)
        {
            gif_s.Play();
        }

        private void gif_t_PointerEntered(object sender, PointerRoutedEventArgs e)
        {
            gif_t.Play();
        }

        private void gif_u_PointerEntered(object sender, PointerRoutedEventArgs e)
        {
            gif_u.Play();
        }

        private void gif_v_PointerEntered(object sender, PointerRoutedEventArgs e)
        {
            gif_v.Play();
        }

        private void gif_w_PointerEntered(object sender, PointerRoutedEventArgs e)
        {
            gif_w.Play();
        }

        private void gif_x_PointerEntered(object sender, PointerRoutedEventArgs e)
        {
            gif_x.Play();
        }

        private void gif_y_PointerEntered(object sender, PointerRoutedEventArgs e)
        {
            gif_y.Play();
        }

        private void gif_z_PointerEntered(object sender, PointerRoutedEventArgs e)
        {
            gif_z.Play();
        }
        #endregion


        #region ponterexited events
        private void gif_a_PointerExited(object sender, PointerRoutedEventArgs e)
        {
            gif_a.Stop();
        }

        private void gif_b_PointerExited(object sender, PointerRoutedEventArgs e)
        {
            gif_b.Stop();
        }

        private void gif_c_PointerExited(object sender, PointerRoutedEventArgs e)
        {
            gif_c.Stop();
        }

        private void gif_d_PointerExited(object sender, PointerRoutedEventArgs e)
        {
            gif_d.Stop();
        }

        private void gif_e_PointerExited(object sender, PointerRoutedEventArgs e)
        {
            gif_e.Stop();
        }

        private void gif_f_PointerExited(object sender, PointerRoutedEventArgs e)
        {
            gif_f.Stop();
        }

        private void gif_g_PointerExited(object sender, PointerRoutedEventArgs e)
        {
            gif_g.Stop();
        }

        private void gif_h_PointerExited(object sender, PointerRoutedEventArgs e)
        {
            gif_h.Stop();
        }

        private void gif_i_PointerExited(object sender, PointerRoutedEventArgs e)
        {
            gif_i.Stop();
        }

        private void gif_j_PointerExited(object sender, PointerRoutedEventArgs e)
        {
            gif_j.Stop();
        }

        private void gif_k_PointerExited(object sender, PointerRoutedEventArgs e)
        {
            gif_k.Stop();
        }

        private void gif_l_PointerExited(object sender, PointerRoutedEventArgs e)
        {
            gif_l.Stop();
        }

        private void gif_m_PointerExited(object sender, PointerRoutedEventArgs e)
        {
            gif_m.Stop();
        }

        private void gif_n_PointerExited(object sender, PointerRoutedEventArgs e)
        {
            gif_n.Stop();
        }

        private void gif_o_PointerExited(object sender, PointerRoutedEventArgs e)
        {
            gif_o.Stop();
        }

        private void gif_p_PointerExited(object sender, PointerRoutedEventArgs e)
        {
            gif_p.Stop();
        }

        private void gif_q_PointerExited(object sender, PointerRoutedEventArgs e)
        {
            gif_q.Stop();
        }

        private void gif_r_PointerExited(object sender, PointerRoutedEventArgs e)
        {
            gif_r.Stop();
        }

        private void gif_s_PointerExited(object sender, PointerRoutedEventArgs e)
        {
            gif_s.Stop();
        }

        private void gif_t_PointerExited(object sender, PointerRoutedEventArgs e)
        {
            gif_t.Stop();
        }

        private void gif_u_PointerExited(object sender, PointerRoutedEventArgs e)
        {
            gif_u.Stop();
        }

        private void gif_v_PointerExited(object sender, PointerRoutedEventArgs e)
        {
            gif_v.Stop();
        }

        private void gif_w_PointerExited(object sender, PointerRoutedEventArgs e)
        {
            gif_w.Stop();
        }

        private void gif_x_PointerExited(object sender, PointerRoutedEventArgs e)
        {
            gif_x.Stop();
        }

        private void gif_y_PointerExited(object sender, PointerRoutedEventArgs e)
        {
            gif_y.Stop();
        }

        private void gif_z_PointerExited(object sender, PointerRoutedEventArgs e)
        {
            gif_z.Stop();
        }
#endregion


    }
}
