using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class Movement : MonoBehaviour {

    public float speed;

    private Rigidbody rigid;
    private EnemyMovement EM;

    // Use this for initialization
    void Start()
    {
        rigid = GetComponent<Rigidbody>();
        EM = gameObject.GetComponent<EnemyMovement>();
    }

    // Update is called once per frame
    void Update()
    {
        float moveHorizontal = CrossPlatformInputManager.GetAxis("Horizontal");
        float moveVertical = CrossPlatformInputManager.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);

        rigid.AddForce(movement * speed);
    }
}
