using System.IO;
using BruTile.Cache;
using NUnit.Framework;

namespace BruTile.Tests.Cache
{
    public class FileCacheTests : CacheTests<FileCache>
    {
        public FileCacheTests()
            : base(ClearedFileCacheTest())
        {
        }

        private static FileCache ClearedFileCacheTest()
        {
            if (Directory.Exists("FileCacheTest"))
                Directory.Delete("FileCacheTest", true);
            return new FileCache("FileCacheTest", "buf");
        }

        [Test, Category("CacheTest"), Ignore("Long running, only test once in a while")]
        public void Test()
        {
            TestInsertFindRemove();
        }
    }
}