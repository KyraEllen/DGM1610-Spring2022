using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class If_Statements : MonoBehaviour
{
    //public string lightColor;

    //public string Weather;

    //public string Magic;

    //public string flowers;

    //public string vision;

    public int height;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {   
        if(lightColor == "Red")        
            Debug.Log("The light is "+ lightColor + "STOP!!");

        else if(lightColor == "Yellow")
        {
            Debug.Log("The light is "+ lightColor +" Start to stop or clear the intersection!");
        }
        else if(lightColor == "Green")
        {
            Debug.Log ("The light is "+ lightColor + "Goooooooooooo!!!"); 
        }
        else 
        {
            Debug.Log("Wrong Color!");
        }
        if(Weather == "Rain" || Weather == "Snow")
        {
            Debug.Log("The weather is stormy you need a coat");
        } 
        else if(Weather == "Sunny" || Weather == "Partly Cloudy")
        {
            Debug.Log("You do not need a coat");
        } 
        if(height == "5" && height == "6")
        {
            Debug.Log("You Are Tall Enough to Ride the Fire Dragon Coaster");
        }
        else if(height == 5 && height == 6)
        {
            Debug.Log("You are Not Tall Enough to Ride the Fire Dragon");
        }
        
        if(Magic is "Pink")
        {
         Debug.Log("You have love magic");
        }
        else if(Magic is "Blue")
        {
            Debug.log("You have water magic");
        }
        else if(Magic is "Violet")
        {
            Debug.Log("You have space magic");
        }
        else if(Magic is "Peach")
        {
            Debug.Log("You have air magic");
        }
        else if(Magic is "Yellow")
        {
            Debug.Log("You have light magic");
        }
        else if(Magic is "Sage")
        {
            Debug.Log("You have plant magic");
        }
        if(flowers == four || flowers == five)
        {
            Debug.Log("Your flowers don't have enough petals");
        }
        else if(flowers is "six" || "seven")
        {
            Debug.Log("You have enough petals");
        }
        if(vision == ("blurry") && vision == ("confused"))
        {
            Debug.Log("You need to find your glasses");
        }
        else if(vision is ("clear") && vision is ("pretty"))
        {
            Debug.Log("Don't lose your glasses");
        }
    }
}




