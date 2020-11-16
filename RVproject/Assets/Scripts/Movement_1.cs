using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement_1 : MonoBehaviour{

    public float speed = 2.5f;


    // Start is called before the first frame update
    void Start()
    {

        transform.position = new Vector3(4, 3, 1);
    }

    // Update is called once per frame
    void Update()
    {

        transform.position = new Vector3(Mathf.PingPong(Time.time * speed, 5), transform.position.y, transform.position.z);

    }
}
