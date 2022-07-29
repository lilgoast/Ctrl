using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectHit : MonoBehaviour
{
    int redColor = 24;
    int greenColor = 21;
    int blueColor = 21;

    int hitCount = 0;
    private void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.tag == "Player")
        {
            if(redColor < 255)
            {
                redColor += 33;
                greenColor -= 3;
                blueColor -= 3;

                hitCount++;
                gameObject.tag = hitCount + "Hit";
            }

            GetComponent<MeshRenderer>().material.color = new Color(redColor/255f, greenColor/255f, blueColor/255f);
        }
        
    }
}
