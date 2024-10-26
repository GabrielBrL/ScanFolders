using Newtonsoft.Json;

namespace ScanFolders;

public static class ScanFolder
{
    /// <summary>
    /// 
    /// </summary>
    /// <param name="path">Path</param>
    /// <param name="extension">File extension that you will search</param>
    /// <returns> 
    /// Return a json having Directory name, File name, File path and Length of each file
    /// - <c>DirectoryName</c>: The directory name where the file is.
    /// - <c>FileName</c>: File Name.
    /// - <c>FilePath</c>: Complete file path.
    /// - <c>Length</c>: Length of the file in bytes.
    /// </returns>
    public static string GetFiles(string path, string extension = "*")
    {
        DirectoryInfo directoryInfo = new DirectoryInfo(path);
        var files = directoryInfo.GetFiles($"*.{extension}", SearchOption.AllDirectories);
        var filesFormated = files.Select(x => new { DirectoryName = x.Directory?.Name, FileName = x.Name, FilePath = x.FullName, Length = x.Length });
        return JsonConvert.SerializeObject(filesFormated);
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="path">Path</param>
    /// <param name="folderName">Folder name</param>
    /// <returns>
    /// Return a json having Directory name and Directory path
    /// - <c>DirectoryName</c>: The directory name.
    /// - <c>DirectoryPath</c>: Complete folder path.    
    /// </returns>
    public static string GetDirectories(string path, string folderName = "")
    {
        DirectoryInfo directoryInfo = new DirectoryInfo(path);
        var files = directoryInfo.GetDirectories($"{folderName}*", SearchOption.AllDirectories);
        var filesFormated = files.Select(x => new { DirectoryName = x.Name, DirectoryPath = x.FullName });
        return JsonConvert.SerializeObject(filesFormated);
    }

}
