using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBalloons : MonoBehaviour
{
    public float moveSpeed = 1.0f;
    public float lowerBound = -10.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Moves the Balloon downwawrd
       transform.Translate(0 ,-moveSpeed * Time.deltaTime,0);
        
        // Destory the Balloon  after it passes lowerbound
       if(transform.position.y < lowerBound)
       {
           Destroy(gameObject);
       } 
    }
}
