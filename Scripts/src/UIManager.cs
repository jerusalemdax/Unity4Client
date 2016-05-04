using UnityEngine;
using UnityEngine.UI;

class UIManager
{
    private static UIManager _instance;
    private UIManager() { }
    public static UIManager Instance
    {
        get
        {
            if (_instance == null)
            {
                _instance = new UIManager();
            }
            return _instance;
        }
    }

    public void Start()
    {
        Debug.Log("UIManager Start");
        GameObject go = new GameObject("UI");
        Canvas canvas = go.AddComponent<Canvas>();
        canvas.renderMode = RenderMode.ScreenSpaceOverlay;
        CanvasScaler scaler = go.AddComponent<CanvasScaler>();
        scaler.uiScaleMode = CanvasScaler.ScaleMode.ScaleWithScreenSize;
        scaler.referenceResolution = new Vector2(960, 640);
        scaler.screenMatchMode = CanvasScaler.ScreenMatchMode.MatchWidthOrHeight;
        scaler.matchWidthOrHeight = 1.0f;
    }

    public void OnDestroy()
    {
        Debug.Log("UIManager OnDestroy");
    }
}
