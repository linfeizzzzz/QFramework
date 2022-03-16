/****************************************************************************
 * Copyright (c) 2015 - 2022 liangxiegame UNDER MIT License
 * 
 * http://qframework.io
 * https://github.com/liangxiegame/QFramework
 ****************************************************************************/

using System;
using System.IO;

namespace QFramework
{
#if UNITY_EDITOR
    [ClassAPI("FluentAPI.CSharp", "System.IO", 2)]
    [APIDescriptionCN("针对 System.Collections 提供的链式扩展，理论上任何集合都可以使用")]
    [APIDescriptionEN("The chain extension provided by System.Collections can theoretically be used by any collection")]
#endif
    public static class SystemIOExtension
    {
#if UNITY_EDITOR
        // V1 No.10
        [MethodAPI]
        [APIDescriptionCN("创建文件夹,如果存在则不创建")]
        [APIDescriptionEN("Create folder or not if it exists")]
        [APIExampleCode(@"
var testDir = ""Assets/TestFolder"";
testDir.CreateDirIfNotExists();"
        )]
#endif
        public static string CreateDirIfNotExists(this string dirFullPath)
        {
            if (!Directory.Exists(dirFullPath))
            {
                Directory.CreateDirectory(dirFullPath);
            }

            return dirFullPath;
        }

#if UNITY_EDITOR
        // V1 No.11
        [MethodAPI]
        [APIDescriptionCN("删除文件夹，如果存在")]
        [APIDescriptionEN("Delete the folder if it exists")]
        [APIExampleCode(@"
var testDir =""Assets/TestFolder"";
testDir.DeleteDirIfExists();
        ")]
#endif
        public static void DeleteDirIfExists(this string dirFullPath)
        {
            if (Directory.Exists(dirFullPath))
            {
                Directory.Delete(dirFullPath, true);
            }
        }

#if UNITY_EDITOR
        // V1 No.12
        [MethodAPI]
        [APIDescriptionCN("清空 Dir（保留目录),如果存在")]
        [APIDescriptionEN("Clear Dir (reserved directory), if exists")]
        [APIExampleCode(@"
var testDir = ""Assets/TestFolder"";
testDir.EmptyDirIfExists();
        ")]
#endif
        public static void EmptyDirIfExists(this string dirFullPath)
        {
            if (Directory.Exists(dirFullPath))
            {
                Directory.Delete(dirFullPath, true);
            }

            Directory.CreateDirectory(dirFullPath);
        }

#if UNITY_EDITOR
        // V1 No.13
        [MethodAPI]
        [APIDescriptionCN("删除文件 如果存在")]
        [APIDescriptionEN("Delete the file if it exists")]
        [APIExampleCode(@"
var filePath = ""Assets/Test.txt"";
File.Create(""Assets/Test"");
filePath.DeleteFileIfExists();
        ")]
#endif
        public static bool DeleteFileIfExists(this string fileFullPath)
        {
            if (File.Exists(fileFullPath))
            {
                File.Delete(fileFullPath);
                return true;
            }

            return false;
        }


#if UNITY_EDITOR
        // V1 No.14
        [MethodAPI]
        [APIDescriptionCN("合并路径")]
        [APIDescriptionEN("Combine path")]
        [APIExampleCode(@"
var path = Application.dataPath.CombinePath(""Resources"");
Debug.Log(Path)
// projectPath/Assets/Resources
        ")]
#endif
        public static string CombinePath(this string selfPath, string toCombinePath)
        {
            return Path.Combine(selfPath, toCombinePath);
        }


#if UNITY_EDITOR
        // V1 No.15
        [MethodAPI]
        [APIDescriptionCN("根据路径获取文件名")]
        [APIDescriptionEN("get file name by path")]
        [APIExampleCode(@"
var fileName =""/abc/def/b.txt"".GetFileName();
Debug.Log(fileName0);
// b.txt
        ")]
#endif
        public static string GetFileName(this string filePath)
        {
            return Path.GetFileName(filePath);
        }

#if UNITY_EDITOR
        // V1 No.16
        [MethodAPI]
        [APIDescriptionCN("根据路径获取文件名，不包含文件扩展名")]
        [APIDescriptionEN("Get the file name based on the path, excluding the file name extension")]
        [APIExampleCode(@"
var fileName =""/abc/def/b.txt"".GetFileNameWithoutExtend();
Debug.Log(fileName0);
// b
        ")]
#endif

        public static string GetFileNameWithoutExtend(this string filePath)
        {
            return Path.GetFileNameWithoutExtension(filePath);
        }

#if UNITY_EDITOR
        // V1 No.17
        [MethodAPI]
        [APIDescriptionCN("根据路径获取文件扩展名")]
        [APIDescriptionEN("Get the file extension based on the path")]
        [APIExampleCode(@"
var fileName =""/abc/def/b.txt"".GetFileExtendName();
Debug.Log(fileName0);
// .txt
        ")]
#endif
        public static string GetFileExtendName(this string filePath)
        {
            return Path.GetExtension(filePath);
        }
    }
}