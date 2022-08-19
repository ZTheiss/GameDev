using UnityEngine;

public class RTSCamera : MonoBehaviour {

    public float panSpeed = 20f;

    // Update is called once per frame
    void Update(){
        Vector3 pos = transform.position;

        if (Input.GetKey("w")){
            pos.z += panSpeed * Time.deltaTime;
        }

        transform.position = pos;
    }
}
