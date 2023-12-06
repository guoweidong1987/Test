using AppodealStack.Monetization.Api;
using AppodealStack.Monetization.Common;
using UnityEngine;

public class Main : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Appodeal.SetTesting(true);
        Appodeal.SetLogLevel(AppodealLogLevel.Debug);

        int adTypes = AppodealAdType.Interstitial | AppodealAdType.Banner | AppodealAdType.RewardedVideo;
        Appodeal.Initialize("79d58876f945c2505d980ce742825c30a94c31eb27380888", adTypes);

        var adBtn = GetComponentInChildren<UnityEngine.UI.Button>();
        adBtn.onClick.AddListener(() =>
        {
            Appodeal.Show(AppodealShowStyle.Interstitial);
        });
    }
}
