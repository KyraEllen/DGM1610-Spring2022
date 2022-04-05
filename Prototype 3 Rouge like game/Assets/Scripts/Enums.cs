using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Enums : MonoBehaviour
{
    enum Color {periwinkle = 0, rose = 1, buttercup = 2, pea = 3, peach = 4, lavander =5};
    enum CarMake {Oldsmobile, Chevrolet, Ford, Mazda, Toyota, Dodge};
    enum CarModel {Alero, Cruza, Tacoma, Mustang, Miata, Viper};
    enum Tires {WhiteWall, Dual, Classic, Snow};
    enum Interior {White, Saddleback, Vinyl, Leather};
    enum Transmission {manuel, automatic};
    enum LicensePlate {InGodWeTrust, LifeElevatedSkier, LifeElevatedArches, Olympic};
    enum AirFreshener {BlackIce, DaisyFields, BaysideBreeze, PureSteel, Leather, NewCar, RainShine, Sliced};
    enum Age {Vintage, Retro, Recent, New}
    enum Stereos {CD, Cassette, Bluetooth, AuxCord, Radio};
    // Start is called before the first frame update
    void Start()
    {
       Color paint;
        paint = Color.periwinkle;

        print(paint);
    
      
        CarMake make;
        
        CarModel model;

        make = CarMake.Dodge;
        model = CarModel.Viper;

        
        //print("Car Manufacture:" + make + " Model:"+ model);
        //Recall(CarMake.Mazda,Miata);
    
    }

    // Update is called once per frame
    void Update()
    {
        
    }
     void Recall(LicensePlate plate, Transmission transmission)
    {
        if(plate == LicensePlate.Olympic && transmission == Transmission.manuel)
        {
            print("Living for the good old times eh?");
        }
        else if(plate == LicensePlate.LifeElevatedArches && transmission == Transmission.automatic)
        {
            print("You are not one to make many waves.");
        }
        else
        {
            print("Well you need a transmission to drive and you should have plates or you'll get pulled over.");
        }
    }

    void Recall(AirFreshener scent, Stereos stereo)
    {
        if(scent == AirFreshener.BaysideBreeze && stereo == Stereos.Cassette)
        {
            print("How are you enjoying retirement?");
        }
        else if(scent == AirFreshener.NewCar && stereo == Stereos.AuxCord)
        {
            print("You are clean slick and fressh.");
        }
        else
        {
            print("Glad you are smelling good and have toons.");
        }
    }
    
    void Recall(Color color, Interior interior)
    {
        if(interior == Interior.White && color == Color.buttercup)
        {
            print("You sound like sunshine but be careful to keep your car clean.");
        }
        else if(interior == Interior.Saddleback && color == Color.rose)
        {
            print("This better be a truck.");
        }
        else
        {
            print("I like your style!");
        }
    }

    void Recall(Tires tires, Age age)
    {
        if(tires == Tires.WhiteWall && age == Age.Vintage)
        {
            print("You good Sir have a crazy classy car.");
        }
        else if(tires == Tires.Dual && age == Age.Retro)
        {
            print("You are a trucker that is running with the times.");
        }
        else
        {
            print("You have a car yay!");
        }
    }

    void Recall(CarMake make, CarModel model)
    {
        if(make == CarMake.Ford && model == CarModel.Mustang)
        {
            print("There is a recall on your vehicle due to being a Ford, please take your care to the nearest dealer for repairs.");
        }
        else if(make == CarMake.Toyota && model == CarModel.Tacoma)
        {
            print("There is a recall on your vehicle due to a faulty ignition, please take your care to the nearest dealer for repairs.");
        }
        else
        {
            print("There is no recall notice for your vehicle's make and model");
        }
    }
} 
