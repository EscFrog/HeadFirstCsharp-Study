﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p323_BeehiveManagementSystem {
    class Bee {
        const double HoneyConsumedPerMg = .25;

        public double WeightMg { get; private set; }

        public Bee (double weightMg) {
            WeightMg = weightMg;
        }

        public virtual double HoneyConsumptionRate() {
            return WeightMg * HoneyConsumedPerMg;
        }
    }
}
