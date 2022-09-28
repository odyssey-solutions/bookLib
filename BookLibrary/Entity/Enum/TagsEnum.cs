namespace BookLibrary.Entity.Enum;

public enum TagsEnum
{
    /// <summary>
    /// When a member has 3 or less tasks 
    /// </summary>
    New_User = 1,
    /// <summary>
    /// 1. All New Business Scheme members would automatically we marked as VIP
    /// 2. Must be able to flag a member as a VIP manually
    /// </summary>
    VIP = 2, 
    /// <summary>
    /// Manual - Agent flags this and the task is escalated to Management (to redact text)
    /// </summary>
    Sensitive_Information = 3, 
    /// <summary>
    /// Manual - Agent flags this and the task is escalated to Management (for member communication)
    /// </summary>
    Prohibited = 4, 
    /// <summary>
    /// Manual - agent flags this. Sometimes a user might not udnerstand the app and they enter a non sensical message.
    /// The agent must be able to mark this task as invalid and it then must not count as a task (important if someone had an invalid request as their first free task) - in this case the member should then get another free task
    /// </summary>
    Invalid = 5, 
   /// <summary>
   /// Manual - Agent flags this when a task will be quick to action.
   /// These are tasks where we would like to automate the fulfilment in the future
   /// </summary>
    Express_Sourcing = 6, 
    /// <summary>
    /// Automatic when the request has the following words - urgent, urgently, emergency, asap, as soon as possible, rush.
    /// Must also be able to do tad this Manually - Agent flags this when a task needs to be actioned because of the time sensitivity. 
    /// </summary>
    Urgent = 7, 
    /// <summary>
    /// Manual not automatic
    /// </summary>
    Influencer = 8, //
    /// <summary>
    /// Automatic - when a "Pay as you use" member has not paid for 3 or more tasks
    /// </summary>
    Potential_abuser = 9  //TODO: add flag once payments are done
}