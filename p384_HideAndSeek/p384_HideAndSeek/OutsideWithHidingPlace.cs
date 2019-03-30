using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p384_HideAndSeek {
    class OutsideWithHidingPlace : Outside, IHidingPlace {
        public OutsideWithHidingPlace (string name, bool hot, string hidingPlaceName) : base(name, hot) {
            HidingPlaceName = hidingPlaceName;
        }

        public string HidingPlaceName { get; private set; }

        public override string Description
        {
            get
            {
                return base.Description + "\r\n\r\n아마도 <" + HidingPlaceName + ">에 숨을 수 있을 것 같습니다";
            }
        }
    }
}
