using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    [SerializeField] private GameObject marketUI;

    private void Start()
    {
        marketUI.SetActive(false);
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
