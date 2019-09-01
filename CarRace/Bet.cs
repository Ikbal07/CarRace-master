using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace carrace
{
    class placingbet
    {
        public int moenybts;
        public int carraceing;
        public racecars carbets;

      
        public string messageboard()
        {
            if(moenybts > 0) return carbets.beetingperson + " bets " + moenybts + " dollars on car #" + carraceing;
            return carbets.beetingperson + " hasn't placed a bet";
        }
        public placingbet(racecars beters)
        {
            carbets = beters;
        }
        public int winningracers(int winner)
        {
            if (carraceing == winner) return moenybts;
            return -moenybts;
        }
    }
}
