using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Factory : Building
{
    private float maxWorkersCount = 20;
    private float currentWorkersCount = 0;

    void OnMouseButtonDown()
	{
        Debug.Log("Click");
	}
}
