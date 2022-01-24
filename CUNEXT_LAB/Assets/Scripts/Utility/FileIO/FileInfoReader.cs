using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static System.IO.Directory;
using CUNEXT.Utility.Enums;

namespace CUNEXT
{
    namespace Utility
    {
        namespace FileIO
        {
            public static class FileInfoReader
            {
                public static List<FileInformation> GetFileInfos(string folderPath)
                {
                    if (!Exists(folderPath))
                    {
                        LogSender.SendLog(ELogType.Error, "A path that doesn't exist.");
                        return new List<FileInformation>();
                    }

                    System.IO.DirectoryInfo di = new System.IO.DirectoryInfo(folderPath);

                    List<FileInformation> fileInfos = new List<FileInformation>();
                    
                    foreach (var file in di.GetFiles())
                    {
                        if(!file.Exists)
                        {
                            LogSender.SendLog(ELogType.Error, "A file that doesn't exist.");
                            continue;
                        }

                        if (string.IsNullOrEmpty(file.Name))
                        {
                            LogSender.SendLog(ELogType.Warning, "There is no file name.");
                            continue;
                        }

                        if(string.IsNullOrEmpty(file.DirectoryName))
                        {
                            LogSender.SendLog(ELogType.Warning, "There is no path name.");
                            continue;
                        }

                        EFileNameExtension extension = ExtensionClassifier.Classifying(file);
                        if (extension == EFileNameExtension.None)
                            continue;

                        fileInfos.Add(new FileInformation(file.Name, file.DirectoryName, extension));
                    }

                    if (fileInfos == null || fileInfos.Count <= 0)
                    {
                        LogSender.SendLog(ELogType.Warning, "No files have been added.");
                        return new List<FileInformation>();
                    }

                    return fileInfos;
                }
            }
        }
    }
}