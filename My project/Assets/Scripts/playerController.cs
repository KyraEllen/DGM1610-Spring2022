using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerController: MonoBehaviour
{
    public float speed = 20.0f;
    private float turnSpeed = 50.0f;
    private float hInput;
    private float fInput;

    // Start is called before the first frame update
    void Start()
    {
       
    }
    // Update is called once per frame
    void Update()
    {   
        hInput = Input.GetAxis("Horizontal");
        fInput = Input.GetAxis("Vertical");
        
      // Makes player move forward
      transform. Translate(Vector3.forward * Time.deltaTime * speed * fInput);
      transform.Rotate(Vector3.up, turnSpeed * Time.deltaTime * hInput);
    }
}
