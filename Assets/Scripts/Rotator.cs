using UnityEngine;
using System.Collections;

/**
 * Rotates the object constantly over time
 **/
public class Rotator : MonoBehaviour {

	public float rotationSpeed = 1.0f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		transform.Rotate(new Vector3(0, 0, 45) * Time.deltaTime * rotationSpeed);
	}
}
