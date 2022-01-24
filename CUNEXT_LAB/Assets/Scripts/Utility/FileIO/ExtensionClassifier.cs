using System;
using System.IO;
using static System.IO.Directory;
using CUNEXT.Utility.Enums;

namespace CUNEXT
{
    namespace Utility
    {
        namespace FileIO
        {
            public class ExtensionClassifier
            {
                public static EFileNameExtension Classifying (string path = "", string fileName = "")
                {
                    if (!Exists(path))
                    {
                        LogSender.SendLog(ELogType.Warning, "A path that doesn't exist. Can't classifying. / path : {0} ", path);
                        return EFileNameExtension.None;
                    }

                    string strExtension = Path.GetExtension(fileName);
                    strExtension = strExtension.Remove(0, 1); // Remove '.' for parsing.

                    EFileNameExtension extension = EFileNameExtension.None;

                    if (!Enum.IsDefined(typeof(EFileNameExtension), strExtension))
                    {
                        LogSender.SendLog(ELogType.Error, "This extension does not exist in the EFileNameExtension.");
                        return extension;
                    }

                    extension = (EFileNameExtension)Enum.Parse(typeof(EFileNameExtension), strExtension);
                    return extension;
                }
            }
        }
    }
}