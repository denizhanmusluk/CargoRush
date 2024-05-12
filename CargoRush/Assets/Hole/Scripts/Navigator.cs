using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Navigator : MonoBehaviour
{
    private bool MoveByTouch;
    private Vector3 _mouseStartPos, playerStartPos;
    [SerializeField] [Range(0f, 100f)] private float maxAcceleration;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            MoveByTouch = true;

            Plane plane = new Plane(Vector3.up, 0f);

            float distance;

            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            if(plane.Raycast(ray,out distance))
            {
                _mouseStartPos = ray.GetPoint(distance);
                playerStartPos = transform.position;
            }
        }
        else if(Input.GetMouseButtonUp(0))
        {
            MoveByTouch = false;
        }

        if (MoveByTouch)
        {
            Plane plane = new Plane(Vector3.up, 0f);
            float distance;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            if(plane.Raycast(ray, out distance))
            {
                Vector3 mousePos = ray.GetPoint(distance);
                Vector3 move = mousePos - _mouseStartPos;
                Vector3 navigator = playerStartPos + move;

                navigator = Vector3.ClampMagnitude(navigator, 5f);

                transform.position = Vector3.Lerp(transform.position, navigator, Time.deltaTime * maxAcceleration);
            }
        }
    }
}
