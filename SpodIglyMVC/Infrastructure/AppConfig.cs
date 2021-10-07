using System.Configuration;

namespace SpodIglyMVC.Infrastructure
{
    public class AppConfig
    {
        private static string _genreIconsFolderRelative = ConfigurationManager.AppSettings["GenreIconsFolder"];
        private static string _photosFolderRelative = ConfigurationManager.AppSettings["PhotosFolder"];

        public static string GenreIconsFolderRelative { 
            get {
                return _genreIconsFolderRelative;
            } 
        }

        public static string PhotosFolderRelative
        {
            get
            {
                return _genreIconsFolderRelative;
            }
        }
    }
}