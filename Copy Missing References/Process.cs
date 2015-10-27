using System.IO;
using System.Text.RegularExpressions;

namespace Copy_Missing_References
{
  public class Process
  {
    public string ErrorMessage { get; set; }
    public string MissingFile { get; private set; }
    public string CopyFile { get; private set; }

    #region Preprocess

    public void Preprocess()
    {
      if (ComputeMissingFile()) return;

      var name = Path.GetFileName(MissingFile);
      if (name == null) return;

      var copyFromPath = Path.Combine(ComputeCasellePath(MissingFile), name);
      CopyFile = copyFromPath;
    }

    private bool ComputeMissingFile()
    {
      var match = Regex.Match(ErrorMessage, "\\\".*\\\"");

      if (match.Groups.Count == 0 || !match.Groups[0].Success)
      {
        match = Regex.Match(ErrorMessage, "'.*'");

        if (match.Groups.Count == 0 || !match.Groups[0].Success) return true;
      }

      MissingFile = match.Groups[0].Value.Trim('\"', '\'');
      return false;
    }

    private static string ComputeCasellePath(string path)
    {
      var info = new DirectoryInfo(path);
      if (info.Parent == null) return string.Empty;

      if (info.Name == "MasterSln") return Path.Combine(info.Parent.FullName, "Caselle");
      return ComputeCasellePath(info.Parent.FullName);
    }

    #endregion


    #region Copy

    public void Copy()
    {
      var missing = Path.GetDirectoryName(MissingFile);
      if (missing == null) return;

      CreateDirectory(missing);

      if (File.Exists(MissingFile)) return;
      File.Copy(CopyFile, MissingFile);
    }

    private static void CreateDirectory(string missingBinDebug)
    {
      if (Directory.Exists(missingBinDebug)) return;

      var root = Directory.GetParent(missingBinDebug).Parent;
      if (root == null) return;

      var bin = root.CreateSubdirectory("bin");
      bin.CreateSubdirectory("Debug");
    }

    #endregion
  }
}
