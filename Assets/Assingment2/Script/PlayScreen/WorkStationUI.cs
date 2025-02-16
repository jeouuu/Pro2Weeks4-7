using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WorkStationUI : MonoBehaviour
{
    public Transform ChefPos;
    public SpriteRenderer workStationPos;
    public GameObject workStationUI;

    public Vector3 reachStationOffset = new Vector3(1,1,0);

    private void Start()
    {
        workStationUI.SetActive(false);
    }

    private void Update()
    {
        if (reachStation())
        {
            workStationUI.SetActive(true);
        } else
        {
            workStationUI.SetActive(false);
        }
    }

    bool reachStation()
    {

        Bounds expandBound = workStationPos.bounds;
        expandBound.Expand(reachStationOffset);

        if (expandBound.Contains(ChefPos.position))
        {
            return true;
        } else
        {
            return false;
        }

    }

}


