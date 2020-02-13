using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class audioTrigger : TriggerClass
{
    public AudioSource bigay;

    public override void myOnTriggerCheck(Collider2D collision)
    {
        if (RightTrigger(collision))
        {
            bigay.Play();
        }
    }

    public override void myUpdate()
    {
        
    }

    // Start is called before the first frame update
    void Start()
    {
        bigay = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
       
    }
}
