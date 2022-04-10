using System.Collections;
using System.Collections.Generic;
using Unity.Netcode;
using UnityEngine;

public class NetworkCameraController : NetworkBehaviour
{
	public float mouseSensitivity = 10.0f;
	public Transform playerBody;


	private float XRotation = 0.0f;

	// Start is called before the first frame update
	void Start()
	{
		if (Application.platform != RuntimePlatform.Android)
		{
			Cursor.lockState = CursorLockMode.Locked;

		}
	}

	// Update is called once per frame
	void Update()
	{
		float mouseX;
		float mouseY;


		mouseX = Input.GetAxis("Mouse X") * mouseSensitivity;
		mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity;






		XRotation -= mouseY;
		XRotation = Mathf.Clamp(XRotation, -90.0f, 90.0f);

		transform.localRotation = Quaternion.Euler(XRotation, 0.0f, 0.0f);
		playerBody.Rotate(Vector3.up * mouseX);
	}
}
