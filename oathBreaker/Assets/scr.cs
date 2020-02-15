using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scr : MonoBehaviour
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
		GetComponent<Animation>().Play("Jump");
		Debug.Log("Collided");
	  }
	}
}
