﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace DSAACA.Entities
{
    class Player : Sprite
    {
        #region Properties

        #endregion

        #region Constructor
        public Player(Texture2D image, Vector2 position, Color tint, int frameCount) 
            : base(image, position, tint, frameCount)
        {

        }
        #endregion

        #region Methods

        #endregion
    }
}