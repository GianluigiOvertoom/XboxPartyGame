using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    //Assign Axis
    protected float b_verticalToInt;
    protected int b_vertical;
    //Assign Buttons
    public bool b_Y;
    public bool b_B;
    public bool b_A;
    public bool b_X;
    //Assign air
    protected float m_air;
    protected float m_minAir;
    protected float m_maxAir;
    //Assign airtank
    protected float m_airTank;
    //Assign Player
    [SerializeField]
    protected GameObject m_player;
    //Assign Pump
    [SerializeField]
    protected GameObject m_pump;
    protected float m_yPos;
    //Assign status
    protected bool s_pumpIsUp;
    //Assign Balloon
    [SerializeField]
    protected GameObject m_balloon;
    protected Vector3 m_Temp;
    protected bool m_canPump;

    protected void Start()
    {
        
        //Assign variables
        m_yPos = 0.5f;
        m_minAir = 0;
        m_maxAir = 10;
        m_air = m_minAir;
        m_airTank = m_air;
        m_Temp.y = 1f;
        m_canPump = true;
    }
    protected void FixedUpdate()
    {
        //fix controller problems
        b_vertical = (int)b_verticalToInt;
        //Checkmovement
        //Pump up
        if (b_vertical >= 1 && m_canPump == true)
        {
            if (m_air <= m_maxAir)
            {
                m_air += 0.2f;
            }
            if (m_yPos <= 1)
            {
                m_yPos += 0.025f;
            }
            s_pumpIsUp = true;
        }
        //Pump down
        if (b_vertical <= -1 && s_pumpIsUp == true && m_canPump == true)
        {
            m_airTank += m_air;
            m_air = m_minAir;
            s_pumpIsUp = false;
            m_Temp.y = m_airTank;
        }
        //Controlling Pump
        if (b_vertical <= -1)
        {
            if (m_yPos >= 0.5)
            {
                m_yPos -= 0.05f;
            }
        }
        //transformpump
        m_pump.transform.position = new Vector3(transform.position.x, m_yPos, transform.position.z);
        //transformballoon
        m_balloon.transform.position = new Vector3(transform.position.x, transform.position.y + 1, transform.position.z + 4);
        m_balloon.transform.localScale = new Vector3(1, m_Temp.y / 100, 1);
    }
}
