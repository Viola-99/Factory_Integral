using System.Collections;
using System.Collections.Generic;
using UnityEngine.EventSystems;
using UnityEngine;

public class Factory : Building
{
    [Space]
    [SerializeField] private int maxWorkersCount = 20;
    [SerializeField] private int currentWorkersCount = 0;
    [SerializeField] private float addOneWorkerTime = 3f;
    [Space]
    [SerializeField] private Resource producingResource;
    [SerializeField] private float baseProducingTime = 2f;
    [SerializeField] private float productionUpdateRate = 0.5f;

    private void Start()
    {
        StartCoroutine(BuildInit());
    }

    private IEnumerator BuildInit()
    {
        yield return new WaitUntil(() => isBuilded);
        StartCoroutine(AddingWorkersRoutine(addOneWorkerTime));
        StartCoroutine(ProductionRoutine());
    }

    private void OnMouseDown()
	{
        if(isBuilded)
        {
            UIManager.I.buildingUIPanel.FillBuildingPanelWithInfo(this, currentWorkersCount, maxWorkersCount, 2);
            UIManager.I.buildingUIPanel.InverseBuildingUIPanel();
        }
	}

    private IEnumerator AddingWorkersRoutine(float addTime)
    {
        while(currentWorkersCount < maxWorkersCount)
        {
            yield return new WaitForSeconds(addTime);
            currentWorkersCount++;
            UIManager.I.buildingUIPanel.UpdateInfo(this, currentWorkersCount);
        }
    }

    private IEnumerator ProductionRoutine()
    {
        float productionProgress = 0;
        while (true)
        {
            yield return new WaitForSeconds(productionUpdateRate);
            productionProgress += (productionUpdateRate / baseProducingTime) * ((float)currentWorkersCount / (float)maxWorkersCount);

            if(productionProgress >= 1)
            {
                productionProgress--;
                GameManager.I.ChangeResourceCount(producingResource, +1);
            }
        }
    }
}
