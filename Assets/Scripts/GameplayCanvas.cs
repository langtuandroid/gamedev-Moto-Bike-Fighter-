using System;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameplayCanvas : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI coinsText;

    private void Update()
    {
        coinsText.text = PlayerPrefs.GetInt("score") + "$";
    }

    public void ToSelectLevelsScene()
    {
        SceneManager.LoadScene(2);
    }
}
