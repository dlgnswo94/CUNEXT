using CUNEXT.Utility.Enums;

namespace CUNEXT
{
    namespace Utility
    {
        namespace FileIO
        {
            public class FileInformation
            {
                string name = "Please name the file.";
                string pathName = "Please name the pathName.";
                EFileNameExtension extension = EFileNameExtension.None;

                public FileInformation(string name, string pathName, EFileNameExtension extension)
                {
                    this.name = name;
                    this.pathName = pathName;
                    this.extension = extension;
                }

                public string GetName()
                {
                    if (this == null || string.IsNullOrEmpty(name))
                        LogSender.SendLog(ELogType.Error, "Initialization has not been done properly");
                    return name;
                }

                public string GetPathName()
                {
                    if (this == null || string.IsNullOrEmpty(pathName))
                        LogSender.SendLog(ELogType.Error, "Initialization has not been done properly");
                    return pathName;
                }

                public EFileNameExtension GetExtension()
                {
                    if (this == null)
                        LogSender.SendLog(ELogType.Error, "Initialization has not been done properly");
                    return extension;
                }
            }
        }
    }
}