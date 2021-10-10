using MvcSiteMapProvider;
using SpodIglyMVC.DAL;
using SpodIglyMVC.Models;
using System.Collections.Generic;


namespace SpodIglyMVC.Infrastructure
{
    public class ProductListDynamicNodeProvider : DynamicNodeProviderBase
    {
        private StoreContext db = new StoreContext();
        public override IEnumerable<DynamicNode> GetDynamicNodeCollection(ISiteMapNode node)
        {
            var nodes = new List<DynamicNode>();

            foreach (Genre genre in db.Genres)
            {
                DynamicNode dynamicNode = new DynamicNode();
                dynamicNode.Title = genre.Name;
                dynamicNode.Key = "Genre_" + genre.GenreId;
                dynamicNode.RouteValues.Add("genrename", genre.Name);
                nodes.Add(dynamicNode);
            }
            return nodes;
        }
    }
}