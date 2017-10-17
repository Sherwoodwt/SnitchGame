using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnitchGame.Physics
{
    interface IPhysicsComponent : IComponent
    {
        void ChangeVelocity();
        void ChangePosition();
        void DetectCollision();
    }
}
