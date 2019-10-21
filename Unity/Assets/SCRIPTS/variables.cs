using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class variables : MonoBehaviour {

	public string miNombre;
	public int miEdad;

	// Use this for initialization
	void Start () {
		Debug.Log ("Mi nombre es: " + miNombre);
		Debug.Log ("Mi edad es: " + miEdad)

		for (var i = 0; i < miEdad; i+) {
			Debug.Log ("Contador edad: " + i);
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
