using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ballGenerator : MonoBehaviour
{
    public GameObject ballPrefab;
    public int number;

    // Update is called once per frame

    private void Start()
    {
        for (int i = 0; i < number; i++)
        {
            float x = Random.Range(-5f, 5f);
            float y = Random.Range(-2f, 4f);
            float z = Random.Range(4f, 15f);
            Instantiate(ballPrefab, new Vector3(x, y, z), Quaternion.identity);
        }
    }

    void Update()
    {
      
    }
}
