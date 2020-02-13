using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpanwOrDeSpawn : TriggerClass
{
    [SerializeField] GameObject myGameObject;
    bool HasDoneThing = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public override void myUpdate()
    {
        
    }
    public override void myOnTriggerCheck(Collider2D collision)
    {
        if (RightTrigger(collision) && !HasDoneThing)
        {
            myGameObject.SetActive(!myGameObject.activeSelf);
            TriggerComplete = true;
            HasDoneThing = true;
        }
    }
}
