using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBalloons : MonoBehaviour
{
    public float moveSpeed = 1.0f;
    public float lowerBound = -10.0f;

    public ScoreManager scoreManager; // A variable to reference the ScoreManager
    
    private Balloon balloon;

    // Start is called before the first frame update
    void Start()
    {
      //Reference ScoreManager Component
      scoreManager = GameObject.Find("ScoreManager").GetComponent<ScoreManager>();  
      balloon = GetComponent<Balloon>();
    }

    // Update is called once per frame
    void Update()
    {
        //Moves the Balloon downwawrd
       transform.Translate(Vector3.down * Time.deltaTime);
        
        // Destory the Balloon  after it passes lowerbound
       if(transform.position.y < lowerBound)
       {
           scoreManager.DecreaseScoreText(balloon.scoreToGive);
           Destroy(gameObject);
       } 
    }
}
