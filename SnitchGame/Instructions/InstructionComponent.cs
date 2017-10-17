using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework.Input;

namespace SnitchGame.Instructions
{
    class InstructionComponent: Component, IInstructionComponent
    {
        public InstructionComponent(GameObject gameObject)
            : base(gameObject)
        {
        }

        public override void Update()
        {
            var keyboardState = Keyboard.GetState();
            if (keyboardState.IsKeyDown(Keys.A))
                this.gameObject.Angle = (this.gameObject.Angle - .05f) % GameObject.TAO;
            if (keyboardState.IsKeyDown(Keys.D))
                this.gameObject.Angle = (this.gameObject.Angle + .05f) % GameObject.TAO;

            if (keyboardState.IsKeyDown(Keys.W))
                this.gameObject.Acceleration = .1f;
            else if (keyboardState.IsKeyDown(Keys.S))
                this.gameObject.Acceleration = -.1f;
            else
                this.gameObject.Acceleration = 0;
        }
    }
}
