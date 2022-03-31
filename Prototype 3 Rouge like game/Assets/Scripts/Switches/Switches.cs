using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Switches : MonoBehaviour
{
    public string npcConv;

    public int socialClass =1;

    public float grade; 

    public string animals;

    public int age;

    public bool crossRiver;

    public float keys;

    public string shop;

    public int monsterLevel;

    public float health;

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
            Debug.Log("Hello, your Majesty!");
            break;
            case 4:
            Debug.Log("Hello Young Princess Alexandrea!");
            break;
            case 3:
            Debug.Log("Good evening Duchess Farington");
            break;
            case 2:
            Debug.Log("Hello, Knight Cassandra!");
            break;
            case 1:
            Debug.Log("May I purchase some of your fine potatos");
            break;
            case 0:
            Debug.Log("Stay away from me traitor");
            break;
            default:
            Debug.Log("I don't talk with strangers");
            break;
        }
            switch(grade)
        {
            case 90:
            Debug.Log("You got an A!");
            break;
            case 80:
            Debug.Log("You got a B!");
            break;
            case 70:
            Debug.Log("You got a C.");
            break;
            case 60:
            Debug.Log("You got a D");
            break;
            default:
            Debug.Log("You failed.");
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
            Debug.Log("Congrats you are an adult!");
            break;
            case 16:
            Debug.Log("You can now drive!");
            break;
            case 13:
            Debug.Log("Technically a teen");
            break;
            case 12:
            Debug.Log("Akward tweenager");
            break;
            case 7:
            Debug.Log("A Child");
            break;
            case 2:
            Debug.Log("It's a baby.");
            break;
            default:
            Debug.Log("Are you immortal?");
            break;
        }
               switch(crossRiver)
        {
            case false:
            print("You don't have what you need to cross this river");
            break;
            case true:
            print("You can cross on the bridge or the boat.");
            break;
            default:
            print("Don't you wonder what treasures are on the other side of the river?");
            break;
        }
        switch(keys)
        {
            case 5:
            Debug.Log("You have all the keys you can go open the door!");
            break;
            case 4:
            Debug.Log("You need one more key. I heard it was on top of the montain.");
            break;
            case 3:
            Debug.Log("You still need to find two keys the next one should be in the forest.");
            break;
            case 2:
            Debug.Log("You still need to find three keys the next key is in the lake.");
            break;
            case 1:
            Debug.Log("You still need to find four keys, the next key is in the meadow.");
            break;
            default:
            Debug.Log("If you want to open the door you must find all five keys. The first is in town hall");
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
            Debug.Log("You need an entire party with masterskills to beat this monster.");
            break;
            case 4:
            Debug.Log("You might wanna couple of friends before trying to take on this guy.");
            break;
            case 3:
            Debug.Log("You'll want a friend to help you with this monster.");
            break;
            case 2:
            Debug.Log("You need a strong sword to beat this monster.");
            break;
            case 1:
            Debug.Log("You can beat this monster.");
            break;
            default:
            Debug.Log("This is barely a monster.");
            break;
        }
        switch(health)
        {
            case 5:
            Debug.Log("You have full health!");
            break;
            case 4:
            Debug.Log("You have 4 heart watch and see what hurts you.");
            break;
            case 3:
            Debug.Log("You have 3 hearts, if you drink a health potion you will be to full health.");
            break;
            case 2:
            Debug.Log("You only have 2 hearts left be careful.");
            break;
            case 1:
            Debug.Log("You only have one heart left if you lose all of them you'll die.");
            break;
            case 0:
            Debug.Log("You died.");
            break;
            default:
            Debug.Log("Careful with your hearts.");
            break;
        }
    }
}
