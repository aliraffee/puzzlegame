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
    [SerializeField] public TextMeshProUGUI[] textLetters;


    [SerializeField] public Button[] numbers;
    List<string> sequence = new List<string>();
    List<string> word1 = new List<string> {"a","m","a","z", "i", "n", "g"};
    List<string> word2 = new List<string> {"e", "n", "d", "i", "n", "g"};
    private string ch = "";
    
 

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.tag == "letter")
        {
            //panel shows up
            panel.SetActive(true);

        }
    }

    public void StoreInList(string i)
    {

        ch = i;
        sequence.Add(ch);

        for(int k = 0; k < textLetters.Length; k++)
        {
            if(textLetters[k].text == null)
            {

                textLetters[k].text = ch;
                Debug.Log(textLetters[k].text);
            }
            
        }
       

    }

    public void clear()
    {
        sequence.Clear();
        for(int j = 0; j<textLetters.Length; j++)
        {
              textLetters[j].text = null;
        }
       
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
                    //textLetters.text = sequence[j];
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
