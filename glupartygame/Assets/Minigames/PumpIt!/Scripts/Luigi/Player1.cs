using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player1 : Player
{
    void Update ()
    {
        b_Y = Input.GetButtonDown("Player0_Y");
        b_B = Input.GetButtonDown("Player0_B");
        b_A = Input.GetButtonDown("Player0_A");
        b_X = Input.GetButtonDown("Player0_X");
        //Axis
        b_verticalToInt = Input.GetAxis("Player0_Vertical");
    }
}
