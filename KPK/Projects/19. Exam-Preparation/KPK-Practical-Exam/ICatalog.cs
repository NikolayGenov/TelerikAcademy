using System;
using System.Collections.Generic;
using System.Linq;

namespace FreeContentCatalog
{
    public interface ICatalog
    {
        void Add(IContent content);

        IEnumerable<IContent> GetListContent(string title, int numberOfContentElementsToList);

        Int32 UpdateContent(string oldUrl, string newUrl);
    }
}