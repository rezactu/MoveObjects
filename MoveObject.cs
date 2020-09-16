using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveObject : MonoBehaviour
{
    public GameObject Item;
    public GameObject TempParent;
    public Transform Guide;

    

    // Start is called before the first frame update
    void Start()
    {
        Item.GetComponent<Rigidbody>().useGravity = true;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnMouseDown()
    {        
            Item.GetComponent<Rigidbody>().useGravity = false;
            Item.GetComponent<Rigidbody>().isKinematic = true;
            Item.transform.position = Guide.transform.position;
            Item.transform.rotation = Guide.transform.rotation;
            Item.transform.parent = TempParent.transform;
    }

    void OnMouseUp()
    {
            Item.GetComponent<Rigidbody>().useGravity = true;
            Item.GetComponent<Rigidbody>().isKinematic = false;
            Item.transform.parent = null;
            Item.transform.position = Guide.transform.position;     
    }
}
