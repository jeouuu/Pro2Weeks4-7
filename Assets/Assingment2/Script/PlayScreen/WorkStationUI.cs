using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WorkStationUI : MonoBehaviour
{
    //this scrip is for the work station ui pops up when player approach it

    public Transform ChefPos;
    public SpriteRenderer workStationPos;
    public GameObject workStationUI;

    public Vector3 reachStationOffset = new Vector3(1,1,0);

    public GameObject serveFoodUI;

    private void Start()
    {
        workStationUI.SetActive(false);
    }

    private void Update()
    {
        //when player reach the work station, the ui pops up
        if (reachStation())
        {
            workStationUI.SetActive(true);

            // when the ui pops up AND player press space the serve food ui turns on
            if (reachStation() && Input.GetKeyDown(KeyCode.Space))
            {
                serveFoodUI.SetActive(true);               
            }
        } 
        else
        {
            //else the serve food ui turns off
            workStationUI.SetActive(false);
        }
    }

    bool reachStation()
    {
        //expand the bound box, so the UI can show up a bit earlier.
        Bounds expandBound = workStationPos.bounds;
        expandBound.Expand(reachStationOffset);

        //if the chef position is in the bound, return true
        if (expandBound.Contains(ChefPos.position))
        {
            return true;
        } else
        {
            return false;
        }

    }


}


