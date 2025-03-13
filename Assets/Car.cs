using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Car : MonoBehaviour
{
    private bool playerMovement; //boolean player movement
    private bool carMovement;

    public Car(bool carMovement)
    {
        this.carMovement = carMovement;
    }

    public Car(object carMovementForward)
    {
        this.carMovementForward = carMovementForward;
    }

    private object carMovementBackward;

    public object GetCarMovementBackward()
    {
        return carMovementBackward;
    }

    public void SetCarMovementBackward(object value)
    {
        carMovementBackward = value;
    }

    private object carMovementForward;
    public object GetCarMovementForward()
    {
        return carMovementForward;
    }

    public void SetCarMovementForward(object value)
    {
        carMovementForward = value;
    }

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
        _ = GetCarMovementForward(); //the car moves forward
        _ = GetCarMovementBackward(); //the car moves backward
    }
}
