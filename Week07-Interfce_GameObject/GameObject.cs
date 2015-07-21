using Week07_Interface_GameObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week07_Interface_GameObject{
    interface IAttackable{ string Attack(); }
    interface IProtectable{ string Attack(); }
    class GameObject{
        protected int x; protected int y; protected int z;
        public string Position{ get{ return (string.Format("<{0}, {1}, {2}>", x, y, z)); } }
    }
    class Vampire: GameObject, IAttackable, IProtectable{
        public Vampire(){ x = 0; y = 0; z = 0; }
        string IAttackable.Attack(){ return "bite"; }
        string IProtectable.Attack(){ return "garllic"; }
    }
    class Soilder : GameObject{ public Soilder(){ x = 0; y = 0; z = 0; }}
    class Allien : GameObject{

    }
}
