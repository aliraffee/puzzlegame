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
    [SerializeField] public TextMeshProUGUI btn1;
    [SerializeField] public TextMeshProUGUI btn2;

    [SerializeField] public Button[] numbers;
    List<string> sequence1 = new List<string>();
    List<string> sequence2 = new List<string>();
    List<string> word1 = new List<string> { "a", "m", "a", "z", "i", "n", "g" };
    List<string> word2 = new List<string> { "e", "n", "d", "i", "n", "g" };
    private string ch = "";



    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.tag == "letter")
        {
            //panel shows up
            panel.SetActive(true);
            sequence1.Clear();
            sequence2.Clear();

        }
    }

    public void StoreInList(string i)
    {
      
        ch = i;

        if(btn1.enabled==true)
        {
            sequence1.Add(ch);
        }
        else if(btn2.enabled == true)
        {
            sequence2.Add(ch);
            Debug.Log(ch);
        }
        
       

        switch (i[0])
        {
            case 'a':

                if (textLetters[1].text == null)
                {
                    textLetters[1].text = ch;
                }
                break;
            case 'm':
                textLetters[0].text = ch;
                break;
            case 'i':
                if (textLetters[2].text == null)
                {
                    textLetters[2].text = ch;
                }
               else if (textLetters[5].text == null)
                {
                    textLetters[5].text = ch;
                }
                break;

            case 'e':
                if (textLetters[4].text == null)
                {
                    textLetters[4].text = ch;
                }

                break;
            case 'n':
                if (textLetters[3].text == null)
                {
                    textLetters[3].text = ch;
                }
                else if (textLetters[6].text == null)
                {
                    textLetters[6].text = ch;
                }
                break;

        }

       
        

    }

    public void clear()
    {
        sequence1.Clear();
        sequence2.Clear();

        for (int j = 0; j < textLetters.Length; j++)
        {
            textLetters[j].text = null;
        }

    }

    public void Display()
    {
        bool FisSame = false;
        bool TisSame = false;

     
            for (int j = 0; j < sequence1.Count; j++)
            {

                if (sequence1.Contains("a"))
                {
                    //textLetters.text = sequence[j];
                    FisSame = true;
                if (sequence1.Contains("m"))
                {
                    //textLetters.text = sequence[j];
                    FisSame = true;
                    if (sequence1.Contains("i"))
                    {
                        //textLetters.text = sequence[j];
                        FisSame = true;
                        if (sequence1.Contains("n"))
                        {
                            //textLetters.text = sequence[j];
                            FisSame = true;
                            TisSame = false;

                        }

                    }

                }
            }
        
                else
                {
               
                FisSame = false;
                    break;
                }

            

        }

        for (int j = 0; j < sequence2.Count; j++)
        {

            if (sequence2.Contains("e"))
            {
                //textLetters.text = sequence[j];
                TisSame = true;
            }
            if (sequence2.Contains("i"))
            {
                //textLetters.text = sequence[j];
             
                TisSame = true;
            }
            if (sequence2.Contains("n"))
            {
                //textLetters.text = sequence[j];
                
                TisSame = true;
                FisSame = false;
            }


            else
            {
                TisSame = false;
                break;

            }

           

        }

        if (FisSame == true)
        {

            Debug.Log("Yay!");
            panel.SetActive(false);
            panel2.SetActive(true);
            //reveal hidden path
        }
        else if (TisSame == true)
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
