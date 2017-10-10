using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnitchGame
{
    class PhysicsComponent : Component
    {
        const float MAX_SPEED = 10;

        public PhysicsComponent(GameObject gameObject)
            : base(gameObject)
        {
        }

        public override void Update()
        {
            var angle = gameObject.Angle;
            var acceleration = gameObject.Acceleration;
            gameObject.Velocity += new Vector2((float)(Math.Sin(angle)) * acceleration, -(float)(Math.Cos(angle)) * acceleration);
            if (gameObject.Velocity.Length() > MAX_SPEED)
            {
                gameObject.Velocity.Normalize();
                gameObject.Velocity *= MAX_SPEED;
            }
            gameObject.Position += gameObject.Velocity;
        }
    }
}
