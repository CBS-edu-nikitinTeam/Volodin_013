using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise2
{
    interface IAction
    {
        public void ShowName();

        public void Execute();

        public int GetActionId();
    }
}
