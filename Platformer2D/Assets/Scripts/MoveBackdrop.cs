using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBackdrop : MonoBehaviour
{
    [SerializeField] private float _speedBack;
    private void Update()
    {
        if (transform.position.x <-25)
        {
            Destroy(gameObject);
        }
        else
        {
            transform.Translate(Vector2.left * _speedBack * Time.deltaTime);
        }
    }
}
