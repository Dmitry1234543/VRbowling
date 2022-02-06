using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallTeleport : MonoBehaviour
{
    private Vector3 startPos;
    private Rigidbody rigidbody;

    void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
        startPos = this.transform.position;
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "teleport")
        {
            rigidbody.isKinematic = true;
            this.transform.position = startPos;
            rigidbody.velocity = Vector3.zero;
            rigidbody.isKinematic = false;
        }
    }
}








