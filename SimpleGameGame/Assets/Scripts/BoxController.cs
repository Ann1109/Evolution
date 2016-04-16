using UnityEngine;
using System.Collections;

public class BoxController : MonoBehaviour {
    public int acceleration;


    void Update () {
        var direction = new Vector3(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"), 0);
        GetComponent<Rigidbody>().AddForce(direction * acceleration);
    }
}
