using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadingScreenManager : MonoBehaviour
{
    public static LoadingScreenManager instance;
    
    [SerializeField] private TextMeshProUGUI text;

    private const string LoadingText = "Loading ";

    private void Awake()
    {
        instance = this;
        gameObject.SetActive(false);
    }

    public void LoadScene(int index)
    {
        gameObject.SetActive(true);
        StartCoroutine(LoadSceneAsynchronously(index));
    }
    
    private IEnumerator LoadSceneAsynchronously(int index)
    {
        AsyncOperation operation = SceneManager.LoadSceneAsync(index);

        while (!operation.isDone)
        {
            // Unity loads scenes in the background in range 0.0 to 0.9
            float progress = Mathf.Clamp01(operation.progress / 0.9f);

            // Update slider and text
            text.text = LoadingText + Mathf.RoundToInt(progress * 100f) + "%";

            yield return null;
        }
    }
}
