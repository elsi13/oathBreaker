using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ciwi : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
	
	void OnTriggerEnter(Collider c)
	{
		if (c.gameObject.transform.parent.name.Equals("index"))
      {
		GetComponent<Animator>().Play("Jump");
		GetComponent<Animator>().Play("Jump");
		//jumps twice
		//idealy go back to previous scene here
		GetComponent<Animator>().Play("Idle");
		
	  }
	}
}
