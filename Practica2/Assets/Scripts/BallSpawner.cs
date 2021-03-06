﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallSpawner : MonoBehaviour {
    public Ball ball;
    private Vector3 tam;
    //public int numBalls;
    // Use this for initialization
    void Start () {

    }

    // Update is called once per frame
    /*void Update () {


        //Intento chusco
        if (Input.GetKeyUp(KeyCode.C))
        {
            //ball1.GetComponent<Ball>().startMove();
        }
        else if (Input.GetKeyUp(KeyCode.V))
        {
            //ball2.GetComponent<Ball>().startMove();
        }
    }*/

    //Falta la dirección que van a tomar las bolas
    public void spawnBalls(uint numBalls, Vector2 direction) {
        StartCoroutine(spawnBallsCoroutine(numBalls, direction));
    }
    public void setScale(Vector3 tamX) {
        tam = tamX;
    }

    public void setLaunchPos(float x, float y) {
        posX = x; posY = y;
    }
    public void setLaunchPosX(float x)
    {
        posX = x;
    }
    public Vector2 getLaunchPos()
    {
        return new Vector2(posX, posY);
    }

    IEnumerator spawnBallsCoroutine(uint numBalls, Vector2 direction)
    {
        for (int i = 0; i < numBalls; i++)
        {
            Ball actB = Instantiate(ball);
            actB.init(tam);
            actB.startMove(new Vector2(posX,posY),speed * direction);
            yield return new WaitForFixedUpdate();
            yield return new WaitForFixedUpdate();
            yield return new WaitForFixedUpdate();
        }
        gameObject.SetActive(false);
    }

    private float posX, posY;
    private float speed = 50;
}
