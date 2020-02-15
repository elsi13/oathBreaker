using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    public float speed;
    private GameObject ground, ground1, ground2, ground3, ground4, ground5, ground6, ground7;
    private GameObject wall0, wall1, wall2, wall3, wall4, wall5, wall6, wall7;

    // Start is called before the first frame update
    void Start()
    {
        ground = GameObject.Find("Planes/Ground");
        ground1 = GameObject.Find("Planes/Ground(1)");
        ground2 = GameObject.Find("Planes/Ground(2)");
        ground3 = GameObject.Find("Planes/Ground(3)");
        ground4 = GameObject.Find("Planes/Ground(4)");
        ground5 = GameObject.Find("Planes/Ground(5)");
        ground6 = GameObject.Find("Planes/Ground(6)");
        ground7 = GameObject.Find("Planes/Ground(7)");

        wall0 = GameObject.Find("Walls/Group0");
        wall1 = GameObject.Find("Walls/Group1");
        wall2 = GameObject.Find("Walls/Group2");
        wall3 = GameObject.Find("Walls/Group3");
        wall4 = GameObject.Find("Walls/Group4");
        wall5 = GameObject.Find("Walls/Group5");
        wall6 = GameObject.Find("Walls/Group6");
        wall7 = GameObject.Find("Walls/Group7");
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);

        transform.Translate(movement * Time.deltaTime * speed);
    }


    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Lu"))
        {
            SceneManager.LoadScene("Lu");
        }

        if (other.gameObject.CompareTag("Yash"))
        {
            SceneManager.LoadScene("1");
        }

        if (other.gameObject.CompareTag("Danielle"))
        {
            SceneManager.LoadScene("1");
        }

        if (other.gameObject.CompareTag("Hell"))
        {
            SceneManager.LoadScene("TouchThePotato");
        }

        if (other.gameObject.CompareTag("Ground0"))
        {
            HideObjects();
            ground.gameObject.SetActive(true);
            wall0.gameObject.SetActive(true);
        }

        if (other.gameObject.CompareTag("Ground1"))
        {
            HideObjects();
            ground1.gameObject.SetActive(true);
            wall1.gameObject.SetActive(true);
        }

        if (other.gameObject.CompareTag("Ground2"))
        {
            HideObjects();
            ground2.gameObject.SetActive(true);
            wall2.gameObject.SetActive(true);
        }

        if (other.gameObject.CompareTag("Ground3"))
        {
            HideObjects();
            ground3.gameObject.SetActive(true);
            wall3.gameObject.SetActive(true);
        }

        if (other.gameObject.CompareTag("Ground4"))
        {
            HideObjects();
            ground4.gameObject.SetActive(true);
            wall4.gameObject.SetActive(true);
        }

        if (other.gameObject.CompareTag("Ground5"))
        {
            HideObjects();
            ground5.gameObject.SetActive(true);
            wall5.gameObject.SetActive(true);
        }

        if (other.gameObject.CompareTag("Ground6"))
        {
            HideObjects();
            ground6.gameObject.SetActive(true);
            wall6.gameObject.SetActive(true);
        }

        if (other.gameObject.CompareTag("Ground7"))
        {
            HideObjects();
            ground7.gameObject.SetActive(true);
            wall7.gameObject.SetActive(true);
        }

    }

    private void HideObjects()
    {
        List<GameObject> planes = (from g in UnityEngine.Object.FindObjectsOfType<GameObject>() where g.name.Contains("Ground") select g).ToList();
        List<GameObject> walls = (from g in UnityEngine.Object.FindObjectsOfType<GameObject>() where g.name.Contains("Group") select g).ToList();
        foreach (GameObject ground in planes)
        {
            ground.gameObject.SetActive(false);
        }
        foreach (GameObject wall in walls)
        {
            wall.gameObject.SetActive(false);
        }
    }
}
