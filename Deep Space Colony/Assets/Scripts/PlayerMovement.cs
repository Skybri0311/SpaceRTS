using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    float speed = 0.06f;
    float zoomSpeed = 5f;

    float maxHeight = 8;
    float minHeight = 2;

    public Camera _camera;

    private void Awake()
    {
        _camera = FindObjectOfType<Camera>();
    }
    // Update is called once per frame
    void Update()
    {
        float hsp = speed * Input.GetAxis("Horizontal");
        float vsp = speed * Input.GetAxis("Vertical");


        if (_camera.orthographic)
        {
            _camera.orthographicSize -= Input.GetAxis("Mouse ScrollWheel") * zoomSpeed;
            if (_camera.orthographicSize <= minHeight)
                _camera.orthographicSize = minHeight;
            if (_camera.orthographicSize >= maxHeight)
                _camera.orthographicSize = maxHeight;
        }



        Vector3 lateralMove = hsp * transform.right;
        Vector3 forwardMove = transform.up;
        forwardMove.Normalize();
        forwardMove *= vsp;

        Vector3 move = lateralMove + forwardMove;

        transform.position += move;
    }
}
