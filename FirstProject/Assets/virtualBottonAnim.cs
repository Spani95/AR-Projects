using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class virtualBottonAnim : MonoBehaviour, IVirtualButtonEventHandler {

    private GameObject vWalkBotton;
    private GameObject zombie;

	// Use this for initialization
	void Start () {
        vWalkBotton = GameObject.Find("walkBotton");
        zombie = GameObject.Find("zombie");

        vWalkBotton.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);
	}
	

    public void OnButtonPressed(VirtualButtonBehaviour vb)
    {
        //zombie.GetComponent<Animation>.Play();
        Debug.Log("Botton pressed!!!");
        
    }

    public void OnButtonReleased(VirtualButtonBehaviour vb)
    {
        //zombie.GetComponent<Animation>.Stop();
        
    }
}
