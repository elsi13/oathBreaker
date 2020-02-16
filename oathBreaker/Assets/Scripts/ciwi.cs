using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ciwi : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
		if (Input.GetMouseButtonDown(0))
		{
			GetComponent<Animator>().Play("Jump");
			//jumps twice
			//idealy go back to previous scene here
			GetComponent<Animator>().Play("Idle");
		} else if (Input.GetMouseButtonDown(1)){
			SceneManager.LoadScene("Top-scene");
		}
    }
	
	/*void OnTriggerEnter(Collider c)
	{
		if (c.gameObject.transform.parent.name.Equals("index"))
      {
		GetComponent<Animator>().Play("Jump");
		GetComponent<Animator>().Play("Jump");
		//jumps twice
		//idealy go back to previous scene here
		GetComponent<Animator>().Play("Idle");
		
	  }
	}*/
}
