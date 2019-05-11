using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {
	public float speed=1f;

	// Use this for initialization
	void Start () 
	{
		// var Sound_Desierto = GameObject.Find ("Sound_Desierto");
		// sonido = Sound_Desierto.GetComponent (audioengine);			
		//sonido.Fade_in();
	}
	
	// Update is called once per frame
	void Update () 
	{
	
		// Dibujar 8 lineas al centro cuando se pulsa disparo
		// Añadir el sonidillo repelente...

			transform.Translate(Vector3.forward * Input.GetAxis("Vertical") * Time.deltaTime*speed);

	}
}
