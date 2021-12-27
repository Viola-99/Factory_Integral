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
    [SerializeField] private GameObject marketUI;

    private void Start()
    {
        marketUI.SetActive(false);
        buildingUIPanel.gameObject.SetActive(false);
    }

    public void UpdateMoneyTextUI(float newValue)
    {
        moneyText.text = newValue.ToString() + " $";
    }

    public void OnMarketButtonPress()
    {
        marketUI.SetActive(true);
    }

    public void OnReturn()
    {
        marketUI.SetActive(false);
    }
}
