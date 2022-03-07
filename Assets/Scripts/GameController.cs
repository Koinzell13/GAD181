using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{

    public GameObject weapon;
    public GameObject NPCController;
    public bool goodHit = false;
    public GameObject success;
    public GameObject failure;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            Debug.Log("space key was pressed");
            weapon.SetActive(true);
            Strike();
        }
    }

    public void Strike()
    {
        
        if (goodHit)
        {
            Debug.Log("Good timing");
            success.SetActive(true);
        } else
        {
            Debug.Log("Bad timing");
            failure.SetActive(true);
        }
        NPCController.GetComponent<NPC_Controller>().Reset();

        HitAgain();
    }

    public void HitAgain()
    {
        weapon.SetActive(false);
    }
}
