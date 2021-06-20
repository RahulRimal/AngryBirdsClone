using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlingShotController : MonoBehaviour
{
    public LineRenderer[] stripes;

    public Transform shootPoint;
    [HideInInspector] public Transform idleStripePoint;
    public Transform frontStripePoint;
    public Transform backStripePoint;

    public bool isDragging;
    public bool isReleased;

    Vector3 dragStartPos;
    [HideInInspector] public Vector3 dragEndPos;
    Vector3 stripeFinalPosition;

    // public float launchForce;

    // public float endPointOffset;


    private void Awake()
    {
        stripes[0].positionCount = 2;
        stripes[1].positionCount = 2;

        stripes[0].SetPosition(0, frontStripePoint.position);
        stripes[1].SetPosition(0, backStripePoint.position);

        stripes[0].SetPosition(1, idleStripePoint.position);
        stripes[1].SetPosition(1, idleStripePoint.position);

        isDragging = false;
        isReleased = false;

    }


    private void Update()
    {
        // setStripes(stripeFinalPosition);
    }

    private void OnMouseDown()
    {
        isDragging = true;
        dragStartPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
    }

    private void OnMouseUp()
    {
        setStripes(idleStripePoint.position);
    }


    private void OnMouseDrag()
    {
        isDragging = true;

        dragEndPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);


        dragEndPos.x = Mathf.Clamp(dragEndPos.x, -11.5f, -5f);
        dragEndPos.y = Mathf.Clamp(dragEndPos.y, -5f, 0);

        // stripeFinalPosition = dragEndPos - dragStartPos;

        setStripes(dragEndPos);

    }


    void setStripes(Vector3 position)
    {

        stripes[0].SetPosition(1, position);
        stripes[1].SetPosition(1, position);

    }


}
