﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace App.Contracts
{
    public enum ActionKind
    {
        Normal = 0,
        BeginGroup = 1,
        EndGroup = 2,
        Else = 3,
        Exit = 4,
        Repeat = 5,
        Variable = 6,
        Code = 7,
        Placeholder = 8,
        Separator = 9,
        Label = 10,
    }
}
