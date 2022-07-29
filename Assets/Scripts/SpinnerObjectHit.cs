using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinnerObjectHit : MonoBehaviour
{
    int redColor = 185;
    int greenColor = 84;
    int blueColor = 206;

    int hitCount = 0;
    private void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.tag == "Player")
        {
            if(redColor < 255)
            {
                redColor += 10;
                greenColor -= 12;
                blueColor -= 30;

                hitCount++;
                gameObject.tag = hitCount + "Hit";
            }

            GetComponent<MeshRenderer>().material.color = new Color(redColor/255f, greenColor/255f, blueColor/255f);
        }
        
    }
}
