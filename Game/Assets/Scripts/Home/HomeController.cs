using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HomeController : MonoBehaviour
{
    public ControlScenes controlScenes;

    public int NextScene;
    void Start()
    {
        ControlScenes ScenesController = FindObjectOfType<ControlScenes>();
        if (ScenesController != null){controlScenes = ScenesController.GetComponent<ControlScenes>();}
        else {Debug.LogError("Objeto indestrutível não encontrado!");}
        //verifica se a string NextScene ta vazia, e bom pq posso no futuro usar isso pra fazer o jogo comecar na ultima cena salva
        if (NextScene == 0)
        {
            NextScene = 1;
        }
        //controla rotacao de tela (muda pra retrato)
        Screen.orientation = ScreenOrientation.Portrait;
        
    }
    public void StartGame()
    {
        controlScenes.ChangeScene(NextScene);
    }
    public void StartPinha()
    {
        controlScenes.ChangeScene(1);
    }
    public void StartTrem()
    {
        controlScenes.ChangeScene(2);
    }
    public void QuitGame()
    {
        controlScenes.QuitGame();
    }
}
