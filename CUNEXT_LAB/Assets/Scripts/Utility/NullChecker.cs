using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CUNEXT.Utility.Enums;

namespace CUNEXT
{
    namespace Utility
    {
        public class NullChecker
        {
            public static bool IsNull<T>(T obj, ELogType logType, string errorMessage = "This obj is NULL!", params string[] args)
            {
                if (obj == null)
                {
                    LogSender.SendLog(ELogType.Error, errorMessage, args);
                    return true;
                }
                return false;
            }

            public static bool IsNull<T>(T[] obj, ELogType logType, string errorMessage = "This obj is NULL!", params string[] args)
            {
                if (obj == null)
                {
                    LogSender.SendLog(ELogType.Error, errorMessage, args);
                    return true;
                }

                if (obj.Length <= 0)
                {
                    LogSender.SendLog(ELogType.Error, errorMessage, args);
                    return true;
                }

                for (int i = 0; i < obj.Length; i++)
                {
                    if (obj[i] == null)
                    {
                        LogSender.SendLog(ELogType.Error, errorMessage, args);
                        return true;
                    }
                }
                return false;
            }
        }
    }
}