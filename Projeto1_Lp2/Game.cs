using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto1_Lp2
{
    class Game
    {
        int ID { get; }
        string Name { get; }
        DateTime ReleaseDate { get; }
        int RequiredAge { get; }
        int DLCCount { get; }
        int Metacritic { get; }
        int MovieCount { get; }
        int RecommendationCount { get; }
        int ScreenshotCount { get; }
        int Owners { get; }
        int NumberOfPlayers { get; }
        int AchievementCount { get; }
        bool ControllerSupport { get; }
        bool PlatformWindows { get; }
        bool PlatformLinux { get; }
        bool PlatformMac { get; }
        bool CategorySinglePlayer { get; }
        bool CategoryMultiplayer { get; }
        bool CategoryCoop { get; }
        bool CategoryIncludeLevelEditor { get; }
        bool CategoryVRSupport { get; }
        Uri SupportURL { get; }
        string AboutText { get; }
        Uri HeaderImage { get; }
        Uri Website { get; }
    }
}
