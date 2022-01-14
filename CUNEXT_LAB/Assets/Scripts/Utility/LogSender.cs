using System.Collections.Generic;
using UnityEngine;
using CUNEXT.Utility.Enum;
using CUNEXT.Utility.Environment;
using CUNEXT.Utility.Environment.Enum;

// Test Later.
namespace CUNEXT
{
    namespace Utility
    {
        public static class LogSender
        {
            public static void SendLog(ELogType logType, string message = "Please write a message.", string[] args = null)
            {
                if (EnvironmentInfo.GetOperationSystemInfo() != EEnvironmentInfo.UNITY_EDITOR)
                    return;

                string formatMessage = message;
                if (string.IsNullOrEmpty(formatMessage))
                {
                    Debug.Log("Please write a message.");
                    return;
                }

                // Process of counting the number of curly bracket pairs and safely putting them in string.format.
                if (args != null && args.Length > 0)
                {
                    int bracketCnt = 0;           // The number of curly bracket pairs.
                    char curlyBracket = '_';    // save the '{'

                    for (int i = 0; i < formatMessage.Length; i++)
                    {
                        if (formatMessage[i] == '{' || formatMessage[i] == '}')
                        {
                            if (curlyBracket != '{')
                            {
                                curlyBracket = '{';
                            }
                            else
                            {
                                if (formatMessage[i] == '{')
                                {
                                    Debug.LogWarning("Please check args (curly bracketts).");
                                    return;
                                }

                                if (formatMessage[i] != '}')
                                    continue;

                                curlyBracket = '_'; // Set it to '_' for the next search.
                                bracketCnt++;
                            }
                        }
                    }

                    if (bracketCnt != args.Length)
                    {
                        Debug.LogError("The number of args and brackets must be the same!");
                        return;
                    }

                    List<string> formatArgs = new List<string>();

                    for (int j = 0; j < bracketCnt; j++)
                        formatArgs.Add(args[j]);

                    if (formatArgs == null || formatArgs.Count <= 0)
                    {
                        Debug.LogError("FormatArgs is null or count is 0.");
                        return;
                    }

                    formatMessage = string.Format(formatMessage, formatArgs);
                }
            
                switch (logType)
                {
                    case ELogType.Error:
                        Debug.LogError(formatMessage);
                        break;

                    case ELogType.Assert:
                        Debug.LogAssertion(formatMessage);
                        break;

                    case ELogType.Warning:
                        Debug.LogWarning(formatMessage);
                        break;

                    case ELogType.Log:
                        Debug.Log(formatMessage);
                        break;

                    default:
                        Debug.Log("Unregistered log type.");
                        break;
                }
            }
        }
    }
}