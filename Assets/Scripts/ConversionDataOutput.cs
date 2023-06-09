using AppsFlyerSDK;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ConversionDataOutput : MonoBehaviour, IAppsFlyerConversionData
{
    public TextMeshProUGUI conData;

    void Start()
    {
        conData = GameObject.Find("ConversionData").GetComponent<TextMeshProUGUI>();

        /* AppsFlyer.setDebugLog(true); */
        AppsFlyer.initSDK("devkey", "appID", this);
        AppsFlyer.startSDK();
    }

    public void onConversionDataSuccess(string conversionData)
    {
        AppsFlyer.AFLog("onConversionDataSuccess", conversionData);
        Dictionary<string, object> conversionDataDictionary = AppsFlyer.CallbackStringToDictionary(conversionData);
        // add deferred deeplink logic here

       conData.text = conversionData.ToString();
        print(conversionData);
    }
    public void onConversionDataFail(string error)
    {
        AppsFlyer.AFLog("onConversionDataFail", error);
    }

    public void onAppOpenAttribution(string attributionData)
    {
        AppsFlyer.AFLog("onAppOpenAttribution", attributionData);
        Dictionary<string, object> attributionDataDictionary = AppsFlyer.CallbackStringToDictionary(attributionData);
        // add direct deeplink logic here
    }

    public void onAppOpenAttributionFailure(string error)
    {
        AppsFlyer.AFLog("onAppOpenAttributionFailure", error);
    }
}
