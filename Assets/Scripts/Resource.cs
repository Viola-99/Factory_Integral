using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Resource", menuName = "Custom/Resource")]
public class Resource : ScriptableObject
{
    [SerializeField] public Sprite icon;
    [SerializeField] public string resourceName;
    [SerializeField] public int baseSellPrice;
}
