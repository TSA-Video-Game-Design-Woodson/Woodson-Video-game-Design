using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectPlayerPos : MonoBehaviour
{
    public GameObject player;
    GameObject NPC;

    // Update is called once per frame
    void Update()
    {
        NPC = gameObject;

        Transform playerTransform = player.transform;
        float PosXPlayer = playerTransform.position.x;
        float PosYPlayer = playerTransform.position.y;

        Transform NPCTransform = NPC.transform;
        float PosXNPC = NPCTransform.position.x;
        float PosYNPC = NPCTransform.position.y;

        Animator NPCAnim = NPC.GetComponent<Animator>();

        float PlayerRelativeY = PosYNPC - PosYPlayer;

        if (PosYNPC > PosYPlayer && PosYPlayer > PlayerRelativeY || PosYPlayer < PlayerRelativeY && NPCAnim.GetBool("Idle") == true)
        {
            NPCAnim.SetBool("WasMovingLeft/Right", false);
            NPCAnim.SetBool("WasMovingUp", false);
        }

        else if (PosYNPC < PosYPlayer && PosYPlayer > PlayerRelativeY || PosYPlayer < PlayerRelativeY && NPCAnim.GetBool("Idle") == true)
        {
            NPCAnim.SetBool("WasMovingLeft/Right", false);
            NPCAnim.SetBool("WasMovingUp", true);
        }

        if (PosXNPC < PosXPlayer && PosYNPC >= PlayerRelativeY && NPCAnim.GetBool("Idle") == true)
        {
            NPCAnim.SetBool("WasMovingLeft/Right", true);
            NPC.GetComponent<SpriteRenderer>().flipX = true;
            NPCAnim.SetBool("WasMovingUp", false);
        }

        else if(PosXNPC > PosXPlayer && PosYNPC <= PlayerRelativeY && NPCAnim.GetBool("Idle") == true)
        {
            NPCAnim.SetBool("WasMovingLeft/Right", true);
            NPC.GetComponent<SpriteRenderer>().flipX = false;
            NPCAnim.SetBool("WasMovingUp", false);
        }


    }
}