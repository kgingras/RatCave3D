using UnityEngine;
using System.Collections;

public class CharacterController : MonoBehaviour {

	public GameObject arm;
	public GameObject lamp;
	public Transform origArmPos;
	public Transform origLampPos;
	public Transform newArmPos;
	public Transform newLampPos;

	public GameObject lampLight;
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.B)) {
			arm.transform.position = newArmPos.transform.position;
			arm.transform.rotation = newArmPos.transform.rotation;

			lamp.transform.position = newLampPos.transform.position;
			lamp.transform.rotation = newLampPos.transform.rotation;
			lampLight.GetComponent<Light>().intensity = 4;
			
		} else if (Input.GetKeyUp(KeyCode.B)){
			arm.transform.position = origArmPos.transform.position;
			arm.transform.rotation = origArmPos.transform.rotation;
			
			lamp.transform.position = origLampPos.transform.position;
			lamp.transform.rotation = origLampPos.transform.rotation;
			lampLight.GetComponent<Light>().intensity = .3f;
			
		}
	}
}
