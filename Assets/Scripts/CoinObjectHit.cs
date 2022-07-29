using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinObjectHit : MonoBehaviour
{
    [SerializeField] int sideWallLength = 40;
    System.Random random = new System.Random();

    private void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.tag == "Player")
        {
            ChangePosition();
        }
        if(other.gameObject.tag != "Floor")
        {
            ChangePosition();
        }
    }

    public void ChangePosition()
    {
        int x = random.Next((-1 * (sideWallLength / 2)) + 2, (sideWallLength / 2) - 2);
        int z = random.Next((-1 * (sideWallLength / 2)) + 2, (sideWallLength / 2) - 2);

        transform.position = new Vector3(x, 20 ,z);
    }
}
