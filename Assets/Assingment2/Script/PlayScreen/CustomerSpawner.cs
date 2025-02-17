using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class CustomerSpawner : MonoBehaviour
{

    public GameObject customerPrefab;

    public Vector2[] seats = new Vector2[4];
    public List<Vector2> availableSeats;

    public List<GameObject> customers;

    public GameObject playUI;
   
    private void Start()
    {        
        customers = new List<GameObject>();
        availableSeats = new List<Vector2>();
        availableSeats.Add(seats[0]);
        availableSeats.Add(seats[1]);
        availableSeats.Add(seats[2]);
        availableSeats.Add(seats[3]);
    }

    private void Update()
    {
        if (playUI.activeSelf)
        {
            SpawnCustomer();
        }
        
    }

    void SpawnCustomer()
    {
        if(customers.Count < 4 && availableSeats.Count>0)
        {
            Vector2 pickSeat = availableSeats[Random.Range(0, customers.Count)];    
            availableSeats.Remove(pickSeat);

            GameObject newCustomer = Instantiate(customerPrefab);
            Customer script = newCustomer.GetComponent<Customer>();
            if (script != null) 
            { 
                script.AssignSeat(pickSeat);
            }

            customers.Add(newCustomer);
        }
        
    }


}
