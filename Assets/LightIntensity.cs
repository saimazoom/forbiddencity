using UnityEngine;
using System.Collections;

public class LightIntensity : MonoBehaviour {

	public float speed = 1.0f;
	public float amplitud=5.0f;
	private float counter=0.0f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update ()
	{
		if (counter<(Mathf.PI*2)) counter+=0.01f*Time.deltaTime*speed;
			else counter=0.0f;
		this.GetComponent<Light>().intensity = amplitud*Mathf.Abs (Mathf.Cos (counter));
	}
}
