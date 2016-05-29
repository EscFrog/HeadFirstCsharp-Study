using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p323_BeehiveManagementSystem {
    class Queen {
        public Queen(Worker[] workers) { // 생성자
            this.workers = workers;
        }

        private Worker[] workers;
        private int shiftNumber = 0;

        private int beeNumber; // 몇 번 벌에게 일이 배정되었는지 확인하기 위해 넣은 필드
        public int BeeNumber{
            get { return beeNumber; }
        }
        
        public bool AssignWork(string job, int numberOfShift) {
            for (int i = 0; i < workers.Length; i++) {
                beeNumber = (i + 1); // 몇 번 벌에게 일이 배정되었는지 확인하기 위해 넣은 코드
                if (workers[i].DoThisJob(job, numberOfShift))
                    return true;
                }
            return false;
        }

        public string WorkTheNextShift() {
            shiftNumber++;
            string report = "#" + shiftNumber+ " 턴째 보고\r\n\r\n";
            for (int i = 0; i < workers.Length; i++) {
                if (workers[i].DidYouFinish()) {
                report += "일벌 #" + (i + 1) + " 이 일을 마쳤습니다.\r\n";
                }

                if (String.IsNullOrEmpty(workers[i].CurrentJob)) {
                    report += "일벌 #" + (i + 1) + " 은 할 일이 없습니다.\r\n\r\n";
                }
                else {
                    if (workers[i].ShiftsLeft > 0) {
                        report += "일벌 #" + (i + 1) + " 은 '" + workers[i].CurrentJob + "' 업무를 " + workers[i].ShiftsLeft + " 턴 더 할 예정입니다.\r\n\r\n";
                    }
                    else {
                        report += "일벌 #" + (i + 1) + " 은 '" + workers[i].CurrentJob + "' 업무를 이번 턴 후에 마칠 예정입니다.\r\n\r\n";
                    }
                }
            }
            return report;
        }
    }
}
