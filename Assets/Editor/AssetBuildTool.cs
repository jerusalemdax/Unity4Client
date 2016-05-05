using UnityEditor;
using UnityEngine;

public class AssetBuildTool{

    [MenuItem("Build/Resources")]
	public static void BuildBundle ()
    {
        var go = AssetDatabase.LoadAssetAtPath("Assets/Prefabs/UpdatePanel.prefab", typeof(GameObject));
        BuildPipeline.BuildAssetBundle(go, null, Application.streamingAssetsPath + "/UpdatePanel.prefab.unity3d", BuildAssetBundleOptions.DeterministicAssetBundle | BuildAssetBundleOptions.CollectDependencies | BuildAssetBundleOptions.CompleteAssets, BuildTarget.StandaloneWindows);
    }
}
