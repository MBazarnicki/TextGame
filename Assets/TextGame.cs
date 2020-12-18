using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement

public class TextGame : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int min = 1;
        int max = 1000;
        int guess = 500;
        Debug.Log("Witaj w liczbowym czarodzieju");
        Debug.Log("Wybierz liczbe w przedziale od 1 do 1000");
        Debug.Log("Czy twoja liczba jest wieczka lub mniejsza od 500");
        Debug.Log("Aby odpowiedzieć na pytanie: Gorna strzałka = wyzsza liczba, dolna strzalka = nizsza liczba");
        
    }

    // Update is called once per frame
    void Update()
        
        if Input.GetKeyDown(KeyCode.UpArrow))
        {
        min = guess;
        guess = (min + max) /2;
        Debug.Log("Czy twoja liczba jest mniejsza lub wieksza od "+ guess + " ?");
        }

        if Input.GetKeyDown(KeyCode.DownArrow))
        {
        min = guess;
        guess = (min + max) /2;
        Debug.Log("Czy twoja liczba jest mniejsza lub wieksza od "+ guess + " ?");
        }


        if Input.GetKeyDown(KeyCode.Return))
        {
        Debug.Log("Wygralem");
        }

}
