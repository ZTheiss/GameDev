using UnityEngine;

public class CameraMovement : MonoBehaviour
{

    public float panSpeed = 40f;

    // Update is called once per frame
    void Update()
    {
        Vector3 pos = transform.position;

        //moveup
        if (Input.GetKey("w"))
        {
            pos.z -= panSpeed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            pos.z -= panSpeed * Time.deltaTime;
        }
        //movedown
        if (Input.GetKey("s"))
        {
            pos.z += panSpeed * Time.deltaTime;
        }
        //moveleft
        if (Input.GetKey("d"))
        {
            pos.x -= panSpeed * Time.deltaTime;
        }
        //moveright
        if (Input.GetKey("a"))
        {
            pos.x += panSpeed * Time.deltaTime;
        }

        transform.position = pos;
    }
}
