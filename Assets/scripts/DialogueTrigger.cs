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
        if (collision.CompareTag("letter"))
        {
            Debug.Log("collision detected");
            TriggerDialogue();
          
        }

        if(collision.CompareTag("sharp"))
        {
            Debug.Log("collision detected");
            FoundTool();
        }
    }

}
