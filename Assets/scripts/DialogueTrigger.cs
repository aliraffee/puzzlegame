using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueTrigger : MonoBehaviour
{
    [SerializeField] public Dialogue dialogue;
    public NPCManager manager;


    public void TriggerDialogue()
    {
       manager.StartDialogue(dialogue);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            Debug.Log("collision detected");
            TriggerDialogue();
          
        }
    }

}
