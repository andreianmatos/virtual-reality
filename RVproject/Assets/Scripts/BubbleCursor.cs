/*using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BubbleCursor : MonoBehaviour
{

    static Color s_UnityHighlight = Color.yellow;
    float rSpeed = 0.1f;
    static Color s_UnityCyan = new Color(0.019f, 0.733f, 0.827f, 0.5f);
    GameObject nearestBall;
    public GameObject Bubbleprefab;
    public GameObject Bubble;
    private BubblePointer Parent;

    // Start is called before the first frame update
    void Start()
    {
        transform.position = transform.parent.position;
        transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z - transform.parent.localScale.y);
        Vector3 position = new Vector3(0,0,0);
        Quaternion rotation = new Quaternion(1, 1, 1, 1);
        Bubble = Instantiate(Bubbleprefab, position, rotation) as GameObject;
        Bubble.SetActive(false);

        Parent = gameObject.GetComponentInParent<BubblePointer>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Bubble != null && nearestBall != null)
            Bubble.transform.position = nearestBall.gameObject.transform.position;
    }

    void OnTriggerEnter(Collider other)
    {
        // ..and if the game object we intersect has the tag 'Pick Up' assigned to it..
        if (other.gameObject.CompareTag("Ball"))
        {
            // Make the other game object (the pick up) inactive, to make it disappear
            //other.gameObject.SetActive (false);
            Bubble.transform.position = other.gameObject.transform.position;
            Bubble.SetActive(true);
            //other.gameObject.GetComponent<Renderer>().material.color = s_UnityHighlight;
            nearestBall = other.gameObject;
        }
    }

    void OnTriggerExit(Collider other)
    {
        // ..and if the game object we intersect has the tag 'Pick Up' assigned to it..
        if (other.gameObject.CompareTag("Ball"))
        {
            Debug.Log("here");
            Bubble.SetActive(false);
            // Make the other game object (the pick up) inactive, to make it disappear
            //other.gameObject.SetActive (false);
            other.gameObject.GetComponent<Renderer>().material.color = s_UnityCyan;
            nearestBall = null;
        }
    }

    public void onTriggerSelect()
    {
        if (nearestBall != null)
            Destroy(nearestBall);
        nearestBall = null;
        Bubble.SetActive(false);
    }

    public void changePosition(Vector2 axis2d)
    {
        if (axis2d.x > 0.2 || axis2d.x < -0.2)
        {
            GameObject ball = Parent.getNextBall();
            transform.position = ball.transform.position;
        }
    }

    public void createBubble()
    {

        GameObject ball = Parent.getNextBall();
        transform.position = ball.transform.position;
    }
}*/