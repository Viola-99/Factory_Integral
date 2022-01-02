using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public static UIManager I;
    private void Awake()
    {
        I = this;
    }

    [SerializeField] Text moneyText;
    [Space]
    [SerializeField] public UIBuildingPanel buildingUIPanel;
    [SerializeField] public UIResourcesTab resourcesTab;
    [SerializeField] private UIMarket marketUI;

    private void Start()
    {
        marketUI.gameObject.SetActive(false);
        buildingUIPanel.gameObject.SetActive(false);
    }

    public void UpdateMoneyTextUI(float newValue)
    {
        moneyText.text = newValue.ToString() + " $";
    }

    public void OnMarketButtonPress()
    {
        marketUI.gameObject.SetActive(true);
        marketUI.UpdateMarketUI();
    }

    public void OnReturn()
    {
        marketUI.gameObject.SetActive(false);
    }
}
