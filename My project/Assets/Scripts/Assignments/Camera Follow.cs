using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
   public GameObject player; 
    private Vecotor3 offset = new Vector3(0,2,-4);
    
    void FixedUpdate()
    {
        // Follow Player position
        transform.position = player.transform.position + offset;
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    
}
