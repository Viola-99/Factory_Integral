using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIResourcesTab : MonoBehaviour
{
    [SerializeField] private SerializableDictionary<Resource, UIResourcePanel> resourcePanels;

    void Start()
    {
        foreach (var i in resourcePanels)
        {
            i.Value.SetupPanel(i.Key.resourceName, 0);
        }
    }

    public void UpdateResource(Resource targetResource, int newAmount)
    {
        resourcePanels[targetResource].UpdateResourceAmount(newAmount);
    }
}
