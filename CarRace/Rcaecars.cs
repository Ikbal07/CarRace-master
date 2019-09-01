using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace carrace
{
    class racecars
    {
        public int carsmoney;
        public RadioButton radiocars;
        public Label labelracer;
        public string beetingperson;
        public placingbet BetMaker;
        

      


        public void clearbts()
        {
            BetMaker.moenybts = 0;
        }
        public racecars(string Namecar, int amt, RadioButton radiocarsbtn, Label carlabes)
        {
            beetingperson = Namecar;
            carsmoney = amt;
            radiocars = radiocarsbtn;
            labelracer = carlabes;
            BetMaker = new placingbet(this);
        }
        public bool carbeetingrace(int betamt, int pos1)
        {
            BetMaker.moenybts = betamt;
            BetMaker.carraceing = pos1;
            if (carsmoney >= betamt) return true;
            return false;
        }

        public void UpdateLb()
        {
            labelracer.Text = BetMaker.messageboard();
            radiocars.Text = beetingperson + " has " + carsmoney + " bucks";
        }
        public void firstracer(int win)
        {
            carsmoney += BetMaker.winningracers(win);
            clearbts();
            UpdateLb();
        }
    }
}
