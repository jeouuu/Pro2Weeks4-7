using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class CustomerSpawner : MonoBehaviour
{
    //this script is for spawing the customers

    public GameObject customerPrefab;

    public Vector2[] seats = new Vector2[4];
    public List<Vector2> availableSeats;

    public List<GameObject> customers;

    public GameObject playUI;
   
    private void Start()
    {        
        //add the seats sets in the inspector in the available seats
        customers = new List<GameObject>();
        availableSeats = new List<Vector2>();
        availableSeats.Add(seats[0]);
        availableSeats.Add(seats[1]);
        availableSeats.Add(seats[2]);
        availableSeats.Add(seats[3]);
    }

    private void Update()
    {
        //when the player ui is active, start spawing customers.
        if (playUI.activeSelf)
        {
            SpawnCustomer();
        }
        
    }

    void SpawnCustomer()
    {
        //if there's less than 4 customers AND there's available seats, spawn a customer
        if(customers.Count < 4 && availableSeats.Count>0)
        {
            //pick a random seat from the available seat list, then remove it from the list to prevent more than 1 customer at the same seat
            Vector2 pickSeat = availableSeats[Random.Range(0, customers.Count)];    
            availableSeats.Remove(pickSeat);

            GameObject newCustomer = Instantiate(customerPrefab);
            Customer script = newCustomer.GetComponent<Customer>();
            if (script != null) 
            { 
                //assign the seat to the customer
                script.AssignSeat(pickSeat);
            }
            //add this new customer in the list, because there can only be 4 customers on screen
            customers.Add(newCustomer);            
        }
        
    }
}
