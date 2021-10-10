using MvcSiteMapProvider;
using SpodIglyMVC.DAL;
using SpodIglyMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SpodIglyMVC.Infrastructure
{
    public class ProductDetailsDynamicNodeProvider : DynamicNodeProviderBase
    {
        private StoreContext db = new StoreContext();
        public override IEnumerable<DynamicNode> GetDynamicNodeCollection(ISiteMapNode node)
        {
            var nodes = new List<DynamicNode>();

            foreach(Album album in db.Albums)
            {
                DynamicNode dynamicNode = new DynamicNode();
                dynamicNode.Title = album.AlbumTitle;
                dynamicNode.Key = "Album_" + album.AlbumId;
                dynamicNode.ParentKey = "Genre_" + album.GenreId;
                dynamicNode.RouteValues.Add("id", album.AlbumId);
                nodes.Add(dynamicNode);
            }
            return nodes;
        }
    }
}