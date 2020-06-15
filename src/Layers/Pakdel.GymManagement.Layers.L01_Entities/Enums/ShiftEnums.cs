using System;
using System.Collections.Generic;
using System.Text;

namespace Pakdel.GymManagement.Layers.L01_Entities.Enums
{
    public enum TimeType : byte
    {
        Morning = 1,
        Evening = 2,
        Define = 3,
        All = 4

    }

    public enum ShiftStatus : byte
    {
        Active = 1,
        Deactive = 2,
        Deleted = 4
    }
}
