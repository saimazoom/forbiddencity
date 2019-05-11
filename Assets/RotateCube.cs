using UnityEngine;
using System.Collections;

public class RotateCube : MonoBehaviour {
	public float speed = 1000f;
	public float pulse_speed = 10f;
	public bool x_axis;
	public bool y_axis;
	public bool z_axis_plus;
	public bool z_axis_minus;
	private float counter=0;
	// private Vector3;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (counter < 2*Mathf.PI) counter=counter+0.01f;
			else counter=0.0f;

		if (z_axis_plus==true) transform.Rotate(Vector3.up, speed * Time.deltaTime, Space.World);
		if (z_axis_minus==true) transform.Rotate(Vector3.down, speed * Time.deltaTime, Space.World);
		if (x_axis==true) transform.Rotate(Vector3.right, speed * Time.deltaTime, Space.World);
		if (y_axis==true) transform.Rotate(Vector3.left, speed * Time.deltaTime, Space.World);

		transform.localScale = new Vector3( 5f+pulse_speed* Time.deltaTime*Mathf.Sin (counter), 
		                                   5f+pulse_speed* Time.deltaTime*Mathf.Sin (counter), 
		                                   5f+pulse_speed* Time.deltaTime*Mathf.Sin (counter));
	}
}
