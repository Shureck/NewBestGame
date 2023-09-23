using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Puzzle : MonoBehaviour
{
    // Start is called before the first frame update
    private Vector3 rightPosition;
    public bool inRightPos;
    public bool selected;

    void Start()
    {
        rightPosition = transform.position;
        transform.position = new Vector3(Random.Range(39.05f,43.57f), Random.Range(-0.24f, -8.27f));
    }

    // Update is called once per frame
    void Update()
    {
        if (Vector3.Distance(transform.position, rightPosition) < 0.5f){
            inRightPos = true;
            if (!selected){
                transform.position = rightPosition;
            }
        }

    }
}
