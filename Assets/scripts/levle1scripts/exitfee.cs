using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class exitfee : MonoBehaviour
{
    // Start is called before the first frame update
    public displayletter dsp;


    void CheckForLetters(string letter)
    {
        if (System.Array.Exists(dsp.lb.letters, element => element == letter))
        {
            Debug.Log("The array contains the letter: " + letter);
        }
        else
        {
            Debug.Log("The array does not contain the letter: " + letter);
        }
    }

        private void OnTriggerEnter2D(Collider2D collision)
    {
        dsp = collision.gameObject.GetComponent<displayletter>();
       
    }
}
