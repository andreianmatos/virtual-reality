using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mov1b : MonoBehaviour {

    public float speed = 2.5f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        transform.position = new Vector3 (Mathf.PingPong(Time.time * speed, -5), transform.position.y, transform.position.z);

    }
}
