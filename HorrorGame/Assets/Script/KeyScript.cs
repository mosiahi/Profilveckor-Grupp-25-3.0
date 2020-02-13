using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyScript : ItemClass
{
    [SerializeField] string Name, Description;
    [SerializeField] string DoorToOpenName;
    public bool OpenDoor = false;
    // Start is called before the first frame update
    void Start()
    {

        DontDestroyOnLoad(this.gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        if (GameObject.Find(DoorToOpenName) && OpenDoor)
        {
            GameObject.Find(DoorToOpenName).GetComponent<KeyCollison>().CanOpenDoor = true; ;
        }
    }

    public override void UseItem()
    {
        OpenDoor = true;
    }


}
