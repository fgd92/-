using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractWithObject : MonoBehaviour
{
    float distance = 10f;

    void Update()
    {
        RaycastHit hit;
        if (Input.GetKeyDown(KeyCode.E))
        {
            Vector3 forward = transform.TransformDirection(Vector3.forward) * distance;
            Ray ray = new Ray(transform.position, forward);

            Physics.Raycast(ray, out hit, distance);

            if (hit.collider != null)
            {
                if (hit.collider.gameObject.tag == "Door")
                {
                    GameObject door = hit.collider.gameObject;
                    Animator animator = door.GetComponent<Animator>();
                    animator.SetBool("IsOpened", !animator.GetBool("IsOpened"));
                }
            }
        }
    }
}
