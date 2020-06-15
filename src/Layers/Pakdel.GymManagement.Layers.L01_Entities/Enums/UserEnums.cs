using System;
using System.Collections.Generic;
using System.Text;

namespace Pakdel.GymManagement.Layers.L01_Entities.Enums
{
    /// <summary>
    /// وضعیت کاربر
    /// </summary>
    public enum UserStatus : byte
    {
        Active = 1,
        Deactive = 2,
        Deleted = 4
    }

    public enum UserType : byte
    {
        Admin = 1,
        coach=2,
        Operator=3,
    }

    public enum GenderType : byte
    {
        Male = 1,
        Female = 2
    }



}
