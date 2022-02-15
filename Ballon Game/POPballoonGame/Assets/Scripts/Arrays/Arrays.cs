using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrays : MonoBehaviour
{

    public string[] friendNames = {"Bob", "Jessica", "Jody", "Arthur", "Randall", "Todd", "Becky"};
    public string[] pets = {"Waddles", "Timothy", "Clyde", "Pebbles"};
    public string[] fairyHelpers = {"Adelina", "Chepi", "Dorielle", "Tippi", "Winnie"};
    public string[] gnomes = {"Perrin", "Shmebulock", "Timbers"};
    public string[] Bosses ={"Spike", "Cyclone", "Red Wolf", "Plauge"};
    public int[] numbers = {23,46,77,10,42,98,63,81};
    //                      {0, 1, 2, 3, 4, 5, 6}
    public int[] powerPoints = {300, 400, 600};
    public int[] goldCoins = {75};

    public int[] numberOfkills = {10};
    public int[] itemsInpocket = {32};

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Former friend" + friendNames[0]);
        Debug.Log(friendNames[3]+" says Hello as he walks to class");
        friendNames[0] = "Veronica";
        Debug.Log("New friend" + friendNames[0]);

        Debug.Log("Best college turtle" + pets[1]);
        Debug.Log(pets[2]+" says woof woof");
        Debug.Log("my pond buddy, " + pets[3]);

        Debug.Log("You haven't unlocked this helper yet " + fairyHelpers[0]);
        Debug.Log(fairyHelpers[3]+" can help you beat the slime monsters");
        Debug.Log("New fairy unlocked" + fairyHelpers[0]);

        Debug.Log("In the meadow of flowers you spot " + gnomes[0]);
        Debug.Log(gnomes[2]+" pops his magic bubble on you as you walk by");
        Debug.Log(gnomes[1] +" says Shmebulock (That's all he can say)");

        Debug.Log("You can now fight " + Bosses[0]);
        Debug.Log(Bosses[3]+" taunts you as you aproach");
        Bosses[0] = "Blade";
        Debug.Log("Locked Boss" + Bosses[2]);
        
        foreach(int numbers in numbers)
        {
            print(numbers); 
        }
        foreach(int powerPoints in numbers)
        {
            print(numbers); 
        }
        foreach(int goldCoins in numbers)
        {
            print(numbers); 
        }
        foreach(int numberOfkills in numbers)
        {
            print(numbers); 
        }
        foreach(int itemsInpocket in numbers)
        {
            print(numbers); 
        }
    }
}
