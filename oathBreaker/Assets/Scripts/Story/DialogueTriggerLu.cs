﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueTriggerLu : MonoBehaviour
{
    public Dialogue dialogue;
    public void TriggerDialogue ()
    {
        FindObjectOfType<DialogueManagerLu>().StartDialogue(dialogue);

    }
}
