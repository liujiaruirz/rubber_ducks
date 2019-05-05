using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wrap : MonoBehaviour
{
    public Transform warpTarget;

    void OnTriggerEnter2D(Collider2D other){

        Debug.Log("An object Collided.");
        other.gameObject.transform.position = warpTarget.position;
        Camera.main.transform.position = warpTarget.position;

    }

}
