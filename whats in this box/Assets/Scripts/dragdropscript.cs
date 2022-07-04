using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dragdropscript : MonoBehaviour
{
    private Vector3 screenPoint;
    private Vector3 offset;

    private bool isDragging = false;

    private Rigidbody2D rb;

    private AudioSource hit;

    Vector3 lastMousePos;
    public Vector3 mouseDelta
    {
        get
        {
            return Input.mousePosition - lastMousePos;
        }
    }

    private void Start()
    {
        Cursor.lockState = CursorLockMode.Confined;
        rb = GetComponent<Rigidbody2D>();
        hit = GetComponent<AudioSource>();

        lastMousePos = Input.mousePosition;
    }

    private void Update()
    {


        lastMousePos = Input.mousePosition;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        hit.Play();
    }


    void OnMouseDown()
    {
        offset = gameObject.transform.position - Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPoint.z));
    }

    void OnMouseDrag()
    {
        Vector3 curScreenPoint = new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPoint.z);
        Vector3 curPosition = Camera.main.ScreenToWorldPoint(curScreenPoint) + offset;
        rb.velocity = mouseDelta;
        transform.position = curPosition;
        isDragging = true;
    }

    private void OnMouseUp()
    {
        isDragging = false;
        rb.velocity = mouseDelta * 0.3f;
    }
}
