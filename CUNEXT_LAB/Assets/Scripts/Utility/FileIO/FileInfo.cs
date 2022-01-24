using CUNEXT.Utility.Enums;

namespace CUNEXT
{
    namespace Utility
    {
        namespace FileIO
        {
            public class FileInfo
            {
                string name = "Please name the file.";
                string pathName = "Please name the pathName.";
                EFileNameExtension extension = EFileNameExtension.None;

                string tagName;

                public FileInfo(string name, string pathName, EFileNameExtension extension, string tagName = "None")
                {
                    this.name = name;
                    this.pathName = pathName;
                    this.extension = extension;
                    this.tagName = tagName;
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

                public string GetTagName()
                {
                    if (this == null)
                        LogSender.SendLog(ELogType.Error, "Initialization has not been done properly");
                    return tagName;
                }
            }
        }
    }
}