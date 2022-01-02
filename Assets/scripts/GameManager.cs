using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
	public static GameManager I;
	private void Awake()
	{
		I = this;
	}

	[SerializeField] private float money = 10f;
	private Dictionary<Resource, int> resources;

    void Start()
	{
		UIManager.I.UpdateMoneyTextUI(money);
		resources = new Dictionary<Resource, int>();
	}

	public float GetMoney()
	{
		return money;
	}

    public bool ChangeMoney(float deltaMoney)
	{
		if (money + deltaMoney < 0)
		{
			return false;
		}

		money += deltaMoney;
		UIManager.I.UpdateMoneyTextUI(money);
		return true;
	}

	public bool ChangeResourceCount(Resource res, int resourceCountChange)
	{
		if(!resources.ContainsKey(res))
		{
			resources.Add(res, 0);
		}

		if(resources[res] + resourceCountChange < 0)
		{
			return false;
		}

		resources[res] = resources[res] + resourceCountChange;
		UIManager.I.resourcesTab.UpdateResource(res, resources[res]);
		return true;
	}

	public int GetResourceCount(Resource res)
	{
		if(resources.ContainsKey(res))
		{
			return resources[res];
		}
		else
		{
			return 0;
		}
	}

	public List<Resource> GetResourceTypes()
	{
		List<Resource> res = new List<Resource>();

		if(resources != null)
		{
			foreach (var k in resources.Keys)
			{
				res.Add(k);
			}
		}

		return res;
	}
}
