 using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Building : MonoBehaviour
{
    public Renderer MainRenderer;
    public Vector2Int Size = Vector2Int.one;

    public float buildingCost = 5;


    protected bool isBuilded = false;


    public void SetTransparent(bool available) 
    {
        

        if (available)
          MainRenderer.material.color = Color.green;
        
        else
            MainRenderer.material.color = Color.red;
        

    }

    

  /*  void OnMouseDown()
    {
        buildingUIPanel.SetActive(true);
    }*/



    public void SetNormal()
    {
        MainRenderer.material.color = Color.white;
        isBuilded = true;
    }

    protected void OnDrawGizmos()
    {
        for (int x = 0; x < Size.x; x++)
        {
            for (int y = 0; y < Size.y; y++)
            {
                 if ((x + y) % 2 == 0) Gizmos.color = new Color(0.88f, 0f, 1f, 0.3f);
                else Gizmos.color = new Color(1f, 0.68f, 0f, 0.3f);
                //Gizmos.color = new Color(1f, 0.68f, 0f, 0.3f);

                Gizmos.DrawCube(transform.position + new Vector3(x, 0, y), new Vector3(1, .1f, 1));
            }
        }
    }
}
