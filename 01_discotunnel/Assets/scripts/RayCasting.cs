using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RayCasting : MonoBehaviour
{
    Camera cam;
    public GameObject[] players;
    // Use this for initialization
    void Start()
    {
        cam = Camera.main;
    }

    // Update is called once per frame
    void Update()
    {
        RaycastHit hit; // raycasthit: a struct that stores the info
        Ray aRay = cam.ScreenPointToRay(Input.mousePosition);//casting from camera through mouse till infinity
        if (Physics.Raycast(aRay, out hit))
        {
            if (hit.transform.name.Contains("Sphere")){
                Debug.Log("HELLO WORLD");
            }

        }
    }
}