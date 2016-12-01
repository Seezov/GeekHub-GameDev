using UnityEngine;
using System.Collections;

public class TriggerGuardRails : MonoBehaviour
{

    public GameObject guardrails;
    private bool guardrailsAreActivated = false;
    void OnMouseDown()
    {
        if (!guardrailsAreActivated)
        {
            guardrails.transform.Translate(0, 0.5f, 0);
            guardrailsAreActivated = true;
        }
        else
        {
            guardrails.transform.Translate(0, -0.5f, 0);
            guardrailsAreActivated = false;
        }

    }
}
