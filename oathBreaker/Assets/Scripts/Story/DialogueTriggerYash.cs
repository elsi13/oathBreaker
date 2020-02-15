using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueTriggerYash: MonoBehaviour
{
    public Dialogue dialogue;
    public void TriggerDialogue ()
    {
        FindObjectOfType<DialogueManagerYash>().StartDialogue(dialogue);

    }
}
