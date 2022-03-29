using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Switches : MonoBehaviour
{
    public string npcConv;

    public int socialClass =1;

    public bool milk;

    public float grade; 

    public string animals;

    public int age;

    public bool crossRiver;

    public float 

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
            print("YOu run away in shame, you coward!");
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
            switch(milk)
        {
            case "false-false":
            print("You are lactose intolerance or hate cows");
            break;
            case "false-true":
            print("You don't like chocolate milk but you do like regular milk");
            break;
            case "true-false":
            print("You like chocolate milk but not regular milk");
            break;
            case "true-true":
            print("You love all milk and cute cows");
            break;
            default:
            print("You aren't thristy");
            break;
        }
            switch(grade)
        {
            case 90:
            Debug.log("You got an A!");
            break;
            case 80:
            Debug.log("You got a B!");
            break;
            case 70:
            Debug.log("You got a C.");
            break;
            case 60:
            Debug.log("You got a D");
            break;
            default:
            Debug.log("You failed.")
            break;
        }
           
            switch(animals)
        {
            case "Pets dog":
            print("This makes the dog very happy and it loves you now.");
            break;
            case "Pets cats":
            print("Cat is happy but does not want to show it but will descretly follow you around");
            break;
            case "Pets cow":
            print("Cow is a little confused but moos happily");
            break;
            case "Pets fish":
            print("It slips away you can't pet fish dang it");
            break;
            case "Pets horse":
            print("Happy horse will let you ride him for a little bit");
            break;
        }

            switch(age)
        {
            case 18:
            Debug.log("Congrats you are an adult!");
            break;
            case 16:
            Debug.log("You can now drive!");
            break;
            case 13:
            Debug.log("Technically a teen");
            break;
            case 12:
            Debug.log("Akward tweenager");
            break;
            case 7:
            Debug.log("A Child");
            break;
            case 2:
            Debug.log("It's a baby.");
            break;
            default:
            Debug.log("Are you immortal?");
            break;
        }
               switch(crossRiver)
        {
            case "false-false":
            print("You don't have what you need to cross this river");
            break;
            case "false-true":
            print("You can walk across the bridge but you can't take the boat it has a hole in it.");
            break;
            case "true-false":
            print("The bridge is broken but you can cross on the boat.");
            break;
            case "true-true":
            print("YOu can cross on the bridge or the boat.");
            break;
            default:
            print("Don't you wonder what treasures lie on the other side of the river?");
            break;
        }
    }
}
