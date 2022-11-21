using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Advertisements;

public class AdsManager : MonoBehaviour, IUnityAdsInitializationListener
{
    public string androidID;
    public string iOsID;
    public bool testMode;

    public void OnInitializationComplete()
    {
        Debug.Log("Initialization completed.");
    }

    public void OnInitializationFailed(UnityAdsInitializationError error, string message)
    {
        Debug.Log("Initialization failed " + message);
    }

    private void Start()
    {
        Init();
    }

    public void Init()
    {
        string id;
        if (Application.platform == RuntimePlatform.IPhonePlayer)
        {
            id = iOsID;
        }
        else
        {
            id = androidID;
        }
        Advertisement.Initialize(id, testMode, this);
    }
}