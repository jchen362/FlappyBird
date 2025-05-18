using UnityEngine;

public class MovePipe : MonoBehaviour
{
    [SerializeField] private float _pipeSpeed = 0.5f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += Vector3.left * _pipeSpeed * Time.deltaTime;
    }
}
