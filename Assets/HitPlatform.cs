using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitPlatform : MonoBehaviour
{
    public GameObject start;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        FindObjectOfType<Grant_Controll>().transform.position = start.transform.position;
    }
}
