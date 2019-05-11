using UnityEngine;
using System.Collections;

public class Colisiones : MonoBehaviour {

	void OnTriggerEnter (Collider other)
	{
		var tormenta = GameObject.Find("Tormenta");
		tormenta.GetComponent<ParticleEmitter>().emit=false;
		RenderSettings.fog = false;

		// var Sound_Desierto = GameObject.Find ("Sound_Desierto");
		//Sound_Desierto
		//Sound_Desierto.audio.volume = 0.1f;
	}

	void OnTriggerStay (Collider other)
	{
		var sonido = GameObject.Find ("Sound_Desierto");
		if (sonido.GetComponent<AudioSource>().volume>0.0f) sonido.GetComponent<AudioSource>().volume-=0.01f;		    
	}

	void OnTriggerExit (Collider other)
	{
		var tormenta = GameObject.Find("Tormenta");
		tormenta.GetComponent<ParticleEmitter>().emit=true;
		RenderSettings.fog = true;
		var sonido = GameObject.Find ("Sound_Desierto");

		sonido.GetComponent<AudioSource>().volume=1.0f;		    
//		var Sound_Desierto = GameObject.Find ("Sound_Desierto");
		//Sound_Desierto.audio.volume = 1;
	}

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
