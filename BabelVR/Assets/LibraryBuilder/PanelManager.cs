﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanelManager : MonoBehaviour {

	public GameObject book;

	public int numberOfShelves = 4;
	public int numberOfBooksPerShelf = 20;

	public float bookSpacing = 0.125f;
	public float shelfSpacing = 0.55f;

	public float hexagon;
	public int rowNumber;

	// Use this for initialization
	void Start () {
		for (int i = 0; i < numberOfShelves; i++) {
			for (int j = 0; j < numberOfBooksPerShelf; j++) {
				GameObject b = GameObject.Instantiate(book, new Vector3 (transform.localPosition.x + j*bookSpacing, transform.localPosition.y + i*shelfSpacing, transform.localPosition.z), Quaternion.identity);
				b.transform.SetParent (transform);
				b.transform.localPosition = new Vector3 (b.transform.localPosition.x + rowNumber*2.5f, b.transform.localPosition.y, b.transform.localPosition.z);
				//b.transform.localRotation = transform.rotation;
			}
		}

		transform.localEulerAngles = new Vector3 (0, hexagon * 60, 0);

	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
