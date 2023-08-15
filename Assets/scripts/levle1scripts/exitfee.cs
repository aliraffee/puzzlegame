using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class exitfee : MonoBehaviour
{
    // Start is called before the first frame update
    public displayletter dsp;
    public string[] ball,ballin,nill;

    


    


    bool CheckForLetters(string letter)
    {
        if (System.Array.Exists(dsp.lb.letters, element => element == letter))
        {
            Debug.Log("The array contains the letter: " + letter);
            return true;
        }
        else
        {
            Debug.Log("The array does not contain the letter: " + letter);
            return false;
        }
    }

        private void OnTriggerEnter2D(Collider2D collision)
    {
        dsp = collision.gameObject.GetComponent<displayletter>();

        if (CheckForLetters("b"))
        {
            if (CheckForLetters("a"))
            {
                if (CheckForLetters("l"))
                {
                    //spawn ball
                }
            }
        }
        if (CheckForLetters("n"))
        {
            if (CheckForLetters("i"))
            {
                if (CheckForLetters("l"))
                {
                    //exit level
                }
            }
        }
        if (CheckForLetters("b"))
        {
            if (CheckForLetters("a"))
            {
                if (CheckForLetters("l"))
                {
                    if (CheckForLetters("n"))
                    {
                        if (CheckForLetters("i"))
                        {
                            //exit level
                        }
                    }
                
                 
                }
            }
        }
    }
}
