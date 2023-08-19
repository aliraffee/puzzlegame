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
    List<int> sequence = new List<int>();
    List<int> tseq = new List<int> {1,3,6};
    List<int> fseq = new List<int> {0,1,1,2,5};
    private int num = 0;
    
 

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.tag == "letter")
        {
            //panel shows up
            panel.SetActive(true);

        }
    }

    public void StoreInList(int i)
    {

        num = i;
        sequence.Add(num);

        

    }

    public void clear()
    {
        sequence.Clear();
    }



    public void Display()
    {
        bool FisSame = false;
        bool TisSame = false;

        if(sequence.Count == fseq.Count)
        {
            for (int j = 0; j < sequence.Count; j++)
            {

                if (sequence[j] == fseq[j])
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
        
        if(sequence.Count == tseq.Count)
        {
            for (int j = 0; j < sequence.Count; j++)
            {

                if (sequence[j] == tseq[j])
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
