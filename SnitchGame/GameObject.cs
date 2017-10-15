using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using SnitchGame.Instructions;
using SnitchGame.Physics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnitchGame
{
    class GameObject
    {
        public static float TAO = (float)(2 * Math.PI);
        private const int MAX_SPEED = 10;

        public Texture2D Image { get; set; }
        public Vector2 Position { get; set; }
        public Vector2 Velocity { get; set; }
        public float Acceleration { get; set; }
        public float Angle { get; set; }

        private InstructionsComponent instructionsComponent;
        private PhysicsComponent physicsComponent;

        public PhysicsComponent PhysicsComponent { set { this.physicsComponent = value; } }
        public InstructionsComponent InstructionsComponent { set { this.instructionsComponent = value; } }

        public GameObject(Texture2D image, Vector2 position)
        {
            this.Position = position;
            this.Velocity = new Vector2();
            this.Acceleration = 0;
            this.Angle = 0;
            this.Image = image;
        }

        public void Update(KeyboardState keyboardState)
        {
            if (instructionsComponent != null)
            {
                instructionsComponent.Update();
            }
            physicsComponent.Update();
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(Image, Position, null, Color.White, Angle, new Vector2(25, 25), .5f, SpriteEffects.None, 1);
        }
    }
}
