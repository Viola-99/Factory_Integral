using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProcessingFactory : Factory
{
    [Space]
    [SerializeField] private Resource rawResource;
    [SerializeField] private int rawResourcesPerOneProduct = 5;

    protected override IEnumerator ProductionRoutine()
    {
        float productionProgress = 0;
        while (true)
        {
            yield return new WaitForSeconds(productionUpdateRate);
            if(GameManager.I.GetResourceCount(rawResource) >= rawResourcesPerOneProduct)
            {
                productionProgress += (productionUpdateRate / baseProducingTime) * ((float)currentWorkersCount / (float)maxWorkersCount);

                if (productionProgress >= 1)
                {
                    productionProgress--;
                    GameManager.I.ChangeResourceCount(rawResource, -rawResourcesPerOneProduct);
                    GameManager.I.ChangeResourceCount(producingResource, +1);
                }
            }
        }
    }
}
