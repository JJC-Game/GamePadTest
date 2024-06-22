using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GamePadScript : MonoBehaviour
{
    float speed = 5.0f;
    Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float veloX = 0.0f, veloZ = 0.0f;
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");
        float L_R_Tri_Input = Input.GetAxis("L_R_Trigger");
        float horizontalInput_R = Input.GetAxis("R_Stick_H");
        float verticalInput_R = Input.GetAxis("R_Stick_V");

        if (Input.GetAxis("Horizontal") >= 0.1f || Input.GetAxis("Horizontal") <= -0.1f)
        {
            veloX = Input.GetAxis("Horizontal") * speed;
            Debug.Log("LStick“ü—Í " + horizontalInput.ToString() + ", " + verticalInput.ToString());
        }

        if (Input.GetAxis("Vertical") >= 0.1f || Input.GetAxis("Vertical") <= -0.1f)
        {
            veloZ = Input.GetAxis("Vertical") * speed;
            Debug.Log("LStick“ü—Í " + horizontalInput.ToString() + ", " + verticalInput.ToString());
        }

        if (L_R_Tri_Input >= 0.1f)
        {
            Debug.Log("RTrigger“ü—Í " + L_R_Tri_Input.ToString());
        }

        if (L_R_Tri_Input <= -0.1f)
        {
            Debug.Log("LTrigger“ü—Í " + L_R_Tri_Input.ToString());
        }

        if (horizontalInput_R >= 0.1f || horizontalInput_R <= -0.1f)
        {
            Debug.Log("RStick“ü—Í " + horizontalInput_R.ToString() + ", " + verticalInput_R.ToString());
        }
        if (verticalInput_R >= 0.1f || verticalInput_R <= -0.1f)
        {
            Debug.Log("RStick“ü—Í " + horizontalInput_R.ToString() + ", " + verticalInput_R.ToString());
        }

        if (Input.GetAxis("Vertical") >= 0.1f || Input.GetAxis("Vertical") <= -0.1f)
        {
            veloZ = Input.GetAxis("Vertical") * speed;
            Debug.Log(horizontalInput.ToString() + ", " + verticalInput.ToString());
        }

        if (Input.GetKeyDown("joystick button 0"))
        {
            Debug.Log("button0");
        }
        if (Input.GetKeyDown("joystick button 1"))
        {
            Debug.Log("button1");
        }
        if (Input.GetKeyDown("joystick button 2"))
        {
            Debug.Log("button2");
        }
        if (Input.GetKeyDown("joystick button 3"))
        {
            Debug.Log("button3");
        }
        if (Input.GetKeyDown("joystick button 4"))
        {
            Debug.Log("button4");
        }
        if (Input.GetKeyDown("joystick button 5"))
        {
            Debug.Log("button5");
        }
        if (Input.GetKeyDown("joystick button 6"))
        {
            Debug.Log("button6");
        }
        if (Input.GetKeyDown("joystick button 7"))
        {
            Debug.Log("button7");
        }
        if (Input.GetKeyDown("joystick button 8"))
        {
            Debug.Log("button8");
        }
        if (Input.GetKeyDown("joystick button 9"))
        {
            Debug.Log("button9");
        }

        rb.velocity = new Vector3(veloX, 0.0f, veloZ);
    }
}
