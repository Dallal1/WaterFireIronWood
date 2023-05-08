using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using Unity.VisualScripting;
using UnityEditor.PackageManager;
using UnityEngine;
using UnityEngine.UI;

public class Enerjy : MonoBehaviour
{
    public GameObject Player;
    public GameObject PlayerSu;
    public GameObject PlayerAtes;
    public GameObject PlayerDemir;
    public GameObject PlayerTahtah;

    public Image BackgraondSu;
    public Image BackgraondAtes;
    public Image BackgraondDemir;
    public Image BackgraondTahtah;

    float EnerjyToplamSayisiSu;
    float EnerjyToplamSayisiAtas;
    float EnerjyToplamSayisiDemir;
    float EnerjyToplamSayisiTahtah;

    bool SetActivePlayer = true;
    bool SetActivPlayerSu = false;
    bool SetActivPlayerAtes = false;
    bool SetActivPlayerDemir = false;
    bool SetActivPlayerTahtah = false;

    private void Start()
    {


    }
    private void Update()
    {
        
        NoktaTakibetmek();
    }
    void NoktaTakibetmek()
    {
        if (SetActivePlayer == true)
        {
            Debug.Log("Player Calisiyur");
            transform.position = Player.transform.position;
        }
        if (SetActivPlayerSu == true)
        {
            Debug.Log("PlayerSu Calisyur");
            transform.position = PlayerSu.transform.position;
        }

        if (SetActivPlayerAtes == true)
        {
            Debug.Log("PlayerAtes Calisyur");
            transform.position = PlayerAtes.transform.position;
        }

        if (SetActivPlayerDemir == true)
        {
            Debug.Log("PlayerDemir Calisyur");
            transform.position = PlayerDemir.transform.position;
        }

        if (SetActivPlayerTahtah == true)
        {
            Debug.Log("PlayerTahtah Calisyur");
            transform.position = PlayerTahtah.transform.position;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        //Player Su icin
        if (collision.gameObject.tag == "su")
        {    

            EnerjyToplamSayisiSu++;
            Destroy(collision.gameObject);
            Debug.Log(EnerjyToplamSayisiSu);
            BackgraondSu.fillAmount = BackgraondSu.fillAmount - 0.5f;


            if (EnerjyToplamSayisiSu == 2)
            {
                Player.SetActive(false);
                PlayerAtes.SetActive(false);
                PlayerDemir.SetActive(false);
                PlayerTahtah.SetActive(false);

                PlayerSu.transform.position = transform.position;
                SetActivPlayerSu = true;
                SetActivePlayer = false;
                SetActivPlayerAtes = false;
                SetActivPlayerDemir = false;
                SetActivPlayerTahtah = false;
                PlayerSu.SetActive(true);
                EnerjyToplamSayisiSu = 0;
            }          
        }

        //Player Ates icin
        if (collision.gameObject.tag == "atas")
        {
            EnerjyToplamSayisiAtas++;
            Destroy(collision.gameObject);
            Debug.Log(EnerjyToplamSayisiAtas);
            BackgraondAtes.fillAmount = BackgraondAtes.fillAmount - 0.5f;

            if (EnerjyToplamSayisiAtas == 2)
            {
                Player.SetActive(false);
                PlayerSu.SetActive(false);
                PlayerDemir.SetActive(false);
                PlayerTahtah.SetActive(false);

                PlayerAtes.transform.position = transform.position;
                PlayerAtes.SetActive(true);
                SetActivPlayerAtes = true;
                SetActivePlayer = false;
                SetActivPlayerSu = false;
                SetActivPlayerDemir = false;
                SetActivPlayerTahtah = false;
                EnerjyToplamSayisiAtas = 0;
            }
        }

        //Player Demir icin
        if (collision.gameObject.tag == "demir")
        {
            EnerjyToplamSayisiDemir++;
            Destroy(collision.gameObject);
            Debug.Log(EnerjyToplamSayisiDemir);
            BackgraondDemir.fillAmount = BackgraondDemir.fillAmount - 0.5f;

            if (EnerjyToplamSayisiDemir == 2)
            {
                Player.SetActive(false);
                PlayerSu.SetActive(false);
                PlayerAtes.SetActive(false);
                PlayerTahtah.SetActive(false);

                PlayerDemir.transform.position = transform.position;
                PlayerDemir.SetActive(true);
                SetActivPlayerDemir = true;
                SetActivePlayer = false;
                SetActivPlayerAtes = false;
                SetActivPlayerSu = false;
                SetActivPlayerTahtah = false;
                EnerjyToplamSayisiDemir = 0;
            }
        }

        //Player Tahtah icin
        if (collision.gameObject.tag == "tahtah")
        {
            EnerjyToplamSayisiTahtah++;
            Destroy(collision.gameObject);
            Debug.Log(EnerjyToplamSayisiTahtah);
            BackgraondTahtah.fillAmount = BackgraondTahtah.fillAmount - 0.5f;

            if (EnerjyToplamSayisiTahtah == 2)
            {
                Player.SetActive(false);
                PlayerSu.SetActive(false);
                PlayerAtes.SetActive(false);
                PlayerDemir.SetActive(false);

                PlayerTahtah.transform.position = transform.position;
                PlayerTahtah.SetActive(true);
                SetActivPlayerTahtah = true;
                SetActivePlayer = false;
                SetActivPlayerAtes = false;
                SetActivPlayerDemir = false;
                SetActivPlayerSu = false;
                EnerjyToplamSayisiTahtah = 0;
            }
        }

    }    
}
