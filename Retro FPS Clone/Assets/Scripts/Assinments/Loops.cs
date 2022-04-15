using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Loops : MonoBehaviour
{
        //public int numEwoks = 0;
        public int numPeeps = 0;
        public int numFlowers = 0;
        public int numCars = 0;
        public int numGnomes = 0;
        public int ducksInPond = 0;
        public int trainsRunning = 0;
        public int leavesOnTheTree = 0;
        public int gallonsOfJuice = 0;
        public int milesDriven = 0;

    // Start is called before the first frame update
    void Start()
    {
        /*
      for(int i = 99; i >= numEwoks; i-- )
      {
            Debug.Log("There are " + i + " Ewoks on a log!");
      }  
      for(int i = 30; i >= numPeeps; i-- )
      {
            Debug.Log("There are " + i + " peeps in my tummy!");
      }  
       for(int i = 80; i >= numFlowers; i-- )
      {
            Debug.Log("There are " + i + " blooming in the garden!");
      }  
       for(int i = 43; i >= numCars; i-- )
      {
            Debug.Log("There are " + i + " Cars in the junkyard!");
      }  
       for(int i = 23; i >= numGnomes; i-- )
      {
            Debug.Log("There are " + i + " gnomes protecting the garden!");
      }  
        */
        while(ducksInPond < 99)
        {
            Debug.Log(ducksInPond);
            Debug.Log("All of the ducks have flown south for the winter.");
            ducksInPond ++;
        }
         while(trainsRunning < 54)
        {
            Debug.Log(trainsRunning);
            Debug.Log("All of the trains have stopped running for the day.");
            trainsRunning ++;
        }
           while(leavesOnTheTree < 125)
        {
            Debug.Log(leavesOnTheTree);
            Debug.Log("All of the leaves have fallen off the tree.");
            leavesOnTheTree ++;
        }
        while(gallonsOfJuice < 31)
        {
            Debug.Log(gallonsOfJuice);
            Debug.Log("They drank all the juice.");
            gallonsOfJuice ++;
        }
        while(milesDriven < 324)
        {
            Debug.Log(milesDriven);
            Debug.Log("You have arrived!");
            milesDriven ++;
        }
   
}
