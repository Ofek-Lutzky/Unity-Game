using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    // the variables are the movement speed 
    // the SerializeField make refernce in the ui of unity that we 
    //can enter the number we want not depend what write here
    // [SerializeField]float xValue = 0.01f;
    // [SerializeField]float yValue = 0.01f;
    // [SerializeField]float zValue = 0.01f;
    // Start is called before the first frame update

    [SerializeField] float moveSpeed = 10f;
    void Start()
    {
        PrintInstruction();
    }

    // Update is called once per frame
    void Update()
    {
        Moves();
        //in unity Edit -> projectSetting -> inputManager -> Axis
        //we can see the method that save in unity to movement accoeding to 
        //Input.GetAxis("Horizontal") <- left, right ,a, d keyboard keys for movement
    }

    void PrintInstruction(){
        Debug.Log("Welcome to the game");
        Debug.Log("Move your player with WASD or Arrows keys");
        Debug.Log("Dont hit the walls!");

    }
    void Moves()
    {
        float xValue = Input.GetAxis("Horizontal") * Time.deltaTime * moveSpeed;
        float zValue = Input.GetAxis("Vertical") * Time.deltaTime * moveSpeed;
        //move when update the frames according to the var
        transform.Translate(xValue,0,zValue);
    }
}
