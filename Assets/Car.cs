using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Car : MonoBehaviour
{
    bool carMovement;     
    bool playerMovement;
       
    // Start is called before the first frame update
    void Start()
    {
        if(playerMovement)
        {
            playerMovement = true; //if the player moves
            carMovement = true; //the car moves 
        } else {
            carMovement = false; 
        }
    }

    // Update is called once per frame
    void Update()
    {
        float carMovementForward = carMovement.forward; //the car moves forward
        float carMovementBackward = carMovement.backward; //the car moves backward
    }
}
