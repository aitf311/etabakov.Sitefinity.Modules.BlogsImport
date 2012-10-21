using System;
using System.Collections.Generic;
using System.Linq;

namespace eTabakov.Sitefinity.Modules.BlogsImport.BlogsMigrationProvider
{
    public static class BlogsProviderFactory
    {
        public static IEnumerable<IBlogsMigrationProvider> GetAll()
        {
            yield return new BloggerMigrationProvider();
        }
    }
}
