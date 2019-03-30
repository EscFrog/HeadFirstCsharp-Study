using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p376_ExploreHouse {
    abstract class Location {
        public Location(string name) {
            Name = name;
        }

        public Location[] Exits;

        public string Name { get; private set; }

        public virtual string Description {
            get
            {
                string description = "당신은 지금 ";
                for (int i = 0; i < Exits.Length; i++) {
                    description += "[" + Exits[i].Name + "]";
                    if (i != Exits.Length - 1)
                        description += ", ";
                }
                description += "(으)로 통하는 [" + Name + "]에 있습니다.";
                return description;
            }
        }
        
    }
}
