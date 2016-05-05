using UnityEditor;
using UnityEngine;

public class UnityBuildTool{

    [MenuItem("Build/Windows")]
	public static void BuildWindows ()
    {
        BuildPipeline.BuildPlayer(new []{ "Assets/Scenes/Start.unity" }, Application.dataPath + "/../Build/StandaloneWindows/Client.exe", BuildTarget.StandaloneWindows, BuildOptions.None);
    }
}
