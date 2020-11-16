using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class BubblePointer : MonoBehaviour
{
    private static readonly System.Random random = new System.Random();
    public Transform hand_pos;
    static Color s_UnityMagenta = new Color(0.929f, 0.094f, 0.278f, 0.7f);
    static Color s_UnityCyan = new Color(0.019f, 0.733f, 0.827f, 0.8f);
    public HashSet<GameObject> CurrentBalls = new HashSet<GameObject>();
    // Start is called before the first frame update
    void Start()
    {
        transform.position = hand_pos.position;
        transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z + transform.localScale.y);
        transform.parent = hand_pos;

}

    // Update is called once per frame
    void Update()
    {


    }

    void OnTriggerEnter(Collider other)
    {
        // ..and if the game object we intersect has the tag 'Pick Up' assigned to it..
        if (other.gameObject.CompareTag("Ball"))
        {
            // Make the other game object (the pick up) inactive, to make it disappear
            //other.gameObject.SetActive (false);
            other.gameObject.GetComponent<Renderer>().material.color = s_UnityCyan;
            CurrentBalls.Add(other.gameObject);

        }
    }

    void OnTriggerExit(Collider other)
    {
        // ..and if the game object we intersect has the tag 'Pick Up' assigned to it..
        if (other.gameObject.CompareTag("Ball"))
        {
            Debug.Log("here");
            // Make the other game object (the pick up) inactive, to make it disappear
            //other.gameObject.SetActive (false);
            other.gameObject.GetComponent<Renderer>().material.color = s_UnityMagenta;
            CurrentBalls.Remove(other.gameObject);

        }
    }

    public GameObject getNextBall()
    {
        return CurrentBalls.ElementAt(random.Next(CurrentBalls.Count));
    }
}
