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

        List<GameObject> gameObjects;
        
        public float Mass { get; set; }
        public float Size { get; set; }

        public bool HasGravity { get { return Mass > 0; } }
        public bool CanCollide { get { return Size > 0; } }

        public PhysicsComponent(GameObject gameObject, List<GameObject> gameObjects)
            : base(gameObject)
        {
            this.gameObjects = gameObjects;

            Size = 0;
            Mass = 0;
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
            if (HasGravity)
            {
                
            }
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
            if (CanCollide)
            {

            }
        }
    }
}
