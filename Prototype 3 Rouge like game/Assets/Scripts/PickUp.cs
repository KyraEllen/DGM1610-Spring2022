using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUp : MonoBehaviour
{
    public enum PickupType {Key, Coin, Gem};
    public PickupType currentPickup;
    public int pickupAmount;

    private PlayerController playerController;

    // Start is called before the first frame update
    void Start()
    {
       playerController = GameObject.Find("Player").GetComponent<PlayerController>(); 
    }


    void OnTriggerEnter2D(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            if(currentPickup == PickupType.Key)
            {
                playerController.key = pickupAmount;

                Debug.Log("You have picked up a goldent key!");
            }
            else if(currentPickup == PickupType.Coin)
            {
                playerController.coins += pickupAmount;
                Debug.Log("You have picked up" + pickupAmount + " coins");
            }
              else if(currentPickup == PickupType.Gem)
            {
                playerController.gem += pickupAmount;
                Debug.Log("You have picked up"+ pickupAmount +" gems");
            }
            Destroy(gameObject);
        }
    }
}
