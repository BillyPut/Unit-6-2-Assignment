using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleFollow : MonoBehaviour
{
    public GameObject player;
    private Vector3 offset = new Vector3(0f, -0.5f, 0f);

    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void Update()
    {
        if (Input.GetKey("z") )
        {
            gameObject.GetComponent<ParticleSystem>().Play();
        }
    }
    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = player.transform.position + offset;
    }
}
