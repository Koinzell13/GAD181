using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Platformer : MonoBehaviour
{
    public float speed;
    private float Move;

    private Rigidbody2D rb;
    public float jump;

    public bool canJump;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(-speed * Time.deltaTime, 0, 0);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(speed * Time.deltaTime, 0, 0);
        }
        if(Input.GetKey(KeyCode.Space) && canJump == false)
        {
            transform.Translate(0, jump * Time.deltaTime, 0);
            Debug.Log("jump");
        }
    }
    private void OnCollisionEnter2D(Collision2D other)
    {
        if(other.gameObject.CompareTag("Obstacle"))
        {
            canJump = false;
        }
        if (other.gameObject.CompareTag ("Key"))
        {
            Destroy(other.gameObject);
            Debug.Log("Key Taken");
        }
    }
    private void OnCollisionExit2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Obstacle"))
        {
            canJump = true;
        }
    }
}
