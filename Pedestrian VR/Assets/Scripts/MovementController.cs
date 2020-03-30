using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;

public class Constants
{
    public const double axisZ = 0.3860171;
}
public class MovementController : MonoBehaviour
{

    public float movSpeed = 1.0f;
    public float rotSpeed = 1.0f;
    public Camera headset = null;

    void Update()
    {

        //float x = Input.GetAxis("Horitzontal");
        //float z = Input.GetAxis("Vertical");

        //Vector3 move = transform.right * x + transform.forward * z;
        //controller.Move(move * movSpeed * Time.deltaTime);


        if (Input.GetAxis("Joystick") != 0) //Axis Joystic just captures joystic rotation LEFT & RIGHT (-1/1)
        {
            Vector3 rot = transform.rotation.eulerAngles;
            rot.y += Time.deltaTime * rotSpeed * Input.GetAxis("Joystick"); //substracting the joystick constant idle point
            Quaternion rotation = Quaternion.Euler(rot);
            transform.rotation = rotation;

            Debug.Log(transform.rotation.eulerAngles);
        }

        //float camRotX = headset.transform.rotation.eulerAngles.x;
        //Quaternion rot = Quaternion.Euler(camRotX, transform.rotation.eulerAngles.y, transform.rotation.eulerAngles.z);
        //transform.rotation = rot;



        if (Input.GetAxis("Vertical") != 0)
        {
            transform.position += headset.transform.forward * Time.deltaTime * movSpeed * Input.GetAxis("Vertical");
            transform.position = new Vector3(transform.position.x, 8, transform.position.z);
        }
        //if (Input.GetAxis("Horitzontal") != 0)
        //{
        //    Debug.Log(Input.GetAxis("Horitzontal"));
        //    transform.position += transform.right * Time.deltaTime * movSpeed * Input.GetAxis("Horitzontal");
        //    transform.position = new Vector3(transform.position.x, 8, transform.position.z);
        //}
    }
}
