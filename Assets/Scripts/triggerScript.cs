using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class triggerScript : MonoBehaviour
{
    public GameObject NPCController;
    public GameObject GameController;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("TRIGGGGER");
        GameController.GetComponent<GameController>().goodHit = true;
    }

    private void OnTriggerLeave2D(Collider2D other)
    {
        GameController.GetComponent<GameController>().goodHit = false;
    }
}
