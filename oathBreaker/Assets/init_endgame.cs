using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class init_endgame : MonoBehaviour
{
    public static GameObject endgame;

    private void Start()
    {
        endgame = GameObject.Find("EndScene");
        endgame.gameObject.SetActive(false);
    }
}
