using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIMarket : MonoBehaviour
{
    [SerializeField] UISellingElement[] sellingElements;

    void Start()
    {
        UpdateMarketUI();
    }

    public void UpdateMarketUI()
    {
        List<Resource> res = GameManager.I.GetResourceTypes();

        for (int i = 0; i < sellingElements.Length; i++)
        {
            if (i < res.Count)
            {
                sellingElements[i].gameObject.SetActive(true);
                sellingElements[i].Setup(res[i]);
            }
            else
            {
                sellingElements[i].gameObject.SetActive(false);
            }
        }
    }
}
