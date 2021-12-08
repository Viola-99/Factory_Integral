using System.Collections;
using System.Collections.Generic;
using UnityEngine.EventSystems;
using UnityEngine;

public class Factory : Building
{
    private int maxWorkersCount = 20;
    private int currentWorkersCount = 0;


    void OnMouseDown()
	{
        if(isBuilded)
        {
            GameManager.instance.FillBuildingPanelWithInfo(currentWorkersCount, maxWorkersCount, 2);
            GameManager.instance.InverseBuildingUIPanel();
        }
	}

}
