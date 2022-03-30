using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enums : MonoBehaviour
{
    enum Color {periwinkle = 0, rose = 1, buttercup = 2, pea = 3, peach = 4, lavander =5};
    enum CarMake {Oldsmobile, Chevrolet, Ford, Mazda, Toyota, Dodge};
    enum CarModel {Alero, Cruza, Tacoma, Mustang, Miata, Viper};

    // Start is called before the first frame update
    void Start()
    {
      /* Color paint;
        paint = Color.periwinkle

        print(paint);
    */
      
        CarMake make;
        
        CarModel model;

        make = CarMake.Dodge;
        model = CarModel.Viper;

        
        //print("Car Manufacture:" + make + " Model:"+ model);
        Recall(CarMake.Mazda,Miata)
    
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Recall(CarMake make, CarModel model)
    {
        if(make == CarMake.Ford && model == CarModel.Mustang)
        {
            print("There is a recall on your vehicle due to being a Ford, please take your care to the nearest dealer for repairs.");
        }
        else if(make == CarMake.Toyota && model == CarModel.Tacoma);
        {
            print("There is a recall on your vehicle due to a faulty ignition, please take your care to the nearest dealer for repairs.");
        }
        else
        {
            print("There is no recall notice for your vehicle's make and model");
        }
    }
}
