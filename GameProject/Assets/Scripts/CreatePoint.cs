using UnityEngine;
using System.Collections;

public class CreatePoint : MonoBehaviour
{

    public GameObject CreateObject;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Q))
            Instantiate(this.CreateObject,this.transform.position,Quaternion.identity);

        
    }
}
