using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul4_103022300148
{
    enum State { QUIET, BALANCED, PERFORMANCE, TURBO }
    internal class FanLaptop
    {
        State state;
        public FanLaptop()
        {
            state = State.QUIET;
        }

        public void Balanced()
        {
            state = State.BALANCED;
        }

        public void Performance()
        {
            state = State.PERFORMANCE;
        }

        public void Turbo() { 
            state = State.TURBO;
        }

        public void Quiet() { 
            state = State.QUIET;
        }

        public State getState() { 
            return state;
        }
    }
}
