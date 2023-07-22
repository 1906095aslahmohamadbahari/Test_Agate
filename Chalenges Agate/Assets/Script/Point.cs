using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Point : MonoBehaviour
{
    int point = 10;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            FindObjectOfType<UIPoint>().AddToScore(point);
            FindObjectOfType<PickupPoint>().SetUpSpawningPoint();
            Destroy(gameObject);
        }
    }
}