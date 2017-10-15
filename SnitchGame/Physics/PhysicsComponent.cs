using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnitchGame.Physics
{
    class PhysicsComponent : Component, IPhysicsComponent
    {
        const float MAX_SPEED = 10;

        public PhysicsComponent(GameObject gameObject)
            : base(gameObject)
        {
        }

        public override void Update()
        {
            ApplyGravity();
            ChangeVelocity();
            ChangePosition();
            DetectCollision();
        }

        public void ApplyGravity()
        {

        }

        public void ChangeVelocity()
        {
            var angle = gameObject.Angle;
            var acceleration = gameObject.Acceleration;
            gameObject.Velocity += new Vector2((float)(Math.Sin(angle)) * acceleration, -(float)(Math.Cos(angle)) * acceleration);
            if (gameObject.Velocity.Length() > MAX_SPEED)
            {
                var normal = Vector2.Normalize(gameObject.Velocity);
                gameObject.Velocity = normal * MAX_SPEED;
            }
        }

        public void ChangePosition()
        {
            gameObject.Position += gameObject.Velocity;
        }

        public void DetectCollision()
        {

        }
    }
}
