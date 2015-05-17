using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class PlayerController : MonoBehaviour {

	public float speed = 1.0f;
	public Text countText;
	public Text winText;

	private Rigidbody rb;
	private int count;

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody> ();
		count = 0;
		SetCountText ();
		winText.text = "";
	}
	
	// Update is called once per frame
	void Update () {
	}

	// Called just before performing any physics calculations
	void FixedUpdate(){
		float moveHorizontal = Input.GetAxis("Horizontal"); // left and right
		float moveVertical = Input.GetAxis("Vertical"); // up and down

		Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);

		rb.AddForce(movement * speed);
	}

	void OnTriggerEnter(Collider other) {
		//Destroy(other.gameObject);
		if(other.gameObject.CompareTag ("PickUp"))
		{
			other.gameObject.SetActive(false);
			count++;
			SetCountText ();
		}
	}

	void SetCountText()
	{
		countText.text = "Count: " + count.ToString();
		if(count >= 18)
		{
			winText.text = "You Win";
		}
	}
}
