using UnityEngine;
using System;
using System.Collections;
#if UNITY_EDITOR
using UnityEditor;
#endif
using Object = UnityEngine.Object;

public class ResourceManager{

    private static ResourceManager _instance;

    public static ResourceManager Instance
    {
        get
        {
            if (_instance == null)
            {
                _instance = new ResourceManager();
            }
            return _instance;
        }
    }

    public void LoadResource(string path, Action<Object> callback)
    {
#if UNITY_EDITOR
        callback(AssetDatabase.LoadAssetAtPath("Assets/Prefabs/" + path, typeof(GameObject)));
#else
        Main.StartCoroutineFunc(LoadResourceCor(path, callback));
#endif
    }

    public IEnumerator LoadResourceCor(string path, Action<Object> callback)
    {
        string fullPath = "file:///" + Application.streamingAssetsPath + "/" + path + ".unity3d";
        WWW www = new WWW(fullPath);
        yield return www;
        if (www.isDone)
        {
            if (string.IsNullOrEmpty(www.error))
            {
                callback(www.assetBundle.mainAsset);
            }
            else
            {
                Debug.LogError("Load resource error: " + www.error);
            }
        }
        else
        {
            Debug.LogError("Load resource error: is done is false");
        }
    }
}
