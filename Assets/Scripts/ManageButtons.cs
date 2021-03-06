using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

/// <summary>
/// Faz o controle dos botoes do jogo inteiro
/// </summary>
public class ManageButtons : MonoBehaviour
{
    //Carrega o modo de jogo normal, feito em aula
    public void IniciaModoNormalDeJogo()
    {
        SceneManager.LoadScene(GameStrings.modoNormal); //Carrega a cena
        PlayerPrefs.SetString( GameStrings.ultimoModojogado , GameStrings.modoNormal); //Salva o ultimo modo jogado no PlayerPrefs
    }

    //Carrega o primeiro modo customizado
    public void IniciaModoCustomizado1()
    {
        SceneManager.LoadScene(GameStrings.modoC1); //Carrega a cena
        PlayerPrefs.SetString(GameStrings.ultimoModojogado, GameStrings.modoC1); //Salva o ultimo modo jogado no PlayerPrefs
    }

    //Carrega o segundo modo customizado
    public void IniciaModoCustomizado2()
    {
        SceneManager.LoadScene(GameStrings.modoC2); //Carrega a cena
        PlayerPrefs.SetString(GameStrings.ultimoModojogado, GameStrings.modoC2); //Salva o ultimo modo jogado no PlayerPrefs
    }

    //Carrega tela de inicio
    public void VoltarParaInicio()
    {
        SceneManager.LoadScene(GameStrings.telaInicial); //Carrega a cena
    }

    public void IniciaCr?ditos()
    {
        SceneManager.LoadScene(GameStrings.telaCreditos); //Carrega a cena
    }

    // Busca nas Prefs o ultimo modo jogado e inicia ele, quando o bot?o replay ? clicado.
    public void IniciaUltimoModoJogado()
    {
        string ultimoModoJogado = PlayerPrefs.GetString(GameStrings.ultimoModojogado); //Busca string de ultimo modo jogado
        if (ultimoModoJogado == GameStrings.modoNormal) IniciaModoNormalDeJogo(); //Verifica a qual modo essa string pertence e chama a tela.
        else if (ultimoModoJogado == GameStrings.modoC1) IniciaModoCustomizado1();
        else if (ultimoModoJogado == GameStrings.modoC2) IniciaModoCustomizado2();
    }
}
