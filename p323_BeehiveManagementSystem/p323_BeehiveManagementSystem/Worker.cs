using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p323_BeehiveManagementSystem {
    class Worker {
        public Worker(String[] jobsiCanDo) { // 생성자
            this.jobsICanDo = jobsiCanDo;
        }
        
        public int ShiftsLeft {
            get {
                return shiftsToWork - shiftsWorked;
            }
        }

        private string currentJob;
        public string CurrentJob {
            get {
                return currentJob;
            }
        }

        private string[] jobsICanDo; // 할 수 있는 일
        private int shiftsToWork; // 일 해야 될 시간
        private int shiftsWorked; // 일 한 시간
        
        public bool DoThisJob(string job, int numberOfShifts) {
            if (!String.IsNullOrEmpty(currentJob))
                return false;
            for (int i = 0; i < jobsICanDo.Length; i++) {
                if (jobsICanDo[i] == job) {
                    currentJob = job;
                    this.shiftsToWork = numberOfShifts;
                    shiftsWorked = 0;
                    return true;
                }
            }
            return false;
        }

        public bool DidYouFinish() {
            if (String.IsNullOrEmpty(currentJob))
                return false;
            shiftsWorked++;
            if (shiftsWorked > shiftsToWork) {
                shiftsWorked = 0;
                shiftsToWork = 0;
                currentJob = "";
                return true;
            }
            else {
                return false;
            }
        }
    }
}
