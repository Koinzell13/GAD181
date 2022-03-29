using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MazePlayer : MonoBehaviour
{
    public float m_speed;
    public int score = 0;

    public Text keyAmount;
    public Text winner;
    public GameObject door;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       if(Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(-m_speed * Time.deltaTime, 0, 0);
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.Translate(0, m_speed * Time.deltaTime, 0);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(m_speed * Time.deltaTime, 0, 0);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.Translate(0, -m_speed * Time.deltaTime, 0);
        }
        if (score >= 3)
        {
            Destroy(door);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Key")
        {
            score++;
            keyAmount.text = "Keys: " + score;
            Destroy(collision.gameObject);
            Debug.Log("Key Taken");
        }
        
        if (collision.gameObject.tag == "God" && score == 3)
        {
            Debug.Log("You Killed God");
            Destroy(collision.gameObject);
            winner.text = "You Killed God";
        }
        if (collision.gameObject.tag == "Obstacle")
        {
            Debug.Log("Wall");
            if (Input.GetKey(KeyCode.LeftArrow))
            {
                transform.Translate(m_speed * Time.deltaTime, 0, 0);
            }
            if (Input.GetKey(KeyCode.UpArrow))
            {
                transform.Translate(0, -m_speed * Time.deltaTime, 0);
            }
            if (Input.GetKey(KeyCode.RightArrow))
            {
                transform.Translate(-m_speed * Time.deltaTime, 0, 0);
            }
            if (Input.GetKey(KeyCode.DownArrow))
            {
                transform.Translate(0, m_speed * Time.deltaTime, 0);
            }
        }
    }
}
