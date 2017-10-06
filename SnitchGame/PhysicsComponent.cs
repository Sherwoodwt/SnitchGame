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
        public PhysicsComponent(GameObject gameObject)
            : base(gameObject)
        {
        }

        public override void Update()
        {
            var angle = gameObject.Angle;
            var speed = gameObject.Speed;
            gameObject.Position += new Vector2((float)(Math.Sin(angle)) * speed, -(float)(Math.Cos(angle) * speed));
        }
    }
}
