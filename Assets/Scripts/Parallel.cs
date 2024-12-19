using UnityEngine;

public class Parallel : MonoBehaviour
{
    [SerializeField] private float parallelxSpeed;

    private float spriteHeight;
    private Vector3 startPos;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        startPos = transform.position;
        spriteHeight = GetComponent<SpriteRenderer>().bounds.size.y;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.down * parallelxSpeed*Time.deltaTime);

        if(transform.position.y < startPos.y-spriteHeight)
        {
            transform.position = startPos;
        }
    }
}
