using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Advertisements;

public class Script_BannerAd : MonoBehaviour
{
    [SerializeField] private BannerPosition _bannerPosition = BannerPosition.BOTTOM_CENTER; // Edit in Inspector

    [SerializeField] private string _androidAdUnitId = "Banner_Android";
    [SerializeField] private string _iOSAdUnitId = "Banner_iOS";
    private string _adUnitId;

    private void Awake()
    {
        // Get the Ad Unit ID for the current platform:
        _adUnitId = (Application.platform == RuntimePlatform.IPhonePlayer)
            ? _iOSAdUnitId
            : _androidAdUnitId;
    }

    private void Start()
    {
        // Disable the button until an ad is ready to show:
        //_showBannerButton.interactable = false; >>>>>>>>> COMMENTED OUT
        //_hideBannerButton.interactable = false; >>>>>>>>> COMMENTED OUT

        // Set the banner position:
        Advertisement.Banner.SetPosition(_bannerPosition);

        // Configure the Load Banner button to call the LoadBanner() method when clicked:
        //_loadBannerButton.onClick.AddListener(LoadBanner); >>>>>>>>> COMMENTED OUT
        //_loadBannerButton.interactable = true; >>>>>>>>> COMMENTED OUT
        LoadBanner(); // >>>>>>>>> ADDED IN TUTORIAL
    }

    // Implement a method to call when the Load Banner button is clicked:
    public void LoadBanner()
    {
        // Set up options to notify the SDK of load events:
        BannerLoadOptions options = new BannerLoadOptions
        {
            loadCallback = OnBannerLoaded,
            errorCallback = OnBannerError
        };

        // Load the Ad Unit with banner content:
        Advertisement.Banner.Load(_adUnitId, options);
    }

    // Implement code to execute when the loadCallback event triggers:
    private void OnBannerLoaded()
    {
        Debug.Log("Banner loaded");

        // Configure the Show Banner button to call the ShowBannerAd() method when clicked:
        //_showBannerButton.onClick.AddListener(ShowBannerAd); >>>>>>>>> COMMENTED OUT
        // Configure the Hide Banner button to call the HideBannerAd() method when clicked:
        //_hideBannerButton.onClick.AddListener(HideBannerAd); >>>>>>>>> COMMENTED OUT

        // Enable both buttons:
        //_showBannerButton.interactable = true; >>>>>>>>> COMMENTED OUT
        //_hideBannerButton.interactable = true; >>>>>>>>> COMMENTED OUT
    }

    // Implement code to execute when the load errorCallback event triggers:
    private void OnBannerError(string message)
    {
        Debug.Log($"Banner Error: {message}");
        // Optionally execute additional code, such as attempting to load another ad.
    }

    // Implement a method to call when the Show Banner button is clicked:
    public void ShowBannerAd()
    {
        // Set up options to notify the SDK of show events:
        BannerOptions options = new BannerOptions
        {
            clickCallback = OnBannerClicked,
            hideCallback = OnBannerHidden,
            showCallback = OnBannerShown
        };

        // Show the loaded Banner Ad Unit:
        Advertisement.Banner.Show(_adUnitId, options);
    }

    // Implement a method to call when the Hide Banner button is clicked:
    private void HideBannerAd()
    {
        // Hide the banner:
        Advertisement.Banner.Hide();
    }

    private void OnBannerClicked()
    { }

    private void OnBannerShown()
    { }

    private void OnBannerHidden()
    { }

    private void OnDestroy()
    {
        // Clean up the listeners:
        //_loadBannerButton.onClick.RemoveAllListeners(); >>>>>>>>> COMMENTED OUT
        //_showBannerButton.onClick.RemoveAllListeners(); >>>>>>>>> COMMENTED OUT
        //_hideBannerButton.onClick.RemoveAllListeners(); >>>>>>>>> COMMENTED OUT
    }
} // end of class