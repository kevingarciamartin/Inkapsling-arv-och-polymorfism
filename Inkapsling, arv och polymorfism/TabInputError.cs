﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inkapsling__arv_och_polymorfism
{
    internal class TabInputError : UserError
    {
        public override string UEMessage()
        {
            return "You tried to use tab as your only input. This fired an error!";
        }
    }
}
