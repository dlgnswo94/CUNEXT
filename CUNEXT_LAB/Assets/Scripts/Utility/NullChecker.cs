using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CUNEXT.Utility.Enum;

namespace CUNEXT
{
    namespace Utility
    {
        public class NullChecker
        {
            public static bool IsNull<T>(T obj, ELogType logType, string errorMessage = "This obj is NULL!", string[] args = null)
            {
                if (obj == null)
                {
                    return true;
                }
                return false;
            }

            public static bool IsNull<T>(T[] obj, ELogType logType, string errorMessage, string[] args)
            {
                if (obj == null || obj.Length <= 0)
                {
                    return true;
                }
                return false;
            }
        }
    }
}