using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chao_some : MonoBehaviour
{
    private Vector3 originalScale;
    private bool isPlayerOnGround = false;
    private float scaleSpeed = 1.0f; 
    private bool isScaling = false;

    void Start()
    {
        originalScale = transform.localScale;
    }

    void Update()
    {
        if (isPlayerOnGround && !isScaling)
        {
            isScaling = true;
            StartCoroutine(ScaleDown());
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            isPlayerOnGround = true;
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            isPlayerOnGround = false;
        }
    }

    IEnumerator ScaleDown()
    {
        while (transform.localScale.magnitude > 0.01f)
        {
            transform.localScale = Vector3.Lerp(transform.localScale, Vector3.zero, Time.deltaTime * scaleSpeed);
            yield return null;
        }

        transform.localScale = Vector3.zero;

        yield return new WaitForSeconds(3.0f);

        transform.localScale = originalScale;
        isScaling = false;
    }
}