using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
public class grid : MonoBehaviour,IDropHandler
{
    GameObject dropped;
    blocks draggable;
    public void OnDrop(PointerEventData eventData)
    {
        if (transform.childCount == 0)
        {
            dropped = eventData.pointerDrag;
            draggable = dropped.GetComponent<blocks>();
            draggable.parntafterdrag = transform;
        }
    }

   
}
