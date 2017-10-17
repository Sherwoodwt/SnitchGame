using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnitchGame.Instructions
{
    class RockInstructionComponent : Component, IInstructionComponent
    {
        public float Rotation { get; set; }

        public RockInstructionComponent(GameObject gameObject)
            : base(gameObject)
        {
            Rotation = .025f;
        }

        public override void Update()
        {
            gameObject.Angle += Rotation;
        }
    }
}
