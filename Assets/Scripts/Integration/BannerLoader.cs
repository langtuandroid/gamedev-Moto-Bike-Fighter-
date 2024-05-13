using System;
using Integration;
using JetBrains.Annotations;
using UnityEngine;
using Zenject;

namespace AdsManager
{
    public class BannerLoader : MonoBehaviour
    {
        [Inject] private AdMobController adMobController;
        [Inject] private IAPService iapService;

        [SerializeField] private bool showAd = true;
        
        [SerializeField, CanBeNull] private RectTransform upToUp;
        [SerializeField] private float bannerHeight = 60; 

        private void Start()
        {
            if (showAd)
            {
                if (iapService.SubscriptionCanvas.activeSelf)
                {
                    return;
                }
                
                adMobController.RequestBanner();
                adMobController.ShowBanner(true);
                if (upToUp != null) upToUp.anchoredPosition = new Vector3(upToUp.anchoredPosition.x, bannerHeight);
            }
            else
            {
                adMobController.ShowBanner(false);
            }
        }

        private void Update()
        {
            if (showAd == false)
            {
                adMobController.ShowBanner(false);
            }
        }
    }
}