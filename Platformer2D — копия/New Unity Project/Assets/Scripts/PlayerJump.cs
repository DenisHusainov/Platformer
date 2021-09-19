using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerJump : MonoBehaviour
{
    [SerializeField] private float _speedJump;
    private bool _isJump = false;
    [SerializeField] private Rigidbody2D rigidbody;

    private void Awake()
    {
        rigidbody = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && _isJump == true)
        {
            rigidbody.AddForce(Vector2.up * _speedJump, ForceMode2D.Impulse);
            _isJump = false;
        }
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Platform")
        {
            _isJump = true;
            
        }
        if (other.gameObject.tag == "Let")
        {
            Destroy(gameObject);
        }
    }
}
