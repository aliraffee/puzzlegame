using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class blocks : MonoBehaviour,IBeginDragHandler,IDragHandler,IEndDragHandler
{
    public Image img;
   public Transform parntafterdrag;
    Vector2 buffer,tmove = Vector2.zero;
    
    public void OnBeginDrag(PointerEventData eventData)
    {
        img = this.GetComponent<Image>();
        buffer = (Vector2)Camera.main.ScreenToWorldPoint(Input.mousePosition) - (Vector2)transform.position;

        parntafterdrag = transform.parent;
        transform.SetParent(transform.root);
        transform.SetAsLastSibling();
        img.raycastTarget = false;
    }

    public void OnDrag(PointerEventData eventData)
    {
          transform.position =Camera.main.ScreenToViewportPoint(Input.mousePosition);
        //divide by e transform.position = Camera.main.ViewportToScreenPoint(Input.mousePosition).normalized;
        //no transform.position = Camera.main.WorldToScreenPoint(Input.mousePosition);
        transform.position = (Vector2)Camera.main.ScreenToWorldPoint(Input.mousePosition);

    }

    public void OnEndDrag(PointerEventData eventData)
    {
        transform.SetParent(parntafterdrag);
        img.raycastTarget = true;
    }

  
}
