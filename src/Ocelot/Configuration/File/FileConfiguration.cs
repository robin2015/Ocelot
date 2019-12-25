using System.Collections.Generic;

namespace Ocelot.Configuration.File
{
    //TODO 文件配置数据结构
    public class FileConfiguration
    {
        public FileConfiguration()
        {
            ReRoutes = new List<FileReRoute>();
            GlobalConfiguration = new FileGlobalConfiguration();
            Aggregates = new List<FileAggregateReRoute>();
            DynamicReRoutes = new List<FileDynamicReRoute>();
        }

        public List<FileReRoute> ReRoutes { get; set; }
        public List<FileDynamicReRoute> DynamicReRoutes { get; set; }

        // Seperate field for aggregates because this let's you re-use ReRoutes in multiple Aggregates
        public List<FileAggregateReRoute> Aggregates { get; set; }

        public FileGlobalConfiguration GlobalConfiguration { get; set; }
    }
}
