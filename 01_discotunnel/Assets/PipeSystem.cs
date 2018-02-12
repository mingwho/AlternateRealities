﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSystem : MonoBehaviour
{

    public Pipe pipePrefab;

    public int pipeCount;

    private Pipe[] pipes;

    private void Awake()
    {
        pipes = new Pipe[pipeCount];
        for (int i = 0; i < pipes.Length; i++)
        {
            Pipe pipe = pipes[i] = Instantiate<Pipe>(pipePrefab);
            pipe.transform.SetParent(transform, false);
            pipe.Generate();
            // each pipe aligns with its previous pipe
            if (i > 0)
            {
                pipe.AlignWith(pipes[i - 1]);
            }
        }
    }

    public Pipe SetupFirstPipe(){
        transform.localPosition = new Vector3(0f, -pipes[0].CurveRadius);
        return pipes[0];
    }

    public Pipe SetupNextPipe()
    {
        ShiftPipes();
        AlignNextPipeWithOrigin();
        pipes[pipes.Length - 1].Generate();
        pipes[pipes.Length - 1].AlignWith(pipes[pipes.Length - 2]);
        transform.localPosition = new Vector3(0f, -pipes[0].CurveRadius);
        return pipes[0];
    }

    private void ShiftPipes()
    {
        Pipe temp = pipes[0];
        for (int i = 1; i < pipes.Length; i++)
        {
            pipes[i - 1] = pipes[i];
        }
        pipes[pipes.Length - 1] = temp;
    }

    private void AlignNextPipeWithOrigin()
    {
        Transform transformToAlign = pipes[0].transform;
        for (int i = 1; i < pipes.Length; i++)
        {
            pipes[i].transform.SetParent(transformToAlign);
        }

        transformToAlign.localPosition = Vector3.zero;
        transformToAlign.localRotation = Quaternion.identity;

        for (int i = 1; i < pipes.Length; i++)
        {
            pipes[i].transform.SetParent(transform);
        }
    }

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
