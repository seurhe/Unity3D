using UnityEngine;
using System.Collections;

public class CameraSwitcher : MonoBehaviour {

	public Camera overviewCamera;
	public Camera headCamera;

	// Use this for initialization
	void Start () {
		overviewCamera.camera.enabled = true;
		headCamera.camera.enabled = false;
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetKey(KeyCode.O))
		{
			overviewCamera.camera.enabled = true;
			headCamera.camera.enabled = false;
		}
	
		if (Input.GetKey(KeyCode.I))
		{
			overviewCamera.camera.enabled = false;
			headCamera.camera.enabled = true;
		}
	}
}
