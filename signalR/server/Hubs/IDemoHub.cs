namespace realtime;

// ================================================================================
// ================================ Channels ======================================
// ================================================================================

public interface IDemoHub {

    Task DisplayMessage(string message);

    Task SnapshotBroadcast(SnapshotDTO snapshot);

}
