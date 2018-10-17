using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player4 : Player
{
    void Update()
    {
        b_Y = Input.GetButtonDown("Player3_Y");
        b_B = Input.GetButtonDown("Player3_B");
        b_A = Input.GetButtonDown("Player3_A");
        b_X = Input.GetButtonDown("Player3_X");
        //Axis
        b_verticalToInt = Input.GetAxis("Player3_Vertical");
    }
}
