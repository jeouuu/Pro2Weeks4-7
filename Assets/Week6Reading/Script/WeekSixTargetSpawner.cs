using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeekSixTargetSpawner : MonoBehaviour
{
    public GameObject targetPrefab;
    public int howManyTarget = 5;

    public List<GameObject> targets;

    public GameObject victory;
    public AnimationCurve victoryCurve;
    public AnimationCurve buttonCurve;
    float t;

    public GameObject button;
    bool canRestart = false;


    private void Start()
    {
        victory.SetActive(false);
        button.SetActive(false);    

        targets = new List<GameObject>();   
        for(int i = 0; i < howManyTarget; i++)
        {
            GameObject newTarget = Instantiate(targetPrefab);
            newTarget.transform.position = Random.insideUnitCircle * 5;

            Week6TargetScript t = newTarget.GetComponent<Week6TargetScript>();
            t.spawner = this;

            targets.Add(newTarget);
        }
    }

    private void Update()
    {
        if(targets.Count == 0)
        {
            victory.SetActive(true);
            button.SetActive(true);
            t += Time.deltaTime;
            victory.transform.localScale = Vector3.one*victoryCurve.Evaluate(t);
            button.transform.localScale = Vector3.one * buttonCurve.Evaluate(t);
        }

        if (canRestart) {
            Restart();
        }
    }

    public void TargetHit(GameObject t)
    {
        targets.Remove(t);
    }

    public void Restart()
    {
        victory.SetActive(false);
        button.SetActive(false);

        for (int i = 0; i < howManyTarget; i++)
        {
            GameObject newTarget = Instantiate(targetPrefab);
            newTarget.transform.position = Random.insideUnitCircle * 5;

            Week6TargetScript t = newTarget.GetComponent<Week6TargetScript>();
            t.spawner = this;

            targets.Add(newTarget);
        }
    }

    public bool ButtonClickRestart()
    {
        canRestart = true;
        return canRestart;
    }
}
