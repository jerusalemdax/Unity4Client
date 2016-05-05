using UnityEngine;
using UnityEditor;

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

    public Object LoadResource(string path)
    {
        return AssetDatabase.LoadAssetAtPath("Assets/Prefabs/" + path, typeof(GameObject));
    }
}
