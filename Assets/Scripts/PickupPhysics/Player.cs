using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] float speed = 10f;
    [SerializeField] float force = 10f;
    Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");

        //rb.linearVelocityX = horizontal * speed;
        //transform.position += new Vector3 (1,0,0) *speed * horizontal * Time.deltaTime;
        //rb.AddForce(Vector3.right * force * horizontal);
       
    }

    private void FixedUpdate()
    {
        //Viene el update cada x tiempo (el intervalo entre uno y el otro siempre es el mismo)
        //En el update la x no es regular. 

        float horizontal = Input.GetAxis("Horizontal");
        rb.AddForce(Vector3.right * force * horizontal, ForceMode2D.Force);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("He detectado una interacción");

        if (collision.gameObject.tag == "Fruit")
        {
            Debug.Log("Es una piña");
            //Destroy(collision.gameObject);

            Rigidbody2D rb = collision.gameObject.GetComponent<Rigidbody2D>();
            //sr.color = Color.white;

           /* rb.linearVelocityY = 0f;
            rb.AddForce(Vector3.up * 10f, ForceMode2D.Impulse);
           */
        }
    }
}
