using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
   [SerializeField] private GameObject enemyPrefab;
    GameObject createdEnemy;
    [SerializeField]float speed = 5f;


    //TODO

    // Prefab del enemigo que vamos a generar

    // ARRAY:
    // Las posiciones posibles son conocidas y no cambiarán
    // durante la ejecución del juego.
  
    // Número de enemigos que queremos generar en cada ronda

    // LIST:
    // El número de enemigos vivos sí cambiará durante la partida.
   
    //Score
    void Start()
    {
        //TODO: Llamamos a la generación de enemigos
        //Instanciar un enemigo

        createdEnemy = Instantiate(enemyPrefab,Vector3.zero,Quaternion.identity);

       
    }

    void Update()
    {
        //TODO:  Reiniciamos la ronda pulsando R
      
        createdEnemy.transform.position += new Vector3(3, 0, 0)*Time.deltaTime*speed;

        if (createdEnemy.transform.position.x>10.47)
        {
            createdEnemy.transform.position = Vector3.zero;
        }


    }

    //Generar oleada
    private void GenerarEnemigos()
    {
        //TODO: 
        // Evitamos intentar generar más enemigos
        // que posiciones disponibles.
        
        // ARRAY auxiliar:
        // Nos permite saber qué posiciones ya hemos utilizado.
        //
        // false = libre
        // true = ocupada

        // FOR:
        // Sabemos cuántos enemigos queremos generar.
        
            // Elegimos una posición aleatoria.

            // WHILE:
            // Mientras esa posición ya esté ocupada,
            // buscamos otra.
           
            // Marcamos esa posición como utilizada.

            // Creamos el enemigo.

            // Guardamos el enemigo en nuestra lista
            // de enemigos actualmente vivos.

            // Le damos al enemigo una referencia
            // al GameManager.
    }


    //Si se destruye un enemigo, incrementamos el score

    public void EnemigoDestruido(GameObject enemy)
    {
        //TODO: 
        // Eliminamos la referencia de la lista.
        // Cuando la lista esté vacía,
        // hemos terminado la ronda.
        
    }


    //Reiniciar la ronda

    private void ReiniciarEnemigos()
    {
        //TODO: 
        // Primero eliminamos cualquier enemigo
        // que todavía esté vivo.

        // Generamos una nueva oleada.
    }

    // Elminar a todos los enemigos
    private void EliminarEnemigos()
    {
        //TODO: 
        // FOREACH:
        // Queremos hacer la misma operación
        // con todos los enemigos de la lista.

        // Dejamos vacía la lista.

    }
}