using UnityEngine;

public class PlayerScript : MonoBehaviour
{

    [SerializeField] float speed = 5f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //Implementar el movimiento horizontal

        if (Input.GetKey(KeyCode.D))
        {
            transform.position += Vector3.right * speed * Time.deltaTime;
            //Tmb se puede hacer new Vector3 (1,0,0)
        }

        if (Input.GetKey (KeyCode.A))
        {
            transform.position += Vector3.left * speed * Time.deltaTime;

        }

    }
}
