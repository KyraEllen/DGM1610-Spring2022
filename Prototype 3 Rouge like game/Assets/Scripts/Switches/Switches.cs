using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Switches : MonoBehaviour
{
    public string npcConv;

    //public int socialClass =1

    void Start()
    {
        switch(npcConv)
        {
            case "Hello":
            print("Hello good citizen! May the blessings of the earth be upon you!");
            break;
            case "Goodbye":
            print("Goodbye! Afe travels to you and your party!");
            break;
            case "We are being attacked":
            print("YOu run away in shame, you cowar!");
            break;
        }

        switch(socialClass)
        {
            case 5:
            Debug.log("Hello, your Majesty!");
            break;
            case 4:
            Debug.log("Hello Young Princess Alexandrea!");
            break;
            case 3:
            Debug.log("Good evening Duchess Farington");
            break;
            case 2:
            Debug.log("Hello, Knight Cassandra!");
            break;
            case 1:
            Debug.log("May I purchase some of your fine potatos");
            break;
            case 0:
            Debug.log("Stay away from me traitor");
            break;
            default:
            Debug.log("I don't talk with strangers");
            break;

        }
    }
}
