using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinRotation : MonoBehaviour
{
    // we need to define a variable that controls for the speed with which the coin rotates
    public float RotationSpeed;



    void FixedUpdate()
    {
        // I need to instruct this object to constantly rotate around its own Y axis 
        // this is done by accessing the transform component of this gameobject and using the built-in RotateAround unity function
        // this function takes three parameters. first one indicates the point in the 3D space where the rotation should happen. Since i want the coin to rotate around itself, i will pass the position of the coin itself as this parameter
        // the second parameter indicates around which axis should the game object rotate. i will set this to the up axis so the coin rotates around the Y
        // the third parameter indicates the speed with which the coin should rotate. for this i will use our RotationSpeed variable
        gameObject.transform.RotateAround(gameObject.transform.position, transform.up, RotationSpeed);

    }
}