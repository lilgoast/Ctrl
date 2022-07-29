using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField] float moveSpeed = 1;

    // Start is called before the first frame update
    void Start()
    {
        PrintInstructions();
    }

    // Update is called once per frame
    void Update()
    {
        MovePlayer();
    }

    //Print Instructions in console
    void PrintInstructions()
    {
        Debug.Log("Welcome to the game!");
        Debug.Log("W - move forward, S - move back");
        Debug.Log("A - move left, D - move right");
        Debug.Log("Don't hit the walls!");
    }

    //Moves player by WASD
    void MovePlayer()
    {
        float xValue = Input.GetAxis("Horizontal") * Time.deltaTime * moveSpeed;
        float zValue = Input.GetAxis("Vertical") * Time.deltaTime * moveSpeed;

        transform.Translate(xValue, 0, zValue);
    }
}
