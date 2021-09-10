using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinCollection : MonoBehaviour
{
    // this is the default unity function that will called whenever two objects collide and one has the Trigger parameter enabled
    // the argument "other" refers to the object that hits the game object this script is attached to. 
    private void OnTriggerEnter(Collider other)
    {
        // In this case the we want to check if the "other" is the "Ball"
        if (other.name == "Ball")
        {

            // access the audio management game object, then the AudioSource component, and play
            GameObject.Find("Sound Management").GetComponent<AudioSource>().Play();

            // it will remove the coin
            Destroy(this.gameObject);
        }
    }
}