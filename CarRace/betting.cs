using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace carrace
{
    public class Beting
    {
        public PictureBox imgcarshow;
        public int racerpos;
        public Random radomsteps;
        public int posstart;
        public int racestames;
      

        public bool Engine()

        {
            racerpos = radomsteps.Next(5);
            imgcarshow.Left += posstart + racerpos;

            if (imgcarshow.Left >= racestames)
                return true;

            return false;
        }
        public void GOGOGO()
        {
            this.imgcarshow.Left = 0;
            this.racerpos = 0;
        }

       
    }
}
