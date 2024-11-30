using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC : MonoBehaviour
{
    // Start is called before the first frame update
    //Здоровье нпс
    public int health  = 5;
    //Левл нпс
    public int level = 2;
    //Скорость нпс
    public float speed = 1.5f;
    void Start()
    {
        //Здоровье + Левл
        health += level;
        //Вывод Здоровье игрока
        print("Здоровье игрока" + health);
    }

    // Update is called once per frame
    void Update()
    {
        //нпс движется в перед
        Vector3 newPosition = transform.position;
        newPosition.z += speed * Time.deltaTime;
        transform.position = newPosition;
    }
}
