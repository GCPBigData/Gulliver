using System.Collections;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class Weapon : XRGrabInteractable
{
    public float breakDistance = 0.25f;
    public int recoilAmount = 25;

    private new Rigidbody rigidbody = null;
    private Barrel barrel = null;

    private GripHold gripHold = null;
    private GuardHold guardHold = null;

    private XRBaseInteractor gripHand = null;
    private XRBaseInteractor guarHand = null;
    
    private readonly Vector3 gripRotation = new Vector3(45, 0, 0);

    protected override void Awake()
    {
        base.Awake();
        SetupHolds();
        SetupExtras();

        onSelectEnter.AddListener(SetInitialRotation);
    }

    private void SetupHolds()
    {
        gripHold = GetComponentInChildren<GripHold>();
        gripHold.Setup(this);

        guardHold = GetComponentInChildren<GuardHold>();
        guardHold.Setup(this);

    }

    private void SetupExtras()
    {
        rigidbody = GetComponent<Rigidbody>();
        barrel = GetComponentInChildren<Barrel>();
        barrel.Setup(this);
    }

    private void OnDestroy()
    {
        onSelectEnter.RemoveListener(SetInitialRotation);
    }

    private void SetInitialRotation(XRBaseInteractor interactor)
    {
        Quaternion newRotation = Quaternion.Euler(gripRotation);
        interactor.attachTransform.localRotation = newRotation;

    }

    public void SetGripHand(XRBaseInteractor interactor)
    {
        gripHand = interactor;
        OnSelectEnter(gripHand);
    }

    public void ClearGripHand(XRBaseInteractor interactor)
    {
        gripHand = null;
        OnSelectExit(interactor);
    }

    public void SetGuardHand(XRBaseInteractor interactor)
    {
        guarHand = interactor;
    }

    public void ClearGuardHand(XRBaseInteractor interactor)
    {
        guarHand = null;
    }

    public override void ProcessInteractable(XRInteractionUpdateOrder.UpdatePhase updatePhase)
    {
        base.ProcessInteractable(updatePhase);

        if (gripHand && guardHold)
            SetGripRotation();

        CheckDistance(gripHand, gripHold);
        CheckDistance(guarHand, guardHold);
    }

    private void SetGripRotation()
    {
        Vector3 target = gripHand.transform.position - gripHold.transform.position;
        Quaternion lookRotation = Quaternion.LookRotation(target);

        Vector3 gripRotation = Vector3.zero;
        gripRotation.z = gripHand.transform.eulerAngles.z;

        lookRotation = Quaternion.Euler(gripRotation);
        gripHand.attachTransform.rotation = lookRotation;

    }

    private void CheckDistance(XRBaseInteractor interactor, HandHold handHold)
    {
        if(interactor)
        {
            float distanceSqr = GetDistanceSqrToInteractor(interactor);

            if (distanceSqr > breakDistance)
                handHold.BreakHold(interactor);

        }
    }

    public void PullTrigger()
    {
        barrel.StartFiring();
    }

    public void ReleaseTrigger()
    {
        barrel.StopFiring();
    }

    public void ApplyRecoil()
    {
        rigidbody.AddRelativeForce(Vector3.back * recoilAmount, ForceMode.Impulse);
    }
}
