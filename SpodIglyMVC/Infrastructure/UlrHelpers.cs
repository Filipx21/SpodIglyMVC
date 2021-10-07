using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SpodIglyMVC.Infrastructure
{
    public static class UlrHelpers
    {
        public static string GenreIconPath(this UrlHelper helper, string genreIconFilename)
        {
            var genreIconFolder = AppConfig.GenreIconsFolderRelative;
            var path = Path.Combine(genreIconFolder, genreIconFilename);
            var absolutePath = helper.Content(path);
            return absolutePath;
        }
    }
}