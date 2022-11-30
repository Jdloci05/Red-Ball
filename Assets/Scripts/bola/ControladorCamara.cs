using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControladorCamara : MonoBehaviour 
{
    public Vector3 offset;
    private Transform tarjet;
    [Range(0, 1)] public float lerpValue;
    public float sensibilidad;

    // Start is called before the first frame update
    void Start()
    {
        tarjet = GameObject.Find("bola").transform;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = Vector3.Lerp(transform.position, tarjet.position + offset, lerpValue);
        offset = Quaternion.AngleAxis(Input.GetAxis("Mouse X") * sensibilidad, Vector3.up) * offset;

        transform.LookAt(tarjet);
    }
}
