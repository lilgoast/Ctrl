using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DropperObjectHit : MonoBehaviour
{
    [SerializeField] int sideWallLength = 40;
    System.Random random = new System.Random();

    private void OnCollisionEnter(Collision other)
    {
        GetComponent<MeshRenderer>().material.color = new Color(24f/255f, 24f/255f, 24f/255f);

        if(other.gameObject.tag == "Player")
        {
            GetComponent<MeshRenderer>().material.color = Color.red;
        }

        ChangePosition();
    }

    void ChangePosition()
    {
        int x = random.Next((-1 * (sideWallLength / 2)) + 2, (sideWallLength / 2) - 2);
        int z = random.Next((-1 * (sideWallLength / 2)) + 2, (sideWallLength / 2) - 2);

        transform.position = new Vector3(x, 20 ,z);
    }
}
