using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2 : Player
{
    void Update()
    {
        b_Y = Input.GetButtonDown("Player1_Y");
        b_B = Input.GetButtonDown("Player1_B");
        b_A = Input.GetButtonDown("Player1_A");
        b_X = Input.GetButtonDown("Player1_X");
        //Axis
        b_verticalToInt = Input.GetAxis("Player1_Vertical");
    }
}
