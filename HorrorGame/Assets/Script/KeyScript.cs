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
        if (GameObject.Find(DoorToOpenName))
        {
            GameObject.Find(DoorToOpenName).GetComponent<KeyCollison>().SetKeyScript = this;
        }
    }

    // Update is called once per frame
    void Update()
    {
    }

    public override void UseItem()
    {
        OpenDoor = true;
    }
}
