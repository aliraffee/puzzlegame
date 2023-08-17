using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class giveblock : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject[] bockstofill;
    public bool[] isfilled;
    public bool allfilled;
    public int amountofblocks;
    public GameObject prefabToInstantiate;
    public GameObject cv;
    public GameObject clone;

  
   
        // Instantiate the prefab at the current position
        
   

    void Start()
    {
        Canvas cv = GetComponentInParent<Canvas>();
    }
    public void spawnblocks()
    {
        for (int i = 0; i < amountofblocks; i++)
        {
          clone=  Instantiate(prefabToInstantiate, transform.position, Quaternion.identity);
            clone.transform.SetParent(cv.transform);
           

        }
        Destroy(gameObject);
    }
    // Update is called once per frame
    private void FixedUpdate()
    {
        allfilled = true;
        for (int i = 0; i < isfilled.Length; i++)
        {
            if (bockstofill[i].transform.childCount!=0)
            {
                isfilled[i] = true;
            }else
            {
                isfilled[i] = false;
            }
        }
        for (int i = 0; i < isfilled.Length; i++)
        {
            if (isfilled[i]==false)
            {
                allfilled = false;               
            }

        }
        if(allfilled == true)
        {
            spawnblocks();
        }

    }
}
