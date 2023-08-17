using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogueTrigger : MonoBehaviour
{
    [SerializeField] public Dialogue dialogue;
    [SerializeField] public Dialogue dialogue2;
    
    [SerializeField] private Button btn1;
    [SerializeField] private Button btn2;

    public NPCManager manager;

    private void Start()
    {
        
    }
    public void TriggerDialogue()
    {
        btn2.gameObject.SetActive(false);
        btn1.gameObject.SetActive(true);
        manager.StartDialogue(dialogue);
    }

    public void FoundTool()
    {
        btn1.gameObject.SetActive(false);
        btn2.gameObject.SetActive(true);
        manager.FoundObjDialogue(dialogue2);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
      
        if (collision.CompareTag("letter"))
        {
                  TriggerDialogue();

        }

        if(collision.CompareTag("sharp"))
        {
            
            FoundTool();
          
        }
        

    }

}
