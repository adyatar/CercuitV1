using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragDrope : MonoBehaviour
{
    Vector3 offset;
    public string destinationtag = "DropArea";
    void OnMouseDown()
    {
        offset = transform.position - MouseWorldPosition();
        transform.GetComponent<Collider>().enabled = false;
        FindObjectOfType<LightControle>().tfido();
        Debug.Log("hrek1");
    }
    void OnMouseDrag()
    {

        transform.position = MouseWorldPosition() + offset;
        FindObjectOfType<LightControle>().tfido();
        Debug.Log("hrek2");
    }
    void OnMouseUp()
    {
        var rayorigine = Camera.main.transform.position;
        var raydirection = MouseWorldPosition() - Camera.main.transform.position;
        RaycastHit hitinfo;
        if (Physics.Raycast(rayorigine, raydirection, out hitinfo))
        {
            if (hitinfo.transform.tag == destinationtag)
            {
                transform.position = hitinfo.transform.position;
                //allumer
                Debug.Log("allume");
                if(transform.tag=="red")
                {
                    FindObjectOfType<LightControle>().mylight.color = Color.red;
                }
                else
                {
                    FindObjectOfType<LightControle>().mylight.color = Color.green;
                }
                FindObjectOfType<LightControle>().allumer();
            }
        }
        transform.GetComponent<Collider>().enabled = true;
       // FindObjectOfType<LightControle>().tfido();
        Debug.Log("hrek3");
    }
    Vector3 MouseWorldPosition()
    {
        var mouseScreenpos = Input.mousePosition;
        mouseScreenpos.z = Camera.main.WorldToScreenPoint(transform.position).z;
        return Camera.main.ScreenToWorldPoint(mouseScreenpos);
    }
}
