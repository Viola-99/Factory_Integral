using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UISellingElement : MonoBehaviour
{
    [SerializeField] private Image icon;
    [SerializeField] private Text itemName;
    [SerializeField] private Text wholeAmountText;
    [SerializeField] private Text costOfOneText;
    [SerializeField] private Text selectItemsToSellText;
    [SerializeField] private Text priceForSelectedText;

    private Resource item;
    private int wholeItemsAmount;
    private int selectedItemsToSell = 0;

    public void Setup(Resource _item)
    {
        item = _item;
        icon.sprite = item.icon;
        itemName.text = item.resourceName;
        costOfOneText.text = item.baseSellPrice.ToString() + "$";

        wholeItemsAmount = GameManager.I.GetResourceCount(item);
        wholeAmountText.text = wholeItemsAmount.ToString();

        ChangeSelectedAmount(0);
    }

    public void ChangeSelectedAmount(int changeCount)
    {
        if(selectedItemsToSell + changeCount >= 0)
        {
            if (selectedItemsToSell + changeCount <= wholeItemsAmount)
            {
                selectedItemsToSell += changeCount;
            }
            else
            {
                selectedItemsToSell = wholeItemsAmount;
            }
        }
        else
        {
            selectedItemsToSell = 0;
        }
        selectItemsToSellText.text = selectedItemsToSell.ToString();
        priceForSelectedText.text = (selectedItemsToSell * item.baseSellPrice).ToString() + "$";
    }

    public void SellSelected()
    {
        GameManager.I.ChangeMoney(+selectedItemsToSell * item.baseSellPrice);
        GameManager.I.ChangeResourceCount(item, -selectedItemsToSell);
        selectedItemsToSell = 0;

        selectItemsToSellText.text = selectedItemsToSell.ToString();
        priceForSelectedText.text = "0$";
    }

    void Update()
    {
        if(item != null)
        {
            if(wholeItemsAmount != GameManager.I.GetResourceCount(item))
            {
                wholeItemsAmount = GameManager.I.GetResourceCount(item);
                wholeAmountText.text = wholeItemsAmount.ToString();
            }
        }
    }
}
