using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class snapHandleBack : MonoBehaviour {

    public Transform handler;
    public GameObject grabHandle;
    //public Rigidbody grabHandleRB;

    public void dropItem() {

        grabHandle.GetComponent<Transform>().position = handler.transform.position;
        grabHandle.GetComponent<Transform>().rotation = handler.transform.rotation;

        grabHandle.GetComponent<Rigidbody>().velocity = Vector3.zero;
        grabHandle.GetComponent<Rigidbody>().angularVelocity = Vector3.zero;


        //grabHandleRB.velocity = Vector3.zero;
        //grabHandleRB.angularVelocity = Vector3.zero;

    }
}
