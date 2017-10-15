using UnityEngine;
using System.Collections.Generic;
using System;

public class BasePanel : MonoBehaviour 
{
    public Animator animator;
    public bool showOnStart;

    protected List<Action> actions;

    private void Awake()
    {
        actions = new List<Action>();
        if (showOnStart)
            Show();
    }

    public virtual void Show()
    {
        animator.SetBool("Show", true);
    }

    public virtual void Hide()
    {
        animator.SetBool("Show", false);
    }

    public void EndAnimation()
    {
        if (actions.Count > 0)
        {
            for (int i = 0; i < actions.Count; i++)
            {
                actions[i]();
            }

            actions.Clear();
        }
    }
}