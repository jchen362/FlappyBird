using UnityEngine;

public class PipeSpawner : MonoBehaviour
{
    [SerializeField] private float _maxTime = 2f;
    [SerializeField] private float _heightRange = 1f;
    [SerializeField] private GameObject _pipe;
    private float timeToLive = 10f;
    private float _timer;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        SpawnPipe();
        
    }
    
    private void SpawnPipe()
    {
        Vector3 spawnPosition = transform.position += new Vector3(0, Random.Range(-_heightRange, _heightRange));
        GameObject pipe = Instantiate(_pipe, spawnPosition, Quaternion.identity);

        Destroy(pipe, timeToLive);
    }

    // Update is called once per frame
    void Update()
    {
        if (_timer > _maxTime)
        {
            SpawnPipe();
            _timer = 0;
        }
        _timer += Time.deltaTime;
        
    }
}
