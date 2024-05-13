using System;
using System.Collections;
using System.Collections.Generic;
using Integration;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using Zenject;

public class LoadingScreenManager : MonoBehaviour
{
    public static LoadingScreenManager instance;

    [Inject] private AdMobController _adMobController;
    
    [SerializeField] private TextMeshProUGUI text;

    private const string LoadingText = "Loading ";

    private void Awake()
    {
        instance = this;
        gameObject.SetActive(false);
    }

    public void LoadScene(int index)
    {
        if (index >= 3)
        {
            _adMobController.TryToShowInterstitialAd(out bool showed, (() =>
            {
                gameObject.SetActive(true);
                StartCoroutine(LoadSceneAsynchronously(index));
            }));

            if (showed)
            {
                return;
            }
        }

        gameObject.SetActive(true);
        StartCoroutine(LoadSceneAsynchronously(index));
    }
    
    private IEnumerator LoadSceneAsynchronously(int index)
    {
        AsyncOperation operation = SceneManager.LoadSceneAsync(index);

        while (!operation.isDone)
        {
            float progress = Mathf.Clamp01(operation.progress / 0.9f);

            // Update slider and text
            text.text = LoadingText + Mathf.RoundToInt(progress * 100f) + "%";

            yield return null;
        }
    }
}
