using UnityEngine;
using UnityEngine.InputSystem;

public class fly : MonoBehaviour

{
    [SerializeField] private float _velocity = 2f;
    [SerializeField] private float _rotation = 10f;
    private Rigidbody2D _rb;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        GameManager.instance.GameOver();
    }

    // Update is called once per frame
    void Update()
    {
        if (Mouse.current.leftButton.wasPressedThisFrame)
        {
            _rb.linearVelocityY = _velocity;
        }
        
    }

    private void FixedUpdate()
    {
        transform.rotation = Quaternion.Euler(0, 0, _rb.linearVelocityY * _rotation);
    }
}
