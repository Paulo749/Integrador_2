using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DialogueEditor;

public class NPC : MonoBehaviour
{
    public NPCConversation minhaConversa;
    public BoxCollider2D boxCollider;
    

    
    


    protected void OnMouseOver()
    {
        
        if (Input.GetMouseButtonDown(0) && GameManager.instance.conversaAtiva == false)
        {
            ConversationManager.Instance.StartConversation(minhaConversa);
            boxCollider.enabled = false;
            GameManager.instance.podeMover = false;
            GameManager.instance.conversaAtiva = true;
            
            
        }
        
    }

    

    public void LigaHitBox()
    {
        boxCollider.enabled = true;
        GameManager.instance.conversaAtiva = false;
    } 

   




}
