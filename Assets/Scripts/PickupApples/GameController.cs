using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class GameController : MonoBehaviour
{
    [SerializeField] private GameObject appleprefab ;
    [SerializeField] private Transform playerTransform;

    private float timer;
    private float score;

    //Lista para almacenar las manzanas
    List <GameObject> appleList = new List <GameObject>();
    List<GameObject> appleListRemove = new List<GameObject> ();

    [SerializeField]float gravity;
    [SerializeField] private TMP_Text scoreText;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        scoreText.text = "Score: " + score;
        timer = 0f;
        score = 0f;
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;

        if (timer > 1f)
        {
            //Se ha completado el timer
            timer = 0f;

            //Creamos una manzana
            GameObject newApple = Instantiate(appleprefab);

            newApple.transform.position = new Vector3(Random.Range(-3,3),5.5f);

            appleList.Add(newApple);
        }


        foreach (GameObject apple in appleList)
        {
            apple.transform.position += Vector3.down * gravity * Time.deltaTime;

            if (score>0)
            {
                apple.transform.position += Vector3.down * gravity * Time.deltaTime * (score*0.1f);
            }
            //Tmb se podría con un new Vector3 (0,-1,0)

            float distance = Vector3.Distance(apple.transform.position, playerTransform.position);
                
            if (distance < 1f)
            {
                //Debug.Log("He colisionado con una manzana");

                score++;
                scoreText.text = "Score: " + score;

                //Destroy(apple); podría funcionar pero no furula pq la referencia q tenia la lista de manzanas sigue teniendola aunq ya no exista. 
                appleListRemove.Add(apple);

                //Vamos a eliminar la manzana cuando ya se hay recorrido esa instancia.
            }
        }

        foreach (GameObject apple in appleListRemove)
        {
            appleList.Remove(apple);

            Destroy(apple);
        }

       

    }

   
}
