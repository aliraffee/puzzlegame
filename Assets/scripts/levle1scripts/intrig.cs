using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class intrig : MonoBehaviour
{
    public GameObject celldoor;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        celldoor.SetActive(false);
    }

}
