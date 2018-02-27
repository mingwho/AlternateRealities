using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using VRTK;

public class BookCounter : MonoBehaviour {

	VRTK_InteractableObject bookInteraction;
	private bool Grabbed = false;
	private bool pGrabbed = false;

	// Use this for initialization
	void Start () {
		bookInteraction = this.GetComponent<VRTK_InteractableObject>();
	}
	
	// Update is called once per frame
	void Update () {
		 Grabbed = bookInteraction.IsGrabbed();

		if (pGrabbed == false && Grabbed == true) {
			BooksGrabbedCount.booksGrabbed++;
			pGrabbed = true;
		} 

	}
}
