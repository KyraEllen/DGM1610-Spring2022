using System.Collections;
using System.Collections.Generic;
using UnityEngine; 

public class Variables : MonoBehavior
{
    int money; //Whole number value 2,24,248
     int Power; //Whole number value 6,34,904
    float change = 0.32f; // Floating point number or decimal 3.25, 6.47, 14.82
    bool isDay = true;  //Booleans are true or false
    bool isRoyal = false;
    private string loginName = Cindygirl; //Strings are alpha numeric text contained in quotation marks

    // Start is called before the first frame update 
    void Start()
    {
        money = 100;
        Debug.Log("Money in account = $" + money); 
         
        Power = 1000;
        Debug.Log("Power in you have = " + Power); 
    }
    // Update is called once per frame
    void Update()
    {
        if(isDay == true)
        {
            print("It is Day!");
        }
        else if(isDay == false)
        {
            print("It is Night time");
        }
        if(isroyal == true)
        {
            print("Congrats Queen!");
        }
        else if(isroyal == false)
        {
            print("Sorry peasent");
        }
        if (change > 1.00f)
        {
            Debug.log("You have made a purchase");
        }
       if(loginName == "Cindygirl")
        {
            Debug.log("You Have Logged In!!");
        }
     else if("Wrong")
        {
            Debug.log("Invaild Login Name!");
        }
    }
}


