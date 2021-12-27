using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIBuildingPanel : MonoBehaviour
{
	private Building currentBuilding;

	[SerializeField] private Text workersCountText;
	[SerializeField] private Text productionSpeedText;

	private int maxWorkersCount = 0;

	public void InverseBuildingUIPanel()
	{
		if (gameObject.activeSelf)
		{
			gameObject.SetActive(false);
		}
		else
		{
			gameObject.SetActive(true);
		}
	}

	public void FillBuildingPanelWithInfo(Building building, int workersCount, int maxWorkersCount, float productionSpeed)
    {
		currentBuilding = building;
		this.maxWorkersCount = maxWorkersCount;
        workersCountText.text = workersCount.ToString() + "/" + maxWorkersCount.ToString();
        productionSpeedText.text = productionSpeed.ToString() + " unit(s)/sec";
    }

	public void UpdateInfo(Building building, int workersCount)
	{
		if(gameObject.activeSelf)
		{
			if(currentBuilding == building)
			{
				workersCountText.text = workersCount.ToString() + "/" + maxWorkersCount.ToString();
			}
		}
	}
}
