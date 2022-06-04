using Microsoft.AspNetCore.SignalR;

namespace realtime;

public class DemoHub : Hub<IDemoHub>{

    // ================================================================================
    // ================================ Invokers ======================================
    // ================================================================================

    public async Task Hello()   => await Task.Run(HelloHandler);
    public async Task Backup()  => await Task.Run(BackupHandler);

    // ================================================================================
    // ============================= Implementations ==================================
    // ================================================================================

    private async Task HelloHandler() {
        await Clients.Caller.DisplayMessage("Hello signalR from Server!!!");
    }

    private async Task BackupHandler(){
        await Clients.All.SnapshotBroadcast(new SnapshotDTO(Context.ConnectionId));
        await Task.Delay(20000);
        await BackupHandler();
    }

}

