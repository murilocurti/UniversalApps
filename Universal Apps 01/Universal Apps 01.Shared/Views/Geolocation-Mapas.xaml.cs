using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Devices.Geolocation;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace Universal_Apps_01.Views
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Geolocation_Mapas : Page
    {
        public Geolocation_Mapas()
        {
            this.InitializeComponent();

            this.Loaded += Geolocation_Mapas_Loaded;
        }

        async void Geolocation_Mapas_Loaded(object sender, RoutedEventArgs e)
        {
            Geolocator geo = new Geolocator();
            geo.DesiredAccuracy = PositionAccuracy.High;
            //geo.StatusChanged += geo_StatusChanged;

            geo.PositionChanged += geo_PositionChanged;
            var position = await geo.GetGeopositionAsync();

            //this.map.Center =
            //    new Geopoint(new BasicGeoposition()
            //    {
            //        Latitude = position.Coordinate.Latitude,
            //        Longitude = position.Coordinate.Longitude
            //    });
              

        }

        void geo_PositionChanged(Geolocator sender, PositionChangedEventArgs args)
        {
            
        }

        void geo_StatusChanged(Geolocator sender, StatusChangedEventArgs args)
        {
            if(args.Status == PositionStatus.Ready)
            {

            }
        }
    }
}
