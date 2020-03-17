using UnityEngine;
public class JoystickList : MonoBehaviour
{
    // Prints input if is detected.

    void Update()
    {
        if(Input.GetAxis("Joystick") != 0) //Axis Joystic just captures joystic rotation LEFT & RIGHT (-1/1)
        {
            Debug.Log("YEA" + Input.GetAxis("Joystick").ToString());
        }
        if (Input.GetAxis("Vertical") != 0)
        {
            Debug.Log("Vertical = " + Input.GetAxis("Vertical").ToString());
        }
        if (Input.GetAxis("Horitzontal") != 0)
        {
            Debug.Log("Horitzontal = " + Input.GetAxis("Horitzontal").ToString());
        }
    }
}