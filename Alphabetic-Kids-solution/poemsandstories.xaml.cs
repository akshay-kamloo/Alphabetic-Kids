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
    public sealed partial class poemsandstories : Page
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


        public poemsandstories()
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
            try
            {
                poemsandstories_subtitle.Text = e.NavigationParameter.ToString()+" > Poems And Stories";
            }
            catch(Exception) { }
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

        private void btn_poems_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                mediaPlayer.Source = null;
                SV_stories.Visibility = Visibility.Collapsed;
                SV_poems.Visibility = Visibility.Visible;
            }
            catch (Exception) { }
        }

        private void btn_stories_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                mediaPlayer.Source = null;
                SV_poems.Visibility = Visibility.Collapsed;
                SV_stories.Visibility = Visibility.Visible;
            }
            catch (Exception) { }
        }


        private void GridView_Tapped(object sender, TappedRoutedEventArgs e)
        {
            poem_name.Text = p1.Text;
            mediaPlayer.Source = new Uri("ms-appx:///poems/Twinkle Twinkle Little Star.mp4");
        }

        private void GridView_Tapped_1(object sender, TappedRoutedEventArgs e)
        {
            poem_name.Text = p2.Text;
            mediaPlayer.Source = new Uri("ms-appx:///poems/5 Green Bottles.mp4");
        }

        private void GridView_Tapped_2(object sender, TappedRoutedEventArgs e)
        {
            poem_name.Text = p3.Text;
            mediaPlayer.Source = new Uri("ms-appx:///poems/5 Little Speckled Frogs.mp4");
        }

        private void GridView_Tapped_3(object sender, TappedRoutedEventArgs e)
        {
            poem_name.Text = p4.Text;
            mediaPlayer.Source = new Uri("ms-appx:///poems/A Is For Apple.mp4");
        }

        private void GridView_Tapped_4(object sender, TappedRoutedEventArgs e)
        {
            poem_name.Text = p5.Text;
            mediaPlayer.Source = new Uri("ms-appx:///poems/Are You Sleeping.mp4");
        }

        private void GridView_Tapped_5(object sender, TappedRoutedEventArgs e)
        {
            poem_name.Text = p7.Text;
            mediaPlayer.Source = new Uri("ms-appx:///poems/Bingo Song.mp4");
        }

        private void GridView_Tapped_6(object sender, TappedRoutedEventArgs e)
        {
            poem_name.Text = p8.Text;
            mediaPlayer.Source = new Uri("ms-appx:///poems/Cobbler Cobbler Mend My Shoe.mp4");
        }

        private void GridView_Tapped_7(object sender, TappedRoutedEventArgs e)
        {
            poem_name.Text = p9.Text;
            mediaPlayer.Source = new Uri("ms-appx:///poems/Family Finger Songs.mp4");
        }

        private void GridView_Tapped_8(object sender, TappedRoutedEventArgs e)
        {
            poem_name.Text = p10.Text;
            mediaPlayer.Source = new Uri("ms-appx:///poems/Five Little Monkeys Jumping On The Bed.mp4");
        }

        private void GridView_Tapped_9(object sender, TappedRoutedEventArgs e)
        {
            poem_name.Text = p11.Text;
            mediaPlayer.Source = new Uri("ms-appx:///poems/Hey Diddle Diddle.mp4");
        }

        private void GridView_Tapped_10(object sender, TappedRoutedEventArgs e)
        {
            poem_name.Text = p12.Text;
            mediaPlayer.Source = new Uri("ms-appx:///poems/Hickory Dickory Dock.mp4");
        }

        private void GridView_Tapped_11(object sender, TappedRoutedEventArgs e)
        {
            poem_name.Text = p13.Text;
            mediaPlayer.Source = new Uri("ms-appx:///poems/Humpty Dumpty.mp4");
        }

        private void GridView_Tapped_12(object sender, TappedRoutedEventArgs e)
        {
            poem_name.Text = p14.Text;
            mediaPlayer.Source = new Uri("ms-appx:///poems/I Am A Little Teapot.mp4");
        }

        private void GridView_Tapped_13(object sender, TappedRoutedEventArgs e)
        {
            poem_name.Text = p15.Text;
            mediaPlayer.Source = new Uri("ms-appx:///poems/If You Are Happy.mp4");
        }

        private void GridView_Tapped_14(object sender, TappedRoutedEventArgs e)
        {
            poem_name.Text = p16.Text;
            mediaPlayer.Source = new Uri("ms-appx:///poems/Jack And Jill.mp4");
        }

        private void GridView_Tapped_15(object sender, TappedRoutedEventArgs e)
        {
            poem_name.Text = p17.Text;
            mediaPlayer.Source = new Uri("ms-appx:///poems/Johny Johny.mp4");
        }

        private void GridView_Tapped_16(object sender, TappedRoutedEventArgs e)
        {
            poem_name.Text = p18.Text;
            mediaPlayer.Source = new Uri("ms-appx:///poems/Learn Transport.mp4");
        }

        private void GridView_Tapped_17(object sender, TappedRoutedEventArgs e)
        {
            poem_name.Text = p19.Text;
            mediaPlayer.Source = new Uri("ms-appx:///poems/Learning Shapes Song.mp4");
        }

        private void GridView_Tapped_18(object sender, TappedRoutedEventArgs e)
        {
            poem_name.Text = p20.Text;
            mediaPlayer.Source = new Uri("ms-appx:///poems/Lion and Unicorn.mp4");
        }

        private void GridView_Tapped_19(object sender, TappedRoutedEventArgs e)
        {
            poem_name.Text = p21.Text;
            mediaPlayer.Source = new Uri("ms-appx:///poems/Little Bo-peep.mp4");
        }

        private void GridView_Tapped_20(object sender, TappedRoutedEventArgs e)
        {
            poem_name.Text = p22.Text;
            mediaPlayer.Source = new Uri("ms-appx:///poems/Little Miss Muffet.mp4");
        }

        private void GridView_Tapped_21(object sender, TappedRoutedEventArgs e)
        {
            poem_name.Text = p23.Text;
            mediaPlayer.Source = new Uri("ms-appx:///poems/Mary Mary Quite Contrary.mp4");
        }

        private void GridView_Tapped_22(object sender, TappedRoutedEventArgs e)
        {
            poem_name.Text = p24.Text;
            mediaPlayer.Source = new Uri("ms-appx:///poems/Old King Cole.mp4");
        }

        private void GridView_Tapped_23(object sender, TappedRoutedEventArgs e)
        {
            poem_name.Text = p25.Text;
            mediaPlayer.Source = new Uri("ms-appx:///poems/Old MacDonald Had A Farm.mp4");
        }

        private void GridView_Tapped_24(object sender, TappedRoutedEventArgs e)
        {
            poem_name.Text = p27.Text;
            mediaPlayer.Source = new Uri("ms-appx:///poems/Phonics ABC Songs.mp4");
        }

        private void GridView_Tapped_25(object sender, TappedRoutedEventArgs e)
        {
            poem_name.Text = p28.Text;
            mediaPlayer.Source = new Uri("ms-appx:///poems/Rain Rain Go Away.mp4");
        }

        private void GridView_Tapped_26(object sender, TappedRoutedEventArgs e)
        {
            poem_name.Text = p29.Text;
            mediaPlayer.Source = new Uri("ms-appx:///poems/Ringa Ringa Roses.mp4");
        }

        private void GridView_Tapped_27(object sender, TappedRoutedEventArgs e)
        {
            poem_name.Text = p30.Text;
            mediaPlayer.Source = new Uri("ms-appx:///poems/Row Row Row Your Boat.mp4");
        }

        private void GridView_Tapped_28(object sender, TappedRoutedEventArgs e)
        {
            poem_name.Text = p31.Text;
            mediaPlayer.Source = new Uri("ms-appx:///poems/Teddy Bear Song.mp4");
        }

        private void GridView_Tapped_29(object sender, TappedRoutedEventArgs e)
        {
            poem_name.Text = p32.Text;
            mediaPlayer.Source = new Uri("ms-appx:///poems/The Farmer In The Dell.mp4");
        }

        private void GridView_Tapped_30(object sender, TappedRoutedEventArgs e)
        {
            poem_name.Text = p33.Text;
            mediaPlayer.Source = new Uri("ms-appx:///poems/There Was A Old Women.mp4");
        }

        private void GridView_Tapped_31(object sender, TappedRoutedEventArgs e)
        {
            poem_name.Text = p34.Text;
            mediaPlayer.Source = new Uri("ms-appx:///poems/Three Blind Mice.mp4");
        }

        private void GridView_Tapped_32(object sender, TappedRoutedEventArgs e)
        {
            poem_name.Text = p35.Text;
            mediaPlayer.Source = new Uri("ms-appx:///poems/Three Little Kittens.mp4");
        }

        private void GridView_Tapped_33(object sender, TappedRoutedEventArgs e)
        {
            poem_name.Text = p36.Text;
            mediaPlayer.Source = new Uri("ms-appx:///poems/Two Little Dicky Birds.mp4");
        }

        private void GridView_Tapped_34(object sender, TappedRoutedEventArgs e)
        {
            poem_name.Text = p38.Text;
            mediaPlayer.Source = new Uri("ms-appx:///poems/Vegetables Rhymes.mp4");
        }

        private void GridView_Tapped_35(object sender, TappedRoutedEventArgs e)
        {
            poem_name.Text = p39.Text;
            mediaPlayer.Source = new Uri("ms-appx:///poems/Wheels On The Bus Go Round And Round.mp4");
        }

        private void GridView_Tapped_36(object sender, TappedRoutedEventArgs e)
        {
            poem_name.Text = p40.Text;
            mediaPlayer.Source = new Uri("ms-appx:///poems/Wheels On The Bus.mp4");
        }

        private void GridView_Tapped_37(object sender, TappedRoutedEventArgs e)
        {
            poem_name.Text = p41.Text;
            mediaPlayer.Source = new Uri("ms-appx:///poems/Where Is Thumbkin.mp4");
        }

        private void GridView_Tapped_38(object sender, TappedRoutedEventArgs e) //One Two Bickel My Shoe
        {
            poem_name.Text = p26.Text;
            mediaPlayer.Source = new Uri("ms-appx:///poems/One Two Buckle My Shoe.mp4");
        }

        private void GridView_Tapped_39(object sender, TappedRoutedEventArgs e)//Baba Black Sheep
        {
            poem_name.Text = p6.Text;
            mediaPlayer.Source = new Uri("ms-appx:///poems/Baba Baba Black Sheep.mp4");
        }

        private void GridView_Tapped_40(object sender, TappedRoutedEventArgs e)//Five Little Kittens
        {
            poem_name.Text = p42.Text;
            mediaPlayer.Source = new Uri("ms-appx:///poems/Five Little Kittens.mp4");
        }



        //Stories
        private void GridView_Tapped_41(object sender, TappedRoutedEventArgs e)
        {
            poem_name.Text = p43.Text;
            mediaPlayer.Source = new Uri("ms-appx:///stories/thirsty crow.mp4");
        }

        private void GridView_Tapped_42(object sender, TappedRoutedEventArgs e)
        {
            poem_name.Text = p44.Text;
            mediaPlayer.Source = new Uri("ms-appx:///stories/crow who pritended.mp4");
        }

        private void GridView_Tapped_43(object sender, TappedRoutedEventArgs e)
        {
            poem_name.Text = p45.Text;
            mediaPlayer.Source = new Uri("ms-appx:///stories/fox and crow.mp4");
        }

        private void GridView_Tapped_44(object sender, TappedRoutedEventArgs e)
        {
            poem_name.Text = p46.Text;
            mediaPlayer.Source = new Uri("ms-appx:///stories/fox and grapes.mp4");
        }

        private void GridView_Tapped_45(object sender, TappedRoutedEventArgs e)
        {
            poem_name.Text = p47.Text;
            mediaPlayer.Source = new Uri("ms-appx:///stories/greedy dog.mp4");
        }

        private void GridView_Tapped_46(object sender, TappedRoutedEventArgs e)
        {
            poem_name.Text = p48.Text;
            mediaPlayer.Source = new Uri("ms-appx:///stories/hare and tortoise.mp4");
        }

        private void GridView_Tapped_47(object sender, TappedRoutedEventArgs e)
        {
            poem_name.Text = p49.Text;
            mediaPlayer.Source = new Uri("ms-appx:///stories/king and his lazy subjects.mp4");
        }

        private void GridView_Tapped_48(object sender, TappedRoutedEventArgs e)
        {
            poem_name.Text = p50.Text;
            mediaPlayer.Source = new Uri("ms-appx:///stories/silly goats.mp4");
        }

        private void GridView_Tapped_49(object sender, TappedRoutedEventArgs e)
        {
            poem_name.Text = p51.Text;
            mediaPlayer.Source = new Uri("ms-appx:///stories/the capseller.mp4");
        }

        private void GridView_Tapped_50(object sender, TappedRoutedEventArgs e)
        {
            poem_name.Text = p52.Text;
            mediaPlayer.Source = new Uri("ms-appx:///stories/the lion and mouse.mp4");
        }
    }
}
