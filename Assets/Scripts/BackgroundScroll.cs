using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundScroll : MonoBehaviour
{
    public float speed = 0.01f;
    private Vector3 startPos;
    private float repeatWidth;
    // Start is called before the first frame update
    void Start()
    {
        startPos = transform.position;
        repeatWidth = GetComponent<BoxCollider>().size.x / 2;
    }

    // Update is called once per frame
    void Update()
    {
        //move
        transform.Translate(Vector3.left * speed);
        //loop
        if (transform.position.x < startPos.y - repeatWidth){
            transform.position = startPos;
        }
    }
}
