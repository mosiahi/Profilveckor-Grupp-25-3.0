using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotate : MonoBehaviour
{
    Vector3 rotatePog;
    public float battery;
    bool isOn;
    public Vector2 originalSize;

    //private Vector3 currentAngle;
    private int angleIncrease;

    private bool no = false;

    private void Start()
    {
        angleIncrease = 90 / 5;
        battery = 100f;
    }

    void Update()
    {



        if (battery > 100)
        {
            battery = 100;
        }
        if (Input.GetKeyDown(KeyCode.F))
        {
            if (isOn)
            {
                isOn = false;
            }
            else
            {
                isOn = true;
            }
        }

        rotatePog = Vector3.zero;
        rotatePog.x = Input.GetAxisRaw("Horizontal");
        rotatePog.y = Input.GetAxisRaw("Vertical");
        if (rotatePog.x > 0f || rotatePog.y > 0f || rotatePog.x < 0f || rotatePog.y < 0f)
        {
            //Debug.Log("Enters rotaion");
            if (rotatePog.x > 0)
            {
                if (no)
                {
//if (gameObject.transform.eulerAngles.z < 90)
                //{
                //    while (gameObject.transform.eulerAngles.z < 90)
                //    {
                //        this.gameObject.transform.eulerAngles = new Vector3(
                //        gameObject.transform.eulerAngles.x,
                //        gameObject.transform.eulerAngles.y,
                //        gameObject.transform.eulerAngles.z + angleIncrease);
                //    }
                //}

                //if (gameObject.transform.eulerAngles.z > 90)
                //{
                //    while (gameObject.transform.eulerAngles.z > 90)
                //    {
                //        this.gameObject.transform.eulerAngles = new Vector3(
                //        gameObject.transform.eulerAngles.x,
                //        gameObject.transform.eulerAngles.y,
                //        gameObject.transform.eulerAngles.z - angleIncrease);
                //    }
                //}

                //while (gameObject.transform.eulerAngles.z < 90)
                //{
                //    this.gameObject.transform.eulerAngles = new Vector3(
                //    gameObject.transform.eulerAngles.x,
                //    gameObject.transform.eulerAngles.y,
                //    gameObject.transform.eulerAngles.z + angleIncrease);
                //}
                }
                

                this.gameObject.transform.eulerAngles = new Vector3(
                gameObject.transform.eulerAngles.x,
                gameObject.transform.eulerAngles.y,
                90);
            }
            if (rotatePog.x < 0)
            {
                if (no)
                {
                    //while (gameObject.transform.eulerAngles.z < 270)
                    //{
                    //    this.gameObject.transform.eulerAngles = new Vector3(
                    //    gameObject.transform.eulerAngles.x,
                    //    gameObject.transform.eulerAngles.y,
                    //    gameObject.transform.eulerAngles.z);
                    //}
                }
                

                this.gameObject.transform.eulerAngles = new Vector3(
                gameObject.transform.eulerAngles.x,
                gameObject.transform.eulerAngles.y,
                270);
            }
            if (rotatePog.y > 0)
            {
                this.gameObject.transform.eulerAngles = new Vector3(
                gameObject.transform.eulerAngles.x,
                gameObject.transform.eulerAngles.y,
                180);
            }
            else if (rotatePog.y < 0)
            {
                this.gameObject.transform.eulerAngles = new Vector3(
                gameObject.transform.eulerAngles.x,
                gameObject.transform.eulerAngles.y,
                0);
            }
        }

        if (battery > 0f && isOn)
        {
            battery -= Time.deltaTime;

            transform.localScale = new Vector2(originalSize.x * battery * 0.01f, originalSize.y * battery * 0.01f);

            gameObject.GetComponent<Renderer>().enabled = true;

        }
        else
        {
            gameObject.GetComponent<Renderer>().enabled = false;
        }
        
    }
}
