using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishedTrigger : MonoBehaviour
{
    [SerializeField] private GameObject end;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.name == "confused" || collision.gameObject.name == "used")
        {
            end.SetActive(true);
        }
    }
}
