using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enerjy : MonoBehaviour
{
    public GameObject Player;
    public GameObject PlayerSu;
    public GameObject PlayerAtes;
    public GameObject PlayerDemir;
    public GameObject PlayerTahtah;

    float EnerjyToplamSayisi;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        //Player Su icin
        if (collision.gameObject.tag == "su")
        {    
            EnerjyToplamSayisi++;
            Destroy(collision.gameObject);

            if (EnerjyToplamSayisi == 2)
            {
                Player.SetActive(false);
                PlayerAtes.SetActive(false);
                PlayerDemir.SetActive(false);
                PlayerTahtah.SetActive(false);

                Player.SetActive(false);
                PlayerSu.transform.position = Player.transform.position;
                PlayerSu.SetActive(true);
            }          
        }

        //Player Ates icin
        if (collision.gameObject.tag == "atas")
        {
            EnerjyToplamSayisi++;
            Destroy(collision.gameObject);

            if (EnerjyToplamSayisi == 2)
            {
                Player.SetActive(false);
                PlayerSu.SetActive(false);
                PlayerDemir.SetActive(false);
                PlayerTahtah.SetActive(false);

                PlayerAtes.transform.position = Player.transform.position;
                PlayerAtes.SetActive(true);
            }
        }

        //Player Demir icin
        if (collision.gameObject.tag == "demir")
        {
            EnerjyToplamSayisi++;
            Destroy(collision.gameObject);

            if (EnerjyToplamSayisi == 2)
            {
                Player.SetActive(false);
                PlayerSu.SetActive(false);
                PlayerAtes.SetActive(false);
                PlayerTahtah.SetActive(false);

                PlayerDemir.transform.position = Player.transform.position;
                PlayerDemir.SetActive(true);
            }
        }

        //Player Tahtah icin
        if (collision.gameObject.tag == "tahtah")
        {
            EnerjyToplamSayisi++;
            Destroy(collision.gameObject);

            if (EnerjyToplamSayisi == 2)
            {
                Player.SetActive(false);
                PlayerSu.SetActive(false);
                PlayerAtes.SetActive(false);
                PlayerDemir.SetActive(false);

                PlayerTahtah.transform.position = Player.transform.position;
                PlayerTahtah.SetActive(true);
            }
        }

    }    
}
