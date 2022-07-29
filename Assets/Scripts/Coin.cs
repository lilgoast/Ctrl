using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    [SerializeField] int sideWallLength = 40;
    System.Random random = new System.Random();

    // Start is called before the first frame update
    void Start()
    {
        ChangePosition();
    }

    public void ChangePosition()
    {
        int x = random.Next(-1 * (sideWallLength / 2) + 2, sideWallLength / 2 - 5);
        int z = random.Next(-1 * (sideWallLength / 2) + 2, sideWallLength / 2 - 5);

        transform.position = new Vector3(x, 20 ,z);
    }
}
