using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Reproductor
{
    class Play_Stop
    {
        bool play = false;

        public bool Play
        {
            get
            {
                return play;
            }

            set
            {
                play = value;
            }
        }
    }
}
