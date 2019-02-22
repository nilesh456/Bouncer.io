using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shredder : MonoBehaviour {

    public void OnTriggerEnter(Collider collision)
    {
        Destroy(collision.gameObject);
    }
}
