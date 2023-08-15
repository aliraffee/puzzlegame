using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class NumberSequence : MonoBehaviour
{

    [SerializeField] public GameObject panel;
    [SerializeField] public Button[] numbers;
    private int num;
    
 

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.tag == "letter")
        {
            //panel shows up
            panel.SetActive(true);

        }
    }

    public void Check()
    {
        Fibonnacci();
        Triangle();
    }


    public bool Fibonnacci()
    {
        
        List<int> fseq = new List<int> { 0, 1, 1, 2, 5 };
        List<int> sequence = new List<int>();

        for (int i = 0; i < 9; i++)
        {
            if (numbers[i].enabled == true)
            {
                //Debug.Log("num pressed");
                num = i;
                sequence.Add(num);
                
            }

        }

        Debug.Log(sequence);

        if(sequence.Equals(fseq))
        {
            return true;
        }
        else
        {
            return false;
        }

    }


    public bool Triangle()
    {
       
        List<int> tseq = new List<int> { 1,3,6 };
        List<int> sequence = new List<int>();

        for (int i = 0; i < 9; i++)
        {
            if (numbers[i].enabled == true)
            {
                num = i;
                sequence.Add(num);
                Debug.Log(sequence[i]);
            }


        }

       

        if (sequence.Equals(tseq))
        {
            return true;
        }
        else
        {
            return false;
        }

    }


    public void Display()
    {
        if(Fibonnacci() == true)
        {
            Debug.Log("Yay!");
            //reveal hidden path
        }
        else if(Fibonnacci() == false)
        {
            Debug.Log("shame");
        }

        if(Triangle() == true)
        {
            Debug.Log("Woohoo");
            //open path to pressure plate
        }
        else if(Triangle()== false)
        {
            Debug.Log("sad");
        }
    }
}
