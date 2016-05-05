using UnityEngine;

class UpdateManager
{
    private static UpdateManager _instance;

    public static UpdateManager Instance
    {
        get
        {
            if (_instance == null)
            {
                _instance = new UpdateManager();
            }
            return _instance;
        }
    }

    public void Start()
    {
        Debug.Log("UpdateManager Start");
        ResourceManager.Instance.LoadResource("UpdatePanel.prefab", obj =>
        {
            if (obj != null)
            {
                GameObject go = Object.Instantiate(obj) as GameObject;
                if (go != null)
                {
                    go.name = obj.name;
                    go.transform.SetParent(GameObject.Find("UI").transform, false);
                }
            }
        });
    }

    public void OnDestroy()
    {
        Debug.Log("UpdateManager OnDestroy");
    }
}
