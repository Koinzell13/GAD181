using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundScroller : MonoBehaviour
{
    public BoxCollider2D collider;
    public Rigidbody2D body;
    private float width;
    private float scrollSpeed = -5f;
    
    // Start is called before the first frame update
    void Start()
    {
        collider = GetComponent<BoxCollider2D>();
        body = GetComponent<Rigidbody2D>();

        width = collider.size.x;
        collider.enabled = false;

        body.velocity = new Vector2(scrollSpeed, 0);
        //ResetObstacle();
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.x < -width)
        {
            Vector2 resetPosition = new Vector2(width * 2f, 0);
            transform.position = (Vector2)transform.position + resetPosition;
            //ResetObstacle();
        }
    }

    /*void ResetObstacle()
    {
        transform.GetChild(0).localPosition = new Vector3(0, Random.Range(-0.372, 0.433), 0);
    }*/
}
