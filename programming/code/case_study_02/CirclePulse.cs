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
    public class CirclePulse : StoryboardObjectGenerator
    {
       [Configurable] public int StartTime = 0;
        [Configurable] public int EndTime = 0;
        [Configurable] public string SpritePath = "sb/circle.png";
        [Configurable] public string RingPath = "sb/ring.png";
        [Configurable] public Vector2 Origin = new Vector2(320, 240);
        [Configurable] public float StartScale = 1f;
        [Configurable] public float PulseScale = 1.2f;
        [Configurable] public float UpbeatMultiplier = 1.1f;
        [Configurable] public float RingMultiplier = 1.1f;
        [Configurable] public OsbEasing Easing = OsbEasing.OutBack;

        public void Pulsate(OsbSprite sprite, bool isRing = false)
        {
            var beatDuration = Beatmap.GetTimingPointAt(StartTime).BeatDuration;
            var iterations = (int)(Math.Ceiling((EndTime - StartTime) / beatDuration * 2));
            var baseScale = StartScale * PulseScale * (isRing ? RingMultiplier : 1);
            sprite.Fade(StartTime, StartTime + 100, 0, 1);
            sprite.Fade(EndTime - 100, EndTime, 1, 0);
            sprite.StartLoopGroup(StartTime, iterations);
            sprite.Scale(Easing, 0, beatDuration, baseScale * UpbeatMultiplier, StartScale);
            sprite.Scale(Easing, beatDuration, beatDuration * 2, baseScale, StartScale);
            sprite.EndGroup();
        }

        public override void Generate()
        {
		    var layer = GetLayer("Circle Pulse");
            var circleSprite = layer.CreateSprite(SpritePath, OsbOrigin.Centre, Origin);
            var ringSprite = layer.CreateSprite(RingPath, OsbOrigin.Centre, Origin);
            Pulsate(circleSprite);
            Pulsate(ringSprite, true);
        }
    }
}
