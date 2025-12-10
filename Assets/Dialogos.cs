using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System.Collections.Generic;
using System.Collections;


public class Dialogos : MonoBehaviour
{
    public TextMeshProUGUI dialogo;
    public List<string> ListaDialogos;
    private int indexDialogos = 0;


    // Start is called before the first frame update
    void Start()
    {
        dialogo.text = "Bla bla bla bla bla";

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            SigueinteDialogo();
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            DialogoAnterior();
        }

    }

    public void SigueinteDialogo()
    {
        if (indexDialogos < ListaDialogos.Count)
        {
            dialogo.text = ListaDialogos[indexDialogos];
            indexDialogos++;
        }
        else
        {
            dialogo.text = "Se acabo.";
            indexDialogos = ListaDialogos.Count - 1;
        }
    }

    public void DialogoAnterior()
    {
        if (indexDialogos > 0)
        {
            dialogo.text = ListaDialogos[indexDialogos];
            indexDialogos--;
        }
        else
        {
            dialogo.text = "Empezaste de nuevo";
            indexDialogos = 0;
        }
    }

    public void Reset()
    {
        indexDialogos = 0;
        
    }
    

}
