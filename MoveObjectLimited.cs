using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveObjectLimited: MonoBehaviour
{
    public GameObject Item;
    public GameObject TempParent;
    public Transform Guide;

    public bool InItem = false;
    public GameObject TriggerGm;



    // Start is called before the first frame update
    void Start()
    {
        Item.GetComponent<Rigidbody>().useGravity = true;
    }

    // Update is called once per frame
    void Update()
    {
        InItem = TriggerGm.GetComponent<MahdodeItem>().flag;
    }

    void OnMouseDown()
    {
        if (InItem)
        {
            Item.GetComponent<Rigidbody>().useGravity = false;
            Item.GetComponent<Rigidbody>().isKinematic = true;
            Item.transform.position = Guide.transform.position;
            Item.transform.rotation = Guide.transform.rotation;
            Item.transform.parent = TempParent.transform;
        }
    }

    void OnMouseUp()
    {
        if (InItem)
        {
            Item.GetComponent<Rigidbody>().useGravity = true;
            Item.GetComponent<Rigidbody>().isKinematic = false;
            Item.transform.parent = null;
            Item.transform.position = Guide.transform.position;
        }

    }
}