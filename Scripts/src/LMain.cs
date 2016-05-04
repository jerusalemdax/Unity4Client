using UnityEngine;

public class LMain
{
	public void Start()
	{
	    Debug.Log("LMain Start");
        UIManager.Instance.Start();
        UpdateManager.Instance.Start();
	}

	public void Update()
	{

	}

	public void OnDestroy()
	{
        UIManager.Instance.OnDestroy();
        UpdateManager.Instance.OnDestroy();
        Debug.Log("LMain OnDestroy");
    }
}