using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
	public static GameManager instance;
	private void Awake()
	{
		instance = this;
	}

    [SerializeField] Text moneyText;
	[SerializeField] private float money = 10f;

	[SerializeField] private GameObject buildingUIPanel;
	[SerializeField] private Text workersCountText;
	[SerializeField] private Text productionSpeedText;

	public Dictionary<Item, int> items;

    void Start()
	{
		UpdateMoneyTextUI(money);
		buildingUIPanel.SetActive(false);
	}

	public float GetMoney()
	{
		return money;
	}

    public void ChangeMoney(float deltaMoney)
	{
        money += deltaMoney;
		UpdateMoneyTextUI(money);
	}

	private void UpdateMoneyTextUI(float newValue)
	{
		moneyText.text = newValue.ToString() + " $";
	}

	public void InverseBuildingUIPanel()
	{
		if(buildingUIPanel.activeSelf)
		{
			buildingUIPanel.SetActive(false);
		}
		else
		{
			buildingUIPanel.SetActive(true);
		}
	}

	public void FillBuildingPanelWithInfo(int workersCount, int maxWorkersCount, float productionSpeed)
	{
		workersCountText.text = workersCount.ToString() + "/" + maxWorkersCount.ToString();
		productionSpeedText.text = productionSpeed.ToString() + " unit(s)/sec";
	}
}
