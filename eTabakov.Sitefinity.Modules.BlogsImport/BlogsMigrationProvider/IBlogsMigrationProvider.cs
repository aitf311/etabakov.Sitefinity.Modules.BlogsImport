using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eTabakov.Sitefinity.Modules.BlogsImport.BlogsMigrationProvider
{
    public interface IBlogsMigrationProvider
    {
        void MigrateBlogs(StreamReader source);

        string SourceTitle { get; }
    }
}
