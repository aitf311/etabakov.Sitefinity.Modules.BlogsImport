using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eTabakov.Sitefinity.Modules.BlogsImport.BlogsMigrationProvider
{
    public class BloggerMigrationProvider : IBlogsMigrationProvider
    {
        public void MigrateBlogs(StreamReader source)
        {
            throw new NotImplementedException();
        }

        public string SourceTitle
        {
            get
            {
                return "Blogger";
            }
        }
    }
}
