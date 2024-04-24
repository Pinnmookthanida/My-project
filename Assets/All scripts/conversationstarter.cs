using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DialogueEditor;
public class conversationStarter : MonoBehaviour
{
    [SerializeField] private NPCConversation myConversation;

    private void OnTriggerStay(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            if(Input.GetKeyDown(KeyCode.F))
            {
                
                Cursor.visible = true;
                Cursor.lockState = CursorLockMode.None;
                ConversationManager.Instance.StartConversation(myConversation);
            }
        }
    }
}