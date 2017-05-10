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
    public class Background : StoryboardObjectGenerator
    {
        [Configurable] public int StartTime = 0;
        [Configurable] public int EndTime = 0;
        [Configurable] public string SpritePath = "sb/pixel.png";
        [Configurable] public string MaskPath = "sb/mask.png";
        [Configurable] public Color4 BaseColor = Color4.LightCyan;
        [Configurable] public float MaskOpacity = 0.4f;
        [Configurable] public Vector2 MaskScale = new Vector2(1, 1);
        [Configurable] public bool UseMask = true;
        
        public override void Generate()
        {
		    var layer = GetLayer("Background");
            var baseSprite = layer.CreateSprite(SpritePath);
            baseSprite.ScaleVec(StartTime, OsuHitObject.WidescreenStoryboardSize);
            baseSprite.Color(StartTime, BaseColor);
            baseSprite.Fade(StartTime, StartTime + 100, 0, 1);
            baseSprite.Fade(EndTime - 100, EndTime, 1, 0);

            if (UseMask)
            {
                var maskLayer = GetLayer("Mask");
                var maskSprite = maskLayer.CreateSprite(MaskPath);
                maskSprite.ScaleVec(StartTime, MaskScale);
                maskSprite.Fade(StartTime, StartTime + 100, 0, MaskOpacity);
                maskSprite.Fade(EndTime - 100, EndTime, MaskOpacity, 0);
            }
        }
    }
}
