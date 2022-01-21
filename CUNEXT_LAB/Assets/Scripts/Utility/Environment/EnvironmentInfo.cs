using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CUNEXT.Utility.Environment.Enums;

namespace CUNEXT
{
    namespace Utility
    {
        namespace Environment
        {
            public static class EnvironmentInfo
            {
                private static readonly EEnvironmentInfo OS;

                static EnvironmentInfo()
                {
#if UNITY_EDITOR || UNITY_EDITOR_WIN || UNITY_EDITOR_OSX || UNITY_EDITOR_LINUX
                    OS = EEnvironmentInfo.UNITY_EDITOR;

#elif UNITY_ANDROID
                    OS = EEnvironmentInfo.UNITY_ANDROID;

#elif UNITY_IOS || UNITY_IPHONE
                    OS = EEnvironmentInfo.UNITY_IOS;

#elif ENABLE_VR
                    OS = EEnvironmentInfo.VR;

#elif ENABLE_AR
                    OS = EEnvironmentInfo.AR;

#else
                    OS = EEnvironmentInfo.ETC;

#endif
                }

                public static EEnvironmentInfo GetOperationSystemInfo() => OS;
            }
        }
    }
}