using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class redgenerator : MonoBehaviour
{
    public GameObject redprefab;
    float span = 1.6f;
    float delta = 0;


    void Start()
    {

    }

    void Update()
    {
        this.delta += Time.deltaTime;
        if (this.delta > this.span)
        {
            this.delta = 0;
            GameObject go = Instantiate(redprefab) as GameObject;
            int px = Random.Range(-3, 5);
            go.transform.position = new Vector3(px, 10, 0);
        }
    }
}
