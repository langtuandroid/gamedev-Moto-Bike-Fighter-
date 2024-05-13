using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using Zenject;

public class Counter : MonoBehaviour
{
    [Inject] private DiamondsService diamondsService;

    [SerializeField] private TextMeshProUGUI text;
    [SerializeField] private Button button;

    private void OnEnable()
    {
        button.onClick.AddListener(diamondsService.ShowSubscriptionPanel);
    }

    private void Update()
    {
        text.text = diamondsService.Diamonds.ToString();
    }
    
    
    
    private void OnDisable()
    {
        button.onClick.RemoveListener(diamondsService.ShowSubscriptionPanel);
    }
}
