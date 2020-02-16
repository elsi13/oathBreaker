using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class init_scene : MonoBehaviour
{
    public static GameObject panel, button, dead_text;
    // Start is called before the first frame update
    void Start()
    {
        panel = GameObject.Find("Canvas/Panel");
        button = GameObject.Find("Canvas/NextButton");
        dead_text = GameObject.Find("Canvas/Text (TMP)");
        panel.gameObject.SetActive(false);
        dead_text.gameObject.SetActive(false);
        button.gameObject.SetActive(false);
    }
}
