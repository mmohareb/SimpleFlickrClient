using FlickrNet;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Windows.UI.Xaml;
using Windows.Devices.Geolocation;

namespace SimpleFlickrClient.ViewModel
{
    /// <summary>
    /// This class contains properties that the main View can data bind to.
    /// <para>
    /// Use the <strong>mvvminpc</strong> snippet to add bindable properties to this ViewModel.
    /// </para>
    /// <para>
    /// You can also use Blend to data bind with the tool's support.
    /// </para>
    /// <para>
    /// See http://www.galasoft.ch/mvvm
    /// </para>
    /// </summary>
    public class MainViewModel : ViewModelBase
    {
        /// <summary>
        /// Initializes a new instance of the MainViewModel class.
        /// </summary>
        public MainViewModel()
        {
            ////if (IsInDesignMode)
            ////{
            ////    // Code runs in Blend --> create design time data.
            ////}
            ////else
            ////{
            ////    // Code runs "for real"
            ////}
        }

        public async void GetDataFromFlickr(int pageNumber)
        {
            if (pageNumber == 0)
            {
                imagesUrls = new ObservableCollection<ThumbnailImage>();
            }
            var results = await FlickrBase.Instance.PhotosGetRecentAsync(pageNumber);
            handleResults(results, ImagesUrls);
        }

        public async void SearchDataFromFlickr(string query)
        {
            ImagesUrls = new ObservableCollection<ThumbnailImage>();
            var o = new PhotoSearchOptions { Tags = query, Extras = PhotoSearchExtras.All };
            var results = await FlickrBase.Instance.PhotosSearchAsync(o);
            handleResults(results, ImagesUrls);
        }

        private void handleResults(PhotoCollection results, ObservableCollection<ThumbnailImage> List)
        {
            foreach (var res in results)
            {
                Geopoint point = null;
                if (res.GeoContext.HasValue)
                {
                    //var location = await FlickrBase.Instance.PhotosGeoGetLocationAsync(res.PhotoId);
                    var position = new BasicGeoposition()
                    {
                        Latitude = 47.620,
                        Longitude = -122.349
                    };
                    point = new Geopoint(position);
                }
                List.Add(new ThumbnailImage() { ImagePath = new Uri(res.ThumbnailUrl), ImageTitle = res.Title, BigImage = new Uri(res.LargeUrl), GeoLocation = point });
            }
        }

        private ObservableCollection<Uri> bigImagesUris;
        public ObservableCollection<Uri> BigImagesUris
        {
            get { return bigImagesUris; }
            set
            {
                bigImagesUris = value;
                RaisePropertyChanged();
            }
        }

        private ObservableCollection<ThumbnailImage> imagesUrls;
        public ObservableCollection<ThumbnailImage> ImagesUrls
        {
            get
            {
                return imagesUrls;
            }
            set
            {
                imagesUrls = value;
                RaisePropertyChanged(() => ImagesUrls);
            }
        }

        private Visibility searchVisibility = Visibility.Collapsed;
        public Visibility SearchVisibility
        {
            get { return searchVisibility; }
            set
            {
                searchVisibility = value;
                RaisePropertyChanged(() => SearchVisibility);
            }
        }

        private Visibility locationAppBArVisibility = Visibility.Collapsed;
        public Visibility LocationAppBarVisibility
        {
            get { return locationAppBArVisibility; }
            set
            {
                locationAppBArVisibility = value;
                RaisePropertyChanged(() => LocationAppBarVisibility);
            }
        }

        public RelayCommand ShowSearch
        {
            get
            {
                return new RelayCommand(() =>
                {
                    if (SearchVisibility == Visibility.Visible)
                    {
                        SearchVisibility = Visibility.Collapsed;
                    }
                    else
                    {
                        SearchVisibility = Visibility.Visible;
                    }
                });
            }
        }

        public RelayCommand<Geopoint> LocateImage
        {
            get
            {
                return new RelayCommand<Geopoint>((point) =>
                {

                });
            }
        }

        private Geopoint location;

        public Geopoint Location
        {
            get { return location; }
            set
            {
                location = value;
                RaisePropertyChanged();
            }
        }
    }
    public class ThumbnailImage
    {
        private Uri imagePath;
        public Uri ImagePath
        {
            get { return imagePath; }
            set { imagePath = value; }
        }

        private string imageTitle;
        public string ImageTitle
        {
            get { return imageTitle; }
            set { imageTitle = value; }
        }

        private Uri bigImage;
        public Uri BigImage
        {
            get { return bigImage; }
            set { bigImage = value; }
        }

        private Geopoint geoLocation;

        public Geopoint GeoLocation
        {
            get { return geoLocation; }
            set { geoLocation = value; }
        }

    }
}