using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rayCasting : MonoBehaviour {
	Camera cam;
	public GameObject[] players;
	// Use this for initialization
	void Start () {
		cam = Camera.main;
	}
	
	// Update is called once per frame
	void Update () {
		RaycastHit hit; // raycasthit: a struct that stores the info
		Ray aRay = cam.ScreenPointToRay(Input.mousePosition);//casting from camera through mouse till infinity
		if (Physics.Raycast (aRay, out hit)) {
			if (hit.transform.name.Contains("Cube")) {
				Debug.Log ("hello hello hello cat");
				players = GameObject.FindGameObjectsWithTag("Player");
				for (int i = 0; i < players.Length; i++) {
					players [i].GetComponent<MeshRenderer> ().material.color = new Color (Random.Range(0f,1f), Random.Range(0f,1f), Random.Range(0f,1f));
				}
//
//				players.GetComponent<MeshRenderer> ().material.color = new Color(0,100,100);
//				transform.Translate(Vector3.up * Time.deltaTime, Space.World);
			}
		}
	}
}
