using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    class Shape
    {
        private protected string _name;

        public string Name
        {
            get { return (this._name); }
            set { _name = value; }

        }

    }
}
