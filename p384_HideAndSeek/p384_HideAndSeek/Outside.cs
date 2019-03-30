using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p384_HideAndSeek {
    class Outside : Location {
        private bool hot;

        public Outside (string name, bool hot) : base(name) {
            this.hot = hot;
        }
                

        public override string Description
        {
            get
            {
                string newDescription = base.Description;
                if (hot)
                    newDescription += "\r\n\r\n이 곳은 몹시 덥습니다.";
                return newDescription;
            }
        }
    }
}
