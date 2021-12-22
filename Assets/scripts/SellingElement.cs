using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SellingElement : MonoBehaviour
{
    [SerializeField] private Image icon;
    [SerializeField] private Text itemName;
    [SerializeField] private Text wholeAmountText;
    [SerializeField] private Text costOfOneText;
    [SerializeField] private Text selectItemsToSellText;
    [SerializeField] private Text priceForSelectedText;

    private Item item;
    private int wholeItemsAmount;
    private int selectedItemsToSell = 0;

    public void Setup(Item _item)
    {
        item = _item;
        icon.sprite = item.icon;
        itemName.text = item.itemName;
        costOfOneText.text = item.sellPrice.ToString() + "$";

        if(GameManager.instance.items.ContainsKey(item))
        {
            wholeItemsAmount = GameManager.instance.items[item];

            wholeAmountText.text = wholeItemsAmount.ToString();
        }
    }

    public void ChangeSelectedAmount(int changeCount)
    {
        if(selectedItemsToSell + changeCount <= wholeItemsAmount)
        {
            selectedItemsToSell += changeCount;
            selectItemsToSellText.text = selectedItemsToSell.ToString();
            priceForSelectedText.text = (selectedItemsToSell * item.sellPrice).ToString() + "$";
        }
    }

    public void SellSelected()
    {
        GameManager.instance.ChangeMoney(+selectedItemsToSell * item.sellPrice);
        selectedItemsToSell = 0;

        selectItemsToSellText.text = selectedItemsToSell.ToString();
        priceForSelectedText.text = "0$";
    }

    void Update()
    {
        if(item != null)
        {
            if (GameManager.instance.items.ContainsKey(item))
            {
                if(wholeItemsAmount != GameManager.instance.items[item])
                {
                    wholeItemsAmount = GameManager.instance.items[item];
                    wholeAmountText.text = wholeItemsAmount.ToString();
                }
            }
        }
    }
}
