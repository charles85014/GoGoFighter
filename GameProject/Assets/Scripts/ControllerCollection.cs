using UnityEngine;
using System.Collections;

public class ControllerCollection : MonoBehaviour
{
    public GameObject Sidewalk1;
    public GameObject Sidewalk2;
    public GameObject Sidewalk3;
    public GameObject Sidewalk4;

    private GameObject tempGameObject;
    private Vector3 tempPosition;


    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.A))
        {
            this.tempGameObject = this.Sidewalk1;
            this.tempPosition = this.Sidewalk1.transform.position;
            this.Sidewalk1.transform.position = this.Sidewalk2.transform.position;
            this.Sidewalk2.transform.position = this.tempPosition;
            this.Sidewalk1 = this.Sidewalk2;
            this.Sidewalk2 = this.tempGameObject;
            
        }
        if (Input.GetKeyUp(KeyCode.S))
        {
            this.tempGameObject = this.Sidewalk2;
            this.tempPosition = this.Sidewalk2.transform.position;
            this.Sidewalk2.transform.position = this.Sidewalk3.transform.position;
            this.Sidewalk3.transform.position = this.tempPosition;
            this.Sidewalk2 = this.Sidewalk3;
            this.Sidewalk3 = this.tempGameObject;
        }
        if (Input.GetKeyUp(KeyCode.D))
        {
            this.tempGameObject = this.Sidewalk3;
            this.tempPosition = this.Sidewalk3.transform.position;
            this.Sidewalk3.transform.position = this.Sidewalk4.transform.position;
            this.Sidewalk4.transform.position = this.tempPosition;
            this.Sidewalk3 = this.Sidewalk4;
            this.Sidewalk4 = this.tempGameObject;
        }
    }
}