using UnityEngine.XR.Interaction.Toolkit;

public class HandHold : XRBaseInteractable
{
    protected Weapon weapon = null;

    public void Setup(Weapon weapon)
    {
        this.weapon = weapon;
    }

    protected override void Awake()
    {
        base.Awake();
        onActivate.AddListener(BeginAction);
        onActivate.AddListener(EndAction);
        onSelectEnter.AddListener(Grab);
        onSelectExit.AddListener(Drop);

    }

    private void OnDestroy()
    {
        onActivate.RemoveListener(BeginAction);
        onDeactivate.RemoveListener(EndAction);
        onSelectEnter.RemoveListener(Grab);
        onSelectExit.RemoveListener(Drop);
    }

    protected virtual void BeginAction(XRBaseInteractor interactor)
    {
        // Empty
    }

    protected virtual void EndAction(XRBaseInteractor interactor)
    {
        // Empty
    }

    protected virtual void Grab(XRBaseInteractor interactor)
    {
        TryToHideHand(interactor, false);
    }

    protected virtual void Drop(XRBaseInteractor interactor)
    {
        TryToHideHand(interactor, true);
    }

    private void TryToHideHand(XRBaseInteractor interactor, bool hide)
    {
        if (interactor is Hand hand)
            hand.SetVisibility(hide);
    }

    public void BreakHold(XRBaseInteractor interactor)
    {
        Drop(interactor);
    }
}
