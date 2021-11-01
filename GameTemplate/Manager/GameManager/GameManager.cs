﻿using UnityEngine;
using MyLibrary.Manager;

public partial class GameManager : MonoBehaviour
{
    #region Singleton

    private static GameManager _instance;
    public static GameManager Instance
    {
        get
        {
            if (_instance == null)
            {
                _instance = (GameManager) FindObjectOfType(typeof(GameManager));
                if (_instance == null)
                {
                    GameObject singletonObject = new GameObject($"{typeof(GameManager)} (Singleton)");
                    _instance = singletonObject.AddComponent<GameManager>();
                    DontDestroyOnLoad(singletonObject);
                }
            }

            return _instance;
        }
    }

    #endregion
    
    private GamePlayState _gameStates;
    private GamePlayResult _inGameState;

    public GamePlayState GetGameState
    {
        get { return _gameStates; }
        set
        {
            _gameStates = value;
            GameObject[] inSceneObjs = GetAllObjectsInScene();
            foreach (var rObject in inSceneObjs)
            {
                if (rObject.GetComponent<IGamePlayState>() != null)
                {
                    switch (_gameStates)
                    {
                        case GamePlayState.Play:
                            rObject.GetComponent<IGamePlayState>().GamePlayCallBack();
                            break;

                        case GamePlayState.Pause:
                            rObject.GetComponent<IGamePlayState>().GamePauseCallBack();
                            break;

                        case GamePlayState.Resume:
                            rObject.GetComponent<IGamePlayState>().GameResumeCallBack();
                            break;

                        case GamePlayState.Quit:
                            rObject.GetComponent<IGamePlayState>().GameQuitCallBack();
                            break;
                    }
                }
            }
        }
    }

    public GamePlayResult GetInGameState
    {
        get { return _inGameState; }
        set
        {
            _inGameState = value;
            GameObject[] inSceneObjs = GetAllObjectsInScene();
            foreach (var rObject in inSceneObjs)
            {
                if (rObject.GetComponent<IGamePlayResult>() != null)
                {
                    switch (_inGameState)
                    {
                        case GamePlayResult.Win:
                            rObject.GetComponent<IGamePlayResult>().InGameWinCallback();
                            break;

                        case GamePlayResult.Lose:
                            rObject.GetComponent<IGamePlayResult>().InGameLoseCallback();
                            break;

                        case GamePlayResult.Draw:
                            rObject.GetComponent<IGamePlayResult>().InGameDrawCallback();
                            break;
                    }
                }
            }
        }
    }
    
    public static string GetGameVersion()
    {
        return Application.version;
    }
    
    private GameObject[] GetAllObjectsInScene()
    {
        return FindObjectsOfType<GameObject>();
    }
}