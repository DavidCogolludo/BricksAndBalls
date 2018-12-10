﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour {
    public BallSpawner bSpawn;
    public BallSink bSink;
    public DeathZone dZone;

    private uint _numBalls;


	// Use this for initialization
	void Start () {
        //Prueba de elementos
        bSink.hide();
        dZone.init(bSink);
        _numBalls = 20;
        bSpawn.setLaunchPos(0, -6);
        bSpawn.spawnBalls(_numBalls);
	}
	
	// Update is called once per frame
	/*void Update () {
		
	}*/
}