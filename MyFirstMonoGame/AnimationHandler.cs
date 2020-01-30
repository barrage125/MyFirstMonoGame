using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework.Graphics;

namespace MyFirstMonoGame
{
    class AnimationHandler
    {
        private List<Texture2D> frames;
        int frameIndex;
        public AnimationHandler(Texture2D sheet, int height, int width, int offset)
        {
            for (int w = 0; (w + width) <= sheet.Width; w+=width + offset)
            {
                //frames.Add(sheet.GetData);
            }
            frameIndex = 0;
        }

        public AnimationHandler(Texture2D sheet, int height, int width) : this(sheet, height, width, 0)
        {

        }

        private void AnimationLoader()
        {

        }

        public Texture2D NextFrame()
        {
            if (frames.Count <= 0)
            {
                throw new System.IndexOutOfRangeException("Animation must contain at least one frame");
            }
            Texture2D frame = frames[frameIndex];
            frameIndex++;
            if (frameIndex >= frames.Count)
                frameIndex = 0;
            return frame;
        }


    }
}
