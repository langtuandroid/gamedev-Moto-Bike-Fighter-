using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Button))]
public class Level : MonoBehaviour
{
    [SerializeField, Range(1, 10)] private int levelNumber;
    [SerializeField] private TextMeshProUGUI levelNumberText;

    [SerializeField] private GameObject lockIcon;

    private Button _button;

    private void Awake()
    {
        _button = GetComponent<Button>();
    }

    private void Start()
    {
        levelNumberText.text = levelNumber.ToString();
    }

    public void Unlock()
    {
        lockIcon.gameObject.SetActive(false);
        levelNumberText.gameObject.SetActive(true);

        _button.interactable = true;
    }

    public void Lock()
    {
        lockIcon.gameObject.SetActive(true);
        levelNumberText.gameObject.SetActive(false);
        
        _button.interactable = false;
    }
}
