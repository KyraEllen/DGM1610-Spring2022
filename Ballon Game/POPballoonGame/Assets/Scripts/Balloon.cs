using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Balloon : MonoBehaviour
{
    public int scoreToGive = 100; // Score given for popped balloon.

    public int clickToPop = 3; // How many clicks before balloon pops

    public float scaleToIncrease = 0.1f; // Scale increase each time the ballon is clicked

public ScoreManager scoreMananger; // A variable to referance the ScoreManager

    // Start is called before the first frame update
    void Start()
    {
       //Reference ScoreManager Componet
       scoreMananger = GameObject.Find("ScoreManager").GetComponent<ScoreManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnMouseDown()
    {
        // Reduce clicks by one
        clickToPop -= 1;
        //Increase balloon size
        transform.localScale += Vector3.one * scaleToIncrease;
    
        if(clickToPop == 0)
        {
            scoreMananger.IncreaseScoreText(scoreToGive);
            Destroy(gameObject);
        }
    }
}
