using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelEnded : MonoBehaviour
{
    [SerializeField] private GameObject ending;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.name == "confused")
        {
            ending.SetActive(true);
        }
    }
}
