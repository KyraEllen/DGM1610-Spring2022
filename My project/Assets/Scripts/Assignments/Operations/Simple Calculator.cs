using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleCalculator : MonoBehaviour 
{    //Access Modifier DataType Name;
        public int numberA = 10;
        public int numberB = 33;
        public int numberC = 7;

         public float numberD = 33;
        public float numberE = 7;

        // + - * / %
    // Start is called before the first frame update
    void Start()
    { 

        Add();
        Sub();
        Mult();
        Div();

        int total;

        total = numberA + numberB;
        
        Debug.log(numberA +" + "+ numberB +" = "+ total);

    // Update is called once per frame
    void Update()
    {
        
    }
        void Add()
        {
            int total;

            total = numberA + numberB;
        
            Debug.log(numberA +" + "+ numberB +" = "+ total);
        }
        void Sub()
        {
            int total;

            total = numberB - numberC;
        
         Debug.log(numberB +" - "+ numberC +" = "+ total);
        }
        void Mult()
        {
            int total;

            total = numberB * numberB;
        
            Debug.log(numberB +" * "+ numberB +" = "+ total);
        }
       void Div()
        {
            int total;
            int Rem;
            float tot;

            total = numberB / numberC;
            rem = numberB % numberC;
            tot = numberD / numberE;

            Debug.log(numberB +" / "+ numberC +" = "+ total);
            Debug.log("Remainder ="+ rem);
            Debug.log(numberD +" / "+ numberE +" = "+ tot);
        }
    
    }
} 


