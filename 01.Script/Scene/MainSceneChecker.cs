using System;
using UnityEngine;
using UnityEngine.Playables;

public class MainSceneChecker : MonoSingleton<MainSceneChecker>
{
    [SerializeField] private PlayableDirector menuDirector, shortMenuDirector;

    private void Start()
    {
        int loadCount = SceneLoadTracker.GetMainSceneLoadCount();

        if (loadCount >= 1)
        {
            print("MainScene�� �� �� �̻� �ε���.");
            shortMenuDirector.Play();
        }
        else
        {
            menuDirector.Play();
        }
    }

    public void ClearMainSceneFlag()
    {
        SceneLoadTracker.ClearMainSceneLoadedFlag();
        print("MainScene �ε� �÷��װ� ����!!.");
    }
}
