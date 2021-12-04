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

    void Start()
	{
		UpdateMoneyTextUI(money);
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
}
