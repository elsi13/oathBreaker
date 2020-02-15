using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PotatoPortal : MonoBehaviour
{
	ParticleSystem fireAnimation;
	bool onFire = false;
	bool portalActive = false;
	
	float emission = 0;
	float rate = 1e-4f;
		
    // Start is called before the first frame update
    void Start()
    {
        fireAnimation = GetComponentInChildren<ParticleSystem>();
    }


    // Update is called once per frame
    void Update()
    {
		var cam = Camera.main;
		Material myMat = GetComponent<Renderer>().material;
		
        if (Input.GetButtonDown("Jump")) //i.e. spacebar (alt KeyCode.Space)
			{//if you touch potato you go to hell
			//portal active yes
				if (onFire) 
				{//zoom in
					if(cam.fieldOfView > 1)
					{
						cam.fieldOfView = cam.fieldOfView-2;
					}
				}
				else
				{
					portalActive = true;
				//potato goes on fire - fire yes
					SetOnFire();			
				}
			}
			
		if (cam.fieldOfView <=1)
		{//go to hell
			SceneManager.LoadScene("Hell", LoadSceneMode.Single);
		}
		
		if (onFire)
		{
			
			emission = Mathf.MoveTowards(emission,0.5f,rate*Time.deltaTime);
			Color baseColor = new Color(190,20,0f);
			Color finalColor = baseColor * Mathf.LinearToGammaSpace(emission);
			myMat.SetColor("_EmissionColor",finalColor);
		}
    }
	
	void SetOnFire()
	{
		onFire = true;
		fireAnimation.Play();
	}
}
