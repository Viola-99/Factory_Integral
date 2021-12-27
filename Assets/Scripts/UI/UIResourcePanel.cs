using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIResourcePanel : MonoBehaviour
{
    [SerializeField] private Text nameText;
    [SerializeField] private Text countText;

    private int resCount = -1;

    public void SetupPanel(string newResourceName, int newResourceCount)
    {
        nameText.text = newResourceName + "s:";
        UpdateResourceAmount(newResourceCount);
    }

    public void UpdateResourceAmount(int newResourceCount)
    {
        if(resCount != newResourceCount)
        {
            resCount = newResourceCount;
            countText.text = newResourceCount.ToString();
        }
    }
}
