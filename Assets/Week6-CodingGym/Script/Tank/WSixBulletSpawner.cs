using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class WSixBulletSpawner : MonoBehaviour
{

    public GameObject bulletPrefab;
    public WSixBullet currentBullet;


    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Spawn();
            currentBullet.Fire();
        }
    }

    void Spawn()
    {
        GameObject newBullet = Instantiate(bulletPrefab,transform);
        currentBullet = newBullet.GetComponent<WSixBullet>();

    }


}
