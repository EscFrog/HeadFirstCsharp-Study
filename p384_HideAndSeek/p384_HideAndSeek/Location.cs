using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p384_HideAndSeek {
    abstract class Location {
        public Location(string name) {
            Name = name;
        }

        public Location[] Exits;

        public string Name { get; private set; }

        public virtual string Description {
            get
            {
                string description = "당신은 지금 [" + Name + "]에 있습니다.\r\n이 곳은";
                for (int i = 0; i < Exits.Length; i++) {
                    description += "[" + Exits[i].Name + "]";
                    if (i != Exits.Length - 1)
                        description += ", ";
                }
                description += "(으)로 통합니다.";
                return description;
            }
        }
        
    }
}
