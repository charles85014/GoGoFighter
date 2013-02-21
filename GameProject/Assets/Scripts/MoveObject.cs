using UnityEngine;
using System.Collections;

public class MoveObject : MonoBehaviour
{

    public float speed = 5;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        this.transform.position += transform.TransformDirection(new Vector3(-this.speed * Time.deltaTime, 0, 0));
    }
}