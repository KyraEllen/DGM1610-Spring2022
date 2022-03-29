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

    public float keys;

    public string shop;

    public int monsterLevel;

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
            case "Suplies":
            print("Hello good citizen! What would you like to buy today?");
            break;
            case "Monster":
            print("Gggggggggggrrrrrr!");
            break;
            case "Chicken":
            print("Bakwack!");
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
            print("Don't you wonder what treasures are on the other side of the river?");
            break;
        }
        switch(keys)
        {
            case 5:
            Debug.log("You have all the keys you can go open the door!");
            break;
            case 4:
            Debug.log("You need one more key. I heard it was on top of the montain.");
            break;
            case 3:
            Debug.log("You still need to find two keys the next one should be in the forest.");
            break;
            case 2:
            Debug.log("You still need to find three keys the next key is in the lake.");
            break;
            case 1:
            Debug.log("You still need to find four keys, the next key is in the meadow.");
            break;
            default:
            Debug.log("If you want to open the door you must find all five keys. The first is in town hall");
            break;
        }
         switch(shop)
        {
            case "Snowing":
            print("It's chilly would you like to buy a hot chocolate?");
            break;
            case "Rain":
            print("It's wet would you like to buy an umbrella?");
            break;
            case "Windy":
            print("It's windy would you like to buy a wind breaker?");
            break;
            case "Sunny":
            print("It's sunny would you like to buy some sunblock?");
            break;
            case "Cloudy":
            print("It's cloudy would you like to buy a cloud?");
            break;
        }
        switch(monsterLevel)
        {
            case 5:
            Debug.log("You need an entire party with masterskills to beat this monster.");
            break;
            case 4:
            Debug.log("You might wanna couple of friends before trying to take on this guy.");
            break;
            case 3:
            Debug.log("You'll want a friend to help you with this monster.");
            break;
            case 2:
            Debug.log("You need a strong sword to beat this monster.");
            break;
            case 1:
            Debug.log("You can beat this monster.");
            break;
            default:
            Debug.log("This is barely a monster.");
            break;

    }
}
