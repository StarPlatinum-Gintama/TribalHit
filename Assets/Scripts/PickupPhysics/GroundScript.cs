using UnityEngine;

public class GroundScript : MonoBehaviour
{
    [SerializeField] Transform spawn;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D (Collider2D collision)
    {
        if (collision.gameObject.tag == "Fruit")
        {
            collision.gameObject.transform.position = spawn.position;
            collision.gameObject.GetComponent<Rigidbody2D>().linearVelocityY = 0;
        }
    }
}
