using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour
{
    public Transform target;
    public Vector3 offset;
 

    //zoom
    public float zoomrange = 4f;
    public float minzoom = 5f;
    public float maxzoom = 15f;
    public float pitch = 2f;
    private float curentZoom = 10f;

    //yawn
    public float yawnrange = 100f;
    public float curentyawn = 0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        curentZoom -= Input.GetAxis("Mouse ScrollWheel") * zoomrange;
        curentZoom = Mathf.Clamp(curentZoom, minzoom, maxzoom);
        curentyawn -= Input.GetAxis("Horizontal") * yawnrange * Time.deltaTime;
    }

     void LateUpdate()
    {
        transform.position = target.position - offset * curentZoom;
        transform.LookAt(target.position + Vector3.up * pitch);
        transform.RotateAround(target.position, Vector3.up, curentyawn);
    }
}
