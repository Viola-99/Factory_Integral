using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    public static UIManager I;
    private void Awake()
    {
        I = this;
    }

    [SerializeField] public UIBuildingPanel buildingUIPanel;
    [SerializeField] private GameObject marketUI;

    private void Start()
    {
        marketUI.SetActive(false);
        buildingUIPanel.gameObject.SetActive(false);
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
