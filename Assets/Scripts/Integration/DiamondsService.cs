using Integration;
using UnityEngine;
using UnityEngine.UI;
using Zenject;

public class DiamondsService : MonoBehaviour
{
    [SerializeField] private Button closeButton;
    [SerializeField] private GameObject panel;
    
    public int Diamonds => PlayerPrefs.GetInt("Diamond", 0);
    
    public void AddDiamonds(int count)
    {
        PlayerPrefs.SetInt("Diamond" , Diamonds + count);
        PlayerPrefs.Save();
    }
    
    private void OnEnable()
    {
        closeButton.onClick.AddListener(HideSubscriptionPanel);
    }

    private void OnDisable()
    {
        closeButton.onClick.RemoveListener(HideSubscriptionPanel);
    }
    
    public void ShowSubscriptionPanel()
    {
        panel.SetActive(true);
    }
        
    public void HideSubscriptionPanel()
    {
        panel.SetActive(false);
    }
}