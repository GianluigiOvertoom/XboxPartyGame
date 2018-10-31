using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Q_T_E : MonoBehaviour
{
    public GameObject ShowKey; //Shows the keys to press//
    public GameObject PassBox; //Shows if you press the correct button//

    public int QTEGen; //Generates the button//

    public int WaitingTime; //Time to wait for the key to press//
    public int CorrectKey; //If you press to correct key//
    public int Counting; //Counting down for the next key//

    private void Update()
    {
        if (WaitingTime == 0)
        {
            //Generates a random number//
            QTEGen = Random.Range(1, 4);
            Counting = 1;

            //Time between the buttons//
            StartCoroutine(CountDown());

            //Puts the key on screen//
            if (QTEGen == 1)
            {
                WaitingTime = 1;
                ShowKey.GetComponent<Text> ().text = "[E]";
            }
            if (QTEGen == 2)
            {
                WaitingTime = 2;
                ShowKey.GetComponent<Text>().text = "[R]";
            }
            if (QTEGen == 3)
            {
                WaitingTime = 3;
                ShowKey.GetComponent<Text>().text = "[T]";
            }
        }

        //If the correct key is pressed//
        if (QTEGen == 1)
        {
            if (Input.anyKeyDown)
            {
                if (Input.GetButtonDown ("EKey"))
                {
                    CorrectKey = 1;
                    StartCoroutine (KeyPressing ());
                }
                else
                {
                    CorrectKey = 2;
                    StartCoroutine (KeyPressing());
                }
            }
        }
        if (QTEGen == 2)
        {
            if (Input.anyKeyDown)
            {
                if (Input.GetButtonDown("RKey"))
                {
                    CorrectKey = 1;
                    StartCoroutine(KeyPressing());
                }
                else
                {
                    CorrectKey = 2;
                    StartCoroutine(KeyPressing());
                }
            }
        }
        if (QTEGen == 3)
        {
            if (Input.anyKeyDown)
            {
                if (Input.GetButtonDown("TKey"))
                {
                    CorrectKey = 1;
                    StartCoroutine(KeyPressing());
                }
                else
                {
                    CorrectKey = 2;
                    StartCoroutine(KeyPressing());
                }
            }
        }
    }

    IEnumerator KeyPressing()
    {
        QTEGen = 4;
        //What happends when you press the correct or wrong key//
        if (CorrectKey == 1)
        {
            Counting = 2;
            PassBox.GetComponent<Text>().text = "PASS!";
            yield return new WaitForSeconds(1.5f);
            CorrectKey = 0;
            PassBox.GetComponent<Text>().text = "";
            ShowKey.GetComponent<Text>().text = "";
            yield return new WaitForSeconds(1.5f);
            WaitingTime = 0;
            Counting = 1;
        }
        if (CorrectKey == 2)
        {
            Counting = 2;
            PassBox.GetComponent<Text>().text = "Fail!";
            yield return new WaitForSeconds(1.5f);
            CorrectKey = 0;
            PassBox.GetComponent<Text>().text = "";
            ShowKey.GetComponent<Text>().text = "";
            yield return new WaitForSeconds(1.5f);
            WaitingTime = 0;
            Counting = 1;
        }
    }

    //Time between the buttons to press//
    IEnumerator CountDown()
    {
        yield return new WaitForSeconds(3.5f);
        
        if (Counting == 1)
        {
            QTEGen = 4;
            Counting = 2;
            PassBox.GetComponent<Text>().text = "Fail!";
            yield return new WaitForSeconds(1.5f);
            CorrectKey = 0;
            PassBox.GetComponent<Text>().text = "";
            ShowKey.GetComponent<Text>().text = "";
            yield return new WaitForSeconds(1.5f);
            WaitingTime = 0;
            Counting = 1;
        }
    }
}
