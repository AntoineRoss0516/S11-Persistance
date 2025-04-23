using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MiniJeu : MonoBehaviour
{
    public float pointageTemps;
    public TextMeshProUGUI textScore;
    public TextMeshProUGUI textNouveauRecord;
    public GameObject finPanel;
    public TMP_InputField inputNom;
    void Start()
    {
        pointageTemps = 0;
    }

    private void Update()
    {
        textScore.text = pointageTemps.ToString("00.00");
    }

    public void OnPanel()
    {
        float recordActuel = PlayerPrefs.GetFloat("meilleurScore", 0f);
        if (pointageTemps > recordActuel)
        {
          finPanel.SetActive(true);
          textNouveauRecord.text = textScore.text;  
        }
         
    }

    public void ConfirmerNouveauRecord()
    {
        finPanel.SetActive(false);
        string nom = inputNom.text;
        PlayerPrefs.SetString("nomJoueur", nom);
    }
}
