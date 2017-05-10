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
    public class Wave : StoryboardObjectGenerator
    {
        [Configurable] public int StartTime = 0;
        [Configurable] public int EndTime = 0;
        [Configurable] public string SpritePath = "sb/pill.png";
        [Configurable] public int Points = 36;
        [Configurable] public float Phases = 1;
        [Configurable] public int TransitionTime = 800;
        [Configurable] public int LoopTime = 2000;
        [Configurable] public Vector2 Scale = new Vector2(1, 1);
        [Configurable] public Vector2 Origin = new Vector2(320, 240);
        [Configurable] public Vector2 Offset = new Vector2(40, 20);
        [Configurable] public float Rotation = 45;

        public Vector2 Transform(Vector2 position, float angle)
        {
            return Vector2.Transform(position, Quaternion.FromEulerAngles(MathHelper.DegreesToRadians(angle), 0, 0));
        }

        public override void Generate()
        {
            var layer = GetLayer("Wave");

            // Figure out the timing interpolation of various commands for the duration of the effect.
            var waveTotal = MathHelper.TwoPi * Phases;
            var step = waveTotal / Points;
            var transitionTimeStep = TransitionTime / Points;
            var iterations = (int)Math.Ceiling((EndTime - StartTime) / (float)LoopTime);

            // Generate the elements of the entire sine wave.
            for (int i = 0; i < Points; i++)
            {
                var sprite = layer.CreateSprite(SpritePath, OsbOrigin.Centre, Origin);
                sprite.ScaleVec(StartTime, Scale);
                sprite.Fade(EndTime - 100, EndTime, 1, 0);

                sprite.StartLoopGroup(StartTime, iterations);
                sprite.Rotate(0, LoopTime, step * i, step * i + MathHelper.TwoPi);
                sprite.EndGroup();

                // Generate the transition time delayed move effect.
                var startTime = StartTime;
                for (int j = 0; j < i; j++)
                {
                    var position = new Vector2(j * Offset.X, (float)Math.Sin(j * step) * Offset.Y);
                    position = Transform(position, Rotation) + Origin;
                    var endTime = startTime + transitionTimeStep;
                    sprite.Move(startTime, endTime, sprite.PositionAt(startTime), position);
                    startTime = endTime;
                }
            }
        }
    }
}
