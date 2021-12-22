using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Item", menuName = "Custom/Item")]
public class Item : ScriptableObject
{
    [SerializeField] public Sprite icon;
    [SerializeField] public string itemName;
    [SerializeField] public int sellPrice;
}
