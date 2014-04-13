using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NasaReader.Integration.Enums
{
    public class NasaEnums
    {
        public enum NasaSources
        {
            [Description("http://pipes.yahoo.com/pipes/pipe.run?_id=f3faf9053819df86db8a6525ebf927c1&_render=json")]
            BreakingNews = 0,
            [Description("http://pipes.yahoo.com/pipes/pipe.run?_id=0f60a41c19775fff465ed3df122e4a51&_render=json")]
            EducationNews = 1,
            [Description("http://pipes.yahoo.com/pipes/pipe.run?_id=26c2bab6dd90cfaa60be800f942ea68e&_render=json")]
            OnTheStation = 2,
            [Description("http://pipes.yahoo.com/pipes/pipe.run?_id=ba787b13134f46af303a81b194c7af27&_render=json")]
            KeplerMission = 3,
            [Description("http://pipes.yahoo.com/pipes/pipe.run?_id=0f45b09fc1fab017aded53660e0cc4d5&_render=json")]
            InternationalSpaceStation = 4,
            [Description("http://pipes.yahoo.com/pipes/pipe.run?_id=6394401290d063ac5b6f5bec4799f051&_render=json")]
            SpaceStationNews = 5,
            [Description("http://pipes.yahoo.com/pipes/pipe.run?_id=b2083b45abdbb5c891eb0da96b4c97f4&_render=json")]
            SolarNews = 6,
            [Description("http://pipes.yahoo.com/pipes/pipe.run?_id=eeef747ff88b42bb2bd5ae647198e4cc&_render=json")]
            UniverseNews = 7,
            [Description("http://pipes.yahoo.com/pipes/pipe.run?_id=333c6ffaf7077191eb142ad29a9e76e3&_render=json")]
            EarthNews = 8,
            [Description("http://pipes.yahoo.com/pipes/pipe.run?_id=767c1b78d43f68dc54084f64cf36f1cc&_render=json")]
            AeroanuticsNews = 9,
            [Description("http://pipes.yahoo.com/pipes/pipe.run?_id=d1ad270d288e4baad0927e390a493ac8&_render=json")]
            HurricaneUpdate = 10,

        }

        public enum NasaTitles
        {
            [Description("Breaking News")]
            BreakingNews = 0,
            [Description("Education News")]
            EducationNews = 1,
            [Description("On the Station")]
            OnTheStation = 2,
            [Description("Kepler Mission")]
            KeplerMission = 3,
            [Description("Station Reports")]
            InternationalSpaceStation = 4,
            [Description("Station News")]
            SpaceStationNews = 5,
            [Description("Solar News")]
            SolarNews = 6,
            [Description("Universe News")]
            UniverseNews = 7,
            [Description("Earth News")]
            EarthNews = 8,
            [Description("Aeronautics News")]
            AeroanuticsNews = 9,
            [Description("Hurricane Update")]
            HurricaneUpdate = 10,
        }
    }
}
