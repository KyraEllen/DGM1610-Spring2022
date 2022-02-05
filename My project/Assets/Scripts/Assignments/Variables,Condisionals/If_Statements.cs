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
            Debug.log ("The light is "+ lightColor + "STOP!!");

        else if(lightColor == "Yellow")
        {
            Debug.log("The light is "+ lightColor +" Start to stop or clear the intersection!");
        }
        else if(lightColor == "Green")
        {
            Debug.log ("The light is "+ lightColor + "Goooooooooooo!!!"); 
        }
        else 
        {
            Debug.log("Wrong Color!");
        }
        if(Weather == "Rain" || Weather == "Snow")
        {
            Debug.log("The weather is stormy you need a coat");
        }
        else if(Weather == "Sunny" || Weather == "Partly Cloudy")
        {
            Debug.log("You do not need a coat");
        } 
        if(height == "5" && height == "6")
        {
            Debug.log("You Are Tall Enough to Ride the Fire Dragon Coaster");
        }
        else if(height == 5 && height == 6)
        {
            Debug.log("You are Not Tall Enough to Ride the Fire Dragon");
        }
        
        if(magic == Pink)
        {
         Debug.log("You have love magic");
        }
        else if(Magic is "Blue")
        {
            Debug.log("You have water magic");
        }
        else if(Magic is "Violet")
        {
            Debug.log("You have space magic");
        }
        else if(Magic is "Peach")
        {
            Debug.log("You have air magic");
        }
        else if(Magic is "Yellow")
        {
            Debug.log("You have light magic");
        }
        else if(Magic is "Sage")
        {
            Debug.log("You have plant magic");
        }
        if(flowers == four || flowers == five)
        {
            Debug.log("Your flowers don't have enough petals");
        }
        else if(flowers is "six" || "seven")
        {
            Debug.log("You have enough petals");
        }
        if(vision == ("blurry") && vision == ("confused"))
        {
            Debug.log("You need to find your glasses");
        }
        else if(vision is ("clear") && vision is ("pretty"))
        {
            Debug.log("Don't lose your glasses");
        }
    }
}




