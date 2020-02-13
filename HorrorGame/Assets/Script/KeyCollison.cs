using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class KeyCollison : MonoBehaviour
{
    public bool CanOpenDoor = false;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
       
            if (collision.collider.tag == "Player" && CanOpenDoor)
            {
                gameObject.SetActive(false);
            }
        
    }
    private void OnCollisionStay2D(Collision2D collision)
    {
        
            if (collision.collider.tag == "Player" && CanOpenDoor)
            {
                gameObject.SetActive(false);
            }
        
    }


}
