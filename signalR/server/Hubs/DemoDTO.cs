namespace realtime;

// ================================================================================
// ============================= DATA OBJECTS =====================================
// ================================================================================

public class SnapshotDTO {

    public Guid Id { get; set; }
    public DateTime Date { get; set; }
    public string From { get; set; }
    
    public SnapshotDTO(string from){
        Id = Guid.NewGuid();
        Date = DateTime.Now;
        From = from;
    }

}