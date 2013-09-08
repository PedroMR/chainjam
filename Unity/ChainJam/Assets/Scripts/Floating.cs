using UnityEngine;
using System.Collections;

//[RequireComponent(Rigidbody)]
public class Floating : MonoBehaviour {
	public float Buoyancy = 9.8f;
	public float MinBuoyancy = 3.0f;
	public float MaxBuoyancy = 13.0f;

	public float InflateRate = 5f;
	public float DeflateRate = 0.05f;

	// Use this for initialization
	void Start () {

	}

	void Update() {
		if (Input.GetKey(KeyCode.A))
		{
			Buoyancy += InflateRate * Time.deltaTime;
		}
		else
		{
			Buoyancy -= (Buoyancy * DeflateRate) * Time.deltaTime;
		}
		Buoyancy = Mathf.Clamp(Buoyancy, MinBuoyancy, MaxBuoyancy);

		gameObject.transform.localScale = Vector3.one * (Buoyancy / 9.8f);
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		var force = Buoyancy;

		rigidbody.AddForce(force * Vector3.up);
	}
}
