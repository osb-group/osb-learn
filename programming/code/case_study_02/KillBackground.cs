using OpenTK;
using OpenTK.Graphics;
using StorybrewCommon.Mapset;
using StorybrewCommon.Scripting;
using StorybrewCommon.Storyboarding;
using StorybrewCommon.Storyboarding.Util;
using StorybrewCommon.Subtitles;
using StorybrewCommon.Util;
using System;
using System.Collections.Generic;
using System.Linq;

namespace StorybrewScripts
{
    public class KillBackground : StoryboardObjectGenerator
    {
        [Configurable] public int StartTime = 0;
        [Configurable] public int EndTime = 1312;
        [Configurable] public OsbEasing Easing = OsbEasing.None;
        
        public override void Generate()
        {
		    var sprite = GetLayer("").CreateSprite(Beatmap.BackgroundPath);
            var bitmap = GetMapsetBitmap(Beatmap.BackgroundPath);
            sprite.Scale(StartTime, OsuHitObject.WidescreenStoryboardSize.Y / bitmap.Height);
            sprite.Fade(Easing, StartTime, EndTime, 1, 0);
        }
    }
}
