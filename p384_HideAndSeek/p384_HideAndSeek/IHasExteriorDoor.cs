using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p384_HideAndSeek {
    interface IHasExteriorDoor {
        string DoorDescription { get; }
        Location DoorLocation { get; set; }
    }
}
