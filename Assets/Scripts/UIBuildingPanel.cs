using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIBuildingPanel : MonoBehaviour
{
	[SerializeField] private Text workersCountText;
	[SerializeField] private Text productionSpeedText;

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

	public void FillBuildingPanelWithInfo(int workersCount, int maxWorkersCount, float productionSpeed)
    {
        workersCountText.text = workersCount.ToString() + "/" + maxWorkersCount.ToString();
        productionSpeedText.text = productionSpeed.ToString() + " unit(s)/sec";
    }
}
