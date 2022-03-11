using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestScript : MonoBehaviour
{
    public GameObject player;
    public GameObject yep;



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float ex = transform.position.x;
        float px = player.transform.position.x;


        float dist = ex - px;

        if (Input.GetKeyDown("g"))
        {
            yep.SetActive(true);
        }


        if (dist < 20 && dist > 0)
        {
            yep.transform.position = new Vector3 (102, -26, 0);

        }
        if (dist > -20 && dist < 0)
        {
            yep.transform.position = new Vector3 (105, -26, 0);
        }
    }
}
