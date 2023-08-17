using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bincollection : MonoBehaviour
{
    [SerializeField] rubbishCollection collection;
    [SerializeField] private GameObject inLetters;

    void Update()
    {
        if (collection.rubbishCount == 5)
        {
            inLetters.SetActive(true);
        }
    }
}
