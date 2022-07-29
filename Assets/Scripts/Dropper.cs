using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dropper : MonoBehaviour
{
    MeshRenderer mashRenderer;
    Rigidbody rigitbody;
    [SerializeField] float timeToDrop = 3;
    // Start is called before the first frame update
    [SerializeField] int sideWallLength = 40;
    System.Random random = new System.Random();
    // Start is called before the first frame update

    void Start()
    {
        mashRenderer = GetComponent<MeshRenderer>();
        rigitbody = GetComponent<Rigidbody>();

        rigitbody.useGravity = false;
        mashRenderer.enabled = false;
        
        ChangePosition();
    }

    // Update is called once per frame
    void Update()
    {
        if(Time.time >= timeToDrop)
        {
            rigitbody.useGravity = true;
            mashRenderer.enabled = true;
        }
    }

    public void ChangePosition()
    {
        int x = random.Next(-1 * (sideWallLength / 2) + 2, sideWallLength / 2 - 2);
        int z = random.Next(-1 * (sideWallLength / 2) + 2, sideWallLength / 2 - 2);

        transform.position = new Vector3(x, 20 ,z);
    }
}
