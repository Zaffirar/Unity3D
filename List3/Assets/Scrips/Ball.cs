using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 using UnityEngine.SceneManagement;
public class Ball : MonoBehaviour
{
    public Rigidbody rb;
    public SpringJoint sj;
    public Rigidbody hook;
    private float maxDragDist = 35.0f;
    public GameObject nextBall;
    void Update()
    {
        if (isPressed)
        {
            Vector3 touchPos = Input.mousePosition;
            Transform camTrans = Camera.main.transform;
            float dist = Vector3.Dot(rb.transform.position - camTrans.position, camTrans.forward);
            touchPos.z = dist;
            Vector3 mousePos = Camera.main.ScreenToWorldPoint(touchPos);
            float adist=Vector3.Distance(hook.position, mousePos);
            if(adist>=maxDragDist)
            {
                rb.position = rb.position;
            }
            else
            {
                rb.position = mousePos;
            }
        }
    }
    private bool isPressed = false;
    void OnMouseDown()
    {
        isPressed = true;
        rb.isKinematic = true;
    }
    void OnMouseUp()
    {
        isPressed = false;
        rb.isKinematic = false;
        StartCoroutine(Relase());
    }
    IEnumerator Relase()
    {
        yield return new WaitForSeconds(0.05f);
        sj.spring = 0;

        yield return new WaitForSeconds(6f);
        if (nextBall != null)
        {
            nextBall.SetActive(true);
        }
        else
        {   
            Barrel.noBarrels=0;
            SceneManager.LoadScene (SceneManager.GetActiveScene().buildIndex);
        }
    }
}
