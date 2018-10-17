using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player3 : Player
{
    void Update ()
    {
        b_Y = Input.GetButtonDown("Player2_Y");
        b_B = Input.GetButtonDown("Player2_B");
        b_A = Input.GetButtonDown("Player2_A");
        b_X = Input.GetButtonDown("Player2_X");
        //Axis
        b_verticalToInt = Input.GetAxis("Player2_Vertical");
    }
}
