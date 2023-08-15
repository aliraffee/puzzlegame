using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueTrigger : MonoBehaviour
{
    [SerializeField] public Dialogue dialogue;
    [SerializeField] public Dialogue dialogue2;
    public NPCManager manager;


    public void TriggerDialogue()
    {
       manager.StartDialogue(dialogue);
    }

    public void FoundTool()
    {

        manager.FoundObjDialogue(dialogue2);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        GameObject l = null ;
        GameObject s = null;

        if (collision.CompareTag("letter") && (!collision.CompareTag("sharp")))
        {
            l = collision.transform.gameObject;
            Debug.Log("collision detected");
            TriggerDialogue();

        }
        else if(collision.CompareTag("letter") && collision.CompareTag("sharp"))
        {
            s = collision.transform.gameObject;
            //l.gameObject.SetActive(false);
            Debug.Log("sharp tool detected");
            s.gameObject.SetActive(false);
            FoundTool();
        }

        /*if (collision.CompareTag("sharp"))
        {
            


        }*/


    }

}
