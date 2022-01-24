using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CUNEXT.Utility;

public class FilePathList : MonoBehaviour
{
    [SerializeField]
    List<string> pathList;

    [SerializeField]
    string tagName;

    public FilePathList()
    {
        pathList = new List<string>();
        tagName = "None";
    }

    public List<string> GetPathList()
    {
        if (this == null || pathList == null)
        {
            LogSender.SendLog(CUNEXT.Utility.Enums.ELogType.Error, "FilePathList is not properly initialized.");
            return new List<string>();
        }

        if(pathList.Count <= 0)
        {
            LogSender.SendLog(CUNEXT.Utility.Enums.ELogType.Log, "PathList is empty.");
            return new List<string>();
        }

        return pathList;
    }

    public string GetTagName()
    {
        if (this == null)
        {
            LogSender.SendLog(CUNEXT.Utility.Enums.ELogType.Error, "FilePathList is not properly initialized.");
            return string.Empty;
        }

        if (string.IsNullOrEmpty(tagName))
        {
            LogSender.SendLog(CUNEXT.Utility.Enums.ELogType.Log, "PathList is empty.");
            return string.Empty;
        }

        if (tagName == "None")
        {
            LogSender.SendLog(CUNEXT.Utility.Enums.ELogType.Log, "Please give a name to tag");
            return string.Empty;
        }

        return tagName;
    }
}