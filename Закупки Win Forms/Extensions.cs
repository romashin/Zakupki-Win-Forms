using System;
//using Npgsql;

namespace Закупки_Win_Forms
{
    public static class Extensions
    {
        public static object ValueIfNull(this object value)
        {
            return value ?? DBNull.Value;
        }
    }

}
