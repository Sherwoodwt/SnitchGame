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
        public Vector2 Position { get; set; }
        public float Speed { get; set; }
        public float Angle { get; set; }

        private PhysicsComponent physicsComponent;

        public PhysicsComponent PhysicsComponent { set { this.physicsComponent = value; } }

        public GameObject(Texture2D image, Vector2 position)
        {
            this.Position = position;
            this.Speed = 0;
            this.Angle = 0;
            this.Image = image;
        }

        public void Update(KeyboardState keyboardState)
        {
            Instructions(keyboardState);
            physicsComponent.Update();
        }

        private void Instructions(KeyboardState keyboardState)
        {
            if (keyboardState.IsKeyDown(Keys.A))
                Angle = (Angle - .025f) % TAO;
            if (keyboardState.IsKeyDown(Keys.D))
                Angle = (Angle + .025f) % TAO;
            if (keyboardState.IsKeyDown(Keys.W) && Speed < MAX_SPEED)
                Speed += .1f;
            if (keyboardState.IsKeyDown(Keys.S) && Speed > -MAX_SPEED)
                Speed -= .1f;
        }

        private void Physics()
        {
            
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(Image, Position, null, Color.White, Angle, new Vector2(25, 25), 1.0f, SpriteEffects.None, 1);
        }
    }
}
