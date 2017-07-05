//------------------------------------------------------------
// Author:  FreeKnight
// Date:    20170705
// Desc:    三角形
//------------------------------------------------------------
using System.Collections.Generic;
//------------------------------------------------------------
namespace FKRandomMapGenLib
{
    public class Triangle
    {
        private List<Site> sites;

        public Triangle(Site a, Site b, Site c)
        {
            sites = new List<Site>();
            sites.Add(a);
            sites.Add(b);
            sites.Add(c);
        }

        public List<Site> GetSites()
        {
            return sites;
        }

        public void Dispose()
        {
            sites.Clear();
            sites = null;
        }
    }
}
