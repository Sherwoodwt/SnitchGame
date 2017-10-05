using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnitchGame
{
    class GameObject
    {
        private const int MAX_SPEED = 10;
        private const float TAO = (float)(2 * Math.PI);

        public Texture2D Image { get; set; }

        private Vector2 position;
        private float speed;
        private float rotation;

        public GameObject(Texture2D image, Vector2 position)
        {
            this.position = position;
            this.speed = 0;
            this.rotation = 0;
            this.Image = image;
        }

        public void Instructions(KeyboardState keyboardState)
        {
            if (keyboardState.IsKeyDown(Keys.A))
                rotation = (rotation - .025f) % TAO;
            if (keyboardState.IsKeyDown(Keys.D))
                rotation = (rotation + .025f) % TAO;
            if (keyboardState.IsKeyDown(Keys.W) && speed < MAX_SPEED)
                speed += .1f;
            if (keyboardState.IsKeyDown(Keys.S) && speed > -MAX_SPEED)
                speed -= .1f;
        }

        public void Physics()
        {
            this.position += new Vector2((float)(Math.Sin(rotation)) * speed, -(float)(Math.Cos(rotation) * speed));
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(Image, position, null, Color.White, rotation, new Vector2(25, 25), 1.0f, SpriteEffects.None, 1);
        }
    }
}
