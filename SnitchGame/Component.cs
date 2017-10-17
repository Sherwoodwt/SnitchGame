using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnitchGame
{
    abstract class Component : IComponent
    {
        protected GameObject gameObject;

        public GameObject GameObject { get { return this.gameObject; } }

        public Component(GameObject gameObject)
        {
            this.gameObject = gameObject;
        }

        public abstract void Update();
    }
}
