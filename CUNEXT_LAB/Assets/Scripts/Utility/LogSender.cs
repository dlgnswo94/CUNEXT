using System;
using UnityEngine;
using CUNEXT.Utility.Enums;
using CUNEXT.Utility.Environment;
using CUNEXT.Utility.Environment.Enums;

// Test Later.
namespace CUNEXT
{
    namespace Utility
    {
        public static class LogSender
        {
            public static void SendLog(ELogType logType, string message = "", params string[] args)
            {
                if (EnvironmentInfo.GetOperationSystemInfo() != EEnvironmentInfo.UNITY_EDITOR)
                    return;

                string formatMessage = message;
                if (string.IsNullOrEmpty(formatMessage))
                {
                    Debug.Log("Please write a message.");
                    return;
                }

                if (args != null && args.Length > 0)
                {
                    try
                    {
                        formatMessage = string.Format(formatMessage, args);
                    }
                    catch (FormatException e)
                    {
                        string eMessage = string.Concat("The message format is not correct. Please check the format of this message again. ---> ", message, args.ToString());
                        Debug.LogError(eMessage);
                        return;
                    }
                }
            
                switch (logType)
                {
                    case ELogType.Error:
                        Debug.LogError(formatMessage);
                        return;

                    case ELogType.Assert:
                        Debug.LogAssertion(formatMessage);
                        return;

                    case ELogType.Warning:
                        Debug.LogWarning(formatMessage);
                        return;

                    case ELogType.Log:
                        Debug.Log(formatMessage);
                        return;

                    default:
                        Debug.Log("Unregistered log type.");
                        return;
                }
            }
        }
    }
}