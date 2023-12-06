using System.IO;
using UnityEditor;
using UnityEditor.Callbacks;
using UnityEditor.iOS.Xcode;

namespace Game.Editor
{
    public class BuildPlayer
    {
        [PostProcessBuild(99999)]
        public static void OnPostProcessBuild(BuildTarget buildTarget, string path)
        {
            switch (buildTarget)
            {
                case BuildTarget.iOS:
                    //修改info.plist
                    var plistPath = Path.Combine(path, "Info.plist");
                    var plist = new PlistDocument();
                    plist.ReadFromFile(plistPath);
                    plist.root.SetString("GADApplicationIdentifier", "ca-app-pub-5882480261416236~3510647986");//AdMob App ID
                    plist.WriteToFile(plistPath);
                    break;
            }
        }
    }
}