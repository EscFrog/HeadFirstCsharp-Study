using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P244_PartyPlanner {
    class DinnerParty {
        private int numberOfPeople;  // 파티 참가자 수 저장
        public decimal CostOfBeveragesPerPerson;    // 1인당 음료비 저장
        public decimal CostOfDecorations;   // 장식비 저장

        public const int CostOfFoodPerPerson = 25;

        public void SetHealthOption(bool helthyOptCheck) { // 헬씨 옵션 체크 여부 따라 1인당 음료비를 설정
            if (helthyOptCheck) {
                CostOfBeveragesPerPerson = 5.00M;
            }
            else {
                CostOfBeveragesPerPerson = 20.00M;
            }
        }

        public void CalculateCostOfDecorations(bool fancyDecoCheck) { // 팬시 옵션 체크 여부에 따라 장식비를 계산
            if (fancyDecoCheck) {
                CostOfDecorations = (numberOfPeople * 15.00M) + 50M;
            }
            else {
                CostOfDecorations = (numberOfPeople * 7.50M) + 30M;
            }
        }

        public decimal CalculateCost(bool healthyOptCheck) { // 총비용 계산
            decimal totalCost = CostOfDecorations + ((CostOfBeveragesPerPerson + CostOfFoodPerPerson) * numberOfPeople);

            if (healthyOptCheck) {
                return totalCost * 0.95M;
            }
            else {
                return totalCost;
            }
        }

        public void SetPartyOptions(int people, bool fancyOtpCheck) {
            numberOfPeople = people;
            CalculateCostOfDecorations(fancyOtpCheck);
        }

        public int GetNumberOfPeople() {
            return numberOfPeople;
        }
    }
}
