
public class SmallManObj : InteractObject {
   
    public override void InteractAction()
    {
        base.InteractAction();
        anim.SetTrigger(AnimTriggerName1);
        StopAllCoroutines();

        
    }
}
