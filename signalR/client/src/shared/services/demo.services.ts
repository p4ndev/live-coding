import { Injectable }   from "@angular/core";
import * as signalR     from "@microsoft/signalr";

@Injectable({ providedIn: "root" })
export class DemoServices {

    private _conn? : signalR.HubConnection;

    private Build = () => this._conn = 
        new signalR.HubConnectionBuilder()
            .withUrl("https://localhost:7199/demo")
                .build();

    private OnSuccessConnection(res : any){
        console.log("Success #", this._conn!.connectionId);
        res();
    }

    private OnFailConnection(e : any, rej : any){
        console.error("Error: ", e);
        rej();
    }

    public Init() : Promise<void>{
        return new Promise(
            (res, rej) => {

                this.Build();

                this._conn!.start()
                    .then(() => this.OnSuccessConnection(res))
                    .catch(e => this.OnFailConnection(e, rej));

            }
        );
    }

    public GetConnection = () => this._conn!;
    
}