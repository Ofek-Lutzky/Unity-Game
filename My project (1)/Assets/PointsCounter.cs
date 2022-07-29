using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointsCounter : MonoBehaviour
{
    int playerBadPoints = 0;
    // Start is called before the first frame update
    private void OnCollisionEnter(Collision other) 
    {
        if (other.gameObject.tag != "Hit"){
            Debug.Log("you colided the wall " + playerBadPoints++ + " times");
        }
        

    }
}
