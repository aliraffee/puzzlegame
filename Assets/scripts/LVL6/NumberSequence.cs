using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class NumberSequence : MonoBehaviour
{

    [SerializeField] public GameObject panel;
    [SerializeField] public GameObject panel2;
    [SerializeField] public GameObject panel3;

    [SerializeField] public Button[] numbers;
    List<char> sequence = new List<char>();
    List<char> word1 = new List<char> {'a','m','a', 'z', 'i', 'n', 'g'};
    List<char> word2 = new List<char> {'e', 'n', 'd', 'i', 'n', 'g'};
    private char ch = '0';
    
 

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.tag == "letter")
        {
            //panel shows up
            panel.SetActive(true);

        }
    }

    public void StoreInList(char i)
    {

        ch = i;
        sequence.Add(ch);

        

    }

    public void clear()
    {
        sequence.Clear();
    }



    public void Display()
    {
        bool FisSame = false;
        bool TisSame = false;

        if(sequence.Count == word1.Count)
        {
            for (int j = 0; j < sequence.Count; j++)
            {

                if (sequence[j] == word1[j])
                {
                    FisSame = true;
                    TisSame = false;
                }
                else
                {
                    break;
                }

            }
        }
        
        if(sequence.Count == word2.Count)
        {
            for (int j = 0; j < sequence.Count; j++)
            {

                if (sequence[j] == word2[j])
                {
                    TisSame = true;
                    FisSame = false;
                }
                else
                {
                    break;
                }
            }
        }
       


        if (FisSame == true)
        {
            
            Debug.Log("Yay!");
            panel.SetActive(false);
            panel2.SetActive(true);
            //reveal hidden path
        }
        else if(TisSame == true)
        {
            Debug.Log("Woohoo");
            panel.SetActive(false);
            panel3.SetActive(true);
            //open path to pressure plate
        }
        else
        {
            Debug.Log("shame");
        }


    }


    public void MovePosition()
    {
        this.transform.position = new Vector3(-4.5f, -1, 0);
    }




}
